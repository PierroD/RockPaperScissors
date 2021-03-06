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
            if (current_game.Rounds.Count != 0)
                if (current_game.Rounds.Last().UniqueId == answer.RoundId)
                    SaveAnswer(current_game.Rounds.Last(), answer, player);
                else
                    AddRound(current_game, answer, player);
            else
                AddRound(current_game, answer, player);

            CheckWhoWin(current_game);
        }

        private static void AddRound(Game current_game, Answer answer, Player player)
        {
            current_game.Rounds.Add(new Round { UniqueId = answer.RoundId, Results = null, Winner = null });
            current_game.Rounds.Last().Results = new List<GameResult>();
            current_game.Rounds.Last().Results.Add(new GameResult { player = player, playerChoice = answer.playerChoice });
        }

        private static void SaveAnswer(Round current_round, Answer answer, Player player)
        {
            current_round.Results.Add(new GameResult { player = player, playerChoice = answer.playerChoice });
        }

        private static void CheckWhoWin(Game current_game)
        {
            Round current_round = current_game.Rounds.Last();
            if (current_round.Results.Count == 2) // number of clients, will be stored in a .ini file
            {
                if (current_round.Results[0].playerChoice == current_round.Results[1].playerChoice)
                {
                    current_round.Winner = null; // draw
                    Console.WriteLine($"This Round is a draw, Next Round");
                    Response.NextRoundResponse(current_game);
                }
                else
                { // who win
                    if (current_round.Results[0].playerChoice == Choice.Paper && current_round.Results[1].playerChoice == Choice.Scissors)
                        current_round.Winner = current_round.Results[1].player;
                    else
                        current_round.Winner = (Convert.ToInt32(current_round.Results[0].playerChoice) >= (Convert.ToInt32(current_round.Results[1].playerChoice) % 2)) ? current_round.Winner = current_round.Results[0].player : current_round.Winner = current_round.Results[1].player;
                    
                    if (current_round.Winner.score + 1 != current_game.BestOf)
                    {
                        current_round.Winner.score++;
                        Console.WriteLine($"Player {current_round.Winner.name} with id : {current_round.Winner.id} Win the Round, Next Round");
                        Response.NextRoundResponse(current_game);
                    }
                    else
                    {
                        Console.WriteLine($"Player {current_round.Winner.name} with id : {current_round.Winner.id} Win the BestOf {current_game.BestOf}");
                        Response.WinAndLoseResponse(current_game);
                    }
                }
            }
            // rock > scissors 0 >= result%2 (true == win, false == lose)
            // paper > rock 1 >= result%2 (true == win, false == lose)
            // scissors > paper 2 >= result%2 (true == win, false == lose)
        }

    }
}
