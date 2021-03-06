using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class GameInfo
    {
        public static int myId { get; set; }
        public static Guid UniqueId { get; set; }
        public static Guid RoundGuid { get; set; }
        public static int BestOf { get; set; }
        public static int TimeToAnswer { get; set; }
        public static string EnnemyName { get; set; }
    }
}
