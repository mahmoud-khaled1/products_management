namespace products_management.PL
{
    partial class FRM_CATEGORY
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
            this.LEL_POAITION = new System.Windows.Forms.Label();
            this.button_LAST = new System.Windows.Forms.Button();
            this.button_NEXT = new System.Windows.Forms.Button();
            this.button_PREVIOS = new System.Windows.Forms.Button();
            this.TXT_DESC = new System.Windows.Forms.TextBox();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_FIRST = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTM_EXIT = new System.Windows.Forms.Button();
            this.BTM_SAVE_SINGLE = new System.Windows.Forms.Button();
            this.BTM_SAVE_ALL = new System.Windows.Forms.Button();
            this.BTM_PRINT_SINGLE = new System.Windows.Forms.Button();
            this.BTM_PRINT_ALL = new System.Windows.Forms.Button();
            this.BTM_EDIT = new System.Windows.Forms.Button();
            this.BTTM_delet = new System.Windows.Forms.Button();
            this.BTM_ADD = new System.Windows.Forms.Button();
            this.BTM_NEW = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dglist = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.LEL_POAITION);
            this.groupBox1.Controls.Add(this.button_LAST);
            this.groupBox1.Controls.Add(this.button_NEXT);
            this.groupBox1.Controls.Add(this.button_PREVIOS);
            this.groupBox1.Controls.Add(this.TXT_DESC);
            this.groupBox1.Controls.Add(this.TXT_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_FIRST);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // LEL_POAITION
            // 
            this.LEL_POAITION.AutoSize = true;
            this.LEL_POAITION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEL_POAITION.Location = new System.Drawing.Point(499, 207);
            this.LEL_POAITION.Name = "LEL_POAITION";
            this.LEL_POAITION.Size = new System.Drawing.Size(43, 25);
            this.LEL_POAITION.TabIndex = 7;
            this.LEL_POAITION.Text = "7/6";
            // 
            // button_LAST
            // 
            this.button_LAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LAST.ForeColor = System.Drawing.Color.Black;
            this.button_LAST.Location = new System.Drawing.Point(291, 201);
            this.button_LAST.Name = "button_LAST";
            this.button_LAST.Size = new System.Drawing.Size(76, 31);
            this.button_LAST.TabIndex = 6;
            this.button_LAST.Text = "<<||";
            this.button_LAST.UseVisualStyleBackColor = true;
            this.button_LAST.Click += new System.EventHandler(this.button_LAST_Click);
            // 
            // button_NEXT
            // 
            this.button_NEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NEXT.ForeColor = System.Drawing.Color.Black;
            this.button_NEXT.Location = new System.Drawing.Point(373, 201);
            this.button_NEXT.Name = "button_NEXT";
            this.button_NEXT.Size = new System.Drawing.Size(76, 31);
            this.button_NEXT.TabIndex = 5;
            this.button_NEXT.Text = ">>";
            this.button_NEXT.UseVisualStyleBackColor = true;
            this.button_NEXT.Click += new System.EventHandler(this.button_NEXT_Click);
            // 
            // button_PREVIOS
            // 
            this.button_PREVIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PREVIOS.ForeColor = System.Drawing.Color.Black;
            this.button_PREVIOS.Location = new System.Drawing.Point(588, 201);
            this.button_PREVIOS.Name = "button_PREVIOS";
            this.button_PREVIOS.Size = new System.Drawing.Size(76, 31);
            this.button_PREVIOS.TabIndex = 4;
            this.button_PREVIOS.Text = "<<";
            this.button_PREVIOS.UseVisualStyleBackColor = true;
            this.button_PREVIOS.Click += new System.EventHandler(this.button_PREVIOS_Click);
            // 
            // TXT_DESC
            // 
            this.TXT_DESC.Location = new System.Drawing.Point(323, 108);
            this.TXT_DESC.Multiline = true;
            this.TXT_DESC.Name = "TXT_DESC";
            this.TXT_DESC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_DESC.Size = new System.Drawing.Size(389, 56);
            this.TXT_DESC.TabIndex = 3;
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(515, 64);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(197, 22);
            this.TXT_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // button_FIRST
            // 
            this.button_FIRST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FIRST.ForeColor = System.Drawing.Color.Black;
            this.button_FIRST.Location = new System.Drawing.Point(672, 201);
            this.button_FIRST.Name = "button_FIRST";
            this.button_FIRST.Size = new System.Drawing.Size(76, 31);
            this.button_FIRST.TabIndex = 1;
            this.button_FIRST.Text = "||<<";
            this.button_FIRST.UseVisualStyleBackColor = true;
            this.button_FIRST.Click += new System.EventHandler(this.button_FIRST_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTM_EXIT);
            this.groupBox2.Controls.Add(this.BTM_SAVE_SINGLE);
            this.groupBox2.Controls.Add(this.BTM_SAVE_ALL);
            this.groupBox2.Controls.Add(this.BTM_PRINT_SINGLE);
            this.groupBox2.Controls.Add(this.BTM_PRINT_ALL);
            this.groupBox2.Controls.Add(this.BTM_EDIT);
            this.groupBox2.Controls.Add(this.BTTM_delet);
            this.groupBox2.Controls.Add(this.BTM_ADD);
            this.groupBox2.Controls.Add(this.BTM_NEW);
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحه";
            // 
            // BTM_EXIT
            // 
            this.BTM_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_EXIT.ForeColor = System.Drawing.Color.Red;
            this.BTM_EXIT.Location = new System.Drawing.Point(362, 74);
            this.BTM_EXIT.Name = "BTM_EXIT";
            this.BTM_EXIT.Size = new System.Drawing.Size(120, 48);
            this.BTM_EXIT.TabIndex = 8;
            this.BTM_EXIT.Text = "الخروج";
            this.BTM_EXIT.UseVisualStyleBackColor = true;
            this.BTM_EXIT.Click += new System.EventHandler(this.BTM_EXIT_Click);
            // 
            // BTM_SAVE_SINGLE
            // 
            this.BTM_SAVE_SINGLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_SAVE_SINGLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_SAVE_SINGLE.Location = new System.Drawing.Point(127, 21);
            this.BTM_SAVE_SINGLE.Name = "BTM_SAVE_SINGLE";
            this.BTM_SAVE_SINGLE.Size = new System.Drawing.Size(104, 48);
            this.BTM_SAVE_SINGLE.TabIndex = 7;
            this.BTM_SAVE_SINGLE.Text = "تخزين الصنف المحدد pdf";
            this.BTM_SAVE_SINGLE.UseVisualStyleBackColor = true;
            this.BTM_SAVE_SINGLE.Click += new System.EventHandler(this.BTM_SAVE_SINGLE_Click);
            // 
            // BTM_SAVE_ALL
            // 
            this.BTM_SAVE_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_SAVE_ALL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_SAVE_ALL.Location = new System.Drawing.Point(17, 21);
            this.BTM_SAVE_ALL.Name = "BTM_SAVE_ALL";
            this.BTM_SAVE_ALL.Size = new System.Drawing.Size(104, 48);
            this.BTM_SAVE_ALL.TabIndex = 6;
            this.BTM_SAVE_ALL.Text = "تخزين الكل pdf";
            this.BTM_SAVE_ALL.UseVisualStyleBackColor = true;
            this.BTM_SAVE_ALL.Click += new System.EventHandler(this.BTM_SAVE_ALL_Click);
            // 
            // BTM_PRINT_SINGLE
            // 
            this.BTM_PRINT_SINGLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PRINT_SINGLE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_PRINT_SINGLE.Location = new System.Drawing.Point(347, 21);
            this.BTM_PRINT_SINGLE.Name = "BTM_PRINT_SINGLE";
            this.BTM_PRINT_SINGLE.Size = new System.Drawing.Size(120, 48);
            this.BTM_PRINT_SINGLE.TabIndex = 5;
            this.BTM_PRINT_SINGLE.Text = "طباعه الصنف المحدد";
            this.BTM_PRINT_SINGLE.UseVisualStyleBackColor = true;
            this.BTM_PRINT_SINGLE.Click += new System.EventHandler(this.BTM_PRINT_SINGLE_Click);
            // 
            // BTM_PRINT_ALL
            // 
            this.BTM_PRINT_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PRINT_ALL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_PRINT_ALL.Location = new System.Drawing.Point(237, 21);
            this.BTM_PRINT_ALL.Name = "BTM_PRINT_ALL";
            this.BTM_PRINT_ALL.Size = new System.Drawing.Size(104, 48);
            this.BTM_PRINT_ALL.TabIndex = 4;
            this.BTM_PRINT_ALL.Text = "طباعه كل الاصناف";
            this.BTM_PRINT_ALL.UseVisualStyleBackColor = true;
            this.BTM_PRINT_ALL.Click += new System.EventHandler(this.BTM_PRINT_ALL_Click);
            // 
            // BTM_EDIT
            // 
            this.BTM_EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_EDIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_EDIT.Location = new System.Drawing.Point(473, 21);
            this.BTM_EDIT.Name = "BTM_EDIT";
            this.BTM_EDIT.Size = new System.Drawing.Size(105, 48);
            this.BTM_EDIT.TabIndex = 3;
            this.BTM_EDIT.Text = "تعديل الصنف المحدد";
            this.BTM_EDIT.UseVisualStyleBackColor = true;
            this.BTM_EDIT.Click += new System.EventHandler(this.BTM_EDIT_Click);
            // 
            // BTTM_delet
            // 
            this.BTTM_delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTM_delet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTTM_delet.Location = new System.Drawing.Point(584, 21);
            this.BTTM_delet.Name = "BTTM_delet";
            this.BTTM_delet.Size = new System.Drawing.Size(90, 48);
            this.BTTM_delet.TabIndex = 2;
            this.BTTM_delet.Text = "الحذف";
            this.BTTM_delet.UseVisualStyleBackColor = true;
            this.BTTM_delet.Click += new System.EventHandler(this.BTTM_delet_Click);
            // 
            // BTM_ADD
            // 
            this.BTM_ADD.Enabled = false;
            this.BTM_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_ADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_ADD.Location = new System.Drawing.Point(680, 21);
            this.BTM_ADD.Name = "BTM_ADD";
            this.BTM_ADD.Size = new System.Drawing.Size(90, 48);
            this.BTM_ADD.TabIndex = 1;
            this.BTM_ADD.Text = "اضافه";
            this.BTM_ADD.UseVisualStyleBackColor = true;
            this.BTM_ADD.Click += new System.EventHandler(this.BTM_ADD_Click);
            // 
            // BTM_NEW
            // 
            this.BTM_NEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_NEW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTM_NEW.Location = new System.Drawing.Point(776, 21);
            this.BTM_NEW.Name = "BTM_NEW";
            this.BTM_NEW.Size = new System.Drawing.Size(90, 48);
            this.BTM_NEW.TabIndex = 0;
            this.BTM_NEW.Text = "جديد";
            this.BTM_NEW.UseVisualStyleBackColor = true;
            this.BTM_NEW.Click += new System.EventHandler(this.BTM_NEW_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dglist);
            this.groupBox3.Location = new System.Drawing.Point(12, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 258);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحه جميع الاصناف";
            // 
            // dglist
            // 
            this.dglist.AllowUserToDeleteRows = false;
            this.dglist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglist.Location = new System.Drawing.Point(6, 21);
            this.dglist.Name = "dglist";
            this.dglist.ReadOnly = true;
            this.dglist.RowHeadersWidth = 51;
            this.dglist.RowTemplate.Height = 24;
            this.dglist.Size = new System.Drawing.Size(864, 225);
            this.dglist.TabIndex = 0;
            this.dglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglist_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::products_management.Properties.Resources.Ventas_48px1;
            this.pictureBox1.Location = new System.Drawing.Point(792, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 667);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اداره الاصناف";
            this.Load += new System.EventHandler(this.FRM_CATEGORY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dglist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LEL_POAITION;
        private System.Windows.Forms.Button button_LAST;
        private System.Windows.Forms.Button button_NEXT;
        private System.Windows.Forms.Button button_PREVIOS;
        private System.Windows.Forms.TextBox TXT_DESC;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_FIRST;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTM_EDIT;
        private System.Windows.Forms.Button BTTM_delet;
        private System.Windows.Forms.Button BTM_ADD;
        private System.Windows.Forms.Button BTM_NEW;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dglist;
        private System.Windows.Forms.Button BTM_EXIT;
        private System.Windows.Forms.Button BTM_SAVE_SINGLE;
        private System.Windows.Forms.Button BTM_SAVE_ALL;
        private System.Windows.Forms.Button BTM_PRINT_SINGLE;
        private System.Windows.Forms.Button BTM_PRINT_ALL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}