namespace products_management.PL
{
    partial class FRM_CUSTOMERS_LIST
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
            this.DGV_CUSTOMERS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMERS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CUSTOMERS
            // 
            this.DGV_CUSTOMERS.AllowUserToAddRows = false;
            this.DGV_CUSTOMERS.AllowUserToDeleteRows = false;
            this.DGV_CUSTOMERS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMERS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_CUSTOMERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CUSTOMERS.Location = new System.Drawing.Point(0, 0);
            this.DGV_CUSTOMERS.Name = "DGV_CUSTOMERS";
            this.DGV_CUSTOMERS.ReadOnly = true;
            this.DGV_CUSTOMERS.RowHeadersWidth = 51;
            this.DGV_CUSTOMERS.RowTemplate.Height = 24;
            this.DGV_CUSTOMERS.Size = new System.Drawing.Size(846, 595);
            this.DGV_CUSTOMERS.TabIndex = 0;
            this.DGV_CUSTOMERS.DoubleClick += new System.EventHandler(this.DGV_CUSTOMERS_DoubleClick);
            // 
            // FRM_CUSTOMERS_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 595);
            this.Controls.Add(this.DGV_CUSTOMERS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMERS_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحه جميع العملاء";
            this.Load += new System.EventHandler(this.FRM_CUSTOMERS_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMERS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_CUSTOMERS;
    }
}