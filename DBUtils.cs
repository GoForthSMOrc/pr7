using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practic5
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.70.5";
            int port = 3306;
            string database = "Blog";
            string username = "appuser";
            string password = "pass";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
