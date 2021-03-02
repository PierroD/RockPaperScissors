using RPSMessage;
using SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestRPSServer.Models;

namespace TestRPSServer
{
    public static class Processor
    {
        public static void MessageProcessor(Encapsulation message, Player player)
        {
            switch (message.MessageType)
            {
                case MessageType.Disconnect:
                    Console.WriteLine($"Connection with Client {player.id} closed !");
                    Response.DisconnectResponse(player);
                    Thread.Sleep(1000);
                    player.tcpClient.Close();
                    break;

                case MessageType.Discover:

                    Discover client = Encapsulation.Deserialize<Discover>(message);
                    player.name = client.UserName;
                    Console.WriteLine($"Player username is : {player.name}");
                    break;

                case MessageType.Searching:
                    Console.WriteLine($"Player : {player.name} is searching for a game ");
                    player.status = Status.Searching;
                    break;

                case MessageType.Answer:
                    Console.WriteLine($"Player {player.id} : {player.name} answered ! ");
                    SaveRound(player, message);
                    break;
            }
        }


        public static void SaveRound(Player player, Encapsulation message)
        {
            Answer answer = Encapsulation.Deserialize<Answer>(message);
            Game current_game = TemporaryStorage.AllGames.FirstOrDefault(g => g.UniqueId == answer.GameId);
            if (current_game.Rounds.Last() == null)
                AddRound(current_game, answer, player);

        }

        private static void AddRound(Game current_game, Answer answer, Player player)
        {
            current_game.Rounds.Add(new Round { UniqueId = answer.RoundId, Results = null, Winner = null });
            current_game.Rounds.Last().Results = new List<GameResult>();
            current_game.Rounds.Last().Results.Add(new GameResult { player = player, playerChoice = answer.playerChoice });
            CheckWhoWin(current_game.Rounds.Last());
        }

        private static void CheckWhoWin(Round current_round)
        {
            if (current_round.Results.Count == 2) // number of clients, will be stored in a .ini file
            {
                if (current_round.Results[0].playerChoice == current_round.Results[0].playerChoice)
                {
                    current_round.Winner = null; // draw
                }
                else
                { // who win
                    current_round.Winner = (Convert.ToInt32(current_round.Results[0].playerChoice) >= (Convert.ToInt32(current_round.Results[0].playerChoice)%2)) ? current_round.Winner = current_round.Results[0].player : current_round.Winner = current_round.Results[1].player;
                }
            }
            // rock > scissors 0 >= result%2 (true == win, false == lose)
            // paper > rock 1 >= result%2 (true == win, false == lose)
            // scissors > paper 2 >= result%2 (true == win, false == lose)
        }
    }
}
