﻿namespace products_management.PL
{
    partial class FRM_PRODUCT_LIST
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
            this.DGV_PRODUCTS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PRODUCTS
            // 
            this.DGV_PRODUCTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCTS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGV_PRODUCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PRODUCTS.Location = new System.Drawing.Point(0, 0);
            this.DGV_PRODUCTS.MultiSelect = false;
            this.DGV_PRODUCTS.Name = "DGV_PRODUCTS";
            this.DGV_PRODUCTS.ReadOnly = true;
            this.DGV_PRODUCTS.RowHeadersWidth = 51;
            this.DGV_PRODUCTS.RowTemplate.Height = 24;
            this.DGV_PRODUCTS.Size = new System.Drawing.Size(840, 626);
            this.DGV_PRODUCTS.TabIndex = 0;
            this.DGV_PRODUCTS.DoubleClick += new System.EventHandler(this.DGV_PRODUCTS_DoubleClick);
            // 
            // FRM_PRODUCT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 626);
            this.Controls.Add(this.DGV_PRODUCTS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCT_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جميع المنتجات";
            this.Load += new System.EventHandler(this.FRM_PRODUCT_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_PRODUCTS;
    }
}