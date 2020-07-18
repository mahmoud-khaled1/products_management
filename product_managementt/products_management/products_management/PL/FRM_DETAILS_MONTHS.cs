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
    public partial class FRM_DETAILS_MONTHS : Form
    {

        BL.CLS_CUSTOMERS CUST = new BL.CLS_CUSTOMERS();
        public FRM_DETAILS_MONTHS()
        {
            InitializeComponent();
        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_PRINT_Click(object sender, EventArgs e)
        {

            DateTime dtValue;
            dtValue =dateTimePicker1.Value; // load your date & time into this variable
            string montht = dtValue.ToString("MM");
            string yearrr = dtValue.ToString("yyyy");
            //MessageBox.Show("month :" + montht + "  year :" + yearrr);

            RPT.RPT_PRINT_DETAILS_MONTH REPORT = new RPT.RPT_PRINT_DETAILS_MONTH();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(CUST.get_all_information_toprint(montht.ToString(), yearrr.ToString()));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();


        }
    }
}
