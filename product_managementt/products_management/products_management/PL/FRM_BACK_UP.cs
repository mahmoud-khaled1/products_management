using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace products_management.PL
{
    public partial class FRM_BACK_UP : Form
    {
        SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS; Database=productDB; Integrated Security=true");
        SqlCommand cmd; 

        public FRM_BACK_UP()
        {
            InitializeComponent();
        }

        private void BTM_BROWSE_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                TXT_FILE_NAME.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BTM_CREATE_BACKUP_Click(object sender, EventArgs e)
        {

            try
            {
                string filename = TXT_FILE_NAME.Text + "\\productDB" + DateTime.Now.ToShortDateString().Replace('/', '-')
                    + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuery = "Backup Database productDB to Disk='" + filename + ".bak'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم انشاء النسخه الاحتياطيه بنجاح", "انشاء نسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_FILE_NAME.Clear();
                TXT_FILE_NAME.Focus();
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXT_FILE_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_BACK_UP_Load(object sender, EventArgs e)
        {

        }
    }
}
