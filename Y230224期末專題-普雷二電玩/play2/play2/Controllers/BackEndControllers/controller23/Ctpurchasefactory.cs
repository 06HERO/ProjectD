using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace play2.Controllers
{
    public class Ctpurchasefactory
    {
        public List<CtPurchaseEdit> purchaseListqueryBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            SqlDataReader reader = cmd.ExecuteReader();
            List<CtPurchaseEdit> list = new List<CtPurchaseEdit>();
            while (reader.Read())
            {
                CtPurchaseEdit x = new CtPurchaseEdit();
                x.進貨單號 = (int)reader["進貨單號"];
                x.進貨日期 = reader["進貨日期"].ToString();
                x.SupplierID = (int)reader["SupplierID"];
                x.供應商名稱 = reader["供應商名稱"].ToString();
                x.筆數 = (int)reader["筆數"];
                x.進貨總價 = (decimal)reader["進貨總價"];
                x.倉庫別 = reader["倉庫別"].ToString();
                x.備註 = reader["備註"].ToString();

                list.Add(x);
            }
            con.Close();
            return list;
        }

        public List<CtPurchaseEdit> purchaseListquerySBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            SqlDataReader reader = cmd.ExecuteReader();
            List<CtPurchaseEdit> list = new List<CtPurchaseEdit>();
            while (reader.Read())
            {
                CtPurchaseEdit x = new CtPurchaseEdit();
                x.進貨單號 = (int)reader["進貨單號"];
                x.進貨日期 = reader["進貨日期"].ToString();
                x.SupplierID = (int)reader["SupplierID"];
                x.供應商名稱 = reader["供應商名稱"].ToString();
                x.筆數 = (int)reader["筆數"];
                x.進貨總價 = (decimal)reader["進貨總價"];
                x.倉庫別 = reader["倉庫別"].ToString();
                x.備註 = reader["備註"].ToString();

                list.Add(x);
            }
            con.Close();
            return list;
        }



        public List<CtPurchaseEdit> getpurchaseList()
        {
            string sql = "  select 進貨單號,進貨日期,SupplierID,供應商名稱,倉庫別,備註, COUNT(進貨單號) as 筆數, SUM(小計)as 進貨總價 from view_進貨單新增編輯 GROUP BY 進貨單號 ,進貨日期,SupplierID,供應商名稱,倉庫別,備註 ";
            return purchaseListqueryBySql(sql , null);
        }

        public List<CtPurchaseEdit> getBySupplierID(int SupplierID)
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "  select 進貨單號,進貨日期,SupplierID,供應商名稱,倉庫別,備註, COUNT(進貨單號) as 筆數, SUM(小計)as 進貨總價 from view_進貨單新增編輯 WHERE SupplierID = @K_SupplierID  GROUP BY 進貨單號 ,進貨日期,SupplierID,供應商名稱,倉庫別,備註";

            paras.Add(new SqlParameter("K_SupplierID", (object)SupplierID));
            return purchaseListqueryBySql(sql, paras);
        }


        public List<CtPurchaseEdit> getBypurchaseID(int id)
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "  select 進貨單號,進貨日期,SupplierID,供應商名稱,倉庫別,備註, COUNT(進貨單號) as 筆數, SUM(小計)as 進貨總價 from view_進貨單新增編輯 WHERE 進貨單號 = @K_進貨單號  GROUP BY 進貨單號 ,進貨日期,SupplierID,供應商名稱,倉庫別,備註";

            paras.Add(new SqlParameter("K_進貨單號",  (object)id));
            return purchaseListqueryBySql(sql, paras);
        }

        public List<CtPurchaseEdit> getBypurchaseDate(string date1, string date2)
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "  select 進貨單號,進貨日期,SupplierID,供應商名稱,倉庫別,備註, COUNT(進貨單號) as 筆數, SUM(小計)as 進貨總價 from view_進貨單新增編輯 WHERE 進貨日期 BETWEEN @K_date1 AND  @K_date2 GROUP BY 進貨單號 ,進貨日期,SupplierID,供應商名稱,倉庫別,備註";

            paras.Add(new SqlParameter("K_date1", (object)date1));
            paras.Add(new SqlParameter("K_date2", (object)date2));

            return purchaseListqueryBySql(sql, paras);
        }




        public void update(CtPurchaseEdit p)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = "UPDATE view_進貨單新增編輯  SET ";

            //if (p.進貨單號 != null)
            //{
            //    sql += "進貨單號=@K_進貨單號,";
            //    paras.Add(new SqlParameter("K_進貨單號", p.進貨單號));
            //}
            if (!string.IsNullOrEmpty(p.進貨日期))
            {
                sql += "進貨日期=@K_進貨日期,";
                paras.Add(new SqlParameter("K_進貨日期", p.進貨日期));
            }

            if (p.SupplierID != null)
            {
                sql += "供應商ID=@K_供應商ID,";
                paras.Add(new SqlParameter("K_供應商ID", p.SupplierID));
            }


            if (!string.IsNullOrEmpty(p.供應商名稱))
            {
                sql += "供應商名稱=@K_供應商名稱,";
                paras.Add(new SqlParameter("K_供應商名稱", p.供應商名稱));
            }
            if (p.商品ID != null)
            {
                sql += "商品ID=@K_商品ID,";
                paras.Add(new SqlParameter("K_商品ID", p.商品ID));
            }

            if (!string.IsNullOrEmpty(p.商品名稱))
            {
                sql += "商品名稱=@K_商品名稱,";
                paras.Add(new SqlParameter("K_商品名稱", p.商品名稱));
            }

            if (p.單價 != null)
            {
                sql += "單價=@K_單價,";
                paras.Add(new SqlParameter("K_單價", p.單價));
            }

            if (p.數量 != null)
            {
                sql += "數量=@K_數量,";
                paras.Add(new SqlParameter("K_數量", p.數量));
            }

            if (p.小計 != null)
            {
                sql += "小計=@K_小計,";
                paras.Add(new SqlParameter("K_小計", p.小計));
            }

            if (p.進貨總價 != null)
            {
                sql += "進貨總價=@K_進貨總價,";
                paras.Add(new SqlParameter("K_進貨總價", p.進貨總價));
            }

            if (p.倉庫ID != null)
            {
                sql += "倉庫ID=@K_倉庫ID,";
                paras.Add(new SqlParameter("K_倉庫ID", p.倉庫ID));
            }

            if (!string.IsNullOrEmpty(p.倉庫別))
            {
                sql += "倉庫別=@K_倉庫別,";
                paras.Add(new SqlParameter("K_倉庫別", p.倉庫別));
            }
            if (!string.IsNullOrEmpty(p.備註))
            {
                sql += "備註=@K_備註,";
                paras.Add(new SqlParameter("K_備註", p.備註));
            }



            if (sql.Substring(sql.Length - 1, 1) == ",")  //Substring(字元開始的位置(不包含開始),取幾個)
                sql = sql.Substring(0, sql.Length - 1);

            sql += " WHERE 進貨單號 = @K_進貨單號";
            paras.Add(new SqlParameter("K_進貨單號", (object)p.進貨單號)); //

            exeSql(sql, paras);

        }


        public List<CtPurchaseEdit> purchaseEditqueryBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            SqlDataReader reader = cmd.ExecuteReader();
            List<CtPurchaseEdit> list = new List<CtPurchaseEdit>();
            while (reader.Read())
            {
                CtPurchaseEdit x = new CtPurchaseEdit();
                x.進貨單號 = (int)reader["進貨單號"];
                x.進貨日期 = reader["進貨日期"].ToString();
                x.商品名稱 = reader["商品名稱"].ToString();
                x.商品ID = (int)reader["商品ID"];
                x.單價 = (decimal)reader["單價"];
                x.數量 = (int)reader["數量"];
                x.小計 = (decimal)reader["小計"];
                x.倉庫別 = reader["倉庫別"].ToString();
                x.備註 = reader["備註"].ToString();

                list.Add(x);
            }
            con.Close();
            return list;
        }

        public List<CtPurchaseEdit> getpurchaseEdit(int id)
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "  SELECT  進貨單號, 進貨日期 ,  CommodityID as 商品ID ,商品名稱 ,單價 , 數量, 小計  ,倉庫別  ,備註 FROM view_進貨單新增編輯 ";
            sql += " WHERE 進貨單號 = @K_進貨單號";
            paras.Add(new SqlParameter("K_進貨單號", (object)id)); 


            return purchaseEditqueryBySql(sql , paras);
        }





        public void create(CtPurchase s) //順序會影響傳入欄位 
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "INSERT INTO tSupplier (";
            if (s.進貨單號 !=null)   //若使用者不輸入就忽略
            sql += "進貨單號,";
            if (!string.IsNullOrEmpty(s.進貨日期))
                sql += "進貨日期,";
            if (!string.IsNullOrEmpty(s.供應商名稱))
                sql += "供應商名稱,";
            if (!string.IsNullOrEmpty(s.商品名稱))
                sql += "商品名稱,";
            if (!string.IsNullOrEmpty(s.倉庫別))
                sql += "倉庫別,";
            if (!string.IsNullOrEmpty(s.備註))
                sql += "備註,";

            if (sql.Substring(sql.Length - 1, 1) == ",")
                sql = sql.Substring(0, sql.Length - 1); //Substring(字元開始的位置(不包含開始),取幾個)
            sql += ")VALUES(";

            if (s.進貨單號 != null)
            {
                sql += "@K_進貨單號,";
                paras.Add(new SqlParameter("K_進貨單號", s.進貨單號));
            }
            if (!string.IsNullOrEmpty(s.進貨日期))
            {
                sql += "@K_進貨日期,";
                paras.Add(new SqlParameter("K_進貨日期", s.進貨日期));
            }
            if (!string.IsNullOrEmpty(s.供應商名稱))
            {
                sql += "@K_供應商名稱,";
                paras.Add(new SqlParameter("K_供應商名稱", s.供應商名稱));
            }

            if (!string.IsNullOrEmpty(s.商品名稱))
            {
                sql += "@K_商品名稱,";
                paras.Add(new SqlParameter("K_商品名稱", s.商品名稱));
            }

            if (s.進貨總價 != null)
            {
                sql += "@K_進貨總價,";
                paras.Add(new SqlParameter("K_進貨總價", s.進貨總價));
            }

            if (!string.IsNullOrEmpty(s.倉庫別))
            {
                sql += "@K_倉庫別,";
                paras.Add(new SqlParameter("K_倉庫別", s.倉庫別));
            }


            if (!string.IsNullOrEmpty(s.備註))
            {
                sql += "@K_備註,";
                paras.Add(new SqlParameter("K_備註", s.備註));
            }



            if (sql.Substring(sql.Length - 1, 1) == ",")  //Substring(字元開始的位置(不包含開始),取幾個)
                sql = sql.Substring(0, sql.Length - 1);

            sql += ")";

            exeSql(sql, paras);

        }







        internal static void exeSql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            cmd.ExecuteNonQuery();
            con.Close();
        }



    }
}
