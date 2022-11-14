using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;
//using 進銷存系統.DataSet普雷二電玩TableAdapters;

namespace 進銷存系統
{
    public partial class Frm商品類別列表維護 : Form
    {
        SqlFunProduct sqlProduct = null;

        public Frm商品類別列表維護()
        {
            InitializeComponent();

            sqlProduct = new SqlFunProduct();

            dv商品類型列表.RowHeadersVisible = false;
            dv商品類型列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv商品類型列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv商品類型列表.AllowUserToAddRows = false;
            dv商品類型列表.EnableHeadersVisualStyles = false;
            dv商品類型列表.ReadOnly = true;           
        }
        #region 事件

        private void Frm商品類別列表維護_Load(object sender, EventArgs e)
        {
            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            dv商品類型列表.ColumnHeaderMouseClick +=(object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(); };
            txtID.KeyPress += SqlFunBase.Text_KeyPress_INT;

            dv商品類型列表.DataSource = sqlProduct.Get商品類別列表();           
        }        

        private void dv商品類型列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dv商品類型列表.Rows.Count)
                return;

            DataGridViewRow row = dv商品類型列表.Rows[e.RowIndex];
            txtID.Text = row.Cells["商品類型ID"].Value.ToString();
            txtName.Text = row.Cells["商品類型名稱"].Value.ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv商品類型列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "商品類型ID = " + txtID.Text.Trim() + " OR 商品類型名稱 = '" + txtName.Text.Trim() + "'";
                if (dt.Select(sql).Length > 0)
                {
                    MessageBox.Show("已有重複商品類型ID或名稱");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);
            string Name = txtName.Text;

            if (sqlProduct.Insert商品類型(Id, Name) <= 0)
            {
                MessageBox.Show("新增失敗");
                return;
            }

            var find1 = SQLData.db.商品類型列表.FirstOrDefault(o => o.商品類型ID == Id);
            SQLData.db.Entry(find1).Reload();

            this.ReloadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv商品類型列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "商品類型ID = " + txtID.Text.Trim();
                if (dt.Select(sql).Length == 0)
                {
                    MessageBox.Show("無此商品類型ID");
                    return;
                }

                sql = "商品類型名稱 = '" + txtName.Text.Trim() + "'";
                if (dt.Select(sql).Length > 0)
                {
                    MessageBox.Show("已有同名商品類型名稱");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);
            string Name = txtName.Text;

            if (sqlProduct.Update商品類型(Id, Name) <= 0)
            {
                MessageBox.Show("修改失敗!");
                return;
            }            

            var find1 = SQLData.db.商品類型列表.FirstOrDefault(o => o.商品類型ID == Id);
            SQLData.db.Entry(find1).Reload();

            this.ReloadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            DataTable dt = dv商品類型列表.DataSource as DataTable;
            if (dt != null && dt.Rows.Count > 0)
            {
                string sql = "商品類型ID = " + txtID.Text.Trim();
                if (dt.Select(sql).Length == 0)
                {
                    MessageBox.Show("無此商品類型ID");
                    return;
                }
            }

            int Id = Convert.ToInt32(txtID.Text);

            if (SQLData.db.商品列表.Where(q => q.商品類型ID == Id).Count() > 0)
            {
                MessageBox.Show("商品列表有此商品類型目前無法刪除");
                return;
            }

            if (sqlProduct.Delete商品類型(Id) <= 0)
            {
                MessageBox.Show("刪除失敗!");
                return;
            }

            this.ReloadData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = dv商品類型列表.DataSource as DataTable;

            List<ReportDataSource> reportDatas = new List<ReportDataSource>()
            {
                new ReportDataSource("DS商品類型列表", dt)
            };

            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("LoginID", SQLData.LoginID)                
            };

            FrmReport report = new FrmReport("商品類別列表清單");
            report.LoadSources(RdlcData.商品類別列表清單Path, reportDatas, reportParameters);
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        #endregion

        #region 方法

        private void ResetGridStyle()
        {
            if (dv商品類型列表.DataSource == null || dv商品類型列表.Rows.Count == 0)
                return;

            dv商品類型列表.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10);
            dv商品類型列表.Columns["商品類型ID"].Width = 105;
            dv商品類型列表.Columns["商品類型名稱"].Width = dv商品類型列表.Width - 109;

            for (int i = 0; i < dv商品類型列表.Rows.Count; i++)
            {
                DataGridViewRow row = dv商品類型列表.Rows[i];

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
                MessageBox.Show("商品類型ID空白");
                txtID.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("商品類型名稱空白");
                txtName.Focus();
                return false;
            }
            return true;
        }

        private void ReloadData()
        {
            txtID.Clear();
            txtName.Clear();
            dv商品類型列表.DataSource = sqlProduct.Get商品類別列表();
            this.ResetGridStyle();
        }
        #endregion        
    }
}
