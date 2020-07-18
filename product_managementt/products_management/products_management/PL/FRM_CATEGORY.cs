using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace products_management.PL
{
    public partial class FRM_CATEGORY : Form
    {
        SqlConnection con = new SqlConnection(@"server =.\SQLEXPRESS; Database = productDB; Integrated Security = true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmd; 


        public FRM_CATEGORY()
        {
            InitializeComponent();
            da = new SqlDataAdapter("SELECT ID_CAT as 'رقم التسلسلي',DESCRAPTION_CAT as 'الصنف' FROM CATEGORYS", con);
            da.Fill(dt);
            dglist.DataSource = dt;
            TXT_ID.DataBindings.Add("text", dt, "رقم التسلسلي");
            TXT_DESC.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];

            LEL_POAITION.Text =(bmb.Position+1) + " / " + bmb.Count;


        }


        private void BTM_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CATEGORY_Load(object sender, EventArgs e)
        {

        }

        private void button_FIRST_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void button_LAST_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button_PREVIOS_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button_NEXT_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void BTM_NEW_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            BTM_NEW.Enabled = false;
            BTM_ADD.Enabled = true;
            int id=1;
            try
            {
                id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            }
            catch
            {
                id = 1;
            }
            finally
            {
                TXT_ID.Text = id.ToString();
                TXT_DESC.Focus();
            }

        }

        private void BTM_ADD_Click(object sender, EventArgs e)
        {
            if (TXT_DESC.Text != string.Empty)
            {
                bmb.EndCurrentEdit();
                cmd = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تمت الاضافه", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BTM_ADD.Enabled = false;
                BTM_NEW.Enabled = true;
                LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
            }
            else
            {
                MessageBox.Show("يرجي ملئ جميع البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void BTTM_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف الصنف المحدد ؟ ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmd = new SqlCommandBuilder(da);
                da.Update(dt);

                MessageBox.Show("تم الحذف ");
                LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
            }
            else
            {
                MessageBox.Show("تم الغاء الحذف");
            }
        }

        private void BTM_EDIT_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تم التعديل", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            LEL_POAITION.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void dglist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTM_PRINT_SINGLE_Click(object sender, EventArgs e)
        {
           
            RPT.RPT_SINGLE_CATEGORY rpt = new RPT.RPT_SINGLE_CATEGORY();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@ID", Convert.ToInt32(TXT_ID.Text));
            //rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void BTM_PRINT_ALL_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_CATT rpt = new RPT.RPT_ALL_CATT();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            //rpt.SetParameterValue("@ID", Convert.ToInt32(TXT_ID.Text));
            rpt.Refresh();

            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void BTM_SAVE_ALL_Click(object sender, EventArgs e)
        {

            RPT.RPT_ALL_CATT My_Report = new RPT.RPT_ALL_CATT();
            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            //PdfFormatOptions pdfformat = new PdfFormatOptions();
            PdfFormatOptions pdfFormatt = new PdfFormatOptions();
            //set destination of file to save in 
            dfoption.DiskFileName = @"D:\categories_List.pdf";
            export = My_Report.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            //export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormatt;
            //export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoption;
            
            My_Report.Refresh();

            My_Report.Export();
            MessageBox.Show("تم الحفظ ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTM_SAVE_SINGLE_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_CATEGORY My_Report = new RPT.RPT_SINGLE_CATEGORY();
            ExportOptions export = new ExportOptions();

            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();

            //PdfFormatOptions pdfformat = new PdfFormatOptions();
            PdfFormatOptions pdfFormatt = new PdfFormatOptions();
            //set destination of file to save in 
            dfoption.DiskFileName = @"D:\category_details.pdf";
            export = My_Report.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            //export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormatt;
            //export.ExportFormatOptions = pdfformat;
            export.ExportDestinationOptions = dfoption;
            My_Report.SetParameterValue("@ID", Convert.ToInt32(TXT_ID.Text));
            //My_Report.Refresh();

            My_Report.Export();
            MessageBox.Show("تم الحفظ ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
