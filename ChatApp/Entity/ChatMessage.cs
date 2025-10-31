using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Entity
{
    public class ChatMessage
    {
        public ChatMessage() 
        {
            MsgId = Guid.NewGuid().ToString();
            SendTime = DateTime.Now;
            Data = string.Empty;
        }

        public string MsgId { get; set; }
        public MessageType MsgType { get; set; }
        public DateTime SendTime { get; set; }
        public string Data { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
    }
}
