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
        private BindingSource bindingSource = new BindingSource();
        private DatabaseHandler dbh = new DatabaseHandler();

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
            bindingSource.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dgv_Projects.DataSource = bindingSource;
            dgv_Projects.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            int index = dgv_Projects.CurrentRow.Index;
            string temp = dgv_Projects["P_ProjectID", index].Value.ToString();
            int temp1;
            int.TryParse(temp, out temp1);
            MainFormReference.Main.newProjectID = temp1;
            MainFormReference.Main.UpdateDataGridViewProjects();
            this.Close();
        }
    }
}
