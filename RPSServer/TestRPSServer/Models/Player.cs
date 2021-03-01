using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestRPSServer.Models
{
    public class Player
    {
        public TcpClient tcpClient { get; set; }
        public int id { get; set; }
        
        public int score { get; set; }

        public Player(TcpClient tcpClient, int id)
        {
            this.tcpClient = tcpClient;
            this.id = id;
        }

    }
}
