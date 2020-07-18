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
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS CUST = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            this.DGV_CUSTOMERS.DataSource = CUST.GET_ALL_CUSTOMERS();

             this.DGV_CUSTOMERS.Columns[0].Visible = false; 

        }

        private void FRM_CUSTOMERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void DGV_CUSTOMERS_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
