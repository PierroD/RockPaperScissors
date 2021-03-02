using RPSMessage;
using SharedClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class Response
    {
        public static void DisconnectMessage(TcpClients client)
        {
            SocketHelper.WriteToServer(client, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "Disconnect" }, MessageType.Disconnect)));
        }

        public static void DiscoverResponse(TcpClients client)
        {
            SocketHelper.WriteToServer(client, Encapsulation.Serialize(Encapsulation.FromValue(new Discover { UserName = Environment.UserName }, MessageType.Discover)));

        }

        public static void SearchingResponse(TcpClients client)
        {
            SocketHelper.WriteToServer(client, Encapsulation.Serialize(Encapsulation.FromValue(new GenericMessage { Message = "Looking for a game" }, MessageType.Searching)));

        }

        public static void AnswerResponse(TcpClients client, Choice playerChoice, int TimeToAnswer)
        {
            SocketHelper.WriteToServer(client, Encapsulation.Serialize(Encapsulation.FromValue(new Answer { GameId = GameInfo.UniqueId, TimeToAnswer = TimeToAnswer, playerChoice = playerChoice }, MessageType. Answer)));

        }
    }

}
