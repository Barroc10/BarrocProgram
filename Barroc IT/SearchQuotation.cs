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
    public partial class SearchQuotation : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DatabaseHandler dbh = new DatabaseHandler();
        public SearchQuotation()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string select = "*";
            string from = "tbl_quotations";
            string where1 = "Q_Name";
            string where2 = tb_Property.Text;
            where2 = "%" + where2 + "%";
            bindingSource.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dgv_Quotations.DataSource = bindingSource;
            dgv_Quotations.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
