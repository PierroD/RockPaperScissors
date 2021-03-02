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

        public Game(List<Player> players)
        {
            this.UniqueId = Guid.NewGuid();
            this.BestOf = 3;
            this.players = players;
            this.TimeToAnswer = 5000;
            Response.GameInfoResponse(this);
        }


    }

    public class Round
    {
        public Guid UniqueId { get; set; }
        public Dictionary<Player, Answer> Results { get; set;}
        public Player winner { get; set; }
}


}
