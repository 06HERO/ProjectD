using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;

namespace 進銷存系統.SqlFun
{
    public class SqlFunUser
    {
        public SqlFunUser()
        {
            //_con = new SqlConnection(SQLData.資料庫路徑);                
            //_con.Open();
            //if (_con.State != ConnectionState.Open)
            //{
            //    MessageBox.Show("無法連線至資料庫!", "連線錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //_con.Close();
        }

        public bool Login(string LoginID, string LoginPW)
        {
            bool bIsLogin = false;

            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = "使用者Login";
            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@LoginID", LoginID));
            //paras.Add(new SqlParameter("@LoginPW", LoginPW));
            //paras.Add(new SqlParameter("@ReIsAdmin", SqlDbType.Int));

            //SqlCommand cmd = new SqlCommand(sql, _con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddRange(paras.ToArray());
            //cmd.Parameters["@ReIsAdmin"].Direction = ParameterDirection.ReturnValue;

            //cmd.ExecuteNonQuery();

            //int IsAdmin = Convert.ToInt32(cmd.Parameters["@ReIsAdmin"].Value.ToString());
            //if (IsAdmin >= 0)
            //{
            //    bIsLogin = true;
            //    SQLData.LoginID = LoginID;
            //    SQLData.IsAdmin = IsAdmin;
            //}
            
            //_con.Close();

            ObjectParameter objIsAdmin = new ObjectParameter("IsAdmin", typeof(byte));
            SQLData.db.使用者LoginByEntity(LoginID, LoginPW, objIsAdmin);
            int IsAdmin = (byte)objIsAdmin.Value;
            if (IsAdmin >= 0)
            {
                bIsLogin = true;
                SQLData.LoginID = LoginID;
                SQLData.IsAdmin = IsAdmin;
            }

            return bIsLogin;
        }
    }
}
