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

    public class GameInfo
    {
        public Guid UniqueId { get; set; }
        public int BestOf { get; set; }
        public int TimeToAnswer { get; set; }
        public string EnnemyName { get; set; }
    }

}
