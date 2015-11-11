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
    public partial class ViewInvoices : Form
    {
        private DatabaseHandler dbh = new DatabaseHandler();
        public ViewInvoices()
        {
            InitializeComponent();
            GetInvoices();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetInvoices()
        {
            dataGridView1.DataSource = dbh.SelectDTStar("*", "tbl_invoices");
        }
    }
}
