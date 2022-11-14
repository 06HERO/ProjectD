using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;

namespace 進銷存系統.SqlFun
{
    public class SqlFunProduct
    {
        public SqlFunProduct()
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

        #region 廠商列表
        public DataTable Get廠商列表()
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"SELECT * FROM 廠商列表";
            //SqlDataReader reader = base.ReaderSql(sql);

            //DataTable DT = new DataTable();
            //DT.Load(reader);

            //reader.Close();
            //_con.Close();

            //return DT;

            //廠商列表TableAdapter TA = new 廠商列表TableAdapter();
            //DataSet普雷二電玩 DS = new DataSet普雷二電玩();
            //TA.Fill(DS.廠商列表);
            //return DS.廠商列表;

            //廠商列表TableAdapter TA = new 廠商列表TableAdapter();
            //DataSet普雷二電玩.廠商列表DataTable DT = TA.GetData();
            //return DT;

            //return new 廠商列表TableAdapter().GetData();
            //return SQLData.LinqQueryToDataTable(SQLData.db.廠商列表);
            return SQLData.db.廠商列表.ToDataTable();
        }

        //public IEnumerable<廠商列表> Get廠商列表()
        //{
        //    return SQLData.db.廠商列表.AsEnumerable().ToList();            
        //}

        public int Insert廠商(int Id, string Name, string 統一編號, string 代表人姓名, decimal 資本總額, string 聯絡電話, string 顯示與否)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Insert廠商列表";
            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@廠商ID", Id));
            //paras.Add(new SqlParameter("@廠商名稱", Name));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;


            //廠商列表 entity = new 廠商列表()
            //{
            //    廠商ID = (byte)Id,
            //    廠商名稱 = Name
            //};
            //SQLData.db.廠商列表.Add(entity);
            //return = SQLData.db.SaveChanges();

            return SQLData.db.Insert廠商列表((byte)Id, Name, 統一編號, 代表人姓名, 資本總額, 聯絡電話, 顯示與否);
        }

        public int Update廠商(int Id, string Name, string 統一編號, string 代表人姓名, decimal 資本總額, string 聯絡電話, string 顯示與否)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Update廠商列表";

            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@廠商ID", Id));
            //paras.Add(new SqlParameter("@廠商名稱", Name));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;

            return SQLData.db.Update廠商列表((byte)Id, Name, 統一編號, 代表人姓名, 資本總額, 聯絡電話, 顯示與否);
        }

        public int Delete廠商(int Id)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Delete廠商列表";

            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@廠商ID", Id));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;

            return SQLData.db.Delete廠商列表((byte)Id);
        }
        #endregion

        #region 商品類別
        public DataTable Get商品類別列表()
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"SELECT * FROM 商品類型列表";
            //SqlDataReader reader = base.ReaderSql(sql);

            //DataTable DT = new DataTable();
            //DT.Load(reader);

            //reader.Close();
            //_con.Close();

            //return DT;

            //return new 商品類型列表TableAdapter().GetData();            
            //return SQLData.LinqQueryToDataTable(SQLData.db.商品類型列表);
            return SQLData.db.商品類型列表.ToDataTable();
        }

        //public IEnumerable<商品類型列表> Get商品類別列表()
        //{
        //    return SQLData.db.商品類型列表.AsEnumerable().ToList();
        //}

        public int Insert商品類型(int Id, string Name)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Insert商品類型列表";

            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@商品類型ID", Id));
            //paras.Add(new SqlParameter("@商品類型名稱", Name));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;

            return SQLData.db.Insert商品類型列表((byte)Id, Name);
        }

        public int Update商品類型(int Id, string Name)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Update商品類型列表";

            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@商品類型ID", Id));
            //paras.Add(new SqlParameter("@商品類型名稱", Name));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;

            return SQLData.db.Update商品類型列表((byte)Id, Name);
        }

        public int Delete商品類型(int Id)
        {
            //if (_con.State != ConnectionState.Open)
            //    _con.Open();

            //string sql = @"Delete商品類型列表";

            //List<SqlParameter> paras = new List<SqlParameter>();
            //paras.Add(new SqlParameter("@商品類型ID", Id));
            //int count = base.ExecuteSql(sql, paras);

            //_con.Close();
            //return count;

            return SQLData.db.Delete商品類型列表((byte)Id);
        }

        #endregion

        #region 商品列表

        public DataTable Get商品列表()
        {
            //return SQLData.LinqQueryToDataTable(SQLData.db.商品列表);
            return SQLData.db.商品列表.ToDataTable();
        }

        public int Insert商品列表(商品列表 ProData)
        {
            byte 廠商ID = ProData.廠商ID;
            byte 類型ID = ProData.商品類型ID;
            short 商品ID = ProData.商品ID;
            string 商品名稱 = ProData.商品名稱;
            decimal 進貨價 = ProData.進貨價;
            decimal 零售價 = ProData.零售價;

            //int count = SQLData.db.Insert商品列表(廠商ID, 類型ID, 商品ID, 商品名稱, 進貨價, 零售價);

            return SQLData.db.Insert商品列表(廠商ID, 類型ID, 商品ID, 商品名稱, 進貨價, 零售價);
        }

        public int Update商品列表(商品列表 ProData)
        {
            byte 廠商ID = ProData.廠商ID;
            byte 類型ID = ProData.商品類型ID;
            short 商品ID = ProData.商品ID;
            string 商品名稱 = ProData.商品名稱;
            decimal 進貨價 = ProData.進貨價;
            decimal 零售價 = ProData.零售價;

            return SQLData.db.Update商品列表(廠商ID, 類型ID, 商品ID, 商品名稱, 進貨價, 零售價);
        }

        public int Delete商品列表(商品列表 ProData)
        {
            return SQLData.db.Delete商品列表(ProData.廠商ID, ProData.商品類型ID, ProData.商品ID);
        }
        #endregion

        #region 進貨單列表和明細
        public DataTable Get進貨單列表()
        {
            return SQLData.db.進貨單列表.ToDataTable();
        }

        public DataTable Get進貨單明細()
        {
            return SQLData.db.進貨單明細.ToDataTable();
        }

        public int Insert進貨單列表(進貨單列表 InData)
        {
            int 進貨單編號 = InData.進貨單編號;
            byte 廠商ID = InData.廠商ID;
            int 庫存地點ID = InData.庫存地點ID;
            DateTime 進貨日期 = InData.進貨日期;
            byte 明細筆數 = InData.明細筆數;

            return SQLData.db.Insert進貨單列表(進貨單編號, 廠商ID, 庫存地點ID, 進貨日期, 明細筆數);
        }

        public int Update進貨單列表(進貨單列表 InData)
        {
            int 進貨單編號 = InData.進貨單編號;

            int 庫存地點ID = InData.庫存地點ID;
            DateTime 進貨日期 = InData.進貨日期;
            byte 明細筆數 = InData.明細筆數;

            return SQLData.db.Update進貨單列表(進貨單編號, 庫存地點ID, 進貨日期, 明細筆數);
        }

        public int Delete進貨單列表(int 進貨單編號)
        {
            return SQLData.db.Delete進貨單列表(進貨單編號);
        }
        #endregion
    }
}
