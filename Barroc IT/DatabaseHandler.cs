using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;


namespace Barroc_IT
{

    class DatabaseHandler
    {
        private string connectionString;
        public DatabaseHandler()
        {
            //connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Joris\Documents\School\Periode 5\Project\Barroc IT\Barroc IT\Barroc IT.mdf";
            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDBFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Barroc IT.mdf";
        }

        public DatabaseHandler(string ConnectionString)
        {
            connectionString = ConnectionString;
        }

        public int CountQuerry(string count, string from, string where1, string where2)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT COUNT(@0) FROM " + from + " WHERE @1 = @2");
            command.Parameters.Add(new SqlParameter("0", count.ToString()));
            command.Parameters.Add(new SqlParameter("1", where1));
            command.Parameters.Add(new SqlParameter("2", where2.ToCharArray()));
            conn.Open();
            command.Connection = conn;

            result = (int)command.ExecuteScalar();
            conn.Close();
            conn.Dispose();
            return result;

        }

        public DataTable SelectQuerryDT(string select, string from, string where1, string where2)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT @0 FROM @1 WHERE @2 = @3");
            command.Parameters.Add(new SqlParameter("0", select));
            command.Parameters.Add(new SqlParameter("1", from));
            command.Parameters.Add(new SqlParameter("2", where1));
            command.Parameters.Add(new SqlParameter("3", where2));
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();
            conn.Close();
            conn.Dispose();
            return schemaTable;
        }

        public string[] SelectQuerryAR(string select,string from, string where1, string where2)
        {
            int i = 0;
            string[] result = new string[100];
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT @0 FROM @1 WHERE @2 = @3");
            command.Parameters.Add(new SqlParameter("0", select));
            command.Parameters.Add(new SqlParameter("1", from));
            command.Parameters.Add(new SqlParameter("2", where1));
            command.Parameters.Add(new SqlParameter("3", where2));
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result[i] = reader.GetString(0);
                }
            }
            conn.Close();
            conn.Dispose();
            return result;
        }

        //public void InsertIntoQuerry (string insertInto, )
        


    }
}
