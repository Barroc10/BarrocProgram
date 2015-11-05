namespace Barroc_IT
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tab_Clients = new System.Windows.Forms.TabPage();
            this.lbl_Username_C = new System.Windows.Forms.Label();
            this.lbl_LoggedInAs_C = new System.Windows.Forms.Label();
            this.btn_LogOut_C = new System.Windows.Forms.Button();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.btn_PrintClient = new System.Windows.Forms.Button();
            this.btn_SearchClient_C = new System.Windows.Forms.Button();
            this.btn_ModifyClient_C = new System.Windows.Forms.Button();
            this.btn_CreateClient = new System.Windows.Forms.Button();
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.tab_Projects = new System.Windows.Forms.TabPage();
            this.lbl_Username_P = new System.Windows.Forms.Label();
            this.lbl_LoggedInAs_P = new System.Windows.Forms.Label();
            this.btn_LogOut_P = new System.Windows.Forms.Button();
            this.btn_DeleteProject = new System.Windows.Forms.Button();
            this.btn_PrintProject = new System.Windows.Forms.Button();
            this.btn_SearchProject = new System.Windows.Forms.Button();
            this.btn_ModifyProject = new System.Windows.Forms.Button();
            this.btn_CreateProject = new System.Windows.Forms.Button();
            this.dgv_Projects = new System.Windows.Forms.DataGridView();
            this.tab_Meetings = new System.Windows.Forms.TabPage();
            this.lbl_Username_M = new System.Windows.Forms.Label();
            this.lbl_LoggedInAs_M = new System.Windows.Forms.Label();
            this.btn_LogOut_M = new System.Windows.Forms.Button();
            this.btn_ViewMeeting = new System.Windows.Forms.Button();
            this.btn_ModifyMeeting = new System.Windows.Forms.Button();
            this.btn_CreateMeeting = new System.Windows.Forms.Button();
            this.dgv_Meetings = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tab_Finance = new System.Windows.Forms.TabPage();
            this.lbl_Username_F = new System.Windows.Forms.Label();
            this.lbl_LoggedInAs_F = new System.Windows.Forms.Label();
            this.btn_LogOut_F = new System.Windows.Forms.Button();
            this.btn_ModifyNewClient = new System.Windows.Forms.Button();
            this.btn_ViewInvoices = new System.Windows.Forms.Button();
            this.btn_CreateInvoice = new System.Windows.Forms.Button();
            this.lbl_ModifyClient_F = new System.Windows.Forms.Button();
            this.btn_SearchClient_F = new System.Windows.Forms.Button();
            this.dgv_Finance = new System.Windows.Forms.DataGridView();
            this.tab_Offer = new System.Windows.Forms.TabPage();
            this.lbl_Username_Q = new System.Windows.Forms.Label();
            this.lbl_LoggedInAs_Q = new System.Windows.Forms.Label();
            this.btn_LogOut_Q = new System.Windows.Forms.Button();
            this.btn_DeleteQuotation = new System.Windows.Forms.Button();
            this.btn_ChangeStatus = new System.Windows.Forms.Button();
            this.btn_ModifyQuotation = new System.Windows.Forms.Button();
            this.btn_SearchQuotation = new System.Windows.Forms.Button();
            this.btn_CreateQuotation = new System.Windows.Forms.Button();
            this.dgv_Quatations = new System.Windows.Forms.DataGridView();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.tc_Main.SuspendLayout();
            this.tab_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.tab_Projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
            this.tab_Meetings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meetings)).BeginInit();
            this.tab_Finance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finance)).BeginInit();
            this.tab_Offer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quatations)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tab_Clients);
            this.tc_Main.Controls.Add(this.tab_Projects);
            this.tc_Main.Controls.Add(this.tab_Meetings);
            this.tc_Main.Controls.Add(this.tab_Finance);
            this.tc_Main.Controls.Add(this.tab_Offer);
            this.tc_Main.ItemSize = new System.Drawing.Size(120, 50);
            this.tc_Main.Location = new System.Drawing.Point(-3, -3);
            this.tc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(692, 424);
            this.tc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_Main.TabIndex = 0;
            // 
            // tab_Clients
            // 
            this.tab_Clients.Controls.Add(this.lbl_Username_C);
            this.tab_Clients.Controls.Add(this.lbl_LoggedInAs_C);
            this.tab_Clients.Controls.Add(this.btn_LogOut_C);
            this.tab_Clients.Controls.Add(this.btn_DeleteClient);
            this.tab_Clients.Controls.Add(this.btn_PrintClient);
            this.tab_Clients.Controls.Add(this.btn_SearchClient_C);
            this.tab_Clients.Controls.Add(this.btn_ModifyClient_C);
            this.tab_Clients.Controls.Add(this.btn_CreateClient);
            this.tab_Clients.Controls.Add(this.dgv_Clients);
            this.tab_Clients.Location = new System.Drawing.Point(4, 54);
            this.tab_Clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Clients.Name = "tab_Clients";
            this.tab_Clients.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Clients.Size = new System.Drawing.Size(684, 366);
            this.tab_Clients.TabIndex = 0;
            this.tab_Clients.Text = "Clients";
            this.tab_Clients.UseVisualStyleBackColor = true;
            // 
            // lbl_Username_C
            // 
            this.lbl_Username_C.AutoSize = true;
            this.lbl_Username_C.Location = new System.Drawing.Point(601, 321);
            this.lbl_Username_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username_C.Name = "lbl_Username_C";
            this.lbl_Username_C.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username_C.TabIndex = 8;
            this.lbl_Username_C.Text = "Development";
            // 
            // lbl_LoggedInAs_C
            // 
            this.lbl_LoggedInAs_C.AutoSize = true;
            this.lbl_LoggedInAs_C.Location = new System.Drawing.Point(526, 321);
            this.lbl_LoggedInAs_C.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedInAs_C.Name = "lbl_LoggedInAs_C";
            this.lbl_LoggedInAs_C.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoggedInAs_C.TabIndex = 7;
            this.lbl_LoggedInAs_C.Text = "Logged in as:";
            // 
            // btn_LogOut_C
            // 
            this.btn_LogOut_C.Location = new System.Drawing.Point(583, 336);
            this.btn_LogOut_C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut_C.Name = "btn_LogOut_C";
            this.btn_LogOut_C.Size = new System.Drawing.Size(92, 26);
            this.btn_LogOut_C.TabIndex = 6;
            this.btn_LogOut_C.Text = "Log out";
            this.btn_LogOut_C.UseVisualStyleBackColor = true;
            this.btn_LogOut_C.Click += new System.EventHandler(this.btn_LogOut_C_Click);
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.Location = new System.Drawing.Point(583, 186);
            this.btn_DeleteClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(92, 37);
            this.btn_DeleteClient.TabIndex = 5;
            this.btn_DeleteClient.Text = "Delete client";
            this.btn_DeleteClient.UseVisualStyleBackColor = true;
            // 
            // btn_PrintClient
            // 
            this.btn_PrintClient.Location = new System.Drawing.Point(583, 145);
            this.btn_PrintClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PrintClient.Name = "btn_PrintClient";
            this.btn_PrintClient.Size = new System.Drawing.Size(92, 37);
            this.btn_PrintClient.TabIndex = 4;
            this.btn_PrintClient.Text = "Print client";
            this.btn_PrintClient.UseVisualStyleBackColor = true;
            this.btn_PrintClient.Click += new System.EventHandler(this.btn_PrintClient_Click);
            // 
            // btn_SearchClient_C
            // 
            this.btn_SearchClient_C.Location = new System.Drawing.Point(583, 103);
            this.btn_SearchClient_C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SearchClient_C.Name = "btn_SearchClient_C";
            this.btn_SearchClient_C.Size = new System.Drawing.Size(92, 37);
            this.btn_SearchClient_C.TabIndex = 3;
            this.btn_SearchClient_C.Text = "Search client";
            this.btn_SearchClient_C.UseVisualStyleBackColor = true;
            this.btn_SearchClient_C.Click += new System.EventHandler(this.btn_SearchClient_Click);
            // 
            // btn_ModifyClient_C
            // 
            this.btn_ModifyClient_C.Location = new System.Drawing.Point(583, 62);
            this.btn_ModifyClient_C.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModifyClient_C.Name = "btn_ModifyClient_C";
            this.btn_ModifyClient_C.Size = new System.Drawing.Size(92, 37);
            this.btn_ModifyClient_C.TabIndex = 2;
            this.btn_ModifyClient_C.Text = "Modify client";
            this.btn_ModifyClient_C.UseVisualStyleBackColor = true;
            // 
            // btn_CreateClient
            // 
            this.btn_CreateClient.Location = new System.Drawing.Point(583, 20);
            this.btn_CreateClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateClient.Name = "btn_CreateClient";
            this.btn_CreateClient.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateClient.TabIndex = 1;
            this.btn_CreateClient.Text = "Create client";
            this.btn_CreateClient.UseVisualStyleBackColor = true;
            this.btn_CreateClient.Click += new System.EventHandler(this.btn_CreateClient_Click);
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToOrderColumns = true;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Location = new System.Drawing.Point(10, 20);
            this.dgv_Clients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.RowTemplate.Height = 24;
            this.dgv_Clients.Size = new System.Drawing.Size(440, 336);
            this.dgv_Clients.TabIndex = 0;
            this.dgv_Clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellContentClick);
            // 
            // tab_Projects
            // 
            this.tab_Projects.Controls.Add(this.lbl_Username_P);
            this.tab_Projects.Controls.Add(this.lbl_LoggedInAs_P);
            this.tab_Projects.Controls.Add(this.btn_LogOut_P);
            this.tab_Projects.Controls.Add(this.btn_DeleteProject);
            this.tab_Projects.Controls.Add(this.btn_PrintProject);
            this.tab_Projects.Controls.Add(this.btn_SearchProject);
            this.tab_Projects.Controls.Add(this.btn_ModifyProject);
            this.tab_Projects.Controls.Add(this.btn_CreateProject);
            this.tab_Projects.Controls.Add(this.dgv_Projects);
            this.tab_Projects.Location = new System.Drawing.Point(4, 54);
            this.tab_Projects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Projects.Name = "tab_Projects";
            this.tab_Projects.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Projects.Size = new System.Drawing.Size(684, 366);
            this.tab_Projects.TabIndex = 1;
            this.tab_Projects.Text = "Projects";
            this.tab_Projects.UseVisualStyleBackColor = true;
            // 
            // lbl_Username_P
            // 
            this.lbl_Username_P.AutoSize = true;
            this.lbl_Username_P.Location = new System.Drawing.Point(601, 321);
            this.lbl_Username_P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username_P.Name = "lbl_Username_P";
            this.lbl_Username_P.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username_P.TabIndex = 17;
            this.lbl_Username_P.Text = "Development";
            // 
            // lbl_LoggedInAs_P
            // 
            this.lbl_LoggedInAs_P.AutoSize = true;
            this.lbl_LoggedInAs_P.Location = new System.Drawing.Point(526, 321);
            this.lbl_LoggedInAs_P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedInAs_P.Name = "lbl_LoggedInAs_P";
            this.lbl_LoggedInAs_P.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoggedInAs_P.TabIndex = 16;
            this.lbl_LoggedInAs_P.Text = "Logged in as:";
            // 
            // btn_LogOut_P
            // 
            this.btn_LogOut_P.Location = new System.Drawing.Point(583, 336);
            this.btn_LogOut_P.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut_P.Name = "btn_LogOut_P";
            this.btn_LogOut_P.Size = new System.Drawing.Size(92, 26);
            this.btn_LogOut_P.TabIndex = 15;
            this.btn_LogOut_P.Text = "Log out";
            this.btn_LogOut_P.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProject
            // 
            this.btn_DeleteProject.Location = new System.Drawing.Point(583, 186);
            this.btn_DeleteProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteProject.Name = "btn_DeleteProject";
            this.btn_DeleteProject.Size = new System.Drawing.Size(92, 37);
            this.btn_DeleteProject.TabIndex = 14;
            this.btn_DeleteProject.Text = "Delete project";
            this.btn_DeleteProject.UseVisualStyleBackColor = true;
            // 
            // btn_PrintProject
            // 
            this.btn_PrintProject.Location = new System.Drawing.Point(583, 145);
            this.btn_PrintProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_PrintProject.Name = "btn_PrintProject";
            this.btn_PrintProject.Size = new System.Drawing.Size(92, 37);
            this.btn_PrintProject.TabIndex = 13;
            this.btn_PrintProject.Text = "Print project";
            this.btn_PrintProject.UseVisualStyleBackColor = true;
            // 
            // btn_SearchProject
            // 
            this.btn_SearchProject.Location = new System.Drawing.Point(583, 103);
            this.btn_SearchProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SearchProject.Name = "btn_SearchProject";
            this.btn_SearchProject.Size = new System.Drawing.Size(92, 37);
            this.btn_SearchProject.TabIndex = 12;
            this.btn_SearchProject.Text = "Search project";
            this.btn_SearchProject.UseVisualStyleBackColor = true;
            this.btn_SearchProject.Click += new System.EventHandler(this.btn_SearchProject_Click);
            // 
            // btn_ModifyProject
            // 
            this.btn_ModifyProject.Location = new System.Drawing.Point(583, 62);
            this.btn_ModifyProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModifyProject.Name = "btn_ModifyProject";
            this.btn_ModifyProject.Size = new System.Drawing.Size(92, 37);
            this.btn_ModifyProject.TabIndex = 11;
            this.btn_ModifyProject.Text = "Modify project";
            this.btn_ModifyProject.UseVisualStyleBackColor = true;
            // 
            // btn_CreateProject
            // 
            this.btn_CreateProject.Location = new System.Drawing.Point(583, 20);
            this.btn_CreateProject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateProject.Name = "btn_CreateProject";
            this.btn_CreateProject.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateProject.TabIndex = 10;
            this.btn_CreateProject.Text = "Create project";
            this.btn_CreateProject.UseVisualStyleBackColor = true;
            this.btn_CreateProject.Click += new System.EventHandler(this.btn_CreateProject_Click);
            // 
            // dgv_Projects
            // 
            this.dgv_Projects.AllowUserToOrderColumns = true;
            this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Projects.Location = new System.Drawing.Point(10, 20);
            this.dgv_Projects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Projects.Name = "dgv_Projects";
            this.dgv_Projects.RowTemplate.Height = 24;
            this.dgv_Projects.Size = new System.Drawing.Size(440, 336);
            this.dgv_Projects.TabIndex = 9;
            // 
            // tab_Meetings
            // 
            this.tab_Meetings.Controls.Add(this.lbl_Username_M);
            this.tab_Meetings.Controls.Add(this.lbl_LoggedInAs_M);
            this.tab_Meetings.Controls.Add(this.btn_LogOut_M);
            this.tab_Meetings.Controls.Add(this.btn_ViewMeeting);
            this.tab_Meetings.Controls.Add(this.btn_ModifyMeeting);
            this.tab_Meetings.Controls.Add(this.btn_CreateMeeting);
            this.tab_Meetings.Controls.Add(this.dgv_Meetings);
            this.tab_Meetings.Controls.Add(this.monthCalendar1);
            this.tab_Meetings.Location = new System.Drawing.Point(4, 54);
            this.tab_Meetings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Meetings.Name = "tab_Meetings";
            this.tab_Meetings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Meetings.Size = new System.Drawing.Size(684, 366);
            this.tab_Meetings.TabIndex = 2;
            this.tab_Meetings.Text = "Meetings";
            this.tab_Meetings.UseVisualStyleBackColor = true;
            // 
            // lbl_Username_M
            // 
            this.lbl_Username_M.AutoSize = true;
            this.lbl_Username_M.Location = new System.Drawing.Point(601, 321);
            this.lbl_Username_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username_M.Name = "lbl_Username_M";
            this.lbl_Username_M.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username_M.TabIndex = 28;
            this.lbl_Username_M.Text = "Development";
            // 
            // lbl_LoggedInAs_M
            // 
            this.lbl_LoggedInAs_M.AutoSize = true;
            this.lbl_LoggedInAs_M.Location = new System.Drawing.Point(526, 321);
            this.lbl_LoggedInAs_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedInAs_M.Name = "lbl_LoggedInAs_M";
            this.lbl_LoggedInAs_M.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoggedInAs_M.TabIndex = 27;
            this.lbl_LoggedInAs_M.Text = "Logged in as:";
            // 
            // btn_LogOut_M
            // 
            this.btn_LogOut_M.Location = new System.Drawing.Point(583, 336);
            this.btn_LogOut_M.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut_M.Name = "btn_LogOut_M";
            this.btn_LogOut_M.Size = new System.Drawing.Size(92, 26);
            this.btn_LogOut_M.TabIndex = 26;
            this.btn_LogOut_M.Text = "Log out";
            this.btn_LogOut_M.UseVisualStyleBackColor = true;
            // 
            // btn_ViewMeeting
            // 
            this.btn_ViewMeeting.Location = new System.Drawing.Point(579, 74);
            this.btn_ViewMeeting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ViewMeeting.Name = "btn_ViewMeeting";
            this.btn_ViewMeeting.Size = new System.Drawing.Size(92, 37);
            this.btn_ViewMeeting.TabIndex = 25;
            this.btn_ViewMeeting.Text = "View meeting";
            this.btn_ViewMeeting.UseVisualStyleBackColor = true;
            this.btn_ViewMeeting.Click += new System.EventHandler(this.btn_ViewMeeting_Click);
            // 
            // btn_ModifyMeeting
            // 
            this.btn_ModifyMeeting.Location = new System.Drawing.Point(579, 115);
            this.btn_ModifyMeeting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModifyMeeting.Name = "btn_ModifyMeeting";
            this.btn_ModifyMeeting.Size = new System.Drawing.Size(92, 37);
            this.btn_ModifyMeeting.TabIndex = 24;
            this.btn_ModifyMeeting.Text = "Modify meeting";
            this.btn_ModifyMeeting.UseVisualStyleBackColor = true;
            this.btn_ModifyMeeting.Click += new System.EventHandler(this.btn_ModifyMeeting_Click);
            // 
            // btn_CreateMeeting
            // 
            this.btn_CreateMeeting.Location = new System.Drawing.Point(579, 33);
            this.btn_CreateMeeting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateMeeting.Name = "btn_CreateMeeting";
            this.btn_CreateMeeting.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateMeeting.TabIndex = 23;
            this.btn_CreateMeeting.Text = "Create meeting";
            this.btn_CreateMeeting.UseVisualStyleBackColor = true;
            this.btn_CreateMeeting.Click += new System.EventHandler(this.btn_CreateMeeting_Click);
            // 
            // dgv_Meetings
            // 
            this.dgv_Meetings.AllowUserToOrderColumns = true;
            this.dgv_Meetings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Meetings.Location = new System.Drawing.Point(250, 33);
            this.dgv_Meetings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Meetings.Name = "dgv_Meetings";
            this.dgv_Meetings.RowTemplate.Height = 24;
            this.dgv_Meetings.Size = new System.Drawing.Size(180, 295);
            this.dgv_Meetings.TabIndex = 22;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 25);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            // 
            // tab_Finance
            // 
            this.tab_Finance.Controls.Add(this.lbl_Username_F);
            this.tab_Finance.Controls.Add(this.lbl_LoggedInAs_F);
            this.tab_Finance.Controls.Add(this.btn_LogOut_F);
            this.tab_Finance.Controls.Add(this.btn_ModifyNewClient);
            this.tab_Finance.Controls.Add(this.btn_ViewInvoices);
            this.tab_Finance.Controls.Add(this.btn_CreateInvoice);
            this.tab_Finance.Controls.Add(this.lbl_ModifyClient_F);
            this.tab_Finance.Controls.Add(this.btn_SearchClient_F);
            this.tab_Finance.Controls.Add(this.dgv_Finance);
            this.tab_Finance.Location = new System.Drawing.Point(4, 54);
            this.tab_Finance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Finance.Name = "tab_Finance";
            this.tab_Finance.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Finance.Size = new System.Drawing.Size(684, 366);
            this.tab_Finance.TabIndex = 3;
            this.tab_Finance.Text = "Finance";
            this.tab_Finance.UseVisualStyleBackColor = true;
            // 
            // lbl_Username_F
            // 
            this.lbl_Username_F.AutoSize = true;
            this.lbl_Username_F.Location = new System.Drawing.Point(601, 321);
            this.lbl_Username_F.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username_F.Name = "lbl_Username_F";
            this.lbl_Username_F.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username_F.TabIndex = 18;
            this.lbl_Username_F.Text = "Development";
            // 
            // lbl_LoggedInAs_F
            // 
            this.lbl_LoggedInAs_F.AutoSize = true;
            this.lbl_LoggedInAs_F.Location = new System.Drawing.Point(526, 321);
            this.lbl_LoggedInAs_F.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedInAs_F.Name = "lbl_LoggedInAs_F";
            this.lbl_LoggedInAs_F.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoggedInAs_F.TabIndex = 16;
            this.lbl_LoggedInAs_F.Text = "Logged in as:";
            // 
            // btn_LogOut_F
            // 
            this.btn_LogOut_F.Location = new System.Drawing.Point(584, 336);
            this.btn_LogOut_F.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut_F.Name = "btn_LogOut_F";
            this.btn_LogOut_F.Size = new System.Drawing.Size(92, 26);
            this.btn_LogOut_F.TabIndex = 15;
            this.btn_LogOut_F.Text = "Log out";
            this.btn_LogOut_F.UseVisualStyleBackColor = true;
            // 
            // btn_ModifyNewClient
            // 
            this.btn_ModifyNewClient.Location = new System.Drawing.Point(584, 186);
            this.btn_ModifyNewClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModifyNewClient.Name = "btn_ModifyNewClient";
            this.btn_ModifyNewClient.Size = new System.Drawing.Size(92, 37);
            this.btn_ModifyNewClient.TabIndex = 14;
            this.btn_ModifyNewClient.Text = "Modify new client";
            this.btn_ModifyNewClient.UseVisualStyleBackColor = true;
            this.btn_ModifyNewClient.Click += new System.EventHandler(this.btn_ModifyNewClient_Click);
            // 
            // btn_ViewInvoices
            // 
            this.btn_ViewInvoices.Location = new System.Drawing.Point(584, 145);
            this.btn_ViewInvoices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ViewInvoices.Name = "btn_ViewInvoices";
            this.btn_ViewInvoices.Size = new System.Drawing.Size(92, 37);
            this.btn_ViewInvoices.TabIndex = 13;
            this.btn_ViewInvoices.Text = "View invoices";
            this.btn_ViewInvoices.UseVisualStyleBackColor = true;
            this.btn_ViewInvoices.Click += new System.EventHandler(this.btn_ViewInvoices_Click);
            // 
            // btn_CreateInvoice
            // 
            this.btn_CreateInvoice.Location = new System.Drawing.Point(584, 103);
            this.btn_CreateInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateInvoice.Name = "btn_CreateInvoice";
            this.btn_CreateInvoice.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateInvoice.TabIndex = 12;
            this.btn_CreateInvoice.Text = "Create invoice";
            this.btn_CreateInvoice.UseVisualStyleBackColor = true;
            this.btn_CreateInvoice.Click += new System.EventHandler(this.btn_CreateInvoice_Click);
            // 
            // lbl_ModifyClient_F
            // 
            this.lbl_ModifyClient_F.Location = new System.Drawing.Point(584, 62);
            this.lbl_ModifyClient_F.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_ModifyClient_F.Name = "lbl_ModifyClient_F";
            this.lbl_ModifyClient_F.Size = new System.Drawing.Size(92, 37);
            this.lbl_ModifyClient_F.TabIndex = 11;
            this.lbl_ModifyClient_F.Text = "Modify client";
            this.lbl_ModifyClient_F.UseVisualStyleBackColor = true;
            // 
            // btn_SearchClient_F
            // 
            this.btn_SearchClient_F.Location = new System.Drawing.Point(584, 20);
            this.btn_SearchClient_F.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SearchClient_F.Name = "btn_SearchClient_F";
            this.btn_SearchClient_F.Size = new System.Drawing.Size(92, 37);
            this.btn_SearchClient_F.TabIndex = 10;
            this.btn_SearchClient_F.Text = "Search client";
            this.btn_SearchClient_F.UseVisualStyleBackColor = true;
            this.btn_SearchClient_F.Click += new System.EventHandler(this.btn_SearchClient_F_Click);
            // 
            // dgv_Finance
            // 
            this.dgv_Finance.AllowUserToOrderColumns = true;
            this.dgv_Finance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Finance.Location = new System.Drawing.Point(10, 20);
            this.dgv_Finance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Finance.Name = "dgv_Finance";
            this.dgv_Finance.RowTemplate.Height = 24;
            this.dgv_Finance.Size = new System.Drawing.Size(440, 336);
            this.dgv_Finance.TabIndex = 9;
            // 
            // tab_Offer
            // 
            this.tab_Offer.Controls.Add(this.lbl_Username_Q);
            this.tab_Offer.Controls.Add(this.lbl_LoggedInAs_Q);
            this.tab_Offer.Controls.Add(this.btn_LogOut_Q);
            this.tab_Offer.Controls.Add(this.btn_DeleteQuotation);
            this.tab_Offer.Controls.Add(this.btn_ChangeStatus);
            this.tab_Offer.Controls.Add(this.btn_ModifyQuotation);
            this.tab_Offer.Controls.Add(this.btn_SearchQuotation);
            this.tab_Offer.Controls.Add(this.btn_CreateQuotation);
            this.tab_Offer.Controls.Add(this.dgv_Quatations);
            this.tab_Offer.Location = new System.Drawing.Point(4, 54);
            this.tab_Offer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Offer.Name = "tab_Offer";
            this.tab_Offer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Offer.Size = new System.Drawing.Size(684, 366);
            this.tab_Offer.TabIndex = 4;
            this.tab_Offer.Text = "Quotation";
            this.tab_Offer.UseVisualStyleBackColor = true;
            // 
            // lbl_Username_Q
            // 
            this.lbl_Username_Q.AutoSize = true;
            this.lbl_Username_Q.Location = new System.Drawing.Point(601, 321);
            this.lbl_Username_Q.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username_Q.Name = "lbl_Username_Q";
            this.lbl_Username_Q.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username_Q.TabIndex = 17;
            this.lbl_Username_Q.Text = "Development";
            // 
            // lbl_LoggedInAs_Q
            // 
            this.lbl_LoggedInAs_Q.AutoSize = true;
            this.lbl_LoggedInAs_Q.Location = new System.Drawing.Point(526, 321);
            this.lbl_LoggedInAs_Q.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoggedInAs_Q.Name = "lbl_LoggedInAs_Q";
            this.lbl_LoggedInAs_Q.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoggedInAs_Q.TabIndex = 16;
            this.lbl_LoggedInAs_Q.Text = "Logged in as:";
            // 
            // btn_LogOut_Q
            // 
            this.btn_LogOut_Q.Location = new System.Drawing.Point(583, 336);
            this.btn_LogOut_Q.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut_Q.Name = "btn_LogOut_Q";
            this.btn_LogOut_Q.Size = new System.Drawing.Size(92, 26);
            this.btn_LogOut_Q.TabIndex = 15;
            this.btn_LogOut_Q.Text = "Log out";
            this.btn_LogOut_Q.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteQuotation
            // 
            this.btn_DeleteQuotation.Location = new System.Drawing.Point(574, 186);
            this.btn_DeleteQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteQuotation.Name = "btn_DeleteQuotation";
            this.btn_DeleteQuotation.Size = new System.Drawing.Size(102, 37);
            this.btn_DeleteQuotation.TabIndex = 14;
            this.btn_DeleteQuotation.Text = "Delete quotation";
            this.btn_DeleteQuotation.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeStatus
            // 
            this.btn_ChangeStatus.Location = new System.Drawing.Point(574, 145);
            this.btn_ChangeStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ChangeStatus.Name = "btn_ChangeStatus";
            this.btn_ChangeStatus.Size = new System.Drawing.Size(102, 37);
            this.btn_ChangeStatus.TabIndex = 13;
            this.btn_ChangeStatus.Text = "Change status";
            this.btn_ChangeStatus.UseVisualStyleBackColor = true;
            // 
            // btn_ModifyQuotation
            // 
            this.btn_ModifyQuotation.Location = new System.Drawing.Point(574, 103);
            this.btn_ModifyQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ModifyQuotation.Name = "btn_ModifyQuotation";
            this.btn_ModifyQuotation.Size = new System.Drawing.Size(102, 37);
            this.btn_ModifyQuotation.TabIndex = 12;
            this.btn_ModifyQuotation.Text = "Modify quotation";
            this.btn_ModifyQuotation.UseVisualStyleBackColor = true;
            // 
            // btn_SearchQuotation
            // 
            this.btn_SearchQuotation.Location = new System.Drawing.Point(574, 62);
            this.btn_SearchQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SearchQuotation.Name = "btn_SearchQuotation";
            this.btn_SearchQuotation.Size = new System.Drawing.Size(102, 37);
            this.btn_SearchQuotation.TabIndex = 11;
            this.btn_SearchQuotation.Text = "Search quotation";
            this.btn_SearchQuotation.UseVisualStyleBackColor = true;
            this.btn_SearchQuotation.Click += new System.EventHandler(this.btn_SearchQuotation_Click);
            // 
            // btn_CreateQuotation
            // 
            this.btn_CreateQuotation.Location = new System.Drawing.Point(574, 20);
            this.btn_CreateQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CreateQuotation.Name = "btn_CreateQuotation";
            this.btn_CreateQuotation.Size = new System.Drawing.Size(102, 37);
            this.btn_CreateQuotation.TabIndex = 10;
            this.btn_CreateQuotation.Text = "Create quotation";
            this.btn_CreateQuotation.UseVisualStyleBackColor = true;
            this.btn_CreateQuotation.Click += new System.EventHandler(this.btn_CreateQuotation_Click);
            // 
            // dgv_Quatations
            // 
            this.dgv_Quatations.AllowUserToOrderColumns = true;
            this.dgv_Quatations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quatations.Location = new System.Drawing.Point(10, 20);
            this.dgv_Quatations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Quatations.Name = "dgv_Quatations";
            this.dgv_Quatations.RowTemplate.Height = 24;
            this.dgv_Quatations.Size = new System.Drawing.Size(440, 336);
            this.dgv_Quatations.TabIndex = 9;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(619, 7);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(37, 13);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "00:00 ";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(610, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(61, 13);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "00-00-0000";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 418);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.tc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Barroc IT";
            this.tc_Main.ResumeLayout(false);
            this.tab_Clients.ResumeLayout(false);
            this.tab_Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.tab_Projects.ResumeLayout(false);
            this.tab_Projects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
            this.tab_Meetings.ResumeLayout(false);
            this.tab_Meetings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Meetings)).EndInit();
            this.tab_Finance.ResumeLayout(false);
            this.tab_Finance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Finance)).EndInit();
            this.tab_Offer.ResumeLayout(false);
            this.tab_Offer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quatations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tab_Clients;
        private System.Windows.Forms.TabPage tab_Projects;
        private System.Windows.Forms.TabPage tab_Meetings;
        private System.Windows.Forms.TabPage tab_Finance;
        private System.Windows.Forms.TabPage tab_Offer;
        private System.Windows.Forms.Label lbl_Username_C;
        private System.Windows.Forms.Label lbl_LoggedInAs_C;
        private System.Windows.Forms.Button btn_LogOut_C;
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button btn_PrintClient;
        private System.Windows.Forms.Button btn_SearchClient_C;
        private System.Windows.Forms.Button btn_ModifyClient_C;
        private System.Windows.Forms.Button btn_CreateClient;
        private System.Windows.Forms.Button btn_DeleteProject;
        private System.Windows.Forms.Button btn_PrintProject;
        private System.Windows.Forms.Button btn_SearchProject;
        private System.Windows.Forms.Button btn_ModifyProject;
        private System.Windows.Forms.Button btn_CreateProject;
        private System.Windows.Forms.DataGridView dgv_Projects;
        private System.Windows.Forms.DataGridView dgv_Meetings;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_Username_P;
        private System.Windows.Forms.Label lbl_LoggedInAs_P;
        private System.Windows.Forms.Button btn_LogOut_P;
        private System.Windows.Forms.Button btn_ViewMeeting;
        private System.Windows.Forms.Button btn_ModifyMeeting;
        private System.Windows.Forms.Button btn_CreateMeeting;
        private System.Windows.Forms.Label lbl_Username_M;
        private System.Windows.Forms.Label lbl_LoggedInAs_M;
        private System.Windows.Forms.Button btn_LogOut_M;
        private System.Windows.Forms.Label lbl_LoggedInAs_F;
        private System.Windows.Forms.Button btn_LogOut_F;
        private System.Windows.Forms.Button btn_ModifyNewClient;
        private System.Windows.Forms.Button btn_ViewInvoices;
        private System.Windows.Forms.Button btn_CreateInvoice;
        private System.Windows.Forms.Button lbl_ModifyClient_F;
        private System.Windows.Forms.Button btn_SearchClient_F;
        private System.Windows.Forms.DataGridView dgv_Finance;
        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.Label lbl_Username_Q;
        private System.Windows.Forms.Label lbl_LoggedInAs_Q;
        private System.Windows.Forms.Button btn_LogOut_Q;
        private System.Windows.Forms.Button btn_DeleteQuotation;
        private System.Windows.Forms.Button btn_ChangeStatus;
        private System.Windows.Forms.Button btn_ModifyQuotation;
        private System.Windows.Forms.Button btn_SearchQuotation;
        private System.Windows.Forms.Button btn_CreateQuotation;
        private System.Windows.Forms.DataGridView dgv_Quatations;
        private System.Windows.Forms.Label lbl_Username_F;
        private System.Windows.Forms.Label lbl_Time;
        public System.Windows.Forms.Label lbl_Date;
    }
}