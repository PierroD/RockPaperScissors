using RockPaperScissors.Views;
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
                    setGameInfo(message);
                    toogleGame_View(form, true);
                    break;
                case MessageType.NextRound:
                    CloseWaitingWindows();
                    setNextRoundInfo(form, message);
                    break;
                case MessageType.GameEnd:
                    gameEndProcessor(form, message);
                    break;
            }
        }

        private static void toogleMatchMaking_View(Form form)
        {
            form.Invoke(new MethodInvoker(delegate
            {
                form.Controls.Find("pnl_Matchmaking", true).FirstOrDefault().Visible = true;
            }));
        }

        private static void setGameInfo(Encapsulation message)
        {
            var gameInfo = Encapsulation.Deserialize<SharedClasses.GameInfo>(message);
            GameInfo.myId = gameInfo.playerId;
            GameInfo.UniqueId = gameInfo.UniqueId;
            GameInfo.RoundGuid = gameInfo.FirstRoundGuid;
            GameInfo.BestOf = gameInfo.BestOf;
            GameInfo.TimeToAnswer = gameInfo.TimeToAnswer;
            GameInfo.EnnemyName = gameInfo.EnnemyName;
        }

        private static void toogleGame_View(Form form, bool enable)
        {
            form.Invoke(new MethodInvoker(delegate
            {
                form.Controls.Find("pnl_Matchmaking", true).FirstOrDefault().Visible = !enable;
                form.Controls.Find("pnl_gameChoices", true).FirstOrDefault().Visible = enable;
                form.Controls.Find("pnl_results", true).FirstOrDefault().Visible = enable;
                form.Controls.Find("lbl_bestOf", true).FirstOrDefault().Visible = enable;
                form.Controls.Find("lbl_ennemy", true).FirstOrDefault().Text = GameInfo.EnnemyName;
                form.Controls.Find("lbl_bestOf", true).FirstOrDefault().Text += GameInfo.BestOf.ToString();
            }));
        }

        static Thread waitingThread;
        public static void OpenWaitingWindows(Form form)
        {
            waitingThread = new Thread(() => openAppWindow.OpenWindow(form, new Form_Waiting()));
            waitingThread.Start();
        }

        private static void CloseWaitingWindows()
        {
            if (waitingThread.IsAlive)
                waitingThread.Abort();
        }


        private static void setNextRoundInfo(Form form, Encapsulation message)
        {
            var roundInfo = Encapsulation.Deserialize<RoundInfo>(message);
            GameInfo.RoundGuid = roundInfo.UniqueId;

            if (roundInfo.PlayerWinStatus != WinStatus.Tie)
            {
                string label_name = (roundInfo.PlayerWinStatus == WinStatus.Win) ? "lbl_youScore" : "lbl_ennemyScore";
                form.Invoke(new MethodInvoker(delegate
                {
                    form.Controls.Find(label_name, true).FirstOrDefault().Text = $"{(int.Parse(form.Controls.Find(label_name, true).FirstOrDefault().Text) + 1)}";
                }));
            }
        }

        private static void gameEndProcessor(Form form, Encapsulation message)
        {
            var gameEnd = Encapsulation.Deserialize<GameEnd>(message);
            if (gameEnd.PlayerWinStatus == WinStatus.Win)
                openAppWindow.OpenWindow(form, new Form_Win());
            else
                openAppWindow.OpenWindow(form, new Form_Lose());

        }

    }
}
