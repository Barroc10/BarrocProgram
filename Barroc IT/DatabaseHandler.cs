using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Barroc_IT
{

    class DatabaseHandler
    {
        private string connectionString;
        public DatabaseHandler()
        {
            //connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Joris\Documents\School\Periode 5\Project\Barroc IT\Barroc IT\Barroc IT.mdf";
            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Barroc IT.mdf";
        }

        public DatabaseHandler(string ConnectionString)
        {
            connectionString = ConnectionString;
        }

        public int CountQuerry(string count, string from, string where1, string where2) // werkt volledig met de inlog functie
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT COUNT (@count) FROM " + from + " WHERE " + where1 + " = @Pass");
            command.Parameters.AddWithValue("count", SqlDbType.Char); 
            command.Parameters["count"].Value = count;
            command.Parameters.AddWithValue("Pass", SqlDbType.NVarChar);
            command.Parameters["Pass"].Value = where2.ToCharArray();
            command.Connection = conn;

            conn.Open();
            result = (int)command.ExecuteScalar();
            conn.Close();
            conn.Dispose();
            return result;

        }

        public DataTable SelectQuerryDT(string select, string from, string where1, string where2)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + from + " WHERE " + where1 + " LIKE '" + where2 + "'");
            command.Parameters.AddWithValue("0", where2);
            command.Connection = conn;
            
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            da.Fill(table);
            conn.Close();
            conn.Dispose();

            return table;
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
