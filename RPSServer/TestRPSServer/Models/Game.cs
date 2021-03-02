using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;

namespace TestRPSServer.Models
{
    public class Game
    {
        public Guid UniqueId { get; set; }
        public int BestOf { get; set; }
        public List<Player> players { get; set; }
        public int TimeToAnswer { get; set; }
        public bool inProgress { get; set; }

        public List<Round> Rounds { get; set; }

        public Game(List<Player> players)
        {
            this.UniqueId = Guid.NewGuid();
            this.BestOf = 3;
            this.players = players;
            this.TimeToAnswer = 5000;
            this.Rounds = new List<Round>();
            Response.GameInfoResponse(this);
            TemporaryStorage.AllGames.Add(this);
        }


    }

    public class Round
    {
        public Guid UniqueId { get; set; }
        public List<GameResult> Results { get; set; }
        public Player Winner { get; set; }
    }

    
    public class GameResult
    {
        public Player player { get; set; }
        public Choice playerChoice { get; set; }
    }



}
