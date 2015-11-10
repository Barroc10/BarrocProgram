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
        private bool succesfull;


        public CreateQuotation()
        {
            InitializeComponent();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd-MM-yyyy";
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
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

            //succesfull = dbh.InsertIntoQuotations();

        }
    }
}
