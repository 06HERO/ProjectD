using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 進銷存系統.FrmLara
{
    public partial class Frm訂單查詢query : Form
    {
        public Frm訂單查詢query()
        {
            InitializeComponent();
        }
        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 120; 
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 200;

            bool isChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                
                
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
                r.DefaultCellStyle.BackColor = Color.MintCream;
                if (isChanged)
                    r.DefaultCellStyle.BackColor = Color.White;
                isChanged = !isChanged;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm訂單查詢query_Load(object sender, EventArgs e)
        {
            resetGridStyle();
        }

        private void 訂單編號_TextChanged(object sender, EventArgs e)
        {
            SqlCommandBuilder _builder = new SqlCommandBuilder();
            SqlDataAdapter _adapter = null;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            string odrNO = txt訂單編號.Text.Trim();
            string sql = "";

            sql = @"SELECT a.[出貨單編號],[商品名稱],[進貨價],[商品單價],[商品數量]
                        ,[商品單價]*[商品數量] as 銷售小計,[進貨價]*[商品數量] as 進貨小計
                        , [商品單價]*[商品數量]-[進貨價]*[商品數量] as 本項毛利,備註
                        FROM[dbo].[出貨單明細]a
                        JOIN[dbo].[商品列表]b
                        ON a.廠商ID=b.廠商ID AND a.[商品類型ID]=b.商品類型ID AND a.[商品ID] = b.商品ID
                        JOIN[dbo].[出貨單列表]c
                        ON a.[出貨單編號]=c.出貨單編號
                        WHERE a.出貨單編號= @出貨單NO";

            _adapter = new SqlDataAdapter(sql, con);
            _adapter.SelectCommand.Parameters.Add(new SqlParameter("@出貨單NO", odrNO));

            _builder.DataAdapter = _adapter;
            DataSet ds1 = new DataSet();
            _adapter.Fill(ds1);
            con.Close();
            dataGridView1.DataSource = ds1.Tables[0];

            resetGridStyle();
        }

        private void 改備註_Click(object sender, EventArgs e)
        {
            if(txt備註.Text == "")
                this.Close();
            else
            {
                SqlCommandBuilder _builder = new SqlCommandBuilder();
                SqlDataAdapter _adapter = null;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
                con.Open();

                string odrNO = txt訂單編號.Text.Trim();
                string pk = txt備註.Text.Trim();

                string sql = "";

                sql = @"
                        UPDATE[dbo].[出貨單列表]
                            SET 備註=@K_memo
                            WHERE 出貨單編號= @出貨單NO
                        SELECT a.[出貨單編號],[商品名稱],[進貨價],[商品單價],[商品數量]
                            ,[商品單價]*[商品數量] as 銷售小計,[進貨價]*[商品數量] as 進貨小計
                            , [商品單價]*[商品數量]-[進貨價]*[商品數量] as 本項毛利,備註
                            FROM[dbo].[出貨單明細]a
                            JOIN[dbo].[商品列表]b
                            ON a.廠商ID=b.廠商ID AND a.[商品類型ID]=b.商品類型ID AND a.[商品ID] = b.商品ID
                            JOIN[dbo].[出貨單列表]c
                            ON a.[出貨單編號]=c.出貨單編號
                            WHERE a.出貨單編號= @出貨單NO";

                _adapter = new SqlDataAdapter(sql, con);
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@出貨單NO", odrNO));
                _adapter.SelectCommand.Parameters.Add(new SqlParameter("@K_memo", (object)pk));


                _builder.DataAdapter = _adapter;
                DataSet ds1 = new DataSet();
                _adapter.Fill(ds1);
                con.Close();
                dataGridView1.DataSource = ds1.Tables[0];

                resetGridStyle();
            }
        }
    }
}
