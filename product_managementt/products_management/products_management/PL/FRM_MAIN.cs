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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender ,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getmainform
        {
            get
            {
                if(frm==null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
            

        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if(frm==null)
            {
                frm = this;
            }
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = false;
            this.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.اقساطToolStripMenuItem.Enabled = false;
            this.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void اتسجيلالدخولToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_LOGIN FLOGIN = new FRM_LOGIN();
            FLOGIN.ShowDialog();

        }

        private void ادارهالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void اضافهمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORY frm_cat = new FRM_CATEGORY();
            frm_cat.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = false;
            this.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = false;
            this.اقساطToolStripMenuItem.Enabled = false;
        }

        private void ادارهالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER cus = new FRM_CUSTOMER();
            cus.ShowDialog();
        }

        private void اضافهعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافهبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS FRM = new FRM_ORDERS();
            FRM.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS_LIST FRM = new FRM_ORDERS_LIST();
            FRM.ShowDialog();
        }

        private void اضافهمستحدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.ShowDialog();
        }

        private void ادارهالمستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_LIST USER = new FRM_USER_LIST();
            USER.ShowDialog();
        }

        private void اشاءنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACK_UP FRM = new FRM_BACK_UP();
            FRM.ShowDialog();

        }

        private void اعادهنسخهمحفوظهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE_DATABASE FRM = new FRM_RESTORE_DATABASE();
            FRM.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG FRM = new FRM_CONFIG();
            FRM.ShowDialog();
        }

        private void اضافهعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER FRM = new FRM_CUSTOMER();
            FRM.ShowDialog();

        }

        private void ادارهاقساطالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS order = new FRM_ORDERS();
            order.ShowDialog();
        }

        private void ادارهاقساطالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ADD_TAKSEET frm = new FRM_ADD_TAKSEET();
            frm.ShowDialog();        }

        private void ادارهاقساطالعملاءToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TAKSEET_EDITING frm = new TAKSEET_EDITING();

            frm.ShowDialog();

        }

        private void تفاصيلالعملاءوالاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TAKSEET_DETAILS frm = new FRM_TAKSEET_DETAILS();
            frm.ShowDialog();
        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
