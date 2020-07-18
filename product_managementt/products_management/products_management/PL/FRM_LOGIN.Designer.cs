namespace products_management.PL
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.but_loging = new System.Windows.Forms.Button();
            this.but_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(526, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(525, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمه المرور";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_id.Location = new System.Drawing.Point(199, 106);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(276, 22);
            this.txt_id.TabIndex = 2;
            this.txt_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyUp);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_pass.Location = new System.Drawing.Point(199, 173);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(276, 22);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyUp);
            // 
            // but_loging
            // 
            this.but_loging.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_loging.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_loging.ForeColor = System.Drawing.Color.Blue;
            this.but_loging.Location = new System.Drawing.Point(361, 249);
            this.but_loging.Name = "but_loging";
            this.but_loging.Size = new System.Drawing.Size(114, 56);
            this.but_loging.TabIndex = 4;
            this.but_loging.Text = "الدخول";
            this.but_loging.UseVisualStyleBackColor = false;
            this.but_loging.Click += new System.EventHandler(this.but_loging_Click);
            // 
            // but_cancle
            // 
            this.but_cancle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.but_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_cancle.ForeColor = System.Drawing.Color.Red;
            this.but_cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_cancle.Location = new System.Drawing.Point(199, 249);
            this.but_cancle.Name = "but_cancle";
            this.but_cancle.Size = new System.Drawing.Size(114, 56);
            this.but_cancle.TabIndex = 5;
            this.but_cancle.Text = "الالغاء";
            this.but_cancle.UseVisualStyleBackColor = false;
            this.but_cancle.Click += new System.EventHandler(this.but_cancle_Click);
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::products_management.Properties.Resources._942f93bfeae6ce40f95a7d6388ee99fb1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 431);
            this.Controls.Add(this.but_cancle);
            this.Controls.Add(this.but_loging);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_LOGIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة الدخول";
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button but_loging;
        private System.Windows.Forms.Button but_cancle;
    }
}