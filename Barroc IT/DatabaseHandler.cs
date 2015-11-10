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

        public string[] SelectQuerryAR(string select, string from)
        {
            int i = 0;
            string[] result = new string[100];
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + from);
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result[i] = reader.GetString(0);
                    i++;
                }
            }
            conn.Close();
            conn.Dispose();
            return result;
        }

        public string[] SelectQuerryAR(string select, string from, string where1, string where2)
        {
            int i = 0;
            string[] result = new string[100];
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + from + " WHERE " + where1 + " = '" + where2 + "'");
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result[i] = reader.GetString(0);
                    i++;
                }
            }
            conn.Close();
            conn.Dispose();
            return result;
        }

        public int[] SelectID(string select, string from, string where1, string where2)
        {
            int i = 0;
            int[] result = new int[100];
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + from + " WHERE " + where1 + " = '" + where2 + "'");
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result[i] = reader.GetInt32(0);
                    i++;
                }
            }
            conn.Close();
            conn.Dispose();
            return result;
        }

        public bool InsertInto(string adress0, string houseNumber, string city0, string zipcode0, string contact, string contactInitials, int phoneNumber, int fax, string email, string companyName, string adress1, string houseNumber1, string city1, string zipcode1, int phoneNumber1)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_clients (C_Adress0, C_HouseNumber0, C_City0, C_Zipcode0, C_Adress1, C_HouseNumber1, C_City1, C_Zipcode1, C_Contact, C_Contat_Initials, C_Phonenumber0, C_Phonenumber1, C_Fax, C_Email, C_CompanyName, C_CreditWorthy, C_BKRCheck, C_MaintenanceContract, C_BankNumber) VALUES (@a0 , @hn0, @c0 , @zc0 , @a1 , @hn1 , @c1 , @zc1 , @con , @coni , @pn0 , @pn1 , @f , @e , @cn , 0, 0, 0, 0)");
            command.Parameters.AddWithValue("a0", adress0);
            command.Parameters.AddWithValue("a1", adress1);
            command.Parameters.AddWithValue("hn0", houseNumber);
            command.Parameters.AddWithValue("hn1", houseNumber1);
            command.Parameters.AddWithValue("c0", city0);
            command.Parameters.AddWithValue("c1", city1);
            command.Parameters.AddWithValue("zc0", zipcode0);
            command.Parameters.AddWithValue("zc1", zipcode1);
            command.Parameters.AddWithValue("con", contact);
            command.Parameters.AddWithValue("coni", contactInitials);
            command.Parameters.AddWithValue("pn0", phoneNumber);
            command.Parameters.AddWithValue("pn1", phoneNumber1);
            command.Parameters.AddWithValue("f", fax);
            command.Parameters.AddWithValue("e", email);
            command.Parameters.AddWithValue("cn", companyName);
            command.Connection = conn;
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }

        public bool InsertIntoProjects(string projectName, string projectHardware, string projectOS, string projectComment, string projectInternalContact, string projectPrice)
        {
            bool succesfull = false;

            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_projects (P_Name, P_Hardware, P_OS, P_Comment, P_InternalContact, P_Price) VALUES (@pn, @ph, @pos, @pcom, @pic, @pp)");

            command.Parameters.AddWithValue("pn", projectName);
            command.Parameters.AddWithValue("ph", projectHardware);
            command.Parameters.AddWithValue("pos", projectOS);
            command.Parameters.AddWithValue("pcom", projectComment);
            command.Parameters.AddWithValue("pic", projectInternalContact);
            command.Parameters.AddWithValue("pp", projectPrice);


            command.Connection = conn;
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }

        public bool InsertIntoQuotations(string qName, DateTime qDAte, int qPrice, DateTime qTimeSpan, string qContactPerson, string qEmail, string qAddress, int qHouseNumber, string qCity, string qZipCode)
        {
            bool succesfull = false;

            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_quotations (P_Name, P_Hardware, P_OS, P_Comment, P_InternalContact, P_Price) VALUES (@pn, @ph, @pos, @pcom, @pic, @pp)");

            command.Parameters.AddWithValue("pn", projectName);
            command.Parameters.AddWithValue("ph", projectHardware);
            command.Parameters.AddWithValue("pos", projectOS);
            command.Parameters.AddWithValue("pcom", projectComment);
            command.Parameters.AddWithValue("pic", projectInternalContact);
            command.Parameters.AddWithValue("pp", projectPrice);


            command.Connection = conn;
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }

        public bool HasMaintenanceContract(string select, string from, string where1, string where2)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT " + select + " FROM " + from + " WHERE " + where1 + " = '" + where2 + "'");
            command.Connection = conn;
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    result = reader.GetBoolean(0);
                }
                
            }
            conn.Close();
            conn.Dispose();
            return result;
        }

        public bool InsertIntoRules1 (int ledgerNumber, int projectID)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_c_regels1 (C_LedgerNumber, P_ProjectID) VALUES (@cln, @ppid)");
            command.Parameters.AddWithValue("cln", ledgerNumber);
            command.Parameters.AddWithValue("ppid", projectID);
            command.Connection = conn;
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }

        public bool InsertIntoMeeting(string meetingName, DateTime startTime, DateTime endTime, DateTime date, string location, string client, string note)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_meetings (M_Name, M_StartTime, M_EndTime, M_Date, M_Location, M_Participants, M_Note) VALUES (@mn, @st, @et, @md, @ml, @mp, @mn");
            command.Parameters.AddWithValue("@mn", meetingName);
            command.Parameters.AddWithValue("@st", startTime);
            command.Parameters.AddWithValue("@et", endTime);
            command.Parameters.AddWithValue("@md", date);
            command.Parameters.AddWithValue("@ml", location);
            command.Parameters.AddWithValue("@mp", client);
            command.Parameters.AddWithValue("@mn", note);
            command.Connection = conn;
            conn.Open();

            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }


        public bool InsertIntoInvoice(int amount, string reason, DateTime sentDate)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO tbl_invoices (I_Amount, I_SentDate, I_Reason, I_Status, I_IsSent) VALUES (@0, @1, @2, 0, 0)");
            command.Parameters.AddWithValue("0", amount);
            command.Parameters.AddWithValue("1", sentDate);
            command.Parameters.AddWithValue("2", reason);
            command.Connection = conn;

            conn.Open();
            amountOfRows = command.ExecuteNonQuery();
            if (amountOfRows == 1)
            {
                succesfull = true;
            }
            conn.Close();
            conn.Dispose();
            return succesfull;
        }

        public bool Delete(string tbl, string columName, string value)
        {
            bool succesfull = false;
            int amountOfRows = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("DELETE FROM " + tbl + " WHERE " + columName + " = @2");
            command.Parameters.AddWithValue("2", value);
            command.Connection = conn;

            conn.Open();
            amountOfRows = command.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

            if (amountOfRows == 0)
            {
                succesfull = true;
            }
            return succesfull;
        }
    }
}
