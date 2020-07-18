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
namespace products_management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"server=.\SQLEXPRESS; Database=productDB; Integrated Security=true");
            //string moood = Properties.Settings.Default.Mode; if (moood == "SQL")
            //{
            //    sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=false;User ID="+Properties.Settings.Default.id+";Password="+Properties.Settings.Default.password+"");
            //}
            //else
            //{
            //    sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.server + "; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");
            //}
        }


        // open connection in database 
        public void open()
        {
            if(sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        // close connection in database 

        public void close()
        {
            if(sqlconnection.State==ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Read data from database 

        public DataTable SelectData(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;


            if (param!=null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //insert and delete and update data from database 

        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {

            //try
            //{
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {

                    sqlcmd.Parameters.AddRange(param);

                }
                sqlcmd.ExecuteNonQuery();
        //}
        //    catch
        //    {
        //        MessageBox.Show("حدث خطا حاول مره اخري ! ");
        //    }


}





    }
}
