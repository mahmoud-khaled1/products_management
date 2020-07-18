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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            TXT_SERVER_NAME.Text = Properties.Settings.Default.server;
            TXT_DATABASE.Text= Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                radioButton2.Checked = true;
                TXT_NAME.Text = Properties.Settings.Default.id;
                TXT_PASS.Text = Properties.Settings.Default.password;
            }
            else
            {
                radioButton1.Checked = true;
            }
            TXT_NAME.Text= Properties.Settings.Default.id;
            TXT_PASS.Text = Properties.Settings.Default.password ;
            TXT_NAME.Clear();
            TXT_PASS.Clear();

            TXT_NAME.ReadOnly = true;
            TXT_PASS.ReadOnly = true;
        }

        private void BTM_CANCLE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_SAVE_Click(object sender, EventArgs e)
        {

            try
            {
                Properties.Settings.Default.server = TXT_SERVER_NAME.Text;
                Properties.Settings.Default.Database = TXT_DATABASE.Text;

                Properties.Settings.Default.Mode = radioButton2.Checked == true ? "SQL" : "Windows";

                Properties.Settings.Default.id = TXT_NAME.Text;
                Properties.Settings.Default.password = TXT_PASS.Text;

                Properties.Settings.Default.Save();
            }
            catch
            {

            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TXT_NAME.ReadOnly = false;
            TXT_PASS.ReadOnly = false;
        }
    }
}
