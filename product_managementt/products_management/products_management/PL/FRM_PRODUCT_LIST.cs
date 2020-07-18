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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCT PRD = new BL.CLS_PRODUCT(); 

        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.DGV_PRODUCTS.DataSource = PRD.GET_ALL_PRODUCTS();
        }

        private void FRM_PRODUCT_LIST_Load(object sender, EventArgs e)
        {

        }

        private void DGV_PRODUCTS_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
