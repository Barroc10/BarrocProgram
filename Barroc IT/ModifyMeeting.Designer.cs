namespace Barroc_IT
{
    partial class ModifyMeeting
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
            this.btn_Done = new System.Windows.Forms.Button();
            this.gb_CreateMeeting = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_CreateMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(303, 208);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(103, 32);
            this.btn_Done.TabIndex = 6;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // gb_CreateMeeting
            // 
            this.gb_CreateMeeting.Controls.Add(this.dataGridView1);
            this.gb_CreateMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CreateMeeting.Location = new System.Drawing.Point(12, 12);
            this.gb_CreateMeeting.Name = "gb_CreateMeeting";
            this.gb_CreateMeeting.Size = new System.Drawing.Size(394, 190);
            this.gb_CreateMeeting.TabIndex = 5;
            this.gb_CreateMeeting.TabStop = false;
            this.gb_CreateMeeting.Text = "Modify meeting";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(382, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // ModifyMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 245);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.gb_CreateMeeting);
            this.Name = "ModifyMeeting";
            this.Text = "ModifyMeeting";
            this.gb_CreateMeeting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.GroupBox gb_CreateMeeting;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}