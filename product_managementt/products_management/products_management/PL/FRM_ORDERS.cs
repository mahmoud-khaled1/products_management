using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; 

namespace products_management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS ORDER = new BL.CLS_ORDERS();

        BL.CLS_CUSTOMERS CUST = new BL.CLS_CUSTOMERS();
        DataTable DT = new DataTable();


        void CALC_AMOUNT()
        {
            if (TXT_PRICE.Text != string.Empty && TXT_QUA.Text != string.Empty)
            {
                double amountt = Convert.ToDouble(TXT_PRICE.Text) * Convert.ToInt32(TXT_QUA.Text);
                TXT_AMOUNT.Text = amountt.ToString();
            }
        }

        void CALC_TOTAL_AMOUNTT()
        {

            if (TXT_DISCOUNT.Text != string.Empty&&TXT_AMOUNT.Text!=string.Empty)
            {
                double discountt = Convert.ToDouble(TXT_DISCOUNT.Text);
                double amount = Convert.ToDouble(TXT_AMOUNT.Text);
                double total_amunt = amount - (amount * (discountt / 100));
                TXT_TO_AMOUNT.Text = total_amunt.ToString();
            }

        }
        void CLEAR_TXTS()
        {
             TXT_ID_PRODUCT.Clear();
             TXT_NAME_PRODUCT.Clear();
             TXT_PRICE.Clear();
             TXT_QUA.Clear() ;
             TXT_AMOUNT.Clear();
             TXT_DISCOUNT.Clear();
             TXT_TO_AMOUNT.Clear();
        }
        void CLEAR_ALL_DATA()
        {
            TXT_ORDER_ID.Clear();
            TXT_DESC_BILL.Clear();
            TXT_CUSTOMER_ID.Clear();
            TXT_FNAME.Clear();
            TXT_LNAME.Clear();
            TXT_PHONE.Clear();
            TXT_EMAIL.Clear();
            TXT_SALE_DATE.ResetText();
            CLEAR_TXTS();
            DT.Clear();
            dataGridView1.DataSource = null;
            TXT_TOTAL_AMOUNT.Clear();
            BTM_SAVE_SALE.Enabled = false;
            BTM_NEW_SALE.Enabled = true;
            BTM_PRINT_BILL.Enabled = true;

        }
        void CREATE_DATATABLE()
        {
            DT.Columns.Add("معرف المنتج");
            DT.Columns.Add("اسم المنتج");
            DT.Columns.Add("السعر المنتج ");
            DT.Columns.Add("الكميه");
            DT.Columns.Add("المبلغ ");
            DT.Columns.Add("نسبه الخصم (%) ");
            DT.Columns.Add("الاجمالي (%) ");
            dataGridView1.DataSource = DT;

            //add button column to datagrade view 
           /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "اختيار منتج";
            btn.Text = "البحث";
            btn.UseColumnTextForButtonValue = true; 
            dataGridView1.Columns.Insert(0,btn);
            */


        }
        void resize_DGV()
        {
            this.dataGridView1.RowHeadersWidth = 113;
            this.dataGridView1.Columns[0].Width = 113;
            this.dataGridView1.Columns[1].Width = 228;
            this.dataGridView1.Columns[2].Width = 113;
            this.dataGridView1.Columns[3].Width = 113;
            this.dataGridView1.Columns[4].Width = 113;
            this.dataGridView1.Columns[5].Width = 113;
            this.dataGridView1.Columns[6].Width = 223;


        }

        public FRM_ORDERS()
        {
            InitializeComponent();
            CREATE_DATATABLE();
            dataGridView1.ColumnHeadersVisible = false;
            //resize_DGV();
            TXT_SALESMAN.Text = Program.sales_mannn;
             
        }
        
        private void BTM_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_NEW_SALE_Click(object sender, EventArgs e)
        {
            TXT_ORDER_ID.Text = ORDER.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            BTM_NEW_SALE.Enabled = false;
            BTM_SAVE_SALE.Enabled = true;

        }

        private void BTM_SELECT_CUSTOMER_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_CUSTOMERS_LIST CUST_LIST = new FRM_CUSTOMERS_LIST();
                CUST_LIST.ShowDialog();
                this.TXT_CUSTOMER_ID.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[0].Value.ToString();
                this.TXT_FNAME.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[1].Value.ToString();
                this.TXT_LNAME.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[2].Value.ToString();
                this.TXT_PHONE.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[3].Value.ToString();
                this.TXT_EMAIL.Text = CUST_LIST.DGV_CUSTOMERS.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void FRM_ORDERS_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLEAR_TXTS();   
            FRM_PRODUCT_LIST PRD = new FRM_PRODUCT_LIST();

            PRD.ShowDialog();
            this.TXT_ID_PRODUCT.Text = PRD.DGV_PRODUCTS.CurrentRow.Cells[0].Value.ToString();
            this.TXT_NAME_PRODUCT.Text = PRD.DGV_PRODUCTS.CurrentRow.Cells[1].Value.ToString();
            this.TXT_PRICE.Text = PRD.DGV_PRODUCTS.CurrentRow.Cells[3].Value.ToString();
            TXT_QUA.Focus();

        }

        private void TXT_QUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void TXT_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8&&e.KeyChar!=Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void TXT_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter&&TXT_PRICE.Text!=string.Empty)
            {
                TXT_QUA.Focus();
            }
        }

        private void TXT_QUA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TXT_QUA.Text != string.Empty)
            {
                TXT_DISCOUNT.Focus();
            }
        }

        private void TXT_PRICE_KeyUp(object sender, KeyEventArgs e)
        {
            CALC_AMOUNT();
            CALC_TOTAL_AMOUNTT();
        }

        private void TXT_QUA_KeyUp(object sender, KeyEventArgs e)
        {
            CALC_AMOUNT();
            CALC_TOTAL_AMOUNTT();
        }

        private void TXT_DISCOUNT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_DISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TXT_DISCOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            CALC_TOTAL_AMOUNTT();

        }

        private void TXT_DISCOUNT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (ORDER.VERIFIY_QUANTITY(TXT_ID_PRODUCT.Text, Convert.ToInt32(TXT_QUA.Text)).Rows.Count < 1)
                {
                    MessageBox.Show(" الكميه المدخله لهذا المنتج غير متوفره", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i=0;i<dataGridView1.Rows.Count-1;i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == TXT_ID_PRODUCT.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 

                    }
                    
                   
                }

                DataRow r = DT.NewRow();
                r[0] = TXT_ID_PRODUCT.Text;
                r[1] = TXT_NAME_PRODUCT.Text;
                r[2] = TXT_PRICE.Text;
                r[3] = TXT_QUA.Text;
                r[4] = TXT_AMOUNT.Text;
                r[5] = TXT_DISCOUNT.Text;
                r[6] = TXT_TO_AMOUNT.Text;
                DT.Rows.Add(r);
                dataGridView1.DataSource = DT;
                CLEAR_TXTS();
                button1.Focus();
                TXT_TOTAL_AMOUNT.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();



                //double[] array = new double[dataGridView1.RowCount];
                //double summ = 0;
                //for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                //{
                //    //array[i] = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                //    summ += Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                //}
                ////TXT_TOTAL_AMOUNT.Text = array.Sum().ToString();
                //TXT_TOTAL_AMOUNT.Text = summ.ToString();



            }
        }

        private void TXT_TOTAL_AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TXT_ID_PRODUCT.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TXT_NAME_PRODUCT.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TXT_PRICE.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TXT_QUA.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TXT_AMOUNT.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TXT_DISCOUNT.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                TXT_TO_AMOUNT.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                TXT_QUA.Focus();
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TXT_TOTAL_AMOUNT.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void BTM_DEL_SELECTEDeLEMENT_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DT.Clear();
            dataGridView1.Refresh();

        }

        private void BTM_SAVE_SALE_Click(object sender, EventArgs e)
        {



            if (TXT_ORDER_ID.Text == string.Empty || TXT_CUSTOMER_ID.Text == string.Empty || dataGridView1.Rows.Count < 1 || TXT_DESC_BILL.Text == string.Empty)
            {
                MessageBox.Show("ينبغي ملئ جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);

               return;
            }
          
            else
            {
                ORDER.ADD_ORDERS(Convert.ToInt32(TXT_ORDER_ID.Text), TXT_SALE_DATE.Value, Convert
                    .ToInt32(TXT_CUSTOMER_ID.Text), TXT_DESC_BILL.Text, TXT_SALESMAN.Text);
                

                //DateTime dtValue;
                //dtValue = TXT_SALE_DATE.Value; // load your date & time into this variable
                //string montht = dtValue.ToString("MM");
                //string yearrr= dtValue.ToString("yyyy");

                //CUST.ADD_MONTH_YEAR_CUSTOMER(Convert.ToInt32(TXT_CUSTOMER_ID.Text), montht.ToString(), yearrr.ToString());

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ORDER.add_order_details(dataGridView1.Rows[i].Cells[0].Value.ToString()
                        , Convert.ToInt32(TXT_ORDER_ID.Text)
                        , Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString())
                        , dataGridView1.Rows[i].Cells[2].Value.ToString()
                        , Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString())
                        , dataGridView1.Rows[i].Cells[4].Value.ToString()
                        , dataGridView1.Rows[i].Cells[6].Value.ToString());
                }

                MessageBox.Show("تمت عمليه الحفظ بنجاح", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CLEAR_ALL_DATA();

            }
           
        }

        private void BTM_PRINT_BILL_Click(object sender, EventArgs e)
        {
            //get last order to print it 
            int order_id = Convert.ToInt32(ORDER.GET_LAST_ORDER_ID_for_print().Rows[0][0]);
            RPT.RPT_ORDER REPORT = new RPT.RPT_ORDER();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(ORDER.GET_ORDER_DETAILS(Convert.ToInt32(order_id)));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();

        }
    }
}
