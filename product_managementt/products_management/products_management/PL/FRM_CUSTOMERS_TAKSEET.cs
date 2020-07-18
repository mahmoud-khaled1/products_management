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
    public partial class FRM_CUSTOMERS_TAKSEET : Form
    {
        public FRM_CUSTOMERS_TAKSEET()
        {
            InitializeComponent();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CUSTOMERS_TAKSEET_Load(object sender, EventArgs e)
        {

        }
    }
}
