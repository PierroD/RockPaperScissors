using RPSMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public static class Processor
    {
        public static void MessageProcessor(Form form, Encapsulation message, TcpClients client)
        {
            switch (message.MessageType)
            {
                case MessageType.Discover:
                    Response.DiscoverResponse(client);
                    Thread.Sleep(1000);
                    MatchMaking(form);
                    Response.SearchingResponse(client);
                    break;
                case MessageType.Disconnect:
                    Environment.Exit(0);
                    break;
            }
        }


        public static void MatchMaking(Form form)
        {
            form.Invoke(new MethodInvoker(delegate
            {
                form.Controls.Find("pnl_Matchmaking", true).FirstOrDefault().Visible = true;
            }));
        }
    }
}
