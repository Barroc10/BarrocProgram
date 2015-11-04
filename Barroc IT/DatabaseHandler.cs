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

        public bool InsertInto (string adress0, string houseNumber, string city0, string zipcode0, string contact, string contactInitials, int phoneNumber, int fax, string email, string companyName, string adress1, string houseNumber1, string city1, string zipcode1, int phoneNumber1)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_clients (C_Adress0, C_HouseNumber0, C_City0, C_Zipcode0, C_Adress1, C_HouseNumber1, C_City1, C_Zipcode1, C_Contact, C_Contat_Initials, C_Phonenumber0, C_Phonenumber1, C_Fax, C_Email, C_CompanyName, C_CreditWorthy, C_BKRCheck, C_MaintenanceContract, C_BankNumber) VALUES ('" + adress0 + "' , '" + houseNumber + "', '"  + city0 + "' , '" + zipcode0 + "' , '" + adress1 + "' , '" + houseNumber1 + "' , '" + city1 + "' , '" + zipcode1 + "' , '" + contact + "' , '" + contactInitials + "' , " + phoneNumber + " , " + phoneNumber1 + " , " + fax + " , '" + email + "' , '" + companyName + "' , 0, 0, 0, 0)");
            //command.Parameters.AddWithValue("a0",adress0);
            //command.Parameters.AddWithValue("a1",adress1);
            //command.Parameters.AddWithValue("hn0",houseNumber);
            //command.Parameters.AddWithValue("hn1",houseNumber1);
            //command.Parameters.AddWithValue("c0",city0);
            //command.Parameters.AddWithValue("c1",city1);
            //command.Parameters.AddWithValue("zc0",zipcode0);
            //command.Parameters.AddWithValue("zc1",zipcode1);
            //command.Parameters.AddWithValue("con",contact);
            //command.Parameters.AddWithValue("coni",contactInitials);
            //command.Parameters.AddWithValue("pn0",phoneNumber);
            //command.Parameters.AddWithValue("pn1",phoneNumber1);
            //command.Parameters.AddWithValue("f",fax);
            //command.Parameters.AddWithValue("e",email);
            //command.Parameters.AddWithValue("cn",companyName);
            command.Connection = conn;
            //string commandText = command.CommandText.ToString();
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows >= 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }
        


    }
}
