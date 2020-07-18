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
    public partial class FRM_CUSTOMER : Form       
    {
        BL.CLS_CUSTOMERS CUST = new BL.CLS_CUSTOMERS();
        int id,position;

        public FRM_CUSTOMER()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CUST.GET_ALL_CUSTOMERS();
            // to avoid first col in customer table (customer id) not show it !
            
            dataGridView1.Columns[0].Visible = false;
        }

        private void FRM_CUSTOMER_Load(object sender, EventArgs e)
        {

        }

        private void BTM_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_ADD_Click(object sender, EventArgs e)
        {
            if (TXT_FNAME.Text != string.Empty && TXT_LNAME.Text != string.Empty)
            {

                try
                {
                    CUST.ADD_CUSTOMERS(TXT_FNAME.Text, TXT_LNAME.Text, TXT_PHONE.Text, TXT_EMAIL.Text);

                    MessageBox.Show("تم الاضافه", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_FNAME.Text = "";
                    TXT_LNAME.Text = "";
                    TXT_PHONE.Text = "";
                    TXT_EMAIL.Text = "";
                    this.dataGridView1.DataSource = CUST.GET_ALL_CUSTOMERS();


                }
                catch
                {
                    MessageBox.Show("حدث خطا الرجاء المحاوله مره اخري");
                }
                finally
                {
                    BTM_ADD.Enabled = false;
                    BTM_NEW.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("يجي ملي الاسم الاول والاخير ","",MessageBoxButtons.OK);
            }
        }

        private void BTM_NEW_Click(object sender, EventArgs e)
        {
            TXT_FNAME.Clear();
            TXT_LNAME.Clear();
            TXT_PHONE.Clear();
            TXT_EMAIL.Clear();
            TXT_FNAME.Focus();
            BTM_ADD.Enabled = true;
            BTM_NEW.Enabled = false;

        }

        private void TXT_FNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                TXT_LNAME.Focus();
            }
        }

        private void TXT_LNAME_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TXT_LNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PHONE.Focus();
            }
        }

        private void TXT_PHONE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TXT_PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_EMAIL.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.TXT_FNAME.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.TXT_LNAME.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.TXT_PHONE.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.TXT_EMAIL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void BTM_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                CUST.UPDATE_CUSTOMER(TXT_FNAME.Text, TXT_LNAME.Text, TXT_PHONE.Text, TXT_EMAIL.Text, id);

                MessageBox.Show(" تم التعديل ", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //TXT_FNAME.Text = "";
                //TXT_LNAME.Text = "";
                //TXT_PHONE.Text = "";
                //TXT_EMAIL.Text = "";
                this.dataGridView1.DataSource = CUST.GET_ALL_CUSTOMERS();

            }
            catch
            {
                MessageBox.Show("حدث خطا الرجاء المحاوله مره اخري");
            }
        }

        private void BTM_DELETE_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("هل تريد فعلا حذف العميل", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CUST.DELETE_CUSTOMER(id);
                    MessageBox.Show(" تم الحذف ", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = CUST.GET_ALL_CUSTOMERS();
                }
                else
                {
                    MessageBox.Show("تم الالغاء ");
                }

            }
            catch
            {
                MessageBox.Show("حدث خطا الرجاء المحاوله مره اخري");
            }
            

        }

        private void BTM_OK_SEARCH_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CUST.search_customers(TXT_SEARCH.Text);
        }

        private void TXT_SEARCH_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BTM_OK_SEARCH_Click(sender, e);
            }
        }

        private void TXT_SEARCH_Leave(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = CUST.GET_ALL_CUSTOMERS();
        }


        void navigate(int indx)
        {

            try
            {
                DataRowCollection DRC = CUST.GET_ALL_CUSTOMERS().Rows;
                TXT_FNAME.Text = DRC[indx][1].ToString();
                TXT_LNAME.Text = DRC[indx][2].ToString();
                TXT_PHONE.Text = DRC[indx][3].ToString();
                TXT_EMAIL.Text = DRC[indx][4].ToString();
            }
            catch
            {

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (position > 0)
            {
                position = position - 1;
                navigate(position);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (position <=CUST.GET_ALL_CUSTOMERS().Rows.Count-1)
            {
                position = position + 1;
                navigate(position);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                position = CUST.GET_ALL_CUSTOMERS().Rows.Count - 1;
                navigate(position);
            }
            catch
            {

            }
        }
    }
}
