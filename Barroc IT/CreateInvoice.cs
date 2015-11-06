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
    public partial class CreateInvoice : Form
    {
        bool error = false;
        DatabaseHandler dbh = new DatabaseHandler();
        public CreateInvoice()
        {
            InitializeComponent();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd-MM-yyyy";
            string[] projects = dbh.SelectQuerryAR("P_Name", "tbl_projects");
            foreach (string item in projects)
            {
                if (item == null) break;
                cb_Project.Items.Add(item);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            checkInformation();
            if(!error)
            {
                dbh.in
            }
        }

        private void checkInformation()
        {
                if (tb_Reason.ToString() == "")
                {
                    error = true;
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
