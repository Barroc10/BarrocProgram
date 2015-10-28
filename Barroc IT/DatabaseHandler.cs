using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_IT
{
    class DatabaseHandler
    {
        //string conString;
        SqlConnection con;

        public DatabaseHandler()
        {
            //conString = Properties.Settings.Default.DBConnenctionString; source linken in settings
            con = new SqlConnection();
        }

        public void Connect()
        {
            con.Open();
        }

        public void Disconnect()
        {
            con.Close();
            con.Dispose();
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
