namespace products_management.PL
{
    partial class FRM_USER_LIST
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
            this.BTM_ADD_NEW_USER = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_USER = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTM_EDIT_USER = new System.Windows.Forms.Button();
            this.BTM_DELETE_SUER = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTM_CLOSE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTM_ADD_NEW_USER
            // 
            this.BTM_ADD_NEW_USER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_ADD_NEW_USER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_ADD_NEW_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_ADD_NEW_USER.Location = new System.Drawing.Point(154, 523);
            this.BTM_ADD_NEW_USER.Name = "BTM_ADD_NEW_USER";
            this.BTM_ADD_NEW_USER.Size = new System.Drawing.Size(160, 49);
            this.BTM_ADD_NEW_USER.TabIndex = 11;
            this.BTM_ADD_NEW_USER.Text = "اضافه مستخدم جديد";
            this.BTM_ADD_NEW_USER.UseVisualStyleBackColor = false;
            this.BTM_ADD_NEW_USER.Click += new System.EventHandler(this.BTM_ADD_NEW_USER_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_USER);
            this.groupBox1.Location = new System.Drawing.Point(-2, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 363);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحه المبيعات";
            // 
            // DGV_USER
            // 
            this.DGV_USER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_USER.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_USER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USER.Location = new System.Drawing.Point(6, 33);
            this.DGV_USER.Name = "DGV_USER";
            this.DGV_USER.ReadOnly = true;
            this.DGV_USER.RowHeadersWidth = 51;
            this.DGV_USER.RowTemplate.Height = 24;
            this.DGV_USER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_USER.Size = new System.Drawing.Size(973, 330);
            this.DGV_USER.TabIndex = 0;
            this.DGV_USER.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_USER_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(310, 90);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(271, 22);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "قم بادخال الكلمه المراد البحث عنها  : ";
            // 
            // BTM_EDIT_USER
            // 
            this.BTM_EDIT_USER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_EDIT_USER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_EDIT_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_EDIT_USER.Location = new System.Drawing.Point(334, 523);
            this.BTM_EDIT_USER.Name = "BTM_EDIT_USER";
            this.BTM_EDIT_USER.Size = new System.Drawing.Size(160, 49);
            this.BTM_EDIT_USER.TabIndex = 13;
            this.BTM_EDIT_USER.Text = "تعديل المستخدم المحدد";
            this.BTM_EDIT_USER.UseVisualStyleBackColor = false;
            this.BTM_EDIT_USER.Click += new System.EventHandler(this.BTM_EDIT_USER_Click);
            // 
            // BTM_DELETE_SUER
            // 
            this.BTM_DELETE_SUER.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_DELETE_SUER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_DELETE_SUER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_DELETE_SUER.Location = new System.Drawing.Point(514, 523);
            this.BTM_DELETE_SUER.Name = "BTM_DELETE_SUER";
            this.BTM_DELETE_SUER.Size = new System.Drawing.Size(160, 49);
            this.BTM_DELETE_SUER.TabIndex = 14;
            this.BTM_DELETE_SUER.Text = "حذف المستخدم المحدد";
            this.BTM_DELETE_SUER.UseVisualStyleBackColor = false;
            this.BTM_DELETE_SUER.Click += new System.EventHandler(this.BTM_DELETE_SUER_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::products_management.Properties.Resources.Businessman_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(610, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // BTM_CLOSE
            // 
            this.BTM_CLOSE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTM_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTM_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_CLOSE.ForeColor = System.Drawing.Color.Red;
            this.BTM_CLOSE.Location = new System.Drawing.Point(698, 523);
            this.BTM_CLOSE.Name = "BTM_CLOSE";
            this.BTM_CLOSE.Size = new System.Drawing.Size(160, 49);
            this.BTM_CLOSE.TabIndex = 12;
            this.BTM_CLOSE.Text = "الخروج";
            this.BTM_CLOSE.UseVisualStyleBackColor = false;
            this.BTM_CLOSE.Click += new System.EventHandler(this.BTM_CLOSE_Click);
            // 
            // FRM_USER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTM_DELETE_SUER);
            this.Controls.Add(this.BTM_EDIT_USER);
            this.Controls.Add(this.BTM_CLOSE);
            this.Controls.Add(this.BTM_ADD_NEW_USER);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_USER_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اداره المستخدمين";
            this.Load += new System.EventHandler(this.FRM_USER_LIST_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTM_CLOSE;
        private System.Windows.Forms.Button BTM_ADD_NEW_USER;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DGV_USER;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTM_EDIT_USER;
        private System.Windows.Forms.Button BTM_DELETE_SUER;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}