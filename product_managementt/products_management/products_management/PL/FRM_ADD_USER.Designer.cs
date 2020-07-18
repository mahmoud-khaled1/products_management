namespace products_management.PL
{
    partial class FRM_ADD_USER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BTM_SAVE = new System.Windows.Forms.Button();
            this.TXT_USER_TYPE = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_CONFORM_PASS = new System.Windows.Forms.TextBox();
            this.TXT_PASS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_FULLNAME = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BTM_SAVE);
            this.groupBox1.Controls.Add(this.TXT_USER_TYPE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_CONFORM_PASS);
            this.groupBox1.Controls.Add(this.TXT_PASS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_FULLNAME);
            this.groupBox1.Controls.Add(this.TXT_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المستخدم";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(117, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "الخروج";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTM_SAVE
            // 
            this.BTM_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_SAVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_SAVE.Location = new System.Drawing.Point(244, 459);
            this.BTM_SAVE.Name = "BTM_SAVE";
            this.BTM_SAVE.Size = new System.Drawing.Size(147, 39);
            this.BTM_SAVE.TabIndex = 5;
            this.BTM_SAVE.Text = "حفظ المستخدم";
            this.BTM_SAVE.UseVisualStyleBackColor = true;
            this.BTM_SAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_USER_TYPE
            // 
            this.TXT_USER_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_USER_TYPE.FormattingEnabled = true;
            this.TXT_USER_TYPE.Items.AddRange(new object[] {
            "مدير",
            "مستخدم عادي"});
            this.TXT_USER_TYPE.Location = new System.Drawing.Point(117, 360);
            this.TXT_USER_TYPE.Name = "TXT_USER_TYPE";
            this.TXT_USER_TYPE.Size = new System.Drawing.Size(274, 33);
            this.TXT_USER_TYPE.TabIndex = 4;
            this.TXT_USER_TYPE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_USER_TYPE_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع المستخدم";
            // 
            // TXT_CONFORM_PASS
            // 
            this.TXT_CONFORM_PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CONFORM_PASS.Location = new System.Drawing.Point(117, 303);
            this.TXT_CONFORM_PASS.Name = "TXT_CONFORM_PASS";
            this.TXT_CONFORM_PASS.PasswordChar = '*';
            this.TXT_CONFORM_PASS.Size = new System.Drawing.Size(274, 30);
            this.TXT_CONFORM_PASS.TabIndex = 3;
            this.TXT_CONFORM_PASS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_CONFORM_PASS_KeyUp);
            this.TXT_CONFORM_PASS.Validated += new System.EventHandler(this.TXT_CONFORM_PASS_Validated);
            // 
            // TXT_PASS
            // 
            this.TXT_PASS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_PASS.Location = new System.Drawing.Point(117, 240);
            this.TXT_PASS.Name = "TXT_PASS";
            this.TXT_PASS.PasswordChar = '*';
            this.TXT_PASS.Size = new System.Drawing.Size(274, 30);
            this.TXT_PASS.TabIndex = 2;
            this.TXT_PASS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_PASS_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاكيد كلمه السر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "كلمه السر";
            // 
            // TXT_FULLNAME
            // 
            this.TXT_FULLNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_FULLNAME.Location = new System.Drawing.Point(117, 182);
            this.TXT_FULLNAME.Name = "TXT_FULLNAME";
            this.TXT_FULLNAME.Size = new System.Drawing.Size(274, 30);
            this.TXT_FULLNAME.TabIndex = 1;
            this.TXT_FULLNAME.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_FULLNAME_KeyUp);
            // 
            // TXT_ID
            // 
            this.TXT_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID.Location = new System.Drawing.Point(117, 128);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(274, 30);
            this.TXT_ID.TabIndex = 0;
            this.TXT_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_ID_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الكامل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::products_management.Properties.Resources.Businessman_48px;
            this.pictureBox1.Location = new System.Drawing.Point(213, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 574);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مستخدم جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button BTM_SAVE;
        public System.Windows.Forms.ComboBox TXT_USER_TYPE;
        public System.Windows.Forms.TextBox TXT_CONFORM_PASS;
        public System.Windows.Forms.TextBox TXT_PASS;
        public System.Windows.Forms.TextBox TXT_FULLNAME;
        public System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}