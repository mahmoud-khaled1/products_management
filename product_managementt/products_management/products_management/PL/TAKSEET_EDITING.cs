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
    public partial class TAKSEET_EDITING : Form
    {
        BL.CLS_CUSTOMERS frm = new BL.CLS_CUSTOMERS();
        public TAKSEET_EDITING()
        {
            InitializeComponent();
        }

        private void BTM_SELECT_CUSTOMER_Click(object sender, EventArgs e)
        {
           
            try
            {
                FRM_CUSTOMERS_TAKSEET FRM = new FRM_CUSTOMERS_TAKSEET();
                FRM.dataGridView1.DataSource = frm.GET_CUSTOMER_TAKSEET();
                FRM.ShowDialog();
                this.TXT_CUSTOMER_ID.Text = FRM.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.TXT_FNAME.Text = FRM.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.TXT_LNAME.Text = FRM.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.textBox1.Text = FRM.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.TXT_MONTHLY_PRICE.Text = FRM.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double pri = 0.0;


                int id_takseet = 0;
                id_takseet = Convert.ToInt32(frm.GET_ID_TAKSEET(Convert.ToInt32(TXT_CUSTOMER_ID.Text)).Rows[0][0].ToString());



                pri = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
                frm.update_takseet(Convert.ToInt32(TXT_CUSTOMER_ID.Text), pri.ToString());
                frm.ADD_DATE_TO_TAKSEET(id_takseet, dateTimePicker1.Value,textBox2.Text);
                MessageBox.Show("تم اضافه التقسيط", "", MessageBoxButtons.OK);
                TXT_CUSTOMER_ID.Clear();
                TXT_FNAME.Clear();
                TXT_LNAME.Clear();
                textBox1.Clear();
                textBox2.Clear();
                TXT_MONTHLY_PRICE.Clear();

            }
            catch
            {

            }

        }

        private void TAKSEET_EDITING_Load(object sender, EventArgs e)
        {

        }
    }
}
