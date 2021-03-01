using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class SocketHelper
    {
        public static void WriteToServer(TcpClients client, byte[] message)
        {
            client.tcpClient.GetStream().Write(message, 0, message.Length);
        }


    }
}
