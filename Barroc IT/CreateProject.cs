﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    public partial class CreateProject : Form
    {
        DatabaseHandler dbh = new DatabaseHandler();
        private string projectName;
        private string projectHardware;
        private string projectOS;
        private string projectComment;
        private string internalContactPerson;
        private string companyName;
        private string maintenanceContract;
        private bool succesfull;

        public CreateProject()
        {
            InitializeComponent();
            //List<string> companys = new List<string>();
            //string query = "SELECT C_CompanyName FROM tbl_clients";
            //companys.Add("Company");
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

            string[] companys = dbh.SelectQuerryAR("C_CompanyName", "tbl_clients");

            foreach (string item in companys)
            {
                if (item == null) break;
                cb_ClientName.Items.Add(item);
            }



            //for (int i = 0; i < companys.Length - 1; i++)
            //{
            //    if (companys[i] == null) break;
            //    cb_ClientName.Items.Add(companys[i]);
            //}
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            projectName = tb_ProjectName.Text;
            projectHardware = tb_Hardware.Text;
            projectOS = tb_OS.Text;
            projectComment = tb_Appointments.Text;
            internalContactPerson = tb_InternalContactPerson.Text;
            companyName = cb_ClientName.SelectedItem.ToString();


            int projectCount = dbh.CountQuerry("*", "tbl_projects", "P_Name", projectName);

            if (projectCount == 0)
            {
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

                //succesfull1 = dbh.InsertInto("tbl_projects", projectName, projectHardware, projectOS, projectComment);

                //succesfull2 = dbh.InsertInto("tbl_clients", internalContactPerson, companyName, maintenanceContract);

                //if (succesfull1 == true && succesfull2 == true)
                //{
                //    MessageBox.Show("Succesfully created project!");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("The data couldn't be saved, please check your connection to the internet and contact your server administrator");
                //}

                succesfull = dbh.InsertIntoProjects(projectName, projectHardware, projectOS, projectComment, internalContactPerson);


                if (succesfull)
                {
                    string projectID = dbh.SelectQuerryAR("P_ProjectID", "tbl_projects", "P_Name", projectName)[0]; // string id = SELECT P_ProjectID FROM tbl_projects WHERE P_Name = 'projectName'

                    string ledgerNumber = dbh.SelectQuerryAR("C_LedgerNumber", "tbl_clients", "C_CompanyName", companyName)[0]; // string number = SELECT C_LedgerNumber FROM tbl_clients WHERE C_CompanyName = 'companyName'
                 
                    succesfull = dbh.InsertIntoRules1(ledgerNumber, projectID);

                    if (succesfull)
                    {
                        MessageBox.Show("Succesfully created project!");
                        this.Close();
                        return;
                    }
                }

                MessageBox.Show("The data couldn't be saved, please check your connection to the internet and contact your server administrator");

                



            }
        }

        private void cb_ClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cb_ClientName.SelectedItem.ToString();

            bool contract = dbh.HasMaintenanceContract("C_MaintenanceContract", "tbl_clients", "C_CompanyName", company);
            // SELECT C_MaintenanceContract FROM tbl_clients WHERE C_CompanyName = 'company'

            if (contract) lbl_Contract.Text = "Yes";
            else lbl_Contract.Text = "No";
        }
    }
}
