using RPSMessage;
using SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TestRPSServer.Models;

namespace TestRPSServer
{
    public static class Response
    {
        public static void DiscoverResponse(Player player)
        {
            SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "Give me your informations" }, MessageType.Discover)));

        }

        public static void DisconnectResponse(Player player)
        {
            SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "See you later :)" }, MessageType.Disconnect)));

        }

        public static void GameInfoResponse(Game game)
        {
            Guid roundGuid = Guid.NewGuid();
            foreach (Player player in game.players)
                SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GameInfo { playerId = player.id, UniqueId = game.UniqueId, FirstRoundGuid = roundGuid, BestOf = game.BestOf, BestOfScore = 0, TimeToAnswer = game.TimeToAnswer, EnnemyName = game.players.FirstOrDefault(p => p.id != player.id).name }, MessageType.GameInfo)));
        }

        public static void NextRoundResponse(Game game)
        {
            Guid roundGuid = Guid.NewGuid();
            foreach (Player player in game.players)
            {
                WinStatus winStatus = getGameResult(game, player); 
                SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new RoundInfo { UniqueId = roundGuid, PlayerWinStatus = winStatus }, MessageType.NextRound)));
            }
        }

        public static void WinAndLoseResponse(Game game)
        {
            foreach (Player player in game.players)
            {
                WinStatus winStatus = getGameResult(game, player);
                SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue( new GameEnd { PlayerWinStatus = winStatus }, MessageType.GameEnd)));
            }
        }

        public static WinStatus getGameResult(Game game, Player player)
        {
            if (game.Rounds.Last().Winner != null)
                if (game.Rounds.Last().Winner.id == player.id)
                    return WinStatus.Win;
                else
                    return WinStatus.Lose;
            return WinStatus.Tie;
        }


    }
}
