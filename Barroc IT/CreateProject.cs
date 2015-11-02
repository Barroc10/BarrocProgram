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
    public partial class CreateProject : Form
    {
        private string projectName;
        private string projectHardware;
        private string projectOS;
        private string projectComment;
        private string internalContactPerson;
        private string companyName;
        private bool maintenanceContract;

        public CreateProject()
        {
            InitializeComponent();
            List<string> companys = new List<string>();
            string query = "SELECT C_CompanyName FROM tbl_clients";
            companys.Add("Company");

            /*using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        companys.Add(reader.GetString(0));
                    }
                }
            }
             */
            
            foreach (string item in companys)
            {
                cb_ClientName.Items.Add(item);
            }            
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            projectName = tb_ProjectName.Text;
            projectHardware = tb_Hardware.Text;
            projectOS = tb_OS.Text;
            projectComment = tb_Appointments.Text;
            internalContactPerson = tb_InternalContactPerson.Text;
            companyName = cb_ClientName.SelectedItem.ToString();

            if (cb_MaintenanceContract.SelectedItem == "Yes") { maintenanceContract = true; }
            else { maintenanceContract = false; }
            

            /*
             * INSERT INTO tbl_projects (P_Name, P_Hardware, P_OS, P_Comment);
             * command.Parameters.AddWithValue("@Name", projectName);
             * command.Parameters.AddWithValue("@Hardware", projectHardware);
             * command.Parameters.AddWithValue("@OS", projectOS);
             * command.Parameters.AddWithValue("@Comment", projectComment);
             * 
             * 
             * INSERT INTO tbl_clients
             * (C_Contact, C_CompanyName, C_MaintenanceContract)
             * command.Parameters.AddWithValue("@Contact", internalContactPerson);
             * command.Parameters.AddWithValue("@CompanyName", companyName);
             * command.Parameters.AddWithValue("@MaintenanceContract", maintenanceContract);
            */
        }
    }
}
