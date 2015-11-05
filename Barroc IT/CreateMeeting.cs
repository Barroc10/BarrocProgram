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
    public partial class CreateMeeting : Form
    {
        private DatabaseHandler dbh = new DatabaseHandler();
        public CreateMeeting()
        {
            InitializeComponent();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd-MM-yyyy";
            dtp_StartTime.Format = DateTimePickerFormat.Custom;
            dtp_StartTime.CustomFormat = "hh:mm tt";
            dtp_StartTime.ShowUpDown = true;
            dtp_EndTime.Format = DateTimePickerFormat.Custom;
            dtp_EndTime.CustomFormat = "hh:mm tt";
            dtp_EndTime.ShowUpDown = true;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            bool isError = false;
            List<string> errorMessage = new List<string>();
            if (tb_MeetingName.Text == "")
            {
                isError = true;
                errorMessage.Add("Meeting name");
                tb_MeetingName.BackColor = Color.Red;
            }
            if (tb_Location.Text == "")
            {
                isError = true;
                errorMessage.Add("Location");
                tb_Location.BackColor = Color.Red;
            }
            if (cb_Client.Text == "")
	        {
		        isError = true;
                errorMessage.Add("Client");
                cb_Client.BackColor = Color.Red;
	        }
            if (isError)
            {
                string error = "De volgende dingen zijn niet goed ingevuld:";
                for (int i = 0; i < errorMessage.Count; i++)
                {
                    error += "\n" + errorMessage[i];
                }
                MessageBox.Show(error, "Error");
            }
            else
            {
                bool succesfull = false;
                succesfull = dbh.InsertInto(tb_MeetingName.Text, dtp_StartTime.Value, dtp_EndTime.Value, dtp_Date.Value, tb_Location.Text, cb_Client.Text, rtb_Comment.Text);
                if (succesfull)
                {
                    MessageBox.Show("Meeting aangemaakt");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void tb_MeetingName_TextChanged(object sender, EventArgs e)
        {
            tb_MeetingName.BackColor = Color.White;
        }

        private void tb_Location_TextChanged(object sender, EventArgs e)
        {
            tb_Location.BackColor = Color.White;
        }

        private void cb_Client_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Client.BackColor = Color.White;
        }
    }
}
