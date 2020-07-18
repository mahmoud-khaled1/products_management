namespace products_management.PL
{
    partial class FRM_RESTORE_DATABASE
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
            this.BTM_CLOSE = new System.Windows.Forms.Button();
            this.BTM_RESTORE_BACKUP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTM_BROWSE = new System.Windows.Forms.Button();
            this.TXT_FILE_NAME = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BTM_CLOSE
            // 
            this.BTM_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_CLOSE.ForeColor = System.Drawing.Color.Red;
            this.BTM_CLOSE.Location = new System.Drawing.Point(119, 298);
            this.BTM_CLOSE.Name = "BTM_CLOSE";
            this.BTM_CLOSE.Size = new System.Drawing.Size(158, 48);
            this.BTM_CLOSE.TabIndex = 9;
            this.BTM_CLOSE.Text = "الخروج";
            this.BTM_CLOSE.UseVisualStyleBackColor = true;
            this.BTM_CLOSE.Click += new System.EventHandler(this.BTM_CLOSE_Click);
            // 
            // BTM_RESTORE_BACKUP
            // 
            this.BTM_RESTORE_BACKUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_RESTORE_BACKUP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_RESTORE_BACKUP.Location = new System.Drawing.Point(283, 298);
            this.BTM_RESTORE_BACKUP.Name = "BTM_RESTORE_BACKUP";
            this.BTM_RESTORE_BACKUP.Size = new System.Drawing.Size(169, 48);
            this.BTM_RESTORE_BACKUP.TabIndex = 8;
            this.BTM_RESTORE_BACKUP.Text = "اعاده النسخه احتياطيه";
            this.BTM_RESTORE_BACKUP.UseVisualStyleBackColor = true;
            this.BTM_RESTORE_BACKUP.Click += new System.EventHandler(this.BTM_RESTORE_BACKUP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(455, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "الرجاء تحديد مسار النسخه الاحتياطيه";
            // 
            // BTM_BROWSE
            // 
            this.BTM_BROWSE.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BTM_BROWSE.Location = new System.Drawing.Point(119, 143);
            this.BTM_BROWSE.Name = "BTM_BROWSE";
            this.BTM_BROWSE.Size = new System.Drawing.Size(105, 38);
            this.BTM_BROWSE.TabIndex = 6;
            this.BTM_BROWSE.Text = "فتح ملف";
            this.BTM_BROWSE.UseVisualStyleBackColor = true;
            this.BTM_BROWSE.Click += new System.EventHandler(this.BTM_BROWSE_Click);
            // 
            // TXT_FILE_NAME
            // 
            this.TXT_FILE_NAME.Location = new System.Drawing.Point(236, 143);
            this.TXT_FILE_NAME.Multiline = true;
            this.TXT_FILE_NAME.Name = "TXT_FILE_NAME";
            this.TXT_FILE_NAME.ReadOnly = true;
            this.TXT_FILE_NAME.Size = new System.Drawing.Size(446, 38);
            this.TXT_FILE_NAME.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FRM_RESTORE_DATABASE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::products_management.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTM_CLOSE);
            this.Controls.Add(this.BTM_RESTORE_BACKUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTM_BROWSE);
            this.Controls.Add(this.TXT_FILE_NAME);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RESTORE_DATABASE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استعاده النسخه الاحتياطيه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTM_CLOSE;
        private System.Windows.Forms.Button BTM_RESTORE_BACKUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTM_BROWSE;
        private System.Windows.Forms.TextBox TXT_FILE_NAME;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}