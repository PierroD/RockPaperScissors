using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSMessage
{
    public class Message
    {
        public byte[] Data { get; set; }
        public MessageType MessageType { get; set; }
    }

    public enum MessageType
    {
        Searching,
        Found,
        GameInfo,
        NextRound,
        Result,
        Disconnect,
    }
}
