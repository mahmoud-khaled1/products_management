using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace products_management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        private static FRM_PRODUCTS frm;
        BL.CLS_PRODUCT PRD = new BL.CLS_PRODUCT();
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCTS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }


        }

        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PRD.SEARCH_PRODUCTID(txtsearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد ؟", " عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PRD.DELETEPRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());   
                this.dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();
                MessageBox.Show("تم الحذف بنجاح ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الالغاء  ", "عمليه الالغاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm_add = new FRM_ADD_PRODUCT();
            frm_add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.TXTREF.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.TXTDESC.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.TXTQUAN.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.TXTPRICE.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.CMB_CATEGARIES.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تعديل المنتج "+this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.but_OK.Text = "تعديل";
            frm.state = "update";
            frm.TXTREF.ReadOnly = true;
            Byte[] IMG = (Byte[])PRD.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream MS = new MemoryStream(IMG);
            frm.picturePRO.Image = Image.FromStream(MS);

            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_ViewI_mages_product frm = new FRM_ViewI_mages_product(); 
            Byte[] IMG = (Byte[])PRD.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream MS = new MemoryStream(IMG);
            frm.pictureBox1.Image = Image.FromStream(MS);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRD_SINGLE My_Report = new RPT.RPT_PRD_SINGLE();
            My_Report.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = My_Report;
            myForm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCTS My_Report = new RPT.RPT_ALL_PRODUCTS();
           
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = My_Report;
            myForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCTS My_Report = new RPT.RPT_ALL_PRODUCTS();
            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            //PdfFormatOptions pdfformat = new PdfFormatOptions();
            ExcelFormatOptions excelformatt = new ExcelFormatOptions();
            //set destination of file to save in 
            dfoption.DiskFileName = @"D:\ProductList.xls";
            export = My_Report.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            //export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelformatt;
            //export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoption;

            My_Report.Export();
            MessageBox.Show("تم الحفظ ","حفظ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
