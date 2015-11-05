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
    public partial class MainScreen : Form
    {
        Login login = new Login();
        Timer time = new Timer();
        BackgroundWorker updateTimeWorker = new BackgroundWorker();

        CreateClient createClient;
        SearchClient searchClient;
        CreateProject createProject;
        SearchProject searchProject;
        ViewMeeting viewMeeting;
        CreateMeeting createMeeting;
        ModifyMeeting modifyMeeting;
        CreateInvoice createInvoice;
        ViewInvoices viewInvoice;
        CreateQuotation createQuotation;
        SearchQuotation searchQuotation;

        public MainScreen()
        {
            InitializeComponent();
            this.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            login.Show();
            time.Elapsed += SyncSeconds;
            updateTimeWorker.DoWork += UpdateTimeWorker_DoWork;
            updateTimeWorker.WorkerReportsProgress = true;
            lbl_Time.Text = Timer.GetTime();
            lbl_Date.Text = Timer.GetDate();
        }

        private void UpdateTimeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (this.lbl_Time.InvokeRequired)
            {
                this.lbl_Time.BeginInvoke((MethodInvoker)delegate() { this.lbl_Time.Text = Timer.GetTime(); });                
            }
            else
            {
                lbl_Time.Text = Timer.GetTime();
            }
            if (this.lbl_Date.Text != Timer.GetDate())
            {
                if (this.lbl_Date.InvokeRequired)
                {
                    this.lbl_Date.BeginInvoke((MethodInvoker)delegate() { this.lbl_Date.Text = Timer.GetDate(); });
                }
                else
                {
                    lbl_Date.Text = Timer.GetDate();
                }
            }                        
        }

        private void SyncSeconds(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateTimeWorker.RunWorkerAsync();
            time.Enabled = false;
            time.Interval = 60000;
            time.Elapsed -= SyncSeconds;
            time.Elapsed += TimeChanged;
            time.Enabled = true;
        }

        private void TimeChanged(object sender, System.Timers.ElapsedEventArgs e)
        {
            updateTimeWorker.RunWorkerAsync();
        }

        private void btn_CreateClient_Click(object sender, EventArgs e)
        {
            if (createClient == null)
            {
                createClient = new CreateClient();
                createClient.Show();
                return;
            }

            if (!createClient.Visible)
            {
                createClient = new CreateClient();
                createClient.Show();
            }

            else
            {
                createClient.Focus();
            }
        }

        private void btn_SearchClient_Click(object sender, EventArgs e)
        {
            if (searchClient == null)
            {
                searchClient = new SearchClient();
                searchClient.Show();
                return;
            }

            if (!searchClient.Visible)
            {
                createClient = new CreateClient();
                createClient.Show();
            }

            else
            {
                createClient.Focus();
            }
        }

        private void btn_CreateProject_Click(object sender, EventArgs e)
        {
            if (createProject == null)
            {
                createProject = new CreateProject();
                createProject.Show();
                return;
            }

            if (!createProject.Visible)
            {
                createProject = new CreateProject();
                createProject.Show();
            }

            else
            {
                createProject.Focus();
            }
        }

        private void btn_SearchProject_Click(object sender, EventArgs e)
        {

            if (searchProject == null)
            {
                searchProject = new SearchProject();
                searchProject.Show();
                return;
            }

            if (!searchProject.Visible)
            {
                searchProject = new SearchProject();
                searchProject.Show();
            }

            else
            {
                searchProject.Focus();
            }
        }

        private void btn_ViewMeeting_Click(object sender, EventArgs e)
        {
            if (viewMeeting == null)
            {
                viewMeeting = new ViewMeeting();
                viewMeeting.Show();
                return;
            }

            if (!viewMeeting.Visible)
            {
                viewMeeting = new ViewMeeting();
                viewMeeting.Show();
            }

            else
            {
                viewMeeting.Focus();
            }
        }

        private void btn_CreateMeeting_Click(object sender, EventArgs e)
        {
            if (createMeeting == null)
            {
                createMeeting = new CreateMeeting();
                createMeeting.Show();
                return;
            }

            if (!createMeeting.Visible)
            {
                createMeeting = new CreateMeeting();
                createMeeting.Show();
            }

            else
            {
                createMeeting.Focus();
            }
        }

        private void btn_ModifyMeeting_Click(object sender, EventArgs e)
        {
            if (modifyMeeting == null)
            {
                modifyMeeting = new ModifyMeeting();
                modifyMeeting.Show();
                return;
            }
        }

        private void btn_SearchClient_F_Click(object sender, EventArgs e)
        {
            if (searchClient == null)
            {
                searchClient = new SearchClient();
            }

            if (!searchClient.Visible)
            {
                searchClient = new SearchClient();
                searchClient.Show();
            }

            else
            {
                searchClient.Focus();
            }


        }

        private void btn_CreateInvoice_Click(object sender, EventArgs e)
        {
            if (createInvoice == null)
            {
                createInvoice = new CreateInvoice();
                createInvoice.Show();
                return;
            }

            if (!createInvoice.Visible)
            {
                createInvoice = new CreateInvoice();
                createInvoice.Show();
            }

            else
            {
                createInvoice.Focus();
            }
        }

        private void btn_ViewInvoices_Click(object sender, EventArgs e)
        {
            if (viewInvoice == null)
            {
                viewInvoice = new ViewInvoices();
                viewInvoice.Show();
                return;
            }

            if (!viewInvoice.Visible)
            {
                viewInvoice = new ViewInvoices();
                viewInvoice.Show();
            }

            else
            {
                viewInvoice.Focus();
            }
        }

        private void btn_ModifyNewClient_Click(object sender, EventArgs e)
        {
            if (searchClient == null)
            {
                searchClient = new SearchClient();
                searchClient.Show();
                return;
            }

            if (!searchClient.Visible)
            {
                searchClient = new SearchClient();
                searchClient.Show();
            }

            else
            {
                searchClient.Focus();
            }
        }

        private void btn_CreateQuotation_Click(object sender, EventArgs e)
        {
            if (createQuotation == null)
            {
                createQuotation = new CreateQuotation();
                createQuotation.Show();
                return;
            }

            if (!createQuotation.Visible)
            {
                createQuotation = new CreateQuotation();
                createQuotation.Show();
            }

            else
            {
                createQuotation.Focus();
            }

        }

        private void btn_SearchQuotation_Click(object sender, EventArgs e)
        {
            if (searchQuotation == null)
            {
                searchQuotation = new SearchQuotation();
                searchQuotation.Show();
            }

            if (!searchQuotation.Visible)
            {
                searchQuotation = new SearchQuotation();
                searchQuotation.Show();
            }

            else
            {
                searchQuotation.Focus();
            }
        }

        public void LoggedIn()
        {
            this.Enabled = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            login.Close();
        }

        private void btn_LogOut_C_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out!");
            this.Close();
        }

        private void dgv_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void calendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();
            DatabaseHandler dbh = new DatabaseHandler();

            MessageBox.Show(calendar1.SelectionEnd.ToString("dd-MM-yyyy"));
            string select = "M_Name";
            string from = "tbl_meetings";
            string where1 = "M_Date";
            string where2 = calendar1.SelectionEnd.ToString("dd-MM-yyyy");
            bindingSource1.DataSource = dbh.SelectQuerryDT(select, from, where1, where2);
            dgv_Meetings.DataSource = bindingSource1;
        }
    }
}
