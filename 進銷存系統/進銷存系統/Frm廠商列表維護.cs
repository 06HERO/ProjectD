using Microsoft.Reporting.WinForms;
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
using System.Windows.Forms.VisualStyles;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;
//using 進銷存系統.DataSet普雷二電玩TableAdapters;

namespace 進銷存系統
{
    public partial class Frm廠商列表維護 : Form
    {
        SqlFunProduct sqlProduct = null;

        public Frm廠商列表維護()
        {
            InitializeComponent();

            sqlProduct = new SqlFunProduct();

            dv廠商列表.RowHeadersVisible = false;
            dv廠商列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv廠商列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv廠商列表.AllowUserToAddRows = false;
            dv廠商列表.EnableHeadersVisualStyles = false;
            dv廠商列表.ReadOnly = true;
            dv廠商列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #region 事件

        private void 廠商列表維護_Load(object sender, EventArgs e)
        {
            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            dv廠商列表.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(); };

            txtID.KeyPress += SqlFunBase.Text_KeyPress_INT;
            txt統一編號.KeyPress += SqlFunBase.Text_KeyPress_INT;
            txt資本總額.KeyPress += SqlFunBase.Text_KeyPress_Decimal;
            txt聯絡電話.KeyPress += SqlFunBase.Text_KeyPress_INT;

            dv廠商列表.DataSource = sqlProduct.Get廠商列表();
        }        

        private void dv廠商列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dv廠商列表.Rows.Count)
                return;

            DataGridViewRow row = dv廠商列表.Rows[e.RowIndex];
            txtID.Text = row.Cells["廠商ID"].Value.ToString();
            txtName.Text = row.Cells["廠商名稱"].Value.ToString();
            txt統一編號.Text = row.Cells["統一編號"].Value.ToString();
            txt代表人姓名.Text = row.Cells["代表人姓名"].Value.ToString();
            txt資本總額.Text = row.Cells["資本總額"].Value.ToString();
            txt聯絡電話.Text = row.Cells["聯絡電話"].Value.ToString();

            string 顯示與否 = row.Cells["顯示與否"].Value.ToString();
            if(顯示與否.ToLower() == "y")
                chk顯示與否.Checked = true;
            else
                chk顯示與否.Checked = false;
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv廠商列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "廠商ID = " + txtID.Text.Trim() + " OR 廠商名稱 = '" + txtName.Text.Trim() + "'";
                if (dt.Select(sql).Length > 0)
                {
                    MessageBox.Show("已有重複廠商ID或名稱");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);
            string Name = txtName.Text.Trim();
            string 統一編號 = txt統一編號.Text.Trim();
            string 代表人姓名 = txt代表人姓名.Text.Trim();

            decimal 資本總額 = 0;
            if(string.IsNullOrWhiteSpace(txt資本總額.Text) == false )
                資本總額 = Convert.ToDecimal(txt資本總額.Text);

            string 聯絡電話 = txt聯絡電話.Text.Trim();

            string 顯示與否 = "y";
            if(chk顯示與否.Checked == false)
                顯示與否 = "n";

            if (sqlProduct.Insert廠商(Id, Name, 統一編號, 代表人姓名, 資本總額, 聯絡電話, 顯示與否) <= 0)
            {
                MessageBox.Show("新增失敗");
                return;
            }

            var find1 = SQLData.db.廠商列表.FirstOrDefault(o => o.廠商ID == Id);
            SQLData.db.Entry(find1).Reload();

            this.ReloadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv廠商列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "廠商ID = " + txtID.Text.Trim();
                if (dt.Select(sql).Length == 0)
                {
                    MessageBox.Show("無此廠商ID");
                    return;
                }

                sql = $"廠商名稱 = '{txtName.Text.Trim()}' AND 廠商ID <> {Convert.ToInt32(txtID.Text)}";
                if (dt.Select(sql).Length > 0)
                {
                    MessageBox.Show("已有同名廠商名稱");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);
            string Name = txtName.Text;

            string 統一編號 = txt統一編號.Text.Trim();
            string 代表人姓名 = txt代表人姓名.Text.Trim();

            decimal 資本總額 = 0;
            if (string.IsNullOrWhiteSpace(txt資本總額.Text) == false)
                資本總額 = Convert.ToDecimal(txt資本總額.Text);

            string 聯絡電話 = txt聯絡電話.Text.Trim();

            string 顯示與否 = "y";
            if (chk顯示與否.Checked == false)
                顯示與否 = "n";

            if (sqlProduct.Update廠商(Id, Name, 統一編號, 代表人姓名, 資本總額, 聯絡電話, 顯示與否) <= 0)
            {
                MessageBox.Show("修改失敗!");
                return;
            }

            var find1 = SQLData.db.廠商列表.FirstOrDefault(o => o.廠商ID == Id);
            SQLData.db.Entry(find1).Reload();

            this.ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv廠商列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "廠商ID = " + txtID.Text.Trim();
                if (dt.Select(sql).Length == 0)
                {
                    MessageBox.Show("無此廠商ID");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);

            if( SQLData.db.商品列表.Where( q => q.廠商ID == Id).Count() > 0)
            {
                MessageBox.Show("商品列表有此廠商目前無法刪除");
                return;
            }
            
            if (sqlProduct.Delete廠商(Id) <= 0)
            {
                MessageBox.Show("刪除失敗!");
                return;
            }            

            this.ReloadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = dv廠商列表.DataSource as DataTable;

            List<ReportDataSource> reportDatas = new List<ReportDataSource>()
            {
                new ReportDataSource("DS廠商列表", dt)
            };

            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("LoginID", SQLData.LoginID)                
            };

            FrmReport report = new FrmReport("廠商列表清單");
            report.LoadSources(RdlcData.廠商列表清單Path, reportDatas, reportParameters);
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }
        #endregion

        #region 方法

        private void ResetGridStyle()
        {
            if (dv廠商列表.DataSource == null || dv廠商列表.Rows.Count == 0)
                return;

            dv廠商列表.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12);
            //dv廠商列表.Columns["廠商ID"].Width = 90;
            //dv廠商列表.Columns["廠商ID"].SortMode = DataGridViewColumnSortMode.NotSortable; // 設定不要點選排序
            //dv廠商列表.Columns["廠商名稱"].Width = dv廠商列表.Width - 94;
            //dv廠商列表.Columns["廠商名稱"].SortMode = DataGridViewColumnSortMode.NotSortable; // 設定不要點選排序

            for (int i = 0; i < dv廠商列表.Rows.Count; i++)
            {
                DataGridViewRow row = dv廠商列表.Rows[i];

                row.DefaultCellStyle.Font = new Font("微軟正黑體", 12);

                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
            }
        }

        private bool CheckData()
        {
            if (true == string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("廠商ID空白");
                txtID.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("廠商名稱空白");
                txtName.Focus();
                return false;
            }            
            return true;
        }
        
        private void ReloadData()
        {
            txtID.Clear();
            txtName.Clear();
            dv廠商列表.DataSource = sqlProduct.Get廠商列表();
            this.ResetGridStyle();
        }
        #endregion
    }
}
