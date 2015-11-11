using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class CreateQuotation : Form
    {
        DatabaseHandler dbh = new DatabaseHandler();
        private List<string> errorMessage = new List<string>();
        private bool error;
        private string name;
        private DateTime date;
        private int price;
        private DateTime timeSpan;
        private string contactPerson;
        private string email;
        private string phoneNumber;
        private string address;
        private int houseNumber;
        private string city;
        private string zipcode;
        


        public CreateQuotation()
        {
            InitializeComponent();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd-MM-yyyy";
            dtp_TimeSpan.Format = DateTimePickerFormat.Custom;
            dtp_TimeSpan.CustomFormat = "dd-MM-yyyy";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            error = false;
            CheckInformation();
            if (error) return;

            name = tb_Name.Text;
            date = dtp_Date.Value;
            price = (int)num_Price.Value;
            timeSpan = dtp_TimeSpan.Value;
            contactPerson = tb_ContactPerson.Text;
            email = tb_Email.Text;
            phoneNumber = tb_PhoneNumber.Text;
            address = tb_Address.Text;
            houseNumber = (int)num_Number.Value;
            city = tb_City.Text;
            zipcode = tb_Zipcode.Text;

            bool succesfull = false;
            succesfull = dbh.InsertIntoQuotations(name, date, price, timeSpan, contactPerson, address, houseNumber, email, phoneNumber, city, zipcode);

        }

        private void CheckInformation()
        {
            if (tb_Name.Text == "")
            {
                errorMessage.Add("Name");
                error = true;
                tb_Name.BackColor = Color.Red;
            }

            //if (dtp_Date.Text == null)
            //{

            //}

            if (dtp_TimeSpan.Value <= dtp_Date.Value)
            {
                errorMessage.Add("Timespan");
                error = true;
                dtp_TimeSpan.CalendarMonthBackground = Color.Red;
            }

            if (tb_ContactPerson.Text == "")
            {
                errorMessage.Add("Contact person");
                error = true;
                tb_ContactPerson.BackColor = Color.Red;
            }

            if (!Utilities.checkEmail(tb_Email.Text))
            {
                errorMessage.Add("Email");
                error = true;
                tb_Email.BackColor = Color.Red;
            }

            if (Utilities.checkPhoneNumber(tb_PhoneNumber.Text) == false || tb_PhoneNumber.Text == "")
            {
                errorMessage.Add("Phone number");
                error = true;
                tb_PhoneNumber.BackColor = Color.Red;
            }

            if (tb_Address.Text == "")
            {
                errorMessage.Add("Address");
                error = true;
                tb_Address.BackColor = Color.Red;
            }

            if (tb_City.Text == "")
            {
                errorMessage.Add("City");
                error = true;
                tb_City.BackColor = Color.Red;
            }

            if (Utilities.checkZipcode(tb_Zipcode.Text) == false || tb_Zipcode.Text == "")
            {
                errorMessage.Add("Zipcode");
                error = true;
                tb_Zipcode.BackColor = Color.Red;
            }

            if (error)
            {
                string message = "De volgende velden zijn fout:";
                for (int i = 0; i < errorMessage.Count; i++)
                {
                    message += "\n" + errorMessage[i];
                }
                MessageBox.Show(message);
                errorMessage.Clear();
            }
            
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Name.BackColor = Color.White;
        }

        private void tb_ContactPerson_TextChanged(object sender, EventArgs e)
        {
            tb_ContactPerson.BackColor = Color.White;
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            tb_Email.BackColor = Color.White;
        }

        private void tb_PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            tb_PhoneNumber.BackColor = Color.White;
        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {
            tb_Address.BackColor = Color.White;
        }

        private void tb_City_TextChanged(object sender, EventArgs e)
        {
            tb_City.BackColor = Color.White;
        }

        private void tb_Zipcode_TextChanged(object sender, EventArgs e)
        {
            tb_Zipcode.BackColor = Color.White;
        }
    }
}
