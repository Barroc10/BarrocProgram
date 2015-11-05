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
    public partial class ViewMeeting : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private DatabaseHandler dbh = new DatabaseHandler();
        private DateTime date = new DateTime();
        public ViewMeeting()
        {
            InitializeComponent();
        }
        public ViewMeeting(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            string select = "*";
            string from = "tbl_meetings";
            string where1 = "M_Date";
            string where2 = date.ToString();
            bindingSource1.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
