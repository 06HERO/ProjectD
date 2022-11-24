using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
//using WindowsFormsApp1.Modul;
using System.Drawing.Printing;
using System.Threading;
using 進銷存系統.FrmLara;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Security.Cryptography;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;
using 進銷存系統.BaseData;

namespace 進銷存系統
{
    public partial class Frm訂單查詢 : Form
    {
        public Frm訂單查詢()
        {
            InitializeComponent();

        }
        private int _dt列表Index = -1;
        int _出貨單編號 = -1;

        SqlCommandBuilder _builder = new SqlCommandBuilder();
        SqlDataAdapter _adapter = null;
        SqlConnection con = new SqlConnection();
        string sql = "";
        
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[2].Width = 160;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable; 
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

            bool isChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.DefaultCellStyle.BackColor = Color.LightBlue;
                if (isChanged)
                    r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isChanged = !isChanged;
            }
        }



        //*********************查詢*********************//
        private void 查詢_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();           


            //使用者輸入值SQL語法化
            string t出貨單NO = txt出貨單號.Text.Trim();
            string t客戶 = txt客戶.Text.Trim();
            string t訂單金額l = txt訂單金額left.Text.Trim();
            string t訂單金額r = txt訂單金額right.Text.Trim();
            DateTime time1 = Convert.ToDateTime(txtDATE1.Text.Trim());  //txt要有預設值
            DateTime time2 = Convert.ToDateTime(txtDATE2.Text.Trim());

            //檢查USER錯誤輸入值
            checkInput(t出貨單NO, t客戶, t訂單金額l, t訂單金額r, time1, time2);
            
            //出貨單號 不可合併其他條件查詢
            if(t出貨單NO != "" && (t客戶 != "" || t訂單金額r != "0" || t訂單金額l != "0"
                || time1.ToString("yyyy-MM-dd") != "2000-01-01" || time2.ToString("yyyy-MM-dd") != "2000-01-01"))
            {
                MessageBox.Show("出貨單號 不可合併其他條件查詢");
                DataTable dt = dataGridView1.DataSource as DataTable;
                dataGridView1.DataSource = dt;
            }




            //查詢 出貨單號
            if (t出貨單NO != "" && t客戶 == "" && t訂單金額r == "0" && t訂單金額l == "0"
                && txtDATE1.Text == "2000-01-01" && txtDATE2.Text == "2000-01-01")  
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE a.出貨單編號= @出貨單NO
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";
                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@出貨單NO", t出貨單NO));

                顯示data(con);
                #region

                // 普雷二電玩Entities play2db = new 普雷二電玩Entities();
                // var q = from odrno in play2db.出貨單列表
                //         join vendor in play2db.經銷商列表
                //         on odrno.經銷商ID equals vendor.經銷商ID
                //         where odrno.出貨單編號 == int.Parse(t出貨單NO)
                //         select new
                //         {
                //             odrno.出貨單編號,
                //             odrno.出貨日期,
                //             vendor.經銷商名稱,
                //             odrno.進貨成本,
                //             odrno.出貨收益,
                //             odrno.淨利
                //         };

                //dataGridView1.DataSource = q.ToList();
                // play2db.Entry(q).Reload();
                #endregion
            }




            //查詢 客戶別
            if (t出貨單NO == "" && t客戶 != ""  &&  t訂單金額r == "0" && t訂單金額l == "0" 
                && txtDATE1.Text == "2000-01-01" && txtDATE2.Text == "2000-01-01") 
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE 經銷商名稱 LIKE @客戶
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";
                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@客戶", "%"+t客戶+ "%"));
                顯示data(con);
            }

            //查詢 訂單金額+訂單日期
            if (t出貨單NO == "" && t客戶 == "" && (t訂單金額r !="0" || t訂單金額l !="0") 
                && txtDATE1.Text != "2000-01-01" && txtDATE2.Text != "2000-01-01") //OK
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE (訂單金額 BETWEEN @訂單金額1 AND @訂單金額2) AND (訂單日期  BETWEEN @訂單日期1 AND @訂單日期2)
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";
                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額1", t訂單金額l));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額2", t訂單金額r));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期1", time1.ToString("yyyy-MM-dd")));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期2", time2.ToString("yyyy-MM-dd")));

                顯示data(con);
            }

            //查詢 客戶別+訂單金額
            if (t出貨單NO == "" && t客戶 != "" && (t訂單金額r != "0" || t訂單金額l != "0")
                && txtDATE1.Text == "2000-01-01" && txtDATE2.Text == "2000-01-01")  //OK

            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE (訂單金額 BETWEEN @訂單金額1 AND @訂單金額2) AND (經銷商名稱 LIKE @客戶)
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";
                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額1", t訂單金額l));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額2", t訂單金額r));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@客戶", "%" + t客戶 + "%"));

                顯示data(con);
            }

            //查詢 客戶別+訂單金額+訂單日期
            if (t出貨單NO == "" && t客戶 != "" && (t訂單金額l != "0" || t訂單金額r != "0") 
                 && ( txtDATE1.Text != "2000-01-01" || txtDATE2.Text != "2000-01-01")) //OK
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE (訂單金額 BETWEEN @訂單金額1 AND @訂單金額2) AND (經銷商名稱 LIKE @客戶)
                            AND (訂單日期 BETWEEN @訂單日期1 AND @訂單日期2)
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";

                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額1", txt訂單金額left.Text.Trim()));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額2", txt訂單金額right.Text.Trim()));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@客戶", "%" + txt客戶.Text.Trim() + "%"));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期1", time1.ToString("yyyy-MM-dd")));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期2", time2.ToString("yyyy-MM-dd")));

                顯示data(con);
            }

            //查詢 出貨日期
            if (t出貨單NO == "" && t客戶 == "" && t訂單金額l == "0" && t訂單金額r == "0"
                && (txtDATE1.Text != "2000-01-01" || txtDATE2.Text != "2000-01-01"))   //OK
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                             WHERE 訂單日期 BETWEEN @訂單日期1 AND @訂單日期2
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";

                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期1", time1.ToString("yyyy-MM-dd")));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單日期2", time2.ToString("yyyy-MM-dd")));
                顯示data(con);
            }

            //查詢 訂單金額
            if (t出貨單NO == "" && t客戶 == "" && (t訂單金額l != "0" || t訂單金額r != "0")
                && txtDATE1.Text == "2000-01-01" && txtDATE2.Text == "2000-01-01")  //OK
            {
                sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            WHERE 訂單金額 BETWEEN @訂單金額1 AND @訂單金額2
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註";
                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額1", t訂單金額l));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@訂單金額2", t訂單金額r));
                顯示data(con);
            }


        }

        //*********************前100大*********************//

        private void 金額TOP100_Click(object sender, EventArgs e)   //OK
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            sql = @"SELECT a.出貨單編號, 訂單日期, 經銷商名稱 as 客戶 , 訂單金額
                             , SUM([進貨價]*[商品數量]) as 進貨成本,  訂單金額-SUM([進貨價]*[商品數量]) as 毛利,a.備註
                            FROM [出貨單列表]a 
                            JOIN [經銷商列表]b ON a.經銷商ID=b.經銷商ID
                            JOIN [出貨單明細]c ON a.出貨單編號=c.出貨單編號
                            JOIN[dbo].[商品列表]d ON c.廠商ID=d.廠商ID AND c.[商品類型ID]=d.商品類型ID AND c.[商品ID] = d.商品ID
                            GROUP BY a.出貨單編號, 訂單日期, 經銷商名稱, 訂單金額,a.備註
                            ORDER BY 訂單金額 DESC" ;

            _adapter = new SqlDataAdapter(sql, con);
            顯示data(con);
            button4.Visible = false;
            //dataGridView1.Columns[3].DefaultCellStyle.BackColor = Color.Yellow;

        }

        private void 數量TOP100_Click(object sender, EventArgs e)   //OK
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            sql = @"SELECT [商品名稱],SUM([商品數量]) as 商品銷售總計
                        FROM[dbo].[出貨單明細]a
                        JOIN[dbo].[商品列表]b
                        ON a.廠商ID=b.廠商ID AND a.[商品類型ID]=b.商品類型ID AND a.[商品ID] = b.商品ID
                        JOIN[dbo].[出貨單列表]c
                        ON a.[出貨單編號]=c.出貨單編號
                        GROUP BY [商品名稱],[商品數量]
                        ORDER BY SUM([商品數量]) DESC";
           _adapter = new SqlDataAdapter(sql, con);

            _builder.DataAdapter = _adapter;
            DataSet ds1 = new DataSet();
            _adapter.Fill(ds1);
            con.Close();
            dataGridView1.DataSource = ds1.Tables[0];
            dataGridView1.Columns[0].Width = 320;
            dataGridView1.Columns[1].Width = 160;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            bool isChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.DefaultCellStyle.BackColor = Color.LightBlue;
                if (isChanged)
                    r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isChanged = !isChanged;
            }

            string cont = dataGridView1.Rows.Count.ToString();
            label9.Text = "總筆數: " + cont;

            decimal val = 0;
            foreach (DataRow r in ds1.Tables[0].Rows)
            {
                val += Convert.ToDecimal(r["商品銷售總計"].ToString());
            }
            label10.Text = "總銷售數量: " + val.ToString("###,###,##0");

            string cont1 = dataGridView1.Rows.Count.ToString();
            label9.Text = "總筆數: " + cont1;

            button4.Visible = false;

        }

        private void 顯示data(SqlConnection con)
        {
            _builder.DataAdapter = _adapter;
            DataSet ds1 = new DataSet();
            _adapter.Fill(ds1);
            con.Close();
            dataGridView1.DataSource = ds1.Tables[0];
            resetGridStyle();

            decimal val = 0;
            foreach (DataRow r in ds1.Tables[0].Rows)
            {
                val += Convert.ToDecimal(r["訂單金額"].ToString());
            }
            label10.Text = "總金額: " + val.ToString("###,###,##0");

            string cont = dataGridView1.Rows.Count.ToString();
            label9.Text = "總筆數: " + cont;


        }


        private static void checkInput(string t出貨單NO, string t客戶, string t訂單金額l, string t訂單金額r, DateTime time1 , DateTime time2)
        {

            if (t出貨單NO.Length < 1 && t客戶.Length < 1 && t訂單金額l =="0" && t訂單金額r == "0" 
                && time1.ToString("yyyy-MM-dd") == "2000-01-01" && time2.ToString("yyyy-MM-dd") == "2000-01-01")
            {
                MessageBox.Show("請輸入條件");
            }

            else if (DateTime.Compare(time2, time1) < 0)
                MessageBox.Show("日期區間選擇錯誤");

            else if (Int32.Parse(t訂單金額r)  <  Int32.Parse(t訂單金額l))
                MessageBox.Show("金額區間輸入錯誤");

            else
                return;


        }

        //*********************清空*********************//
        private void 重新查詢_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                dt.Rows.Clear();
                dataGridView1.DataSource = dt;
                txt出貨單號.Text = "";
                txt客戶.Text = "";
                txt訂單金額left.Text = "0";
                txt訂單金額right.Text = "0";
                txtDATE1.Text = "2000-01-01";
                txtDATE2.Text = "2000-01-01";
                label9.Text = "訂單總筆數: ";
                label10.Text = "訂單總金額: ";



            }
            else if (txt出貨單號.Text != ""
                || txt客戶.Text != ""
                || txt訂單金額left.Text != "0"
                || txt訂單金額right.Text != "0"
                || txtDATE1.Text != "2000-01-01" || txtDATE2.Text != "2000-01-01")
            {
                txt出貨單號.Text = "";
                txt客戶.Text = "";
                txt訂單金額left.Text = "0";
                txt訂單金額right.Text = "0";
                txtDATE1.Text = "2000-01-01";
                txtDATE2.Text = "2000-01-01";
                label9.Text = "訂單總筆數: ";
                label10.Text = "訂單總金額: ";
                #region
                //dateTimePicker1.Format = DateTimePickerFormat.Custom;
                //dateTimePicker1.CustomFormat = " ";
                //dateTimePicker2.Format = DateTimePickerFormat.Custom;
                //dateTimePicker2.CustomFormat = " ";
                #endregion
            }

            else
                return;

        }





        #region
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        //}

        //private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        //{
        //    dateTimePicker2.CustomFormat = "yyyy/MM/dd";

        //}

        //private void Frm訂單查詢_Load(object sender, EventArgs e)
        //{
        //    dateTimePicker1.Format = DateTimePickerFormat.Custom;
        //    dateTimePicker1.CustomFormat = " ";
        //    dateTimePicker2.Format = DateTimePickerFormat.Custom;
        //    dateTimePicker2.CustomFormat = " ";

        //}
        #endregion

        //點選訂單查詢明細
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _dt列表Index = e.RowIndex;
            if (_dt列表Index < 0 || _dt列表Index >= dataGridView1.Rows.Count)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row == null)
                return;

            _出貨單編號 = Convert.ToInt32(row.Cells["出貨單編號"].Value);

            if (dataGridView1.SelectedRows.Count > 0)
                _position = e.RowIndex;

            //int i = dataGridView1.CurrentCell.RowIndex;
            //int j = dataGridView1.CurrentCell.ColumnIndex;
            Frm訂單查詢query f = new Frm訂單查詢query();
            f.txt訂單編號.Text = _出貨單編號.ToString();
            f.Show();

        }

        int _position = -1;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            int j = dataGridView1.CurrentCell.ColumnIndex;
            Frm訂單查詢query f = new Frm訂單查詢query();
            f.Show();
            if (_position < 0)
                return;

            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];

            f.txt訂單編號.Text = row["出貨單編號"].ToString();
        }

        private void Frm訂單查詢_Load(object sender, EventArgs e)
        {
           // resetGridStyle();
        }


        //*********************列印報表*********************//

        private void btn列印_Click(object sender, EventArgs e)
        {

            DataTable dt = dataGridView1.DataSource as DataTable;
            List<ReportDataSource> reportDatas = new List<ReportDataSource>()
            {
                new ReportDataSource("DataSetOdr", dt)
            };
            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("LoginID", SQLData.LoginID),

            };

            FrmReport report = new FrmReport("訂單查詢列表");
            report.LoadSources(RdlcData.訂單查詢結果Path, reportDatas, reportParameters);
            report.WindowState = FormWindowState.Maximized;
            report.Show();

        }

    }
}

