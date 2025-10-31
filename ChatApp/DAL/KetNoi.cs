using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;

namespace ChatApp.DAL
{
    public static class KetNoi
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["ChatApp"]
            .ConnectionString;
        private static SqlConnection _conn;

        public static SqlConnection GetConnection()
        {
             _conn = new SqlConnection (strConn);
            if (_conn.State != System.Data.ConnectionState.Open)
                _conn.Open();
            return _conn;
        }
    }
}
