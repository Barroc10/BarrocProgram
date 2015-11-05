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
            this.gb_SearchClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SearchClient.Controls.Add(this.dgv_Clients);
            this.gb_SearchClient.Controls.Add(this.tb_Property);
            this.gb_SearchClient.Controls.Add(this.btn_Search);
            this.gb_SearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SearchClient.Location = new System.Drawing.Point(12, 12);
            this.gb_SearchClient.Name = "gb_SearchClient";
            this.gb_SearchClient.Size = new System.Drawing.Size(456, 436);
            this.gb_SearchClient.TabIndex = 0;
            this.gb_SearchClient.TabStop = false;
            this.gb_SearchClient.Text = "Search client";
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToAddRows = false;
            this.dgv_Clients.AllowUserToDeleteRows = false;
            this.dgv_Clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Clients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_Clients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Clients.Location = new System.Drawing.Point(6, 59);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.ReadOnly = true;
            this.dgv_Clients.Size = new System.Drawing.Size(444, 371);
            this.dgv_Clients.TabIndex = 2;
            // 
            // tb_Property
            // 
            this.tb_Property.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Property.Location = new System.Drawing.Point(6, 26);
            this.tb_Property.Name = "tb_Property";
            this.tb_Property.Size = new System.Drawing.Size(348, 27);
            this.tb_Property.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(360, 25);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 29);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.Location = new System.Drawing.Point(372, 454);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(96, 27);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 489);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.gb_SearchClient);
            this.Name = "SearchClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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