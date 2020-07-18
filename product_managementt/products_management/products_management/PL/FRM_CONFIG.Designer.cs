namespace products_management.PL
{
    partial class FRM_CONFIG
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SERVER_NAME = new System.Windows.Forms.TextBox();
            this.TXT_DATABASE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TXT_PASS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTM_SAVE = new System.Windows.Forms.Button();
            this.BTM_CANCLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(451, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر";
            // 
            // TXT_SERVER_NAME
            // 
            this.TXT_SERVER_NAME.Location = new System.Drawing.Point(183, 59);
            this.TXT_SERVER_NAME.Name = "TXT_SERVER_NAME";
            this.TXT_SERVER_NAME.Size = new System.Drawing.Size(237, 24);
            this.TXT_SERVER_NAME.TabIndex = 1;
            // 
            // TXT_DATABASE
            // 
            this.TXT_DATABASE.Location = new System.Drawing.Point(183, 112);
            this.TXT_DATABASE.Name = "TXT_DATABASE";
            this.TXT_DATABASE.Size = new System.Drawing.Size(237, 24);
            this.TXT_DATABASE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(451, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعده البيانات";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(451, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقه الدخول";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(183, 175);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(237, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Windows Authentioation";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(183, 212);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(237, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "SQL Server Authentioation";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Location = new System.Drawing.Point(183, 318);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.ReadOnly = true;
            this.TXT_PASS.Size = new System.Drawing.Size(237, 24);
            this.TXT_PASS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(451, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمه المرور";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(183, 265);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.ReadOnly = true;
            this.TXT_NAME.Size = new System.Drawing.Size(237, 24);
            this.TXT_NAME.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(451, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخم";
            // 
            // BTM_SAVE
            // 
            this.BTM_SAVE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTM_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_SAVE.ForeColor = System.Drawing.Color.MediumBlue;
            this.BTM_SAVE.Location = new System.Drawing.Point(440, 404);
            this.BTM_SAVE.Name = "BTM_SAVE";
            this.BTM_SAVE.Size = new System.Drawing.Size(107, 47);
            this.BTM_SAVE.TabIndex = 11;
            this.BTM_SAVE.Text = "حفظ";
            this.BTM_SAVE.UseVisualStyleBackColor = false;
            this.BTM_SAVE.Click += new System.EventHandler(this.BTM_SAVE_Click);
            // 
            // BTM_CANCLE
            // 
            this.BTM_CANCLE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTM_CANCLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_CANCLE.ForeColor = System.Drawing.Color.Red;
            this.BTM_CANCLE.Location = new System.Drawing.Point(183, 404);
            this.BTM_CANCLE.Name = "BTM_CANCLE";
            this.BTM_CANCLE.Size = new System.Drawing.Size(107, 47);
            this.BTM_CANCLE.TabIndex = 12;
            this.BTM_CANCLE.Text = "الخروج";
            this.BTM_CANCLE.UseVisualStyleBackColor = false;
            this.BTM_CANCLE.Click += new System.EventHandler(this.BTM_CANCLE_Click);
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 532);
            this.Controls.Add(this.BTM_CANCLE);
            this.Controls.Add(this.BTM_SAVE);
            this.Controls.Add(this.TXT_PASS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_NAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_DATABASE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_SERVER_NAME);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة التحكم في اعدادات الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SERVER_NAME;
        private System.Windows.Forms.TextBox TXT_DATABASE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox TXT_PASS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTM_SAVE;
        private System.Windows.Forms.Button BTM_CANCLE;
    }
}