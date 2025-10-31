using ChatApp.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.DAL
{
    public class ChatMessageDAL
    {
        public List<ChatMessage> GetBy(string senderId, string receiverId)
        {
            string sql = string.Format("SELECT * FROM ChatMessage Where SenderId = N'{0}' AND ReceiverId = N'{1}' ORDER BY SendTime ASC", senderId, receiverId);
            List<ChatMessage> msgs = new List<ChatMessage>();
            using (var conn = KetNoi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable ret = new DataTable();
                da.Fill(ret);
                msgs = ConvertToList(ret);
            }
            return msgs;
        }

        private List<ChatMessage> ConvertToList(DataTable tb)
        {
            if (tb.Rows.Count <= 0)
                return new List<ChatMessage>();
            List<ChatMessage> msgs = new List<ChatMessage>();
            foreach (DataRow dr in tb.Rows)
            { 
                ChatMessage msg = new ChatMessage();
                msg.MsgId = dr.Field<string>(nameof(msg.MsgId));
                msg.MsgType = (MessageType) dr.Field<int>(nameof(msg.MsgType));
                msg.SendTime = dr.Field<DateTime>(nameof(msg.SendTime));
                msg.Data = dr.Field<string>(nameof(msg.Data));
                msg.SenderId = dr.Field<string>(nameof(msg.SenderId));
                msg.ReceiverId = dr.Field<string>(nameof(msg.ReceiverId));
                msgs.Add(msg);
            }

            return msgs;
        }

        public int Insert(ChatMessage msg) {
            
            string sql = @"INSERT INTO [ChatMessage] ([MsgId], [MsgType], [SendTime], [Data], [SenderId], [ReceiverId]) 
	        VALUES (@MsgId, @MsgType, @SendTime, @Data, @SenderId, @ReceiverId)";

            using (var conn = KetNoi.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("MsgId", msg.MsgId);
                cmd.Parameters.AddWithValue("MsgType", msg.MsgType);
                cmd.Parameters.AddWithValue("SendTime", msg.SendTime);
                cmd.Parameters.AddWithValue("Data", msg.Data);
                cmd.Parameters.AddWithValue("SenderId", msg.SenderId);
                cmd.Parameters.AddWithValue("ReceiverId", msg.ReceiverId);
                return cmd.ExecuteNonQuery(); 
            }
        }

    }
}
