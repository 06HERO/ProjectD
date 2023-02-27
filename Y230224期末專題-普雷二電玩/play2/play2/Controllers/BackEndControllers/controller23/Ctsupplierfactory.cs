using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace play2.Controllers
{ 

    public class Ctsupplierfactory
    {
        public List<Ctsupplier> queryBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            SqlDataReader reader = cmd.ExecuteReader();
            List<Ctsupplier> list = new List<Ctsupplier>();
            while (reader.Read())
            {
                Ctsupplier x = new Ctsupplier();
                x.SupplierID = (int)reader["SupplierID"];
                x.TaxIDNumber = reader["TaxIDNumber"].ToString();
                x.SupplierName = reader["SupplierName"].ToString();
                x.PrincipalMan = reader["PrincipalMan"].ToString();
                x.Phone = reader["Phone"].ToString();
                x.SwiftCode = reader["SwiftCode"].ToString();
                x.BankName = reader["BankName"].ToString();
                x.Account = reader["Account"].ToString();
                x.Grade = reader["Grade"].ToString();
                x.CapitalAmount = reader["CapitalAmount"].ToString();

                list.Add(x);
            }
            con.Close();
            return list;
        }

        public Ctsupplier getById(int SupplierID)
        {
            string sql = "SELECT * FROM tSupplier WHERE SupplierID = @K_SupplierID";
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_SupplierID", (object)SupplierID));
            List<Ctsupplier> list = queryBySql(sql, paras);
            if (list.Count == 0)
                return null;
            return list[0];
        }

        public List<Ctsupplier> getAll()
        {
            string sql = "SELECT * FROM tSupplier";
            return queryBySql(sql, null);
        }


        public void update(Ctsupplier s)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = "UPDATE tSupplier  SET ";

            if (!string.IsNullOrEmpty(s.TaxIDNumber))
            {
                sql += "TaxIDNumber=@K_TaxIDNumber,";
                paras.Add(new SqlParameter("K_TaxIDNumber", s.TaxIDNumber));
            }
            if (!string.IsNullOrEmpty(s.SupplierName))
            {
                sql += "SupplierName=@K_SupplierName,";
                paras.Add(new SqlParameter("K_SupplierName", s.SupplierName));
            }

            if (!string.IsNullOrEmpty(s.Phone))
            {
                sql += "Phone=@K_Phone,";
                paras.Add(new SqlParameter("K_Phone", s.Phone));
            }


            if (!string.IsNullOrEmpty(s.PrincipalMan))
            {
                sql += "PrincipalMan=@K_PrincipalMan,";
                paras.Add(new SqlParameter("K_PrincipalMan", s.PrincipalMan));
            }

            if (!string.IsNullOrEmpty(s.SwiftCode))
            {
                sql += "SwiftCode=@K_SwiftCode,";
                paras.Add(new SqlParameter("K_SwiftCode", s.SwiftCode));
            }
            if (!string.IsNullOrEmpty(s.BankName))
            {
                sql += "BankName=@K_BankName,";
                paras.Add(new SqlParameter("K_BankName", s.BankName));
            }


            if (!string.IsNullOrEmpty(s.Account))
            {
                sql += "Account=@K_Account,";
                paras.Add(new SqlParameter("K_Account", s.Account));
            }


            if (s.CapitalAmount !=null)
            {
                sql += "CapitalAmount=@K_CapitalAmount,";
                paras.Add(new SqlParameter("K_CapitalAmount", s.CapitalAmount));
            }

            if (!string.IsNullOrEmpty(s.Grade))
            {
                sql += "Grade=@K_Grade,";
                paras.Add(new SqlParameter("K_Grade", s.Grade));
            }


            if (sql.Substring(sql.Length - 1, 1) == ",")  //Substring(字元開始的位置(不包含開始),取幾個)
                sql = sql.Substring(0, sql.Length - 1);

            sql += " WHERE SupplierID = @K_SupplierID";
            paras.Add(new SqlParameter("K_SupplierID", (object)s.SupplierID)); //

            exeSql(sql, paras);

        }



        public void create(Ctsupplier s) //順序會影響傳入欄位
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "INSERT INTO tSupplier (";
            if (!string.IsNullOrEmpty(s.TaxIDNumber))   //若使用者不輸入就忽略
                sql += "TaxIDNumber,";
            if (!string.IsNullOrEmpty(s.SupplierName))
                sql += "SupplierName,";
            if (!string.IsNullOrEmpty(s.Phone))
                sql += "Phone,";
            if (!string.IsNullOrEmpty(s.PrincipalMan))
                sql += "PrincipalMan,";
            if (!string.IsNullOrEmpty(s.SwiftCode))
                sql += "SwiftCode,";
            if (!string.IsNullOrEmpty(s.BankName))
                sql += "BankName,";
            if (!string.IsNullOrEmpty(s.Account))
                sql += "Account,";
            if (s.CapitalAmount != null)
                sql += "CapitalAmount,";
            if (!string.IsNullOrEmpty(s.Grade))
                sql += "Grade,";

            if (sql.Substring(sql.Length - 1, 1) == ",")
                sql = sql.Substring(0, sql.Length - 1); //Substring(字元開始的位置(不包含開始),取幾個)
            sql += ")VALUES(";

            if (!string.IsNullOrEmpty(s.TaxIDNumber))
            {
                sql += "@K_TaxIDNumber,";
                paras.Add(new SqlParameter("K_TaxIDNumber", s.TaxIDNumber));
            }
            if (!string.IsNullOrEmpty(s.SupplierName))
            {
                sql += "@K_SupplierName,";
                paras.Add(new SqlParameter("K_SupplierName", s.SupplierName));
            }
            if (!string.IsNullOrEmpty(s.Phone))
            {
                sql += "@K_Phone,";
                paras.Add(new SqlParameter("K_Phone", s.Phone));
            }

            if (!string.IsNullOrEmpty(s.PrincipalMan))
            {
                sql += "@K_PrincipalMan,";
                paras.Add(new SqlParameter("K_PrincipalMan", s.PrincipalMan));
            }



                if (!string.IsNullOrEmpty(s.SwiftCode))
                {
                    sql += "@K_SwiftCode,";
                    paras.Add(new SqlParameter("K_SwiftCode", s.SwiftCode));
                }

                if (!string.IsNullOrEmpty(s.BankName))
                {
                    sql += "@K_BankName,";
                    paras.Add(new SqlParameter("K_BankName", s.BankName));
                }


                if (!string.IsNullOrEmpty(s.Account))
                {
                    sql += "@K_Account,";
                    paras.Add(new SqlParameter("K_Account", s.Account));
                }

            if (s.CapitalAmount !=null)
            {
                sql += "@K_CapitalAmount,";
                paras.Add(new SqlParameter("K_CapitalAmount", s.CapitalAmount));
            }


            if (!string.IsNullOrEmpty(s.Grade))
                {
                    sql += "@K_Grade,";
                    paras.Add(new SqlParameter("K_Grade", s.Grade));
                }



            if (sql.Substring(sql.Length - 1, 1) == ",")  //Substring(字元開始的位置(不包含開始),取幾個)
                sql = sql.Substring(0, sql.Length - 1);

            sql += ")";

            exeSql(sql, paras);

        }


        public void delete(int SupplierID)
        {
            string sql = "DELETE FROM tSupplier WHERE SupplierID=@K_SupplierID";
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_SupplierID", (object)SupplierID)); 
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

        public List<Ctsupplier> getByKeyword(string keyword)
        {
            string sql = "SELECT * FROM tSupplier WHERE SupplierName LIKE @K_KEYWORD";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_KEYWORD", "%" + (object)keyword + "%"));
            return queryBySql(sql, paras);
        }

        //internal Ctsupplier getByEmail(string txtAccount)
        //{
        //    string sql = "SELECT * FROM tPatient WHERE fEmail = @K_fEmail";
        //    List<SqlParameter> paras = new List<SqlParameter>();
        //    paras.Add(new SqlParameter("K_fEmail", (object)txtAccount));
        //    List<tP> list = queryBySql(sql, paras);
        //    if (list.Count == 0)
        //        return null;
        //    return list[0];

        //}


    }
}
