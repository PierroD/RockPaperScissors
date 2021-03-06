using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{

    public enum MessageType
    {
        Discover,
        Searching,
        GameInfo,
        Answer,
        NextRound,
        GameEnd,
        Disconnect
    }

    public enum Choice
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }

    public enum WinStatus
    {
        Lose, 
        Win,
        Tie,
    }

}
