using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{
    public class GenericMessage
    {
        public string Message { get; set; }
    }

    public class Discover
    {
        public string UserName { get; set; }
    }

    public class Answer
    {
        public Guid GameId { get; set; }
        public Guid RoundId { get; set; }
        public int TimeToAnswer { get; set; }
        public Choice playerChoice { get; set; }
    }

    public class GameInfo
    {
        public int playerId { get; set; }
        public Guid UniqueId { get; set; }
        public Guid FirstRoundGuid { get; set; }
        public int BestOf { get; set; }
        public int BestOfScore { get; set; }
        public int TimeToAnswer { get; set; }
        public string EnnemyName { get; set; }
    }

    public class RoundInfo
    {
        public Guid UniqueId { get; set; }
        public int BestOfScore { get; set; }
        public WinStatus PlayerWinStatus { get; set; }
    }
}
