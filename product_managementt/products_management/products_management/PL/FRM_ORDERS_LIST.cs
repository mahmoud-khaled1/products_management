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
    public partial class FRM_ORDERS_LIST : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
            this.DGV_ORDERS.DataSource = order.SEARCH_ORDERS("");

        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ORDERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGV_ORDERS.DataSource = order.SEARCH_ORDERS(txtsearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void BTM_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                int order_id = Convert.ToInt32(DGV_ORDERS.CurrentRow.Cells[0].Value);
                RPT.RPT_ORDER REPORT = new RPT.RPT_ORDER();
                RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
                REPORT.SetDataSource(order.GET_ORDER_DETAILS(Convert.ToInt32(order_id)));
                FRM.crystalReportViewer1.ReportSource = REPORT;
                FRM.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
