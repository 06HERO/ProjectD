using System.Data.SqlClient;

namespace play2.Controllers { 
    public class Ctrepairfactory
    {


        public List<Ctrepair> getAll()
        {
            string sql = "SELECT * FROM tRepair";
            return queryBySql(sql, null);
        }

        public List<Ctrepair> queryBySql(string sql, List<SqlParameter> paras)
        {
            SqlConnection con = new SqlConnection(
            @"Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());  //AddRange搭配ToArray()
            SqlDataReader reader = cmd.ExecuteReader();
            List<Ctrepair> list = new List<Ctrepair>();
            while (reader.Read())
            {
                Ctrepair x = new Ctrepair();
                x.ID = (int)reader["ID"];
                x.publisher = reader["publisher"].ToString();
                x.extention = reader["extention"].ToString();
                x.describe = reader["describe"].ToString();
                x.registerdate = reader["registerdate"].ToString();
                x.MISresponse = reader["MISresponse"].ToString();
                x.MISprocesser = reader["MISprocesser"].ToString();
                x.closedate = reader["closedate"].ToString();
                x.closeOrpending = reader["closeOrpending"].ToString();

                list.Add(x);
            }
            con.Close();
            return list;
        }


        public void create(Ctrepair r)
        {
            List<SqlParameter> paras = new List<SqlParameter>();

            string sql = "INSERT INTO tRepair (";
            if (!string.IsNullOrEmpty(r.publisher))   //若使用者不輸入就忽略
                sql += "publisher,";
            if (!string.IsNullOrEmpty(r.extention))
                sql += "extention,";
            if (!string.IsNullOrEmpty(r.describe))
                sql += "describe,";
            if (!string.IsNullOrEmpty(r.registerdate))
                sql += "registerdate,";
            if (!string.IsNullOrEmpty(r.MISprocesser))
                sql += "MISprocesser,";

            if (!string.IsNullOrEmpty(r.MISresponse))
                sql += "MISresponse,";
            if (!string.IsNullOrEmpty(r.closeOrpending))
                sql += "closeOrpending,";
            if (!string.IsNullOrEmpty(r.closedate))
                sql += "closedate,";

            if (sql.Substring(sql.Length - 1, 1) == ",")
                sql = sql.Substring(0, sql.Length - 1); //Substring(字元開始的位置(不包含開始),取幾個)
            sql += ")VALUES(";
            if (!string.IsNullOrEmpty(r.publisher))
            {
                sql += "@K_publisher,";
                paras.Add(new SqlParameter("K_publisher", r.publisher));
            }
            if (!string.IsNullOrEmpty(r.extention))
            {
                sql += "@K_extention,";
                paras.Add(new SqlParameter("K_extention", r.extention));
            }
            if (!string.IsNullOrEmpty(r.describe))
            {
                sql += "@K_describe,";
                paras.Add(new SqlParameter("K_describe", r.describe));
            }
            if (!string.IsNullOrEmpty(r.registerdate))
            {
                sql += "@K_registerdate,";
                paras.Add(new SqlParameter("K_registerdate", r.registerdate));
            }
            if (!string.IsNullOrEmpty(r.MISprocesser))
            {
                sql += "@K_MISprocesser,";
                paras.Add(new SqlParameter("K_MISprocesser", r.MISprocesser));
            }
            if (!string.IsNullOrEmpty(r.MISresponse))
            {
                sql += "@K_MISresponse,";
                paras.Add(new SqlParameter("@K_MISresponse", r.MISresponse));
            }

            if (!string.IsNullOrEmpty(r.closeOrpending))
            {
                sql += "@K_closeOrpending,";
                paras.Add(new SqlParameter("K_closeOrpending", r.closeOrpending));
            }
            if (!string.IsNullOrEmpty(r.closedate))
            {
                sql += "@K_closedate,";
                paras.Add(new SqlParameter("K_closedate", r.closedate));
            }


            if (sql.Substring(sql.Length - 1, 1) == ",")  //Substring(字元開始的位置(不包含開始),取幾個)
                sql = sql.Substring(0, sql.Length - 1);

            sql += ")";

            exeSql(sql, paras);

        }

        private static void exeSql(string sql, List<SqlParameter> paras)
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
