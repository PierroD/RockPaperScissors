using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRPSServer.Models;

namespace TestRPSServer
{
    public static class SocketHelper
    {
        public static void WriteToPlayer(Player player, byte[] message)
        {
            player.tcpClient.GetStream().Write(message, 0, message.Length);
        }


    }
}
