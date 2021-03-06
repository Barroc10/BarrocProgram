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
    public partial class SearchClient : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DatabaseHandler dbh = new DatabaseHandler();
        public SearchClient()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string select = "*";
            string from = "tbl_clients";
            string where1 = "C_CompanyName";
            string where2 = tb_Property.Text;
            where2 = "%" + where2 + "%";
            bindingSource.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dgv_Clients.DataSource = bindingSource;
            dgv_Clients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            int index = dgv_Clients.CurrentRow.Index;
            string temp = dgv_Clients["C_LedgerNumber", index].Value.ToString();
            int temp1;
            int.TryParse(temp, out temp1);
            MainFormReference.Main.newLedgerID = temp1;
            MainFormReference.Main.UpdateDataGridViewClients();
            this.Close();
        }
    }
}
