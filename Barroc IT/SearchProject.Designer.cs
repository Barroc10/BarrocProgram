﻿namespace Barroc_IT
{
    partial class SearchProject
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
            this.gb_SearchProject = new System.Windows.Forms.GroupBox();
            this.dgv_Projects = new System.Windows.Forms.DataGridView();
            this.tb_Property = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.gb_SearchProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SearchProject
            // 
            this.gb_SearchProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SearchProject.Controls.Add(this.dgv_Projects);
            this.gb_SearchProject.Controls.Add(this.tb_Property);
            this.gb_SearchProject.Controls.Add(this.btn_Search);
            this.gb_SearchProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SearchProject.Location = new System.Drawing.Point(16, 15);
            this.gb_SearchProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_SearchProject.Name = "gb_SearchProject";
            this.gb_SearchProject.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_SearchProject.Size = new System.Drawing.Size(608, 537);
            this.gb_SearchProject.TabIndex = 1;
            this.gb_SearchProject.TabStop = false;
            this.gb_SearchProject.Text = "Search project";
            // 
            // dgv_Projects
            // 
            this.dgv_Projects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Projects.Location = new System.Drawing.Point(8, 73);
            this.dgv_Projects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Projects.Name = "dgv_Projects";
            this.dgv_Projects.Size = new System.Drawing.Size(592, 457);
            this.dgv_Projects.TabIndex = 2;
            // 
            // tb_Property
            // 
            this.tb_Property.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Property.Location = new System.Drawing.Point(8, 32);
            this.tb_Property.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Property.Name = "tb_Property";
            this.tb_Property.Size = new System.Drawing.Size(463, 32);
            this.tb_Property.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(480, 31);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(120, 36);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.Location = new System.Drawing.Point(496, 559);
            this.btn_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(128, 33);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // SearchProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.gb_SearchProject);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchProject";
            this.gb_SearchProject.ResumeLayout(false);
            this.gb_SearchProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SearchProject;
        private System.Windows.Forms.DataGridView dgv_Projects;
        private System.Windows.Forms.TextBox tb_Property;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Select;
    }
}