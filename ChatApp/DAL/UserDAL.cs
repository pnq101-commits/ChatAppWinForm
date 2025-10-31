using ChatApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.DAL
{
    public class UserDAL
    {
        public List<User> GetAllReceiverExcept(string userId)
        {
            string sql = string.Format("SELECT * FROM [User] WHERE UserId != N'{0}'", userId);
            List<User> msgs = new List<User>();
            using (var conn = KetNoi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable ret = new DataTable();
                da.Fill(ret);
                msgs = ConvertToList(ret);
            }
            return msgs;
        }

        public List<User> GetBy()
        {
            string sql = string.Format("SELECT * FROM [User]");
            List<User> msgs = new List<User>();
            using (var conn = KetNoi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable ret = new DataTable();
                da.Fill(ret);
                msgs = ConvertToList(ret);
            }
            return msgs;
        }

        private List<User> ConvertToList(DataTable tb)
        {
            if (tb.Rows.Count <= 0)
                return new List<User>();
            List<User> msgs = new List<User>();
            foreach (DataRow dr in tb.Rows)
            {
                User msg = new User();
                msg.UserId = dr.Field<string>(nameof(msg.UserId));
                msg.FullName = dr.Field<string>(nameof(msg.FullName));
                msg.Email = dr.Field<string>(nameof(msg.Email));
                msg.Password = dr.Field<string>(nameof(msg.Password));
                msg.AvatarUrl = dr.Field<string>(nameof(msg.AvatarUrl));
               
                msgs.Add(msg);
            }

            return msgs;
        }

        public int Insert(User msg)
        {

            string sql = @"INSERT INTO [User] ([UserId], [FullName], [Email], [Password], [AvatarUrl]) 
	                            VALUES (@UserId, @FullName, @Email, @Password, @AvatarUrl)";

            using (var conn = KetNoi.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("UserId", msg.UserId);
                cmd.Parameters.AddWithValue("FullName", msg.FullName);
                cmd.Parameters.AddWithValue("Email", msg.Email);
                cmd.Parameters.AddWithValue("Password", msg.Password);
                cmd.Parameters.AddWithValue("AvatarUrl", msg.AvatarUrl);
                return cmd.ExecuteNonQuery();
            }
        }

        public User Login(string email, string password)
        {
            string sql = @"SELECT [UserId], [FullName], [Email], [Password], [AvatarUrl]
	                FROM   [dbo].[User]
	                WHERE  [Email] = @Email AND [Password] = @Password";

            using (var conn = KetNoi.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("Email", email);
                da.SelectCommand.Parameters.AddWithValue("Password", password);
                DataTable ret = new DataTable();
                da.Fill(ret);
                if (ret.Rows.Count > 0)
                {
                    var dr = ret.Rows[0];

                    User msg = new User();
                    msg.UserId = dr.Field<string>(nameof(msg.UserId));
                    msg.FullName = dr.Field<string>(nameof(msg.FullName));
                    msg.Email = dr.Field<string>(nameof(msg.Email));
                    msg.Password = dr.Field<string>(nameof(msg.Password));
                    msg.AvatarUrl = dr.Field<string>(nameof(msg.AvatarUrl));

                    return msg;
                }
            }

            return null;
        }
    }
}
