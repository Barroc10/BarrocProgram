namespace Barroc_IT
{
    partial class ViewMeeting
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
            this.gb_ViewMeeting = new System.Windows.Forms.GroupBox();
            this.btn_Done = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_ViewMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ViewMeeting
            // 
            this.gb_ViewMeeting.Controls.Add(this.dataGridView1);
            this.gb_ViewMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ViewMeeting.Location = new System.Drawing.Point(12, 12);
            this.gb_ViewMeeting.Name = "gb_ViewMeeting";
            this.gb_ViewMeeting.Size = new System.Drawing.Size(365, 270);
            this.gb_ViewMeeting.TabIndex = 0;
            this.gb_ViewMeeting.TabStop = false;
            this.gb_ViewMeeting.Text = "View meeting";
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(284, 288);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(96, 27);
            this.btn_Done.TabIndex = 2;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 320);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.gb_ViewMeeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewMeeting";
            this.Text = "ViewMeeting";
            this.gb_ViewMeeting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ViewMeeting;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}