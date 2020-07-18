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
    public partial class FRM_ADD_TAKSEET : Form
    {
        BL.CLS_CUSTOMERS frm = new BL.CLS_CUSTOMERS();
        double CALC_RABH = 0.0;
        public FRM_ADD_TAKSEET()
        {
            InitializeComponent();
        }

        private void BTM_SELECT_CUSTOMER_Click(object sender, EventArgs e)
        {
            try
            {

                //DataGridView dgv1 = new DataGridView();
                FRM_CUSTOMERS_LIST CUST_LIST = new FRM_CUSTOMERS_LIST();
                CUST_LIST.ShowDialog();
                this.TXT_CUSTOMER_ID.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
                this.TXT_FNAME.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
                this.TXT_LNAME.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
                this.TXT_PHONE.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
                this.TXT_EMAIL.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
                this.TXT_ID_CUSTOMER_TAKSEET.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
                //this.TXT_TOTAL_PRICE_TAKSEET.Text = frm.GET_CUSTOMER_TOTAL_AMOUNT(Convert.ToInt32(TXT_CUSTOMER_ID.Text)).Rows[0][0].ToString();
                //dgv1.DataSource = frm.GET_CUSTOMER_TOTAL_AMOUNT(Convert.ToInt32(TXT_CUSTOMER_ID.Text));
                dataGridView1.DataSource= frm.GET_CUSTOMER_TOTAL_AMOUNT(Convert.ToInt32(TXT_CUSTOMER_ID.Text));
                //int sum = 0;

                string[] arr = new string[dataGridView1.Rows.Count];

                for (int i = 0; i < arr.Length; i++)
                {
                    // arr[i]= Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    arr[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }
                double sum =0.0;
                for (int i = 0; i < arr.Length; i++)
                {
                    // arr[i]= Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    sum += Convert.ToDouble(arr[i]);
                    
                }

                TXT_TOTAL_PRICE_TAKSEET.Text = sum.ToString();


                //sum += Convert.ToInt32(dgv1.Rows[0].Cells[0].Value.ToString());
                //TXT_TOTAL_PRICE_TAKSEET.Text = sum.ToString();
                //TXT_TOTAL_PRICE_TAKSEET.Text = sum.ToString();
                //CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();




            }
            catch
            {

            }
        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_TOTAL_PRICE_TAKSEET_TextChanged(object sender, EventArgs e)
        {
            
            //DataGridView dgv = new DataGridView();
           // dgv.DataSource = frm.GET_CUSTOMER_TOTAL_AMOUNT(Convert.ToInt32(TXT_CUSTOMER_ID.Text));

           
           
        }

        private void FRM_ADD_TAKSEET_Load(object sender, EventArgs e)
        {

        }

        private void BTM_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_RECIVE_PRICE.Text != string.Empty && TXT_RBHHH.Text != string.Empty)
                {


                    DateTime dtValue;
                    dtValue = TXT_SALE_DATEe.Value; // load your date & time into this variable
                    string montht = dtValue.ToString("MM");
                    string yearrr = dtValue.ToString("yyyy");
                    

                    
                    frm.ADD_TAKSET(Convert.ToInt32(TXT_CUSTOMER_ID.Text), TXT_RECIVE_PRICE.Text, TXT_PURE_PRICE.Text, CALC_RABH.ToString(),TXT_DAY_TAKSEET.Text,TXT_WHAT_NEED.Text,montht.ToString(),yearrr.ToString());
                    //MessageBox.Show("mon:" + montht + " year" + yearrr);
                    MessageBox.Show("تم اضافه التقسيط للعميل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_CUSTOMER_ID.Clear();
                    TXT_FNAME.Clear();
                    TXT_LNAME.Clear();
                    TXT_EMAIL.Clear();
                    TXT_PHONE.Clear();
                    TXT_RBHHH.Clear();
                    TXT_DAY_TAKSEET.Clear();
                    TXT_ID_CUSTOMER_TAKSEET.Clear();
                    TXT_PURE_PRICE.Clear();
                    TXT_RECIVE_PRICE.Clear();
                    TXT_TOTAL_PRICE_TAKSEET.Clear();
                    TXT_NUM_MONTH.Clear();
                }
                else
                {
                    MessageBox.Show("يجب ادخال البيانات كامله ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {

            }


        }

        

        private void TXT_RECIVE_PRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_RBHHH_KeyUp(object sender, KeyEventArgs e)
        {

        

            double PURE_PRI = 0.0;
             //CALC_RABH = 0.0; 
            try
            {
                PURE_PRI= (Convert.ToDouble(TXT_TOTAL_PRICE_TAKSEET.Text) - Convert.ToDouble(TXT_RECIVE_PRICE.Text));

                CALC_RABH = (PURE_PRI / 100) * (Convert.ToDouble(TXT_RBHHH.Text));
                TXT_PURE_PRICE.Text =(PURE_PRI+ CALC_RABH).ToString();
            }
            catch
            {
                TXT_PURE_PRICE.Text =(Convert.ToDouble(TXT_TOTAL_PRICE_TAKSEET.Text)-(Convert.ToDouble(TXT_RECIVE_PRICE.Text))).ToString();
            }
        }

        private void TXT_RECIVE_PRICE_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                TXT_RBHHH.Focus();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            double PURE_PRI = 0.0;
            //CALC_RABH = 0.0; 
            try
            {
                PURE_PRI = (Convert.ToDouble(TXT_TOTAL_PRICE_TAKSEET.Text) - Convert.ToDouble(TXT_RECIVE_PRICE.Text));

                CALC_RABH = (PURE_PRI / 100) * (Convert.ToDouble(TXT_RBHHH.Text));
                TXT_PURE_PRICE.Text = (PURE_PRI + CALC_RABH).ToString();
            }
            catch
            {
                TXT_PURE_PRICE.Text = (Convert.ToDouble(TXT_TOTAL_PRICE_TAKSEET.Text) - (Convert.ToDouble(TXT_RECIVE_PRICE.Text))).ToString();
            }
        }

        private void TXT_NUM_MONTH_TextChanged(object sender, EventArgs e)
        {

            double NEED = 0.0;
            //CALC_RABH = 0.0; 
            try
            {
                NEED = (Convert.ToDouble(TXT_PURE_PRICE.Text) / Convert.ToDouble(TXT_NUM_MONTH.Text));

                //CALC_RABH = (PURE_PRI / 100) * (Convert.ToDouble(TXT_RBHHH.Text));
                TXT_WHAT_NEED.Text = NEED.ToString();
            }
            catch
            {
                TXT_WHAT_NEED.Text = (Convert.ToDouble(TXT_TOTAL_PRICE_TAKSEET.Text)).ToString();
            }
        }
    }
}
