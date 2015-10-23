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
        private bool succesful = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            succesful = true;   // als login voltooid is
            MainFormReference.Main.LoggedIn(); 
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
