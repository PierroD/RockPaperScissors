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
            SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "Give me your informations"}, MessageType.Discover)));

        }

        public static void DisconnectResponse(Player player)
        {
            SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "See you later :)" }, MessageType.Disconnect)));

        }

        public static void GameInfoResponse(Game game)
        {
            Guid roundGuid = Guid.NewGuid();
            foreach (Player player in game.players)
                SocketHelper.WriteToPlayer(player, Encapsulation.Serialize(Encapsulation.FromValue(new GameInfo { UniqueId = game.UniqueId, FirstRoundGuid = roundGuid, BestOf = game.BestOf, TimeToAnswer = game.TimeToAnswer, EnnemyName = game.players.FirstOrDefault(p => p.id != player.id).name }, MessageType.GameInfo)));
        }
    }
}
