using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RPSMessage
{
    public class Encapsulation
    {
        public MessageType MessageType { get; set; }
        public Object Value { get; set; }

        public static Encapsulation FromValue<T>(T value, MessageType messageType)
        {
            return new Encapsulation { MessageType = messageType, Value = JsonConvert.SerializeObject(value) };
        }

        public static byte[] Serialize(Encapsulation encapsulation)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(encapsulation));
        }

        public static Encapsulation Deserialize(byte[] data)
        {
            string message = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<Encapsulation>(message);
        }

    }

    public enum MessageType
    {
        Discover,
        Searching,
        Found,
        GameInfo,
        NextRound,
        Result,
        Disconnect
    }
}
