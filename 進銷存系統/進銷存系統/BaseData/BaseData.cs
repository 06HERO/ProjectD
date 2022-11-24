using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace 進銷存系統.BaseData
{
    enum User_LV
    {
        User = 0,
        Admin = 1
    }

    enum Change_Mode
    {
        None   = 0, 
        Insert = 1,
        Update = 2,
        Delete = 3
    }

    static public class SQLData
    {
        static public 普雷二電玩Entities db = new 普雷二電玩Entities();

        static public string 資料庫路徑 = "Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";

        static public string LoginID = string.Empty;

        static public int IsAdmin = -1;

        static public bool IsCheck = false;

        // 普雷二電玩Entities 成員 IEnumerable<> 直接呼叫 轉換成 DataTable
        static public DataTable ToDataTable<T>(this IEnumerable<T> source)
        {
            return LinqQueryToDataTable(source);
        }

        // IEnumerable<T> 轉換成 DataTable
        static public DataTable LinqQueryToDataTable<T>(IEnumerable<T> query)
        {
            DataTable tbl = new DataTable();
            PropertyInfo[] props = null;
            foreach (T item in query)
            {
                if (props == null) //尚未初始化
                {
                    Type t = item.GetType();
                    props = t.GetProperties();
                    foreach (PropertyInfo pi in props)
                    {
                        Type colType = pi.PropertyType;

                        // 不加入泛型類型(導覽屬性)
                        if (colType.IsInterface || colType.IsSecurityCritical)
                            continue;

                        //針對Nullable<>特別處理
                        if (colType.IsGenericType && colType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        //建立欄位
                        tbl.Columns.Add(pi.Name, colType);
                    }
                }

                DataRow row = tbl.NewRow();
                foreach (PropertyInfo pi in props)
                {
                    // 不加入泛型類型(導覽屬性)
                    if (pi.PropertyType.IsInterface || pi.PropertyType.IsSecurityCritical)
                        continue ;

                    row[pi.Name] = pi.GetValue(item, null) ?? DBNull.Value;
                }
                tbl.Rows.Add(row);
            }
            return tbl;
        }
    }

    static public class RdlcData
    {
        static public string 廠商列表清單Path = "進銷存系統.Report.Rpt廠商列表.rdlc";

        static public string 商品類別列表清單Path = "進銷存系統.Report.Rpt商品類型列表.rdlc";

        static public string 商品列表清單Path = "進銷存系統.Report.Rpt商品列表.rdlc";

        static public string 訂單查詢結果Path = "進銷存系統.Report.Rpt訂單查詢.rdlc";

        static public string 庫存列表清單Path = "進銷存系統.Report.Rpt商品庫存列表.rdlc";

        static public string 總庫存列表清單Path = "進銷存系統.Report.Rpt總商品庫存表.rdlc";
    }

    public class cCampany //C#端廠商列表
    {
        public int 廠商id { get; set; }
        public string 廠商名稱 { get; set; }
        public string 統一編號 { get; set; }
        public string 代表人姓名 { get; set; }
        public string 資本總額 { get; set; }
        public string 聯絡電話 { get; set; }
        public string 顯示與否 { get; set; }
    }
}
