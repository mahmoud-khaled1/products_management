using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;
namespace products_management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";
        BL.CLS_PRODUCT PRD = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            CMB_CATEGARIES.DataSource = PRD.GET_ALL_CATEGORIES();
            CMB_CATEGARIES.DisplayMember = "DESCRAPTION_CAT";
            CMB_CATEGARIES.ValueMember = "ID_CAT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "ملفات الصور | *JPG; *.PNG ; *GIF";
            if(OFD.ShowDialog()==DialogResult.OK)
            {
                picturePRO.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            if (TXTDESC.Text != string.Empty && TXTPRICE.Text != string.Empty && TXTQUAN.Text != string.Empty && TXTREF.Text != string.Empty)
            {
                if (state == "add")
                {
                    MemoryStream ms = new MemoryStream();
                    picturePRO.Image.Save(ms, picturePRO.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();

                    PRD.ADD_PRODUCT(Convert.ToInt32(CMB_CATEGARIES.SelectedValue), TXTDESC.Text, TXTREF.Text, Convert.ToInt32(TXTQUAN.Text), TXTPRICE.Text, byteimage);
                    MessageBox.Show("تمت الاضافه بنجاح", " عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_PRODUCTS.getmainform.dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();
                    TXTDESC.Clear();
                    TXTPRICE.Clear();
                    TXTQUAN.Clear();
                    TXTREF.Clear();

                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    picturePRO.Image.Save(ms, picturePRO.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();

                    PRD.UPDATE_PRODUCTT(Convert.ToInt32(CMB_CATEGARIES.SelectedValue), TXTDESC.Text, TXTREF.Text, Convert.ToInt32(TXTQUAN.Text), TXTPRICE.Text, byteimage);
                    MessageBox.Show("تمت التعديل بنجاح", " عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FRM_PRODUCTS.getmainform.dataGridView1.DataSource = PRD.GET_ALL_PRODUCTS();
                    TXTDESC.Clear();
                    TXTPRICE.Clear();
                    TXTQUAN.Clear();
                    TXTREF.Clear();
                }
            }
            else
            {
                MessageBox.Show("يجب ملئ جميع البيانات ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void TXTREF_Validated(object sender, EventArgs e)
        {

            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = PRD.VERIFY_PRODUCTID(TXTREF.Text);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذاالمنتج موجود بالفعل !", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXTREF.Focus();
                    TXTREF.SelectionStart = 0;
                    TXTREF.SelectionLength = TXTREF.TextLength;
                }
            }
        }

        private void but_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
