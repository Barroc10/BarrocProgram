namespace Barroc_IT
{
    partial class ViewInvoices
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
            this.gb_ViewInvoices = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_ViewInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ViewInvoices
            // 
            this.gb_ViewInvoices.Controls.Add(this.dataGridView1);
            this.gb_ViewInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ViewInvoices.Location = new System.Drawing.Point(12, 12);
            this.gb_ViewInvoices.Name = "gb_ViewInvoices";
            this.gb_ViewInvoices.Size = new System.Drawing.Size(328, 180);
            this.gb_ViewInvoices.TabIndex = 0;
            this.gb_ViewInvoices.TabStop = false;
            this.gb_ViewInvoices.Text = "View invoices";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(244, 198);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(96, 27);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 234);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gb_ViewInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewInvoices";
            this.Text = "ViewInvoices";
            this.gb_ViewInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ViewInvoices;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}