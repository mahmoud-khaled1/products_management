using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_management.PL
{
    public partial class FRM_DATE_TAKSEET_CUSTOMERS : Form
    {
        BL.CLS_CUSTOMERS frm_cust = new BL.CLS_CUSTOMERS();
        FRM_TAKSEET_DETAILS frm = new FRM_TAKSEET_DETAILS();


        public FRM_DATE_TAKSEET_CUSTOMERS()
        {
            InitializeComponent();
            
            
           

        }

        private void DGV_USER_DoubleClick(object sender, EventArgs e)
        {
            //this.TXT_CUST_NAME.Text = frm.DGV_USER.CurrentRow.Cells[0].Value.ToString();
        }

        private void TXT_CUST_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_DATE_TAKSEET_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_DATE_CUSTOMER rpt = new RPT.RPT_ALL_DATE_CUSTOMER();

            rpt.SetParameterValue("@id_takseet", this.DGV_TAKSEET.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT MY_FORM = new RPT.FRM_RPT_PRODUCT();
            MY_FORM.crystalReportViewer1.ReportSource = rpt;
            MY_FORM.ShowDialog();


        }
    }
}
