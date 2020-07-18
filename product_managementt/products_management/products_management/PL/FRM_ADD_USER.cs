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
    public partial class FRM_ADD_USER : Form
    {
        BL.Cls_Login LOG = new BL.Cls_Login();
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_ID.Text == String.Empty || TXT_PASS.Text == String.Empty || TXT_FULLNAME.Text == String.Empty || TXT_CONFORM_PASS.Text == String.Empty)
            {
                MessageBox.Show("يجب ادخال جميع البيانات صحيحه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TXT_PASS.Text != TXT_CONFORM_PASS.Text)
            {
                MessageBox.Show("كلمه السر غير متطابقه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(BTM_SAVE.Text== "حفظ المستخدم")
            {

                LOG.ADD_USER(TXT_ID.Text, TXT_PASS.Text, TXT_USER_TYPE.Text, TXT_FULLNAME.Text);
                MessageBox.Show("تمت الاضافه بنجاح", "اضافه مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else if(BTM_SAVE.Text== "تعديل المستخدم ")
            {
                LOG.EDIT_USER(TXT_ID.Text, TXT_PASS.Text, TXT_USER_TYPE.Text, TXT_FULLNAME.Text);
                MessageBox.Show("تمت التعديل بنجاح", "  تعديل بيانات مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            TXT_ID.Clear();
            TXT_CONFORM_PASS.Clear();
            TXT_FULLNAME.Clear();
            TXT_PASS.Clear();
            TXT_ID.Focus();
        }

        private void TXT_CONFORM_PASS_Validated(object sender, EventArgs e)
        {
            if(TXT_PASS.Text!=TXT_CONFORM_PASS.Text)
            {
                MessageBox.Show("كلمه السر غير متطابقه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXT_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                this.TXT_FULLNAME.Focus();

            }
        }

        private void TXT_FULLNAME_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TXT_PASS.Focus();

            }
        }

        private void TXT_PASS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TXT_CONFORM_PASS.Focus();

            }
        }

        private void TXT_CONFORM_PASS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.TXT_USER_TYPE.Focus();

            }
        }

        private void TXT_USER_TYPE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BTM_SAVE.Focus();

            }
        }
    }
}
