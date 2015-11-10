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
    public partial class SearchProject : Form
    {
        DatabaseHandler dbh = new DatabaseHandler();

        public SearchProject()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string select = "*";
            string from = "tbl_projects";
            string where1 = "P_Name";
            string where2 = tb_Property.Text;
            where2 = "%" + where2 + "%";
            bs_BindingSource.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dgv_Projects.DataSource = bs_BindingSource;
            dgv_Projects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {

        }
    }
}
