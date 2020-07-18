namespace products_management.PL
{
    partial class FRM_DETAILS_MONTHS
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
            this.BTM_PRINT = new System.Windows.Forms.Button();
            this.BTM_CLOSE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BTM_PRINT
            // 
            this.BTM_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_PRINT.ForeColor = System.Drawing.Color.Blue;
            this.BTM_PRINT.Location = new System.Drawing.Point(91, 290);
            this.BTM_PRINT.Name = "BTM_PRINT";
            this.BTM_PRINT.Size = new System.Drawing.Size(137, 55);
            this.BTM_PRINT.TabIndex = 0;
            this.BTM_PRINT.Text = "طباعه";
            this.BTM_PRINT.UseVisualStyleBackColor = true;
            this.BTM_PRINT.Click += new System.EventHandler(this.BTM_PRINT_Click);
            // 
            // BTM_CLOSE
            // 
            this.BTM_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTM_CLOSE.ForeColor = System.Drawing.Color.Red;
            this.BTM_CLOSE.Location = new System.Drawing.Point(367, 290);
            this.BTM_CLOSE.Name = "BTM_CLOSE";
            this.BTM_CLOSE.Size = new System.Drawing.Size(137, 55);
            this.BTM_CLOSE.TabIndex = 1;
            this.BTM_CLOSE.Text = "الخروج";
            this.BTM_CLOSE.UseVisualStyleBackColor = true;
            this.BTM_CLOSE.Click += new System.EventHandler(this.BTM_CLOSE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "الرجاء تحديد الشهر والسنه";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // FRM_DETAILS_MONTHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 504);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTM_CLOSE);
            this.Controls.Add(this.BTM_PRINT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_DETAILS_MONTHS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "طباعه التافاصيل الشهريه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTM_PRINT;
        private System.Windows.Forms.Button BTM_CLOSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}