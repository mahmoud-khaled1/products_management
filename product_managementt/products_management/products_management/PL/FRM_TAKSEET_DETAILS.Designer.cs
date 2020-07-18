namespace products_management.PL
{
    partial class FRM_TAKSEET_DETAILS
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
            this.DGV_USER = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTM_PRINT_ALL_PROFITS = new System.Windows.Forms.Button();
            this.TXT_PROFITS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTM_PROFITS_ = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_USER);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1214, 342);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحه عملاء التقسيط";
            // 
            // DGV_USER
            // 
            this.DGV_USER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_USER.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_USER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USER.Location = new System.Drawing.Point(6, 21);
            this.DGV_USER.Name = "DGV_USER";
            this.DGV_USER.ReadOnly = true;
            this.DGV_USER.RowHeadersWidth = 51;
            this.DGV_USER.RowTemplate.Height = 24;
            this.DGV_USER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_USER.Size = new System.Drawing.Size(1202, 321);
            this.DGV_USER.TabIndex = 0;
            this.DGV_USER.DoubleClick += new System.EventHandler(this.DGV_USER_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(323, 64);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(271, 22);
            this.txtsearch.TabIndex = 15;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(146, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "قم بادخال اسم العميل :";
            // 
            // BTM_PRINT_ALL_PROFITS
            // 
            this.BTM_PRINT_ALL_PROFITS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_PRINT_ALL_PROFITS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PRINT_ALL_PROFITS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_PRINT_ALL_PROFITS.Location = new System.Drawing.Point(784, 458);
            this.BTM_PRINT_ALL_PROFITS.Name = "BTM_PRINT_ALL_PROFITS";
            this.BTM_PRINT_ALL_PROFITS.Size = new System.Drawing.Size(152, 46);
            this.BTM_PRINT_ALL_PROFITS.TabIndex = 19;
            this.BTM_PRINT_ALL_PROFITS.Text = "طباعه كل الارباح";
            this.BTM_PRINT_ALL_PROFITS.UseVisualStyleBackColor = false;
            this.BTM_PRINT_ALL_PROFITS.Click += new System.EventHandler(this.BTM_PRINT_ALL_PROFITS_Click);
            // 
            // TXT_PROFITS
            // 
            this.TXT_PROFITS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TXT_PROFITS.Location = new System.Drawing.Point(1066, 458);
            this.TXT_PROFITS.Multiline = true;
            this.TXT_PROFITS.Name = "TXT_PROFITS";
            this.TXT_PROFITS.ReadOnly = true;
            this.TXT_PROFITS.Size = new System.Drawing.Size(154, 46);
            this.TXT_PROFITS.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(18, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "اقساط اليوم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTM_PROFITS_
            // 
            this.BTM_PROFITS_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_PROFITS_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PROFITS_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_PROFITS_.Location = new System.Drawing.Point(190, 458);
            this.BTM_PROFITS_.Name = "BTM_PROFITS_";
            this.BTM_PROFITS_.Size = new System.Drawing.Size(190, 46);
            this.BTM_PROFITS_.TabIndex = 23;
            this.BTM_PROFITS_.Text = "طباعه التفاصيل الشهريه";
            this.BTM_PROFITS_.UseVisualStyleBackColor = false;
            this.BTM_PROFITS_.Click += new System.EventHandler(this.BTM_PROFITS__Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::products_management.Properties.Resources.Ganancias_48px1;
            this.pictureBox2.Location = new System.Drawing.Point(951, 458);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::products_management.Properties.Resources.User_Groups_48px;
            this.pictureBox1.Location = new System.Drawing.Point(634, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_TAKSEET_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 605);
            this.Controls.Add(this.BTM_PROFITS_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TXT_PROFITS);
            this.Controls.Add(this.BTM_PRINT_ALL_PROFITS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_TAKSEET_DETAILS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملاء التقسيط";
            this.Load += new System.EventHandler(this.FRM_TAKSEET_DETAILS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DGV_USER;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTM_PRINT_ALL_PROFITS;
        private System.Windows.Forms.TextBox TXT_PROFITS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTM_PROFITS_;
    }
}