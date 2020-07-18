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
   
    public partial class FRM_USER_LIST : Form
    {
        BL.Cls_Login LOGIN = new BL.Cls_Login();
        public FRM_USER_LIST()
        {
            InitializeComponent();
            this.DGV_USER.DataSource = LOGIN.SEARCH_USERS("");

        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_ADD_NEW_USER_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_USER ADD = new FRM_ADD_USER();
            ADD.BTM_SAVE.Text = "حفظ المستخدم";
            ADD.ShowDialog();
            this.DGV_USER.DataSource = LOGIN.SEARCH_USERS("");
        }

        private void BTM_EDIT_USER_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_USER ADD = new FRM_ADD_USER();
            ADD.TXT_ID.Text = DGV_USER.CurrentRow.Cells[0].Value.ToString();
            ADD.TXT_FULLNAME.Text = DGV_USER.CurrentRow.Cells[1].Value.ToString();
            ADD.TXT_PASS.Text = DGV_USER.CurrentRow.Cells[2].Value.ToString();
            ADD.TXT_CONFORM_PASS.Text = DGV_USER.CurrentRow.Cells[2].Value.ToString();
            ADD.TXT_USER_TYPE.Text = DGV_USER.CurrentRow.Cells[3].Value.ToString();

            ADD.BTM_SAVE.Text = "تعديل المستخدم ";
            ADD.ShowDialog();
            this.DGV_USER.DataSource = LOGIN.SEARCH_USERS("");
        }

        private void BTM_DELETE_SUER_Click(object sender, EventArgs e)
        {
            if (DGV_USER.CurrentRow.Cells[3].Value.ToString() == "مدير")
            {
                MessageBox.Show("لا يمكن حذف المدير !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("هل تريد حذف هذا المستخدم", "حذف مستخدم", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LOGIN.DELETE_USER(DGV_USER.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("تم حذف المستخدم بنجاح", "حذف مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV_USER.DataSource = LOGIN.SEARCH_USERS("");
            }
            else
            {
                MessageBox.Show("تم الالغاء", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void FRM_USER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            this.DGV_USER.DataSource = LOGIN.SEARCH_USERS(txtsearch.Text);
        }

        private void DGV_USER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
