namespace products_management.PL
{
    partial class FRM_ORDERS_LIST
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
            this.DGV_ORDERS = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTM_PRINT = new System.Windows.Forms.Button();
            this.BTM_CLOSE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_ORDERS);
            this.groupBox1.Location = new System.Drawing.Point(25, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 399);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحه المبيعات";
            // 
            // DGV_ORDERS
            // 
            this.DGV_ORDERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ORDERS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ORDERS.Location = new System.Drawing.Point(6, 33);
            this.DGV_ORDERS.Name = "DGV_ORDERS";
            this.DGV_ORDERS.ReadOnly = true;
            this.DGV_ORDERS.RowHeadersWidth = 51;
            this.DGV_ORDERS.RowTemplate.Height = 24;
            this.DGV_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ORDERS.Size = new System.Drawing.Size(973, 360);
            this.DGV_ORDERS.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(334, 54);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(271, 22);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(92, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "قم بادخال الكلمه المراد البحث عنها  : ";
            // 
            // BTM_PRINT
            // 
            this.BTM_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PRINT.ForeColor = System.Drawing.Color.Blue;
            this.BTM_PRINT.Location = new System.Drawing.Point(334, 487);
            this.BTM_PRINT.Name = "BTM_PRINT";
            this.BTM_PRINT.Size = new System.Drawing.Size(180, 49);
            this.BTM_PRINT.TabIndex = 6;
            this.BTM_PRINT.Text = "طباعه الفاتوره المحدده";
            this.BTM_PRINT.UseVisualStyleBackColor = true;
            this.BTM_PRINT.Click += new System.EventHandler(this.BTM_PRINT_Click);
            // 
            // BTM_CLOSE
            // 
            this.BTM_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_CLOSE.ForeColor = System.Drawing.Color.Red;
            this.BTM_CLOSE.Location = new System.Drawing.Point(553, 487);
            this.BTM_CLOSE.Name = "BTM_CLOSE";
            this.BTM_CLOSE.Size = new System.Drawing.Size(180, 49);
            this.BTM_CLOSE.TabIndex = 7;
            this.BTM_CLOSE.Text = "الخروج";
            this.BTM_CLOSE.UseVisualStyleBackColor = true;
            this.BTM_CLOSE.Click += new System.EventHandler(this.BTM_CLOSE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::products_management.Properties.Resources.Ventas_48px;
            this.pictureBox1.Location = new System.Drawing.Point(611, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_ORDERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTM_CLOSE);
            this.Controls.Add(this.BTM_PRINT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.FRM_ORDERS_LIST_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ORDERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DGV_ORDERS;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTM_PRINT;
        private System.Windows.Forms.Button BTM_CLOSE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}