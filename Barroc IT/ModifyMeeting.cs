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
        public ModifyMeeting()
        {
            InitializeComponent();
            dtp_Date.Format = DateTimePickerFormat.Custom;
            dtp_Date.CustomFormat = "dd-MM-yyyy";
            dtp_StartTime.Format = DateTimePickerFormat.Custom;
            dtp_StartTime.CustomFormat = "hh:mm tt";
            dtp_StartTime.ShowUpDown = true;
            dtp_EndTime.Format = DateTimePickerFormat.Custom;
            dtp_EndTime.CustomFormat = "hh:mm tt";
            dtp_EndTime.ShowUpDown = true;
        }
    }
}
