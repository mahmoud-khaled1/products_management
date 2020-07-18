using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace products_management.BL
{
    class Cls_Login
    {
        public DataTable LOGIN(string ID ,string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter []parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            parm[1].Value = PWD;
            
            DAL.open();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN1", parm);
            DAL.close();
            return dt;
            
        }
        public void ADD_USER(string ID, string PWD,
                                  string USERTYPE, string FULLNAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@ID_USER", SqlDbType.NVarChar, 50);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            parm[1].Value = PWD;

            parm[2] = new SqlParameter("@USERTYPE", SqlDbType.NVarChar, 50);
            parm[2].Value = USERTYPE;

            parm[3] = new SqlParameter("@FULL_NAME", SqlDbType.NVarChar, 50);
            parm[3].Value = FULLNAME;


            DAL.ExecuteCommand("ADD_USER", parm);
            DAL.close();

        }
        public DataTable SEARCH_USERS(string CRI)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@CRI", SqlDbType.NVarChar, 50);
            parm[0].Value = CRI;

            dt = DAL.SelectData("SEARCH_USERS", parm);
            DAL.close();
            return dt;

        }
        public void EDIT_USER(string ID, string PWD,
                                  string USERTYPE, string FULLNAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@ID_USER", SqlDbType.NVarChar, 50);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            parm[1].Value = PWD;

            parm[2] = new SqlParameter("@USERTYPE", SqlDbType.NVarChar, 50);
            parm[2].Value = USERTYPE;

            parm[3] = new SqlParameter("@FULL_NAME", SqlDbType.NVarChar, 50);
            parm[3].Value = FULLNAME;


            DAL.ExecuteCommand("EDIT_USER", parm);
            DAL.close();

        }
        public void DELETE_USER(string ID_USER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID_USER", SqlDbType.NVarChar, 50);
            parm[0].Value = ID_USER;


            DAL.ExecuteCommand("DELETE_USER", parm);
            DAL.close();

        }


    }
}
