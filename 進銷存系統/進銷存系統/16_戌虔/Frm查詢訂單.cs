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

namespace 進銷存系統
{
    public partial class Frm查詢訂單 : Form
    {
        SqlCommandBuilder _builder = new SqlCommandBuilder();
        SqlDataAdapter _adapter = null;
        int _position = -1;
        public Frm查詢訂單()
        {
            InitializeComponent();
        }
        public void redgvstyle()
        {
            dgv出貨單列表.Columns[0].Width = this.Width * 2 / 30;
            dgv出貨單列表.Columns[1].Width = this.Width * 1 / 20;
            dgv出貨單列表.Columns[2].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[3].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[4].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[5].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[6].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[7].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[8].Width = this.Width * 1 / 10;
            dgv出貨單列表.Columns[9].Width = this.Width * 1 / 10;

            bool isChanged = false;
            foreach (DataGridViewRow r in dgv出貨單列表.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
                r.DefaultCellStyle.BackColor = Color.LightBlue;
                if (isChanged)
                    r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isChanged = !isChanged;
            }
        }
            private void btn查詢_Click(object sender, EventArgs e)
        {
            redata();
        }

        public void redata()
        {
            int a = 0;

            if (!int.TryParse(txt訂單編號.Text,out a)&& !string.IsNullOrEmpty(txt訂單編號.Text.Trim()))
            {
                MessageBox.Show("訂單編號請輸入數字");
                return;
            }
            if (!int.TryParse(cbox經銷商ID.Text, out a) && !string.IsNullOrEmpty(cbox經銷商ID.Text.Trim()))
            {
                MessageBox.Show("經銷商ID請輸入數字");
                return;
            }
            string sql = "select * from 出貨單列表 where 出貨單編號>=0";
            if (!string.IsNullOrEmpty(txt訂單編號.Text.Trim()))
                sql += " and 出貨單編號=" + Convert.ToInt32(txt訂單編號.Text.Trim());
            if (!string.IsNullOrEmpty(cbox經銷商ID.Text.Trim()))
                sql += "and 經銷商ID=" + Convert.ToInt32(cbox經銷商ID.Text.Trim());
            if (!string.IsNullOrEmpty(txt聯絡電話.Text.Trim()))
                sql += "and 聯絡電話='" + txt聯絡電話.Text.Trim() + "'";
            if (!string.IsNullOrEmpty(cbox訂單狀態.Text.Trim()))
                sql += "and 訂單狀態 ='" + cbox訂單狀態.Text.Trim() + "'";
            if (!string.IsNullOrEmpty(date訂單日期s.Text.Trim()))
                sql += "and convert (datetime,訂單日期) >= convert(datetime,'" + date訂單日期s.Text + "')";
            if (!string.IsNullOrEmpty(date訂單日期e.Text.Trim()))
                sql += "and convert (datetime,訂單日期) <= convert(datetime,'" + date訂單日期e.Text + "')";
            if (!string.IsNullOrEmpty(date交貨日期s.Text.Trim()))
                sql += "and convert (datetime,交貨日期) >= convert(datetime,'" + date交貨日期s.Text + "')";
            if (!string.IsNullOrEmpty(date交貨日期e.Text.Trim()))
                sql += "and convert (datetime,交貨日期) <=convert(datetime,'" + date交貨日期e.Text + "')";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder.DataAdapter = _adapter;

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();

            this.dgv出貨單列表.DataSource = ds.Tables[0];

            redgvstyle();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO 出貨單列表 (";
            sql += "訂單日期,";
            sql += "訂單狀態,";
            sql += "交貨日期";
            sql += ") VALUES (";
            sql += "@K_訂單日期,";
            sql += "@K_訂單狀態,";
            sql += "@K_交貨日期)";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("K_訂單日期", DateTime.Now.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("K_訂單狀態", "草稿"));
            paras.Add(new SqlParameter("K_交貨日期", DateTime.Now.ToString("yyyy-MM-dd")));

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source =.; Initial Catalog = 普雷二電玩; Integrated Security = True";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            cmd.ExecuteNonQuery();
            con.Close();

            Frm編輯訂單 f = new Frm編輯訂單();
            f.新增訂單();
            f.ShowDialog();
        }

        private void dgv訂單資訊_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv出貨單列表.SelectedRows.Count > 0)
                _position = e.RowIndex;
        }
        private void dgv訂單資訊_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dgv出貨單列表.DataSource as DataTable;
            if (_position < 0 || _position >= (dgv出貨單列表.RowCount-1))
                return;
            DataRow row = dt.Rows[_position];

          
            Frm編輯訂單 f = new Frm編輯訂單();
            if (row["訂單狀態"].ToString()=="完成"|| row["訂單狀態"].ToString() == "取消")
            {
                COrder or1 = new COrder();
                or1.訂單編號 = Convert.ToInt32(row["出貨單編號"]);
                or1.聯絡人 = row["聯絡人"].ToString();
                or1.聯絡電話 = row["聯絡電話"].ToString();
                or1.地址 = row["地址"].ToString();
                or1.備註 = row["備註"].ToString();
                if (row["經銷商ID"] != null)               
                    or1.經銷商ID = Convert.ToInt32(row["經銷商ID"]);
                or1.訂單日期 = row["訂單日期"].ToString();
                or1.交貨日期 = row["交貨日期"].ToString();
                or1.訂單狀態 = row["訂單狀態"].ToString();

                f.or = or1;
                f.完成或取消訂單();
                f.ShowDialog();
                return;
            }     
             else if (row["訂單狀態"].ToString() == "草稿")                    
            {
                COrder or2 = new COrder();
                or2.訂單編號 = Convert.ToInt32(row["出貨單編號"]);
                or2.聯絡人 = row["聯絡人"].ToString();
                or2.聯絡電話 = row["聯絡電話"].ToString();
                or2.地址 = row["地址"].ToString();
                or2.備註 = row["備註"].ToString();
                or2.訂單日期 = row["訂單日期"].ToString();
                or2.交貨日期 = row["交貨日期"].ToString();
                or2.訂單狀態 = row["訂單狀態"].ToString();
                f.or = or2;
                f.修改訂單();
                f.ShowDialog();
                return;
            }
            COrder or = new COrder();
            or.訂單編號 = Convert.ToInt32(row["出貨單編號"]);
            or.聯絡人 = row["聯絡人"].ToString();
            or.聯絡電話 = row["聯絡電話"].ToString();
            or.地址 = row["地址"].ToString();
            or.備註 = row["備註"].ToString();
            or.經銷商ID = Convert.ToInt32(row["經銷商ID"]);
            or.訂單日期 = row["訂單日期"].ToString();
            or.交貨日期 = row["交貨日期"].ToString();
            or.訂單狀態 = row["訂單狀態"].ToString();
            f.or = or;
            f.修改訂單();
            f.ShowDialog();
        }

        private void btn清空查詢條件_Click(object sender, EventArgs e)
        {
            cbox經銷商ID.Text = null;
            txt聯絡電話.Text = null;
            txt訂單編號.Text = null;
            cbox訂單狀態.Text = null;
            date訂單日期s.CustomFormat = " ";
            date訂單日期e.CustomFormat = " ";
            date交貨日期s.CustomFormat = " ";
            date交貨日期e.CustomFormat = " ";           
            date訂單日期e.MinDate=date訂單日期s.MinDate;
            date交貨日期e.MinDate = date交貨日期s.MinDate;
        }

        private void Frm查詢訂單_Load(object sender, EventArgs e)
        {       
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
        }
        private void date訂單日期s_CloseUp(object sender, EventArgs e)
        {
            date訂單日期s.CustomFormat = "yyyy-MM-dd";
            if (!string.IsNullOrEmpty(date訂單日期s.CustomFormat))
                date訂單日期e.MinDate = Convert.ToDateTime(date訂單日期s.Text);           
        }
        private void date訂單日期e_CloseUp(object sender, EventArgs e)
        {
            date訂單日期e.CustomFormat = "yyyy-MM-dd";
        }
        private void date交貨日期s_CloseUp(object sender, EventArgs e)
        {
            date交貨日期s.CustomFormat = "yyyy-MM-dd";
            if (!string.IsNullOrEmpty(date交貨日期s.CustomFormat))
                date交貨日期e.MinDate = Convert.ToDateTime(date交貨日期s.Text);
        }
        private void date交貨日期e_CloseUp(object sender, EventArgs e)
        {
            date交貨日期e.CustomFormat = "yyyy-MM-dd";
        }
        private void btn清除訂單日期_Click(object sender, EventArgs e)
        {
            date訂單日期s.CustomFormat = " ";
            date訂單日期e.CustomFormat = " ";          
            date訂單日期e.MinDate = date訂單日期s.MinDate;
        }
        private void btn清除交貨日期_Click(object sender, EventArgs e)
        {       
            date交貨日期s.CustomFormat = " ";
            date交貨日期e.CustomFormat = " ";
            date交貨日期e.MinDate = date交貨日期s.MinDate;
        }
        private void btn清除狀態_Click(object sender, EventArgs e)
        {
            cbox訂單狀態.Text = null;
        }
        private void btn清除訂單編號_Click(object sender, EventArgs e)
        {
            txt訂單編號.Text = null;    
        }
        private void btn清除經銷商_Click(object sender, EventArgs e)
        {
            cbox經銷商ID.Text = null;
        }
        private void btn清除電話_Click(object sender, EventArgs e)
        {
            txt聯絡電話.Text = null;
        }
        private void Frm查詢訂單_ResizeEnd(object sender, EventArgs e)
        {
            redata();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Close();
            }
            if (keyData == (Keys.Enter))
            {
                redata();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Frm查詢訂單_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
