﻿using System;
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
    public partial class Login : Form
    {
        private DatabaseHandler dbh = new DatabaseHandler();
        private bool succesful;

        public Login()
        {
            InitializeComponent();
            succesful = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (tb_Username.TextLength != 0)
            {
                username = tb_Username.Text;
            }
            else
            {
                MessageBox.Show("Please enter an username");
                return;
            }

            if (tb_Password.TextLength != 0)
            {
                password = tb_Password.Text;
            }
            else
            {
                MessageBox.Show("Please enter a password");
                return;
            }
            if (username == "sales" || username == "dev" || username == "finance")
            {
                int correct = 0;
                correct = dbh.CountQuerry("*", "tbl_rights", "R_DepartmentPassword", password);
                if (correct == 1)
                {
                    succesful = true;
                    MainFormReference.Main.LoggedIn(tb_Username.Text);
                }
                else
                {
                    MessageBox.Show("The password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("The username is incorrect");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!succesful) MainFormReference.Main.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
