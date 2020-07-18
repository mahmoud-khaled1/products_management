using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace products_management.BL
{
    class CLS_CUSTOMERS
    {


        public void ADD_CUSTOMERS(string fname , string lname,
                                  string tel,string email)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];

            parm[0] = new SqlParameter("@F_NAME", SqlDbType.NVarChar,50);
            parm[0].Value = fname;

            parm[1] = new SqlParameter("@L_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = lname;

            parm[2] = new SqlParameter("@PHONE", SqlDbType.NVarChar, 50);
            parm[2].Value = tel;

            parm[3] = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50);
            parm[3].Value = email;


            DAL.ExecuteCommand("ADD_CUSTOMERS1", parm);
            DAL.close();

        }
        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.close();
            return dt;

        }
        public void UPDATE_CUSTOMER(string fname, string lname,
                                  string tel, string email,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@F_NAME", SqlDbType.NVarChar, 50);
            parm[0].Value = fname;

            parm[1] = new SqlParameter("@L_NAME", SqlDbType.NVarChar, 50);
            parm[1].Value = lname;

            parm[2] = new SqlParameter("@PHONE", SqlDbType.NVarChar, 50);
            parm[2].Value = tel;

            parm[3] = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50);
            parm[3].Value = email;

            parm[4] = new SqlParameter("@ID", SqlDbType.Int);
            parm[4].Value = id;

            

            DAL.ExecuteCommand("UPDATE_CUSTOMER", parm);
            DAL.close();

        }

        public void DELETE_CUSTOMER(int ID)                         
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = ID;

       
            DAL.ExecuteCommand("DELETE_CUSTOMER1", parm);
            DAL.close();

        }
        public DataTable search_customers(string charr)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@charr", SqlDbType.NVarChar,50);
            parm[0].Value = charr;
            dt = DAL.SelectData("search_customers", parm);
            DAL.close();
            return dt;

        }
        public DataTable GET_CUSTOMER_TOTAL_AMOUNT(int ID_CUSTOMER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            parm[0].Value = ID_CUSTOMER;
            dt = DAL.SelectData("GET_CUSTOMER_TOTAL_AMOUNT", parm);
            DAL.close();
            return dt;

        }
        public void ADD_TAKSET(int id ,string rece_price, string total_in_cash,string RABHH,string day,string monthly_price,string mo,string ye)                       
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@ID_CUST", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@REC_PRICE", SqlDbType.NVarChar, 50);
            parm[1].Value = rece_price;

            parm[2] = new SqlParameter("@TOTAL_IN_CASH", SqlDbType.NVarChar, 50);
            parm[2].Value = total_in_cash;

            parm[3] = new SqlParameter("@RABHH", SqlDbType.NVarChar, 50);
            parm[3].Value = RABHH;

            parm[4] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            parm[4].Value = day;

            parm[5] = new SqlParameter("@monthly_price", SqlDbType.NVarChar, 50);
            parm[5].Value = monthly_price;

            parm[6] = new SqlParameter("@MONTH", SqlDbType.NVarChar, 50);
            parm[6].Value = mo;

            parm[7] = new SqlParameter("@YEAR", SqlDbType.NVarChar, 50);
            parm[7].Value = ye;
            DAL.ExecuteCommand("ADD_TAKSET", parm);
            DAL.close();

        }
        public DataTable GET_CUSTOMER_TAKSEET()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CUSTOMER_TAKSEET", null);
            DAL.close();
            return dt;

        }
        public void update_takseet(int id, string total)
                                  
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@total", SqlDbType.NVarChar, 50);
            parm[1].Value = total;

            DAL.ExecuteCommand("update_takseet", parm);
            DAL.close();

        }
        public void ADD_DATE_TO_TAKSEET(int id, DateTime date,string PRICE)
                                 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@ID", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@DATEE", SqlDbType.DateTime);
            parm[1].Value = date;

            parm[2] = new SqlParameter("@PEICE", SqlDbType.NVarChar,50);
            parm[2].Value = PRICE;


            DAL.ExecuteCommand("ADD_DATE_TO_TAKSEET", parm);
            DAL.close();

        }
        public DataTable GET_ID_TAKSEET(int ID_CUSTOMER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID_CUST", SqlDbType.Int);
            parm[0].Value = ID_CUSTOMER;
            dt = DAL.SelectData("GET_ID_TAKSEET", parm);
            DAL.close();
            return dt;

        }
        public DataTable SEARCH_CUST_TAKSEET(string CRI)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@CHA", SqlDbType.NVarChar, 50);
            parm[0].Value = CRI;

            dt = DAL.SelectData("SEARCH_CUST_TAKSEET", parm);
            DAL.close();
            return dt;

        }

        public DataTable get_data_customer_takseetTT(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@id_takseet", SqlDbType.Int);
            parm[0].Value = ID;

            dt = DAL.SelectData("get_data_customer_takseetTT", parm);
            DAL.close();
            return dt;

        }
        public DataTable GET_ALL_PROFITS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PROFITS", null);
            DAL.close();
            return dt;

        }
        public DataTable GET_TODAY_TAKSEETT(string day)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@TODAY", SqlDbType.NVarChar,50);
            parm[0].Value = day;
            dt = DAL.SelectData("GET_TODAY_TAKSEETT", parm);
            DAL.close();
            return dt;

        }
        public DataTable get_minus(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@id_takseet", SqlDbType.Int);
            parm[0].Value = ID;

            dt = DAL.SelectData("get_minus", parm);
            DAL.close();
            return dt;

        }

        public void ADD_MONTH_YEAR_CUSTOMER( int ID , string MONTH , string YEAR)
                                 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            parm[0].Value = ID;

            parm[1] = new SqlParameter("@MONTH", SqlDbType.NVarChar, 50);
            parm[1].Value = MONTH;

            parm[2] = new SqlParameter("@YEAR", SqlDbType.NVarChar, 50);
            parm[2].Value = YEAR;

            DAL.ExecuteCommand("ADD_MONTH_YEAR_CUSTOMER", parm);
            DAL.close();

        }
        public DataTable get_all_information_toprint(string M , string Y)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@mon", SqlDbType.NVarChar,50);
            parm[0].Value = M;

            parm[1] = new SqlParameter("@yea", SqlDbType.NVarChar,50);
            parm[1].Value = Y;

            dt = DAL.SelectData("get_all_information_toprint", parm);
            DAL.close();
            return dt;

        }
    }
}
