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
    public partial class SearchClient : Form
    {
        DatabaseHandler dbh = new DatabaseHandler();
        public SearchClient()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = tb_Property.Text;
            //dgv_Clients.
        }
    }
}
