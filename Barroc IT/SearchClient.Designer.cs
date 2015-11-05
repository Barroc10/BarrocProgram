namespace Barroc_IT
{
    partial class SearchClient
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
            this.gb_SearchClient = new System.Windows.Forms.GroupBox();
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.tb_Property = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.gb_SearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SearchClient
            // 
            this.gb_SearchClient.Controls.Add(this.dgv_Clients);
            this.gb_SearchClient.Controls.Add(this.tb_Property);
            this.gb_SearchClient.Controls.Add(this.btn_Search);
            this.gb_SearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SearchClient.Location = new System.Drawing.Point(16, 15);
            this.gb_SearchClient.Margin = new System.Windows.Forms.Padding(4);
            this.gb_SearchClient.Name = "gb_SearchClient";
            this.gb_SearchClient.Padding = new System.Windows.Forms.Padding(4);
            this.gb_SearchClient.Size = new System.Drawing.Size(608, 537);
            this.gb_SearchClient.TabIndex = 0;
            this.gb_SearchClient.TabStop = false;
            this.gb_SearchClient.Text = "Search client";
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToAddRows = false;
            this.dgv_Clients.AllowUserToDeleteRows = false;
            this.dgv_Clients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Clients.Location = new System.Drawing.Point(8, 73);
            this.dgv_Clients.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.ReadOnly = true;
            this.dgv_Clients.Size = new System.Drawing.Size(592, 457);
            this.dgv_Clients.TabIndex = 2;
            // 
            // tb_Property
            // 
            this.tb_Property.Location = new System.Drawing.Point(8, 32);
            this.tb_Property.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Property.Name = "tb_Property";
            this.tb_Property.Size = new System.Drawing.Size(463, 32);
            this.tb_Property.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(480, 31);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(120, 36);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(496, 559);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(128, 33);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.gb_SearchClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SearchClient";
            this.Text = "SearchClient";
            this.gb_SearchClient.ResumeLayout(false);
            this.gb_SearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SearchClient;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.TextBox tb_Property;
        private System.Windows.Forms.Button btn_Select;
    }
}