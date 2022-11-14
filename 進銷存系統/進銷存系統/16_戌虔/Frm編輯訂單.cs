using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 進銷存系統
{
    public partial class Frm編輯訂單 : Form
    {
        public Frm編輯訂單()
        {
            InitializeComponent();
        }
        int _position = -1;
        SqlCommandBuilder _builder = new SqlCommandBuilder();
        SqlDataAdapter _adapter = null;
        
        private COrder _or;
        public COrder or
        {
            get { return _or; }
            set
            {
                _or = value;
                txt訂單編號.Text = value.訂單編號.ToString();
                txt聯絡人.Text = value.聯絡人.ToString();
                txt聯絡電話.Text = value.聯絡電話.ToString();
                txt地址.Text = value.地址.ToString();
                txt備註.Text = value.備註.ToString();
                cbox經銷商ID.Text = value.經銷商ID.ToString();
                date訂單日期.CustomFormat = value.訂單日期;
                date交貨日期.CustomFormat = value.交貨日期;
                txt訂單狀態.Text = value.訂單狀態.ToString();
            }
        }
        public void redgvstyle()
        {
            dgv訂單明細.Columns[0].Width = this.Width * 1 / 6;
            dgv訂單明細.Columns[1].Width = this.Width * 1 / 6;
            dgv訂單明細.Columns[2].Width = this.Width * 1 / 6;
            dgv訂單明細.Columns[3].Width = this.Width * 1 / 6;
            dgv訂單明細.Columns[4].Width = this.Width * 1 / 6;
            dgv訂單明細.Columns[5].Width = this.Width * 1 / 6;
       
            bool isChanged = false;
            foreach (DataGridViewRow r in dgv訂單明細.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
                r.DefaultCellStyle.BackColor = Color.LightBlue;
                if (isChanged)
                    r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isChanged = !isChanged;
            }
        }
        public void 新增訂單()
        {          
            btn結案.Visible = false;
            btn更新.Visible = false;
            txt訂單狀態.Visible = false;
            lab訂單狀態.Visible = false;
            btn取消.Visible = false;
           
            string sql = "SELECT top 1 出貨單編號 FROM 出貨單列表 order by 出貨單編號 desc";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
          
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                txt訂單編號.Text = reader["出貨單編號"].ToString();

            con.Close();
            date訂單日期.CustomFormat = DateTime.Now.ToString("yyyy-MM-dd");
            txt訂單編號.Enabled = false;
            txt訂單狀態.Text = "接收";
            txt訂單狀態.Enabled = false;
        }
        public void 修改訂單()
        {
            txt訂單編號.Enabled = false;
            btn送出訂單.Visible = false;
            lab警語.Visible = false;
            date訂單日期.Enabled = false;
            redata();
        }
        public void 完成或取消訂單()
        {
            txt訂單編號.Enabled = false;
            txt聯絡人.Enabled = false;
            txt聯絡電話.Enabled = false;
            txt地址.Enabled = false;
            txt訂單狀態.Enabled = false;
            txt單價.Enabled = false;
            txt數量.Enabled = false;
            
            btn送出訂單.Visible = false;
            btn更新.Enabled = false;
            btn結案.Enabled = false;
            btn取消.Visible = false;
            btn刪除品項.Enabled = false;
            
            btn加入明細.Enabled = false;
            btn清除產品資訊.Enabled = false;

            lab警語.Visible = false;

            date訂單日期.Enabled = false;
            date交貨日期.Enabled = false;

            cbox經銷商ID.Enabled = false;
            cbox廠商ID.Enabled = false;
            cbox類型ID.Enabled = false;
            cbox商品ID.Enabled = false;
            cbox品名.Enabled = false;

            dgv訂單明細.Enabled = false;

            btn關閉.Visible = true;


            redata();
        }
        private void totalprice()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            string sql = "select 出貨單編號,sum([商品單價]*[商品數量]) as 'totalprice' from [出貨單明細] group by 出貨單編號 having 出貨單編號="+Convert.ToInt32(txt訂單編號.Text);
            SqlCommand cmd = new SqlCommand(sql, con);
            labtotaprice.Text = "0";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                labtotaprice.Text = reader["totalprice"].ToString();
            }
            con.Close();
        }
        private void redata()
        {
            //string sql = "select o.廠商ID,o.商品類型ID,o.商品ID,商品名稱,商品單價,商品數量  from 出貨單明細　o\r\njoin [dbo].[商品列表] ol\r\non o.廠商ID=ol.廠商ID and o.商品類型ID=ol.商品類型ID and o.商品ID=ol.商品ID where 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text);
            string sql = "select o.廠商ID,o.商品類型ID,o.商品ID,ol.商品名稱,o.商品單價,o.商品數量 from 出貨單明細　o join [dbo].[商品列表] ol on o.廠商ID=ol.廠商ID and o.商品類型ID=ol.商品類型ID and o.商品ID=ol.商品ID where 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text)+" order by o.廠商ID,o.商品類型ID,o.商品ID";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            _adapter = new SqlDataAdapter(sql, con);
            _builder.DataAdapter = _adapter;
            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dgv訂單明細.DataSource = ds.Tables[0];
            redgvstyle();
        }

        private void Frm編輯訂單_Load(object sender, EventArgs e)
        {
            SqlConnection con商品列表 = new SqlConnection();
            con商品列表.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con商品列表.Open();
            string sql商品列表 = "SELECT * FROM 商品列表 where 廠商ID>=0";
         
            SqlCommand cmd商品列表 = new SqlCommand();
            cmd商品列表.Connection = con商品列表;
            cmd商品列表.CommandText = sql商品列表;
            cbox品名.Items.Clear();
            SqlDataReader reader商品列表 = cmd商品列表.ExecuteReader();
            while (reader商品列表.Read())
            {
                cbox品名.Items.Add(/*$"{reader商品列表["廠商ID"]}{reader商品列表["商品類型ID"]}{reader商品列表["商品ID"]}-*/reader商品列表["商品名稱"]/*-${reader商品列表["零售價"]}"*/);
            }
            con商品列表.Close();

            {
                string sql廠商ID = "SELECT DISTINCT 廠商ID from 商品列表";
                SqlConnection con廠商ID = new SqlConnection();
                con廠商ID.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
                con廠商ID.Open();
                SqlCommand cmd廠商ID = new SqlCommand(sql廠商ID, con廠商ID);
                cbox廠商ID.Items.Clear();
                SqlDataReader reader廠商ID = cmd廠商ID.ExecuteReader();
                while (reader廠商ID.Read())
                {
                    cbox廠商ID.Items.Add(reader廠商ID["廠商ID"]);
                }
                con廠商ID.Close();

                string sql類型ID = "SELECT DISTINCT 商品類型ID from 商品列表";
                SqlConnection con類型ID = new SqlConnection();
                con類型ID.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
                con類型ID.Open();
                SqlCommand cmd類型ID = new SqlCommand(sql類型ID, con類型ID);
                cbox類型ID.Items.Clear();
                SqlDataReader reader類型ID = cmd類型ID.ExecuteReader();
                while (reader類型ID.Read())
                {
                    cbox類型ID.Items.Add(reader類型ID["商品類型ID"]);
                }
                con類型ID.Close();

                string sql商品ID = "SELECT DISTINCT 商品ID from 商品列表";
                SqlConnection con商品ID = new SqlConnection();
                con商品ID.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
                con商品ID.Open();
                SqlCommand cmd商品ID = new SqlCommand(sql商品ID, con商品ID);
                cbox商品ID.Items.Clear();
                SqlDataReader reader商品ID = cmd商品ID.ExecuteReader();
                while (reader商品ID.Read())
                {
                    cbox商品ID.Items.Add(reader商品ID["商品ID"]);
                }
                con商品ID.Close();

                SqlConnection con經銷商ID = new SqlConnection();
                con經銷商ID.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
                con經銷商ID.Open();
                string sql經銷商ID = "SELECT * FROM 經銷商列表 ";
                SqlCommand cmd經銷商ID = new SqlCommand(sql經銷商ID, con經銷商ID);
                cbox經銷商ID.Items.Clear();
                SqlDataReader reader經銷商ID = cmd經銷商ID.ExecuteReader();
                while (reader經銷商ID.Read())
                {
                    cbox經銷商ID.Items.Add(reader經銷商ID["經銷商ID"].ToString());
                }
                con經銷商ID.Close();
                totalprice();
                date交貨日期.MinDate = Convert.ToDateTime(date訂單日期.Text);
                txt數量.Text = "0";
                redata();
                redgvstyle();
            }
        }
        private void date訂單日期_ValueChanged(object sender, EventArgs e)
        {
            date訂單日期.CustomFormat = "yyyy-MM-dd";
            date交貨日期.MinDate = Convert.ToDateTime(date訂單日期.Text);
        }

        private void date交貨日期_ValueChanged(object sender, EventArgs e)
        {
            date交貨日期.CustomFormat = "yyyy-MM-dd";
        }

        private void btn送出訂單_Click(object sender, EventArgs e)
        {
            int a = 0;  
            if (string.IsNullOrEmpty(cbox經銷商ID.Text) || date交貨日期.CustomFormat == " " || string.IsNullOrEmpty(txt聯絡電話.Text) || string.IsNullOrEmpty(txt聯絡人.Text))
            {
                MessageBox.Show("請確認資料完整性");
                return;
            }
            if (!int.TryParse(cbox經銷商ID.Text, out a) && !string.IsNullOrEmpty(cbox經銷商ID.Text.Trim()))
            {
                MessageBox.Show("請輸入正確經銷商ID");
                return;
            }
            if ( Convert.ToInt32(cbox經銷商ID.Text) < 1)
            {
                MessageBox.Show("請輸入正確經銷商ID");
                return;
            }
            string message = "                   確定送出訂單嗎?";
            string caption = " ";
            MessageBoxButtons btnIsOK = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, btnIsOK);
            if (result == DialogResult.No)
            {
                return;
            }

            string sql = "UPDATE 出貨單列表 SET ";           
            sql += "經銷商ID=@K_經銷商ID,";
            sql += "聯絡人=@K_聯絡人,";
            sql += "聯絡電話=@K_聯絡電話,";
            sql += "訂單日期=@K_訂單日期,";
            sql += "交貨日期=@K_交貨日期,";
            sql += "地址=@K_地址,";
            sql += "訂單狀態=@K_訂單狀態,";                    
            sql += "備註=@K_備註,";
            sql += "訂單金額=" + Convert.ToDecimal(labtotaprice.Text);
            sql += " where 出貨單編號=@K_出貨單編號 ";

            List <SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_經銷商ID", Convert.ToInt32(cbox經銷商ID.Text)));
            paras.Add(new SqlParameter("K_聯絡人", txt聯絡人.Text));
            paras.Add(new SqlParameter("K_聯絡電話", txt聯絡電話.Text));
            paras.Add(new SqlParameter("K_訂單日期", date訂單日期.Text));
            paras.Add(new SqlParameter("K_交貨日期", date交貨日期.Text));
            paras.Add(new SqlParameter("K_地址", txt地址.Text));
            paras.Add(new SqlParameter("K_訂單狀態", "接收"));
            paras.Add(new SqlParameter("K_備註", txt備註.Text));
            int pk = Convert.ToInt32(txt訂單編號.Text);
            paras.Add(new SqlParameter("K_出貨單編號", (object)pk));          
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("新增資料成功");
            this.Close();
        }

        private void btn結案_Click(object sender, EventArgs e)
        {
            if (txt訂單狀態.Text == "草稿")
            {
                MessageBox.Show("資料不完整無法結案，如要放棄訂單請按取消訂單");
                return;
            }

            string message = "                   確定完成訂單嗎?";
            string caption = " ";
            MessageBoxButtons btnIsOK = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, btnIsOK);
            if (result == DialogResult.No)
            {
                return;
            }

            List<SqlParameter> paras = new List<SqlParameter>();
            string sql = "UPDATE 出貨單列表 SET ";
            sql += "訂單狀態=@K_訂單狀態";
            sql += " where 出貨單編號=@K_出貨單編號 ";
            paras.Add(new SqlParameter("K_訂單狀態", "完成"));
            int pk = Convert.ToInt32(txt訂單編號.Text);
            paras.Add(new SqlParameter("K_出貨單編號", (object)pk));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("訂單完成");
            totalprice();
        }

        private void btn更新_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (!int.TryParse(cbox經銷商ID.Text, out a) && !string.IsNullOrEmpty(cbox經銷商ID.Text.Trim()))
            {
                MessageBox.Show("經銷商ID請輸入數字");
                return;
            }

            if (string.IsNullOrEmpty(cbox經銷商ID.Text) || date交貨日期.CustomFormat == " " || string.IsNullOrEmpty(txt聯絡電話.Text) || string.IsNullOrEmpty(txt聯絡人.Text))
            {
                MessageBox.Show("請確認資料完整性");
                return;
            }         
            if (cbox經銷商ID.Items.Count < Convert.ToInt32(cbox經銷商ID.Text) || Convert.ToInt32(cbox經銷商ID.Text) < 1)
            {
                MessageBox.Show("請確認經銷商ID是否存在");
                return;
            }
            string message = "                   確定更新訂單嗎?";
            string caption = " ";
            MessageBoxButtons btnIsOK = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, btnIsOK);
            if (result == DialogResult.No)
            {
                return;
            }
            string sql = "UPDATE 出貨單列表 SET ";
            sql += "經銷商ID=@K_經銷商ID,";
            sql += "聯絡人=@K_聯絡人,";
            sql += "聯絡電話=@K_聯絡電話,";
            sql += "交貨日期=@K_交貨日期,";
            sql += "地址=@K_地址,";
            sql += "訂單狀態=@K_訂單狀態,";
            sql += "備註=@K_備註,";
            sql += "訂單金額=" + Convert.ToDecimal(labtotaprice.Text);
            sql += " where 出貨單編號=@K_出貨單編號 ";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_經銷商ID", Convert.ToInt32(cbox經銷商ID.Text)));
            paras.Add(new SqlParameter("K_聯絡人", txt聯絡人.Text));
            paras.Add(new SqlParameter("K_聯絡電話", txt聯絡電話.Text));
            paras.Add(new SqlParameter("K_交貨日期", date交貨日期.Text));
            paras.Add(new SqlParameter("K_地址", txt地址.Text));
            paras.Add(new SqlParameter("K_訂單狀態", "接收"));
            paras.Add(new SqlParameter("K_備註", txt備註.Text));
            int pk = Convert.ToInt32(txt訂單編號.Text);
            paras.Add(new SqlParameter("K_出貨單編號", (object)pk));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);        
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("更新資料成功");
            totalprice();
        }
        private void btn取消_Click(object sender, EventArgs e)
        {
            string message = "                   確定取消訂單嗎?";
            string caption = " ";
            MessageBoxButtons btnIsOK = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, btnIsOK);
            if (result == DialogResult.No)
            {
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();
            if (txt訂單狀態.Text=="草稿")
            {
                string sql草稿L = "DELETE FROM 出貨單明細 WHERE 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text);                
                SqlCommand cmd草稿L = new SqlCommand(sql草稿L, con);               
                cmd草稿L.ExecuteNonQuery();
                
                string sql草稿 = "DELETE FROM 出貨單列表 WHERE 出貨單編號="+ Convert.ToInt32(txt訂單編號.Text);                            
                SqlCommand cmd草稿 = new SqlCommand(sql草稿,con);                         
                cmd草稿.ExecuteNonQuery();

                string sql庫存 = "update [dbo].[商品在庫數量] set [商品在庫數量].[商品數量]=[商品在庫數量].[商品數量]+b.[商品數量] "+
                    "from [dbo].[出貨單明細] b where [出貨單編號]= " +Convert.ToInt32(txt訂單編號.Text)+
                    " and [商品在庫數量].廠商ID=b.廠商ID and [商品在庫數量].商品類型ID=b.商品類型ID and [商品在庫數量].商品ID=b.商品ID";
                SqlCommand cmd庫存 = new SqlCommand(sql庫存, con);
                cmd庫存.ExecuteNonQuery();

                string sql明細庫存 = "delete 出貨單明細 where 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text);
                SqlCommand cmd明細庫存 = new SqlCommand(sql明細庫存, con);
                cmd明細庫存.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("草稿刪除");
                this.Close();
                totalprice();
                return;
            }
            string sql接收 = "UPDATE 出貨單列表 SET ";
            sql接收 += "訂單狀態='取消'";
            sql接收 += " where 出貨單編號= "+ Convert.ToInt32(txt訂單編號.Text);                          
            SqlCommand cmd接收 = new SqlCommand(sql接收,con);
            cmd接收.ExecuteNonQuery();

            string sql庫存2 = "update [dbo].[商品在庫數量] set [商品在庫數量].[商品數量]=[商品在庫數量].[商品數量]+b.[商品數量] " +
                    "from [dbo].[出貨單明細] b where [出貨單編號]= " + Convert.ToInt32(txt訂單編號.Text) +
                    " and [商品在庫數量].廠商ID=b.廠商ID and [商品在庫數量].商品類型ID=b.商品類型ID and [商品在庫數量].商品ID=b.商品ID";
            SqlCommand cmd庫存2 = new SqlCommand(sql庫存2, con);
            cmd庫存2.ExecuteNonQuery();

            string sql明細庫存2 = "delete 出貨單明細 where 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text);
            SqlCommand cmd明細庫存2 = new SqlCommand(sql明細庫存2, con);
            cmd明細庫存2.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("訂單取消");
            totalprice();
            this.Close();
        }
        private void btn加入明細_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (!int.TryParse(cbox廠商ID.Text, out a) && !string.IsNullOrEmpty(cbox廠商ID.Text.Trim()))
            {
                MessageBox.Show("廠商請輸入數字");
                return;
            }

            if (!int.TryParse(txt數量.Text, out a) && !string.IsNullOrEmpty(txt數量.Text.Trim()))
            {
                MessageBox.Show("數量請輸入數字");
                return;
            }

            if (!int.TryParse(cbox類型ID.Text, out a) && !string.IsNullOrEmpty(cbox類型ID.Text.Trim()))
            {
                MessageBox.Show("類型請輸入數字");
                return;
            }
            if (!int.TryParse(cbox商品ID.Text, out a) && !string.IsNullOrEmpty(cbox商品ID.Text.Trim()))
            {
                MessageBox.Show("編號請輸入數字");
                return;
            }

            if (string.IsNullOrEmpty(txt數量.Text.Trim())||Convert.ToInt32(txt數量.Text)<=0)
            { 
                MessageBox.Show("請輸選擇商品或數量");
                return;
            }
            if (string.IsNullOrEmpty(cbox廠商ID.Text.Trim())|| string.IsNullOrEmpty(cbox類型ID.Text.Trim()) || string.IsNullOrEmpty(cbox商品ID.Text.Trim()) || string.IsNullOrEmpty(cbox品名.Text.Trim()) )
            {
                MessageBox.Show("請輸選擇商品或數量");
                return;
            }

            if (Convert.ToInt32(txt庫存.Text) < Convert.ToInt32(txt數量.Text))
            {
                MessageBox.Show("下訂數量超過庫存");
                return;
            }
            string sql = "INSERT INTO 出貨單明細 (";
            sql += "出貨單編號,";
            sql += "廠商ID,";
            sql += "商品類型ID,";
            sql += "商品ID,";
            sql += "商品單價,";
            sql += "商品數量";
            sql += ") VALUES (";
            sql += Convert.ToInt32(txt訂單編號.Text) + ",";
            sql += Convert.ToInt32(cbox廠商ID.Text) + ",";
            sql += Convert.ToInt32(cbox類型ID.Text) + ",";
            sql += Convert.ToInt32(cbox商品ID.Text) + ",";
            sql += Convert.ToDecimal(txt單價.Text) + ",";
            sql += Convert.ToInt32(txt數量.Text) + ")";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            string sql庫存 = "update [dbo].[商品在庫數量] set [商品數量] = [商品數量]-" + Convert.ToInt32(txt數量.Text) +
              "where [廠商ID]= " + Convert.ToInt32(cbox廠商ID.Text) +
              "and [商品類型ID]=" + Convert.ToInt32(cbox類型ID.Text) +
              "and [商品ID]=" + Convert.ToInt32(cbox商品ID.Text);

            SqlCommand cmd庫存 = new SqlCommand(sql庫存, con);
            cmd庫存.ExecuteNonQuery();

            con.Close();
            redata();
            totalprice();
            re庫存();
        }

        private void btn清除產品資訊_Click(object sender, EventArgs e)
        {          
            cbox廠商ID.Text = null;
            cbox類型ID.Text = null;
            cbox商品ID.Text = null;
            cbox品名.Text = null;
            txt數量.Text = "0";
            txt單價.Text = null;
            txt庫存.Text = null;
        }

        private void cbox品名_MouseDown(object sender, MouseEventArgs e)
        {
            int a = 0;
            if (!int.TryParse(cbox廠商ID.Text, out a) &&!string.IsNullOrEmpty(cbox廠商ID.Text.Trim()))
            {
                MessageBox.Show("廠商請輸入數字");
                return;
            }
            if (!int.TryParse(cbox類型ID.Text, out a) && !string.IsNullOrEmpty(cbox類型ID.Text.Trim()))
            {
                MessageBox.Show("類型請輸入數字");
                return;
            }
            if (!int.TryParse(cbox商品ID.Text, out a) && !string.IsNullOrEmpty(cbox商品ID.Text.Trim()))
            {
                MessageBox.Show("編號請輸入數字");
                return;
            }
            SqlConnection con商品列表 = new SqlConnection();
            con商品列表.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con商品列表.Open();
            string sql商品列表 = "SELECT * FROM 商品列表 where 廠商ID>=0";
            if (!string.IsNullOrEmpty(cbox廠商ID.Text.Trim()))
                sql商品列表 += " and 廠商ID=" + Convert.ToInt32(cbox廠商ID.Text.Trim());
            if (!string.IsNullOrEmpty(cbox類型ID.Text.Trim()))
                sql商品列表 += " and 商品類型ID=" + Convert.ToInt32(cbox類型ID.Text.Trim());
            if (!string.IsNullOrEmpty(cbox商品ID.Text.Trim()))
                sql商品列表 += " and 商品ID=" + Convert.ToInt32(cbox商品ID.Text.Trim());

            SqlCommand cmd商品列表 = new SqlCommand(sql商品列表, con商品列表);
            cbox品名.Items.Clear();
            SqlDataReader reader商品列表 = cmd商品列表.ExecuteReader();
            while (reader商品列表.Read())
            {
                cbox品名.Items.Add(reader商品列表["商品名稱"]);
            }
            con商品列表.Close();
        }
        private void cbox品名_DropDownClosed(object sender, EventArgs e)
        {
            SqlConnection con商品列表 = new SqlConnection();
            con商品列表.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con商品列表.Open();
            string sql商品列表 = "SELECT * FROM 商品列表 where 商品名稱='" + cbox品名.Text + "'";

            SqlCommand cmd商品列表 = new SqlCommand(sql商品列表, con商品列表);
            SqlDataReader reader商品列表 = cmd商品列表.ExecuteReader();

            while (reader商品列表.Read())
            {
                cbox廠商ID.Text = reader商品列表["廠商ID"].ToString();
                cbox類型ID.Text = reader商品列表["商品類型ID"].ToString();
                cbox商品ID.Text = reader商品列表["商品ID"].ToString();
                txt單價.Text = reader商品列表["零售價"].ToString();
            }
            con商品列表.Close();
            re庫存();
        }
        private void re庫存()
        {
            if (cbox品名.Text == null)
                return;
            
            string sql庫存 = "SELECT * FROM 商品在庫數量  where 廠商ID=" + Convert.ToInt32(cbox廠商ID.Text) +
                     " and 商品類型ID=" + Convert.ToInt32(cbox類型ID.Text) + " and 商品ID=" + Convert.ToInt32(cbox商品ID.Text);
            SqlConnection con庫存 = new SqlConnection();
            con庫存.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con庫存.Open();

            SqlCommand cmd庫存 = new SqlCommand(sql庫存, con庫存);
            SqlDataReader reader庫存 = cmd庫存.ExecuteReader();

            while (reader庫存.Read())
            {
                txt庫存.Text = reader庫存["商品數量"].ToString();
            }
            con庫存.Close();
        }
        private void btn刪除品項_Click(object sender, EventArgs e)
        {            
            DataTable dt = dgv訂單明細.DataSource as DataTable;
            if (_position < 0)
                return;
            DataRow row = dt.Rows[_position];
            string sql = "WITH CTE AS (select top 1 *  from 出貨單明細 where  廠商ID=" + Convert.ToInt32(row["廠商ID"])+
                " and 商品類型ID="+Convert.ToInt32(row["商品類型ID"]) +" and 商品ID=" + Convert.ToInt32(row["商品ID"]) +
                " and 商品數量=" + Convert.ToInt32(row["商品數量"])+ " and 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text)+ ") DELETE FROM CTE";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            string sql庫存 = "update [dbo].[商品在庫數量] set [商品數量] = [商品數量]+" + Convert.ToInt32(row["商品數量"]) +
              "where [廠商ID]= " + Convert.ToInt32(row["廠商ID"]) +
              "and [商品類型ID]=" + Convert.ToInt32(row["商品類型ID"]) +
              "and [商品ID]=" + Convert.ToInt32(row["商品ID"]);
            SqlCommand cmd庫存 = new SqlCommand(sql庫存, con);
            cmd庫存.ExecuteNonQuery();
            con.Close();

            redata();
            totalprice();
        }

        private void dgv訂單明細_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv訂單明細.SelectedRows.Count > 0)
                _position = e.RowIndex;
        }
        private void Frm編輯訂單_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm查詢訂單 f = new Frm查詢訂單();
            f.redata();
        }
        private void btn關閉_Click(object sender, EventArgs e)
        {
            totalprice();
            this.Close();
        }
     
        private void Frm編輯訂單_SizeChanged(object sender, EventArgs e)
        {
            redgvstyle();
        }
    }
}
