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
        public ViewMeeting()
        {
            InitializeComponent();
        }
        public ViewMeeting(string name)
        {
            InitializeComponent();
            string select = "*";
            string from = "tbl_meetings";
            string where1 = "M_Name";
            string where2 = name;
            bindingSource1.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
