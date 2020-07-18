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
    public partial class FRM_RESTORE_DATABASE : Form
    {
        SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS; Database=master; Integrated Security=true");
        SqlCommand cmd;
        public FRM_RESTORE_DATABASE()
        {
            InitializeComponent();
        }

        private void BTM_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTM_BROWSE_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TXT_FILE_NAME.Text = openFileDialog1.FileName;
            }
        }

        private void BTM_RESTORE_BACKUP_Click(object sender, EventArgs e)
        {

            try
            {
                string strQuery = "ALTER Database productDB SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database productDB From Disk='" + TXT_FILE_NAME.Text+"'";
                cmd = new SqlCommand(strQuery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعاده النسخه الاحتياطيه بنجاح", "استعاده النسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_FILE_NAME.Clear();
                TXT_FILE_NAME.Focus();
            }
            catch
            {
                MessageBox.Show("حدث خطا !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
