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
    public partial class CreateClient : Form
    {
        private List<string> errorMessage = new List<string>();
        private bool isError = false;
        private string company1;
        private string address1;
        private string number1;
        private string city1;
        private string zipCode1;
        private string address2;
        private string number2;
        private string city2;
        private string zipCode2;
        private string contactPerson;
        private string initials;
        private int phoneNumber1;
        private int phoneNumber2;
        private int faxNumber;
        private string email;
        private DatabaseHandler dbh = new DatabaseHandler();

        public CreateClient()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            isError = false;
            CheckInformation();
            if (!isError)
            {
                bool succesfull = false;
                company1 = tb_Company1.Text;
                address1 = tb_Address1.Text;
                number1 = tb_Number1.Text;
                city1 = tb_City1.Text;
                zipCode1 = tb_Zipcode.Text;
                address2 = tb_Address2.Text;
                number2 = tb_Number2.Text;
                city2 = tb_City2.Text;
                zipCode2 = tb_Zipcode2.Text;
                contactPerson = tb_ContactPerson.Text;
                initials = tb_Initials.Text;
                phoneNumber1 = Convert.ToInt32(tb_PhoneNumber1.Text);
                if (tb_PhoneNumber2.Text != "")
                {
                    phoneNumber2 = Convert.ToInt32(tb_PhoneNumber2.Text);
                }
                if (tb_FaxNumber.Text != "")
                {
                    faxNumber = Convert.ToInt32(tb_FaxNumber.Text);
                }
                email = tb_Email.Text;

                succesfull = dbh.InsertInto(address1, number1, city1, zipCode1, contactPerson, initials, phoneNumber1, faxNumber, email, company1, address2, number2, city2, zipCode2, phoneNumber2);
                if (succesfull)
                {
                    MessageBox.Show("The data for company " + company1 + " has been saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The data couldn't be saved, please check your connection to the internet and contact your server administrator");
                }
            }
        }

        private void CheckInformation()
        {
            if (tb_Company1.Text == "")
            {
                errorMessage.Add("Company 1");
                isError = true;
                tb_Company1.BackColor = Color.Red;
            }
            if (tb_Address1.Text == "")
            {
                errorMessage.Add("Address 1");
                isError = true;
                tb_Address1.BackColor = Color.Red;
            }
            if (!Utilities.checkNumber(tb_Number1.Text))
            {
                errorMessage.Add("Number 1");
                isError = true;
                tb_Number1.BackColor = Color.Red;
            }
            if (tb_City1.Text == "")
            {
                errorMessage.Add("City 1");
                isError = true;
                tb_City1.BackColor = Color.Red;
            }
            if (!Utilities.checkZipcode(tb_Zipcode.Text))
            {
                errorMessage.Add("Zipcode 1");
                isError = true;
                tb_Zipcode.BackColor = Color.Red;
            }
            if (!Utilities.checkNumber(tb_Number2.Text) && tb_Number2.Text != "")
            {
                errorMessage.Add("Number 2");
                isError = true;
                tb_Number2.BackColor = Color.Red;
            }
            if (!Utilities.checkZipcode(tb_Zipcode2.Text) && tb_Zipcode2.Text != "")
            {
                errorMessage.Add("Zipcode 2");
                isError = true;
                tb_Zipcode2.BackColor = Color.Red;
            }
            if (tb_ContactPerson.Text == "")
            {
                errorMessage.Add("Contact person");
                isError = true;
                tb_ContactPerson.BackColor = Color.Red;
            }
            if (tb_Initials.Text == "")
            {
                errorMessage.Add("Initials");
                isError = true;
                tb_Initials.BackColor = Color.Red;
            }
            if (!Utilities.checkPhoneNumber(tb_PhoneNumber1.Text))
            {
                errorMessage.Add("Phone number 1");
                isError = true;
                tb_PhoneNumber1.BackColor = Color.Red;
            }
            if (!Utilities.checkPhoneNumber(tb_PhoneNumber2.Text) && tb_PhoneNumber2.Text != "")
            {
                errorMessage.Add("Phone number 2");
                isError = true;
                tb_PhoneNumber2.BackColor = Color.Red;
            }
            if (!Utilities.checkNumber(tb_FaxNumber.Text) && tb_FaxNumber.Text != "")
            {
                errorMessage.Add("Fax number");
                isError = true;
                tb_FaxNumber.BackColor = Color.Red;
            }
            if (!Utilities.checkEmail(tb_Email.Text))
            {
                errorMessage.Add("Email");
                isError = true;
                tb_Email.BackColor = Color.Red;
            }



            if (isError)
            {
                string error = "De volgende velden zijn fout:";
                for (int i = 0; i < errorMessage.Count; i++)
                {
                    error += "\n" + errorMessage[i];
                }
                MessageBox.Show(error);
                errorMessage.Clear();
            }
            
        }

        private void tb_Company1_TextChanged(object sender, EventArgs e)
        {
            tb_Company1.BackColor = Color.White;
        }

        private void tb_Address1_TextChanged(object sender, EventArgs e)
        {
            tb_Address1.BackColor = Color.White;
        }

        private void tb_Number1_TextChanged(object sender, EventArgs e)
        {
            tb_Number1.BackColor = Color.White;
        }

        private void tb_City1_TextChanged(object sender, EventArgs e)
        {
            tb_City1.BackColor = Color.White;
        }

        private void tb_Zipcode_TextChanged(object sender, EventArgs e)
        {
            tb_Zipcode.BackColor = Color.White;
        }

        private void tb_Address2_TextChanged(object sender, EventArgs e)
        {
            tb_Address1.BackColor = Color.White;
        }

        private void tb_Number2_TextChanged(object sender, EventArgs e)
        {
            tb_Number2.BackColor = Color.White;
        }

        private void tb_City2_TextChanged(object sender, EventArgs e)
        {
            tb_City2.BackColor = Color.White;
        }

        private void tb_Zipcode2_TextChanged(object sender, EventArgs e)
        {
            tb_Zipcode2.BackColor = Color.White;
        }

        private void tb_ContactPerson_TextChanged(object sender, EventArgs e)
        {
            tb_ContactPerson.BackColor = Color.White;
        }

        private void tb_Initials_TextChanged(object sender, EventArgs e)
        {
            tb_Initials.BackColor = Color.White;
        }

        private void tb_PhoneNumber1_TextChanged(object sender, EventArgs e)
        {
            tb_PhoneNumber1.BackColor = Color.White;
        }

        private void tb_PhoneNumber2_TextChanged(object sender, EventArgs e)
        {
            tb_PhoneNumber2.BackColor = Color.White;
        }

        private void tb_FaxNumber_TextChanged(object sender, EventArgs e)
        {
            tb_FaxNumber.BackColor = Color.White;
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            tb_Email.BackColor = Color.White;
        }
    }
}
