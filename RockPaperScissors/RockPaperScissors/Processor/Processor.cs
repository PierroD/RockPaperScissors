using RPSMessage;
using SharedClasses;
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
                    toogleMatchMaking_View(form);
                    Response.SearchingResponse(client);
                    break;
                case MessageType.Disconnect:
                    Environment.Exit(0);
                    break;
                case MessageType.GameInfo:
                    toogleGame_View(form, message);
                    break;
            }
        }


        public static void toogleMatchMaking_View(Form form)
        {
            form.Invoke(new MethodInvoker(delegate
            {
                form.Controls.Find("pnl_Matchmaking", true).FirstOrDefault().Visible = true;
            }));
        }

        public static void toogleGame_View(Form form, Encapsulation message)
        {
            form.Invoke(new MethodInvoker(delegate
            {
                form.Controls.Find("pnl_Matchmaking", true).FirstOrDefault().Visible = false;
                form.Controls.Find("pnl_gameChoices", true).FirstOrDefault().Visible = true;
                form.Controls.Find("pnl_results", true).FirstOrDefault().Visible = true;
                form.Controls.Find("lbl_ennemy", true).FirstOrDefault().Text = Encapsulation.Deserialize<GameInfo>(message).EnnemyName;
            }));
        }


    }
}
