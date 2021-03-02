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
            switch(message.MessageType)
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
            }
        }
    }
}
