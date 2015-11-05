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
    public partial class ModifyMeeting : Form
    {
        public ModifyMeeting(DataGridViewSelectedRowCollection selected)
        {
            InitializeComponent();
            dataGridView1.DataSource = selected;
        }
    }
}
