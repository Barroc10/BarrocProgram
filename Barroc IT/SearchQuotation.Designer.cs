namespace Barroc_IT
{
    partial class SearchQuotation
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
            this.gb_SearchQuotation = new System.Windows.Forms.GroupBox();
            this.dgv_Quotations = new System.Windows.Forms.DataGridView();
            this.tb_Property = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.gb_SearchQuotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotations)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SearchQuotation
            // 
            this.gb_SearchQuotation.Controls.Add(this.dgv_Quotations);
            this.gb_SearchQuotation.Controls.Add(this.tb_Property);
            this.gb_SearchQuotation.Controls.Add(this.btn_Search);
            this.gb_SearchQuotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SearchQuotation.Location = new System.Drawing.Point(12, 12);
            this.gb_SearchQuotation.Name = "gb_SearchQuotation";
            this.gb_SearchQuotation.Size = new System.Drawing.Size(456, 436);
            this.gb_SearchQuotation.TabIndex = 1;
            this.gb_SearchQuotation.TabStop = false;
            this.gb_SearchQuotation.Text = "Search quotation";
            // 
            // dgv_Quotations
            // 
            this.dgv_Quotations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Quotations.Location = new System.Drawing.Point(6, 59);
            this.dgv_Quotations.Name = "dgv_Quotations";
            this.dgv_Quotations.Size = new System.Drawing.Size(444, 371);
            this.dgv_Quotations.TabIndex = 2;
            // 
            // tb_Property
            // 
            this.tb_Property.Location = new System.Drawing.Point(6, 26);
            this.tb_Property.Name = "tb_Property";
            this.tb_Property.Size = new System.Drawing.Size(348, 27);
            this.tb_Property.TabIndex = 1;
            // 
            // btn_Search
            // 
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
            this.btn_Select.Location = new System.Drawing.Point(372, 454);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(96, 27);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // SearchQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 489);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.gb_SearchQuotation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchQuotation";
            this.Text = "SearchQuotation";
            this.gb_SearchQuotation.ResumeLayout(false);
            this.gb_SearchQuotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Quotations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SearchQuotation;
        private System.Windows.Forms.DataGridView dgv_Quotations;
        private System.Windows.Forms.TextBox tb_Property;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Select;
    }
}