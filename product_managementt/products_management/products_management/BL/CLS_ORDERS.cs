using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace products_management.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.close();
            return dt;

        }
        public DataTable GET_LAST_ORDER_ID_for_print()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_LAST_ORDER_ID_for_print", null);
            DAL.close();
            return dt;

        }
        public void ADD_ORDERS(int id_order, DateTime date_time,
                                 int cust_id, string desc_ord,string sales_man)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ID_ORD", SqlDbType.Int);
            parm[0].Value = id_order;

            parm[1] = new SqlParameter("@DATE_ORD", SqlDbType.DateTime);
            parm[1].Value = date_time;

            parm[2] = new SqlParameter("@CUST_ID", SqlDbType.Int);
            parm[2].Value = cust_id;

            parm[3] = new SqlParameter("@DESC_ORD", SqlDbType.NVarChar,75);
            parm[3].Value = desc_ord;

            parm[4] = new SqlParameter("@SALES_MAN", SqlDbType.NVarChar,50);
            parm[4].Value = sales_man;

            
            DAL.ExecuteCommand("ADD_ORDERS", parm);
            DAL.close();

        }
        public void add_order_details(string id_prod, int id_order ,
                                int qte, string price, float discount, string amount ,string total_amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[7];

            parm[0] = new SqlParameter("@id_pro", SqlDbType.NVarChar, 50);
            parm[0].Value = id_prod;

            parm[1] = new SqlParameter("@id_order", SqlDbType.Int);
            parm[1].Value = id_order;

            parm[2] = new SqlParameter("@qte", SqlDbType.Int);
            parm[2].Value = qte;

            parm[3] = new SqlParameter("@price", SqlDbType.NVarChar, 50);
            parm[3].Value = price;

            parm[4] = new SqlParameter("@discount", SqlDbType.Float);
            parm[4].Value = discount;

            parm[5] = new SqlParameter("@amount", SqlDbType.NVarChar, 50);
            parm[5].Value = amount;

            parm[6] = new SqlParameter("@total_amount", SqlDbType.NVarChar, 50);
            parm[6].Value = total_amount;

            
            DAL.ExecuteCommand("add_order_details", parm);
            DAL.close();

        }
        public DataTable VERIFIY_QUANTITY(string ID_PRO,int QUA)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];

            parm[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            parm[0].Value = ID_PRO;

            parm[1] = new SqlParameter("@QUANTITY", SqlDbType.Int);
            parm[1].Value = QUA;

            dt = DAL.SelectData("VERIFIY_QUANTITY", parm);
            DAL.close();
            return dt;

        }
        public DataTable GET_ORDER_DETAILS(int ID_ORDER)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            parm[0].Value = ID_ORDER;

            dt = DAL.SelectData("GET_ORDER_DETAILS", parm);
            DAL.close();
            return dt;

        }

        public DataTable SEARCH_ORDERS(string CRI)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@CRI", SqlDbType.NVarChar,50);
            parm[0].Value = CRI;

            dt = DAL.SelectData("SEARCH_ORDERS", parm);
            DAL.close();
            return dt;

        }



    }
}
