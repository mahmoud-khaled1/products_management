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
    public partial class FRM_TAKSEET_DETAILS : Form
    {

        BL.CLS_CUSTOMERS frm = new BL.CLS_CUSTOMERS();
        
        public FRM_TAKSEET_DETAILS()
        {
            InitializeComponent();
            this.DGV_USER.DataSource = frm.SEARCH_CUST_TAKSEET("");
        }

        private void FRM_TAKSEET_DETAILS_Load(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.DGV_USER.DataSource = frm.SEARCH_CUST_TAKSEET(txtsearch.Text);
        }

        private void DGV_USER_DoubleClick(object sender, EventArgs e)
        {
            
            FRM_DATE_TAKSEET_CUSTOMERS frmm = new FRM_DATE_TAKSEET_CUSTOMERS();
            frmm.TXT_CUST_NAME.Text = this.DGV_USER.CurrentRow.Cells[1].Value.ToString();
            int id_cust = 0;
            id_cust = Convert.ToInt32(DGV_USER.CurrentRow.Cells[0].Value.ToString());

            int id_Takseet = Convert.ToInt32(frm.GET_ID_TAKSEET(id_cust).Rows[0][0].ToString());


            frmm.DGV_TAKSEET.DataSource = frm.get_data_customer_takseetTT(id_Takseet);



            frmm.dataGridView1.ColumnCount = 1;

            frmm.dataGridView1.Columns[0].Name = "ملاحظات";

            for (int i = 0; i < frmm.DGV_TAKSEET.Rows.Count - 1; i++)
            {


                frmm.dataGridView1.Rows.Add((Convert.ToDouble(frm.get_data_customer_takseetTT(id_Takseet).Rows[i][2].ToString()))
                    - (Convert.ToDouble(frm.get_data_customer_takseetTT(id_Takseet).Rows[i][3].ToString()))).ToString();



            }


            frmm.ShowDialog();
            
            
        }

        private void BTM_PRINT_ALL_PROFITS_Click(object sender, EventArgs e)
        {
            TXT_PROFITS.Text = frm.GET_ALL_PROFITS().Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            FRM_TAKSEET_TODAY frmm = new FRM_TAKSEET_TODAY();
            frmm.dataGridView1.DataSource = frm.GET_TODAY_TAKSEETT(day);
            frmm.ShowDialog();

        }

        private void BTM_PROFITS__Click(object sender, EventArgs e)
        {
            FRM_DETAILS_MONTHS frm = new FRM_DETAILS_MONTHS();
            frm.ShowDialog();
        }
    }
}
