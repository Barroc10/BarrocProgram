namespace Barroc_IT
{
    partial class CreateInvoice
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
            this.gb_CreateInvoice = new System.Windows.Forms.GroupBox();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.tb_Reason = new System.Windows.Forms.TextBox();
            this.cb_Project = new System.Windows.Forms.ComboBox();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.num_Amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.gb_CreateInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_CreateInvoice
            // 
            this.gb_CreateInvoice.Controls.Add(this.lbl_Reason);
            this.gb_CreateInvoice.Controls.Add(this.lbl_ProjectName);
            this.gb_CreateInvoice.Controls.Add(this.lbl_DueDate);
            this.gb_CreateInvoice.Controls.Add(this.tb_Reason);
            this.gb_CreateInvoice.Controls.Add(this.cb_Project);
            this.gb_CreateInvoice.Controls.Add(this.tb_Date);
            this.gb_CreateInvoice.Controls.Add(this.num_Amount);
            this.gb_CreateInvoice.Controls.Add(this.lbl_Amount);
            this.gb_CreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CreateInvoice.Location = new System.Drawing.Point(12, 12);
            this.gb_CreateInvoice.Name = "gb_CreateInvoice";
            this.gb_CreateInvoice.Size = new System.Drawing.Size(292, 176);
            this.gb_CreateInvoice.TabIndex = 0;
            this.gb_CreateInvoice.TabStop = false;
            this.gb_CreateInvoice.Text = "Create invoice";
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reason.Location = new System.Drawing.Point(6, 134);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(69, 20);
            this.lbl_Reason.TabIndex = 38;
            this.lbl_Reason.Text = "Reason:";
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProjectName.Location = new System.Drawing.Point(6, 100);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(106, 20);
            this.lbl_ProjectName.TabIndex = 37;
            this.lbl_ProjectName.Text = "Project name:";
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.Location = new System.Drawing.Point(6, 67);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(79, 20);
            this.lbl_DueDate.TabIndex = 36;
            this.lbl_DueDate.Text = "Due date:";
            // 
            // tb_Reason
            // 
            this.tb_Reason.Location = new System.Drawing.Point(126, 131);
            this.tb_Reason.Name = "tb_Reason";
            this.tb_Reason.Size = new System.Drawing.Size(156, 27);
            this.tb_Reason.TabIndex = 35;
            // 
            // cb_Project
            // 
            this.cb_Project.FormattingEnabled = true;
            this.cb_Project.Location = new System.Drawing.Point(126, 97);
            this.cb_Project.Name = "cb_Project";
            this.cb_Project.Size = new System.Drawing.Size(156, 28);
            this.cb_Project.TabIndex = 34;
            // 
            // tb_Date
            // 
            this.tb_Date.Location = new System.Drawing.Point(126, 64);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(156, 27);
            this.tb_Date.TabIndex = 33;
            // 
            // num_Amount
            // 
            this.num_Amount.Location = new System.Drawing.Point(126, 31);
            this.num_Amount.Name = "num_Amount";
            this.num_Amount.Size = new System.Drawing.Size(156, 27);
            this.num_Amount.TabIndex = 4;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(6, 33);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(69, 20);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 194);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 32);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(201, 194);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(103, 32);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 237);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.gb_CreateInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateInvoice";
            this.Text = "CreateInvoice";
            this.gb_CreateInvoice.ResumeLayout(false);
            this.gb_CreateInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_CreateInvoice;
        private System.Windows.Forms.NumericUpDown num_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label lbl_Reason;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.TextBox tb_Reason;
        private System.Windows.Forms.ComboBox cb_Project;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Create;
    }
}