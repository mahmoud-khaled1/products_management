using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace products_management.BL
{
    class CLS_PRODUCT
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
  
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.close();
            return dt;

        }
        public void ADD_PRODUCT(int id_cat,string label_product,
            string id_product,int quantity,string price ,byte[] image)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            parm[0].Value = id_cat;

            parm[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            parm[1].Value = id_product;

            parm[2] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.NVarChar, 50);
            parm[2].Value = label_product;

            parm[3] = new SqlParameter("@QUANTITY", SqlDbType.Int);
            parm[3].Value = quantity;

            parm[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            parm[4].Value = price;

            parm[5] = new SqlParameter("@PRODUCT_IMAGE", SqlDbType.Image);
            parm[5].Value = image;

            DAL.ExecuteCommand("ADD_PRODUCT", parm);
            DAL.close();

        }
        public DataTable VERIFY_PRODUCTID(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VERIFIY_PRODUCTS", parm);
            DAL.close();
            return dt;

        }
        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.close();
            return dt;

        }

        public DataTable SEARCH_PRODUCTID(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = id;

           
            dt = DAL.SelectData("SEARCH_PRODUCTID", parm);
            DAL.close();
            return dt;

        }
        public void DELETEPRODUCT(string id_product)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            parm[0].Value = id_product;


            DAL.ExecuteCommand("DELETEPRODUCT", parm);
            DAL.close();

        }

        public DataTable GET_IMAGE_PRODUCT(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parm[0].Value = id;


            dt = DAL.SelectData("GET_IMAGE_PRODUCT", parm);
            DAL.close();
            return dt;

        }
        public void UPDATE_PRODUCTT(int id_cat, string label_product,
            string id_product, int quantity, string price, byte[] image)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            parm[0].Value = id_cat;

            parm[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar, 50);
            parm[1].Value = id_product;

            parm[2] = new SqlParameter("@LABEL", SqlDbType.NVarChar, 50);
            parm[2].Value = label_product;

            parm[3] = new SqlParameter("@QUA", SqlDbType.Int);
            parm[3].Value = quantity;

            parm[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar, 50);
            parm[4].Value = price;

            parm[5] = new SqlParameter("@IMG", SqlDbType.Image);
            parm[5].Value = image;

            DAL.ExecuteCommand("UPDATE_PRODUCTT", parm);
            DAL.close();

        }
        
    }
}
