namespace Barroc_IT
{
    partial class CreateProject
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
            this.gb_CreateProject = new System.Windows.Forms.GroupBox();
            this.lbl_Contract = new System.Windows.Forms.Label();
            this.cb_ClientName = new System.Windows.Forms.ComboBox();
            this.lbl_MaintenanceContract = new System.Windows.Forms.Label();
            this.lbl_ClientName = new System.Windows.Forms.Label();
            this.lbl_InternalContact = new System.Windows.Forms.Label();
            this.lbl_Appointments = new System.Windows.Forms.Label();
            this.lbl_OS = new System.Windows.Forms.Label();
            this.tb_InternalContactPerson = new System.Windows.Forms.TextBox();
            this.tb_Appointments = new System.Windows.Forms.TextBox();
            this.tb_OS = new System.Windows.Forms.TextBox();
            this.tb_Hardware = new System.Windows.Forms.TextBox();
            this.tb_ProjectName = new System.Windows.Forms.TextBox();
            this.lbl_Hardware = new System.Windows.Forms.Label();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.gb_CreateProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CreateProject
            // 
            this.gb_CreateProject.Controls.Add(this.tb_Price);
            this.gb_CreateProject.Controls.Add(this.lbl_Price);
            this.gb_CreateProject.Controls.Add(this.lbl_Contract);
            this.gb_CreateProject.Controls.Add(this.cb_ClientName);
            this.gb_CreateProject.Controls.Add(this.lbl_MaintenanceContract);
            this.gb_CreateProject.Controls.Add(this.lbl_ClientName);
            this.gb_CreateProject.Controls.Add(this.lbl_InternalContact);
            this.gb_CreateProject.Controls.Add(this.lbl_Appointments);
            this.gb_CreateProject.Controls.Add(this.lbl_OS);
            this.gb_CreateProject.Controls.Add(this.tb_InternalContactPerson);
            this.gb_CreateProject.Controls.Add(this.tb_Appointments);
            this.gb_CreateProject.Controls.Add(this.tb_OS);
            this.gb_CreateProject.Controls.Add(this.tb_Hardware);
            this.gb_CreateProject.Controls.Add(this.tb_ProjectName);
            this.gb_CreateProject.Controls.Add(this.lbl_Hardware);
            this.gb_CreateProject.Controls.Add(this.lbl_ProjectName);
            this.gb_CreateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CreateProject.Location = new System.Drawing.Point(12, 12);
            this.gb_CreateProject.Name = "gb_CreateProject";
            this.gb_CreateProject.Size = new System.Drawing.Size(436, 297);
            this.gb_CreateProject.TabIndex = 0;
            this.gb_CreateProject.TabStop = false;
            this.gb_CreateProject.Text = "Create project";
            // 
            // lbl_Contract
            // 
            this.lbl_Contract.AutoSize = true;
            this.lbl_Contract.Location = new System.Drawing.Point(181, 263);
            this.lbl_Contract.Name = "lbl_Contract";
            this.lbl_Contract.Size = new System.Drawing.Size(20, 22);
            this.lbl_Contract.TabIndex = 31;
            this.lbl_Contract.Text = "?";
            // 
            // cb_ClientName
            // 
            this.cb_ClientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClientName.FormattingEnabled = true;
            this.cb_ClientName.Location = new System.Drawing.Point(185, 226);
            this.cb_ClientName.Name = "cb_ClientName";
            this.cb_ClientName.Size = new System.Drawing.Size(245, 28);
            this.cb_ClientName.TabIndex = 30;
            this.cb_ClientName.SelectedIndexChanged += new System.EventHandler(this.cb_ClientName_SelectedIndexChanged);
            // 
            // lbl_MaintenanceContract
            // 
            this.lbl_MaintenanceContract.AutoSize = true;
            this.lbl_MaintenanceContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceContract.Location = new System.Drawing.Point(6, 265);
            this.lbl_MaintenanceContract.Name = "lbl_MaintenanceContract";
            this.lbl_MaintenanceContract.Size = new System.Drawing.Size(163, 20);
            this.lbl_MaintenanceContract.TabIndex = 29;
            this.lbl_MaintenanceContract.Text = "Maintenance contract";
            // 
            // lbl_ClientName
            // 
            this.lbl_ClientName.AutoSize = true;
            this.lbl_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ClientName.Location = new System.Drawing.Point(6, 229);
            this.lbl_ClientName.Name = "lbl_ClientName";
            this.lbl_ClientName.Size = new System.Drawing.Size(93, 20);
            this.lbl_ClientName.TabIndex = 28;
            this.lbl_ClientName.Text = "Client name";
            // 
            // lbl_InternalContact
            // 
            this.lbl_InternalContact.AutoSize = true;
            this.lbl_InternalContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InternalContact.Location = new System.Drawing.Point(6, 163);
            this.lbl_InternalContact.Name = "lbl_InternalContact";
            this.lbl_InternalContact.Size = new System.Drawing.Size(173, 20);
            this.lbl_InternalContact.TabIndex = 27;
            this.lbl_InternalContact.Text = "Internal contact person";
            // 
            // lbl_Appointments
            // 
            this.lbl_Appointments.AutoSize = true;
            this.lbl_Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Appointments.Location = new System.Drawing.Point(6, 130);
            this.lbl_Appointments.Name = "lbl_Appointments";
            this.lbl_Appointments.Size = new System.Drawing.Size(108, 20);
            this.lbl_Appointments.TabIndex = 26;
            this.lbl_Appointments.Text = "Appointments";
            // 
            // lbl_OS
            // 
            this.lbl_OS.AutoSize = true;
            this.lbl_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OS.Location = new System.Drawing.Point(6, 97);
            this.lbl_OS.Name = "lbl_OS";
            this.lbl_OS.Size = new System.Drawing.Size(136, 20);
            this.lbl_OS.TabIndex = 25;
            this.lbl_OS.Text = "Operating System";
            // 
            // tb_InternalContactPerson
            // 
            this.tb_InternalContactPerson.Location = new System.Drawing.Point(185, 160);
            this.tb_InternalContactPerson.Name = "tb_InternalContactPerson";
            this.tb_InternalContactPerson.Size = new System.Drawing.Size(245, 27);
            this.tb_InternalContactPerson.TabIndex = 22;
            // 
            // tb_Appointments
            // 
            this.tb_Appointments.Location = new System.Drawing.Point(185, 127);
            this.tb_Appointments.Name = "tb_Appointments";
            this.tb_Appointments.Size = new System.Drawing.Size(245, 27);
            this.tb_Appointments.TabIndex = 21;
            // 
            // tb_OS
            // 
            this.tb_OS.Location = new System.Drawing.Point(185, 94);
            this.tb_OS.Name = "tb_OS";
            this.tb_OS.Size = new System.Drawing.Size(245, 27);
            this.tb_OS.TabIndex = 20;
            // 
            // tb_Hardware
            // 
            this.tb_Hardware.Location = new System.Drawing.Point(185, 62);
            this.tb_Hardware.Name = "tb_Hardware";
            this.tb_Hardware.Size = new System.Drawing.Size(245, 27);
            this.tb_Hardware.TabIndex = 19;
            // 
            // tb_ProjectName
            // 
            this.tb_ProjectName.Location = new System.Drawing.Point(185, 29);
            this.tb_ProjectName.Name = "tb_ProjectName";
            this.tb_ProjectName.Size = new System.Drawing.Size(245, 27);
            this.tb_ProjectName.TabIndex = 18;
            // 
            // lbl_Hardware
            // 
            this.lbl_Hardware.AutoSize = true;
            this.lbl_Hardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hardware.Location = new System.Drawing.Point(6, 64);
            this.lbl_Hardware.Name = "lbl_Hardware";
            this.lbl_Hardware.Size = new System.Drawing.Size(78, 20);
            this.lbl_Hardware.TabIndex = 2;
            this.lbl_Hardware.Text = "Hardware";
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectName.Location = new System.Drawing.Point(6, 32);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(102, 20);
            this.lbl_ProjectName.TabIndex = 1;
            this.lbl_ProjectName.Text = "Project name";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(345, 315);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(103, 32);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(6, 194);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(44, 20);
            this.lbl_Price.TabIndex = 32;
            this.lbl_Price.Text = "Price";
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(185, 193);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(245, 27);
            this.tb_Price.TabIndex = 33;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 359);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.gb_CreateProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.gb_CreateProject.ResumeLayout(false);
            this.gb_CreateProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CreateProject;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Label lbl_Hardware;
        private System.Windows.Forms.Label lbl_MaintenanceContract;
        private System.Windows.Forms.Label lbl_ClientName;
        private System.Windows.Forms.Label lbl_InternalContact;
        private System.Windows.Forms.Label lbl_Appointments;
        private System.Windows.Forms.Label lbl_OS;
        private System.Windows.Forms.TextBox tb_InternalContactPerson;
        private System.Windows.Forms.TextBox tb_Appointments;
        private System.Windows.Forms.TextBox tb_OS;
        private System.Windows.Forms.TextBox tb_Hardware;
        private System.Windows.Forms.TextBox tb_ProjectName;
        private System.Windows.Forms.ComboBox cb_ClientName;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lbl_Contract;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Price;
    }
}