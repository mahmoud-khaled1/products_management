using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Management;
namespace products_management.PL
{
    public partial class FRM_LOGIN : Form
    {
        
        //SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS; Database=productDB; Integrated Security=true");
        BL.Cls_Login log = new BL.Cls_Login();

        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void but_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string getCPU_ID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                cpuInfo = managObj.Properties["processorID"].Value.ToString();
                break;
            }

            return cpuInfo;
        }
        private void but_loging_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server =.\SQLEXPRESS; Database = productDB; Integrated Security = true");
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT ID_USER,PWD,USERTYPE,full_name FROM TABLE_USERS", con);
            da.Fill(dt);

            int roww = dt.Rows.Count;
            bool checkk = false;

            int indx=0;
            for (int i = 0; i < roww; i++)
            {
                if (dt.Rows[i][0].ToString() == txt_id.Text && dt.Rows[i][1].ToString() == txt_pass.Text)
                {
                    
                    checkk = true;
                    indx = i; 
                    break;
                }
     
            }
            if (checkk == true)
            {
                if ( getCPU_ID() == "BFEBFBFF000306D4"||getCPU_ID() == "BFEBFBFF000806EA")
                {



                    FRM_MAIN frm = new FRM_MAIN();
                    if (dt.Rows[indx][2].ToString() == "مدير")
                    {

                        //MessageBox.Show("Login sucess !");
                        FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Visible = true;
                        FRM_MAIN.getmainform.اقساطToolStripMenuItem.Enabled = true;
                        Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                        FRM_MAIN.getmainform.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;


                        this.Close();
                    }
                    else if (dt.Rows[indx][2].ToString() == "مستخدم عادي")
                    {

                        //MessageBox.Show("Login sucess !");
                        FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Visible = false;
                        FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اقساطToolStripMenuItem.Enabled = true;
                        Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                        FRM_MAIN.getmainform.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("يجب شراء المنتج للتواصل 01020795015");
                }
                //MessageBox.Show("Login sucess !");
                //FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                //FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                //FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                //FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                //FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;

                //Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                //this.Close();
            }
            else
            {
                MessageBox.Show("password or username is incorrect!","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SqlConnection con = new SqlConnection(@"server =.\SQLEXPRESS; Database = productDB; Integrated Security = true");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                da = new SqlDataAdapter("SELECT ID_USER,PWD,USERTYPE,full_name FROM TABLE_USERS", con);
                da.Fill(dt);

                int roww = dt.Rows.Count;
                bool checkk = false;

                int indx = 0;
                for (int i = 0; i < roww; i++)
                {
                    if (dt.Rows[i][0].ToString() == txt_id.Text && dt.Rows[i][1].ToString() == txt_pass.Text)
                    {

                        checkk = true;
                        indx = i;
                        break;
                    }

                }
                if (checkk == true)
                {
                    FRM_MAIN frm = new FRM_MAIN();
                    if (dt.Rows[indx][2].ToString() == "مدير")
                    {

                        //MessageBox.Show("Login sucess !");
                        FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Visible = true;
                        FRM_MAIN.getmainform.اقساطToolStripMenuItem.Enabled = true;
                        Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                        FRM_MAIN.getmainform.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;


                        this.Close();
                    }
                    else if (dt.Rows[indx][2].ToString() == "مستخدم عادي")
                    {

                        //MessageBox.Show("Login sucess !");
                        FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Visible = false;
                        FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.اقساطToolStripMenuItem.Enabled = true;
                        Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                        FRM_MAIN.getmainform.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;
                        this.Close();
                    }
                    //MessageBox.Show("Login sucess !");
                    //FRM_MAIN.getmainform.العملاءToolStripMenuItem.Enabled = true;
                    //FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                    //FRM_MAIN.getmainform.المنتجاتToolStripMenuItem.Enabled = true;
                    //FRM_MAIN.getmainform.اعادهنسخهمحفوظهToolStripMenuItem.Enabled = true;
                    //FRM_MAIN.getmainform.اشاءنسخهاحتياطيهToolStripMenuItem.Enabled = true;

                    //Program.sales_mannn = dt.Rows[indx]["full_name"].ToString();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("password or username is incorrect!", "تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
