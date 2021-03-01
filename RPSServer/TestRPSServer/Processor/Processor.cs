using RPSMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRPSServer.Models;

namespace TestRPSServer
{
    public static class Processor
    {
        public static void MessageProcessor(Encapsulation message, Player player)
        {
            switch(message.MessageType)
            {
                case MessageType.Disconnect:
                    Console.WriteLine($"Connection with Client {player.id} closed !");
                    player.tcpClient.Close();
                    break;
            }
        }
    }
}
