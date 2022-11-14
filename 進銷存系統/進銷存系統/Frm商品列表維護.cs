using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;

namespace 進銷存系統
{
    public partial class Frm商品列表維護 : Form
    {
        private SqlFunProduct sqlProduct = null;

        //private DataTable _dt商品列表 = null;

        private int _dtIndex = -1;

        public Frm商品列表維護()
        {
            InitializeComponent();

            sqlProduct = new SqlFunProduct();

            dv商品列表.RowHeadersVisible = false;
            dv商品列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv商品列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv商品列表.AllowUserToAddRows = false;
            dv商品列表.EnableHeadersVisualStyles = false;
            dv商品列表.ReadOnly = true;
            dv商品列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //DataTable dt廠商 = new 廠商列表TableAdapter().GetData();
            DataTable dt廠商 = SQLData.db.廠商列表.ToDataTable();
            DataRow row廠商 = dt廠商.NewRow();
            row廠商["廠商ID"] = 0;
            row廠商["廠商名稱"] = "全部";
            dt廠商.Rows.Add(row廠商);
            dt廠商.DefaultView.Sort = "廠商ID";
            cmb廠商.ValueMember = "廠商ID";
            cmb廠商.DisplayMember = "廠商名稱";
            cmb廠商.DataSource = dt廠商;
            cmb廠商.SelectedIndexChanged += (object s, EventArgs ev) => { this.Set_商品列表(); };

            //DataTable dt商品類別 = new 商品類型列表TableAdapter().GetData();
            DataTable dt商品類別 = SQLData.db.商品類型列表.ToDataTable();
            DataRow row類別 = dt商品類別.NewRow();
            row類別["商品類型ID"] = 0;
            row類別["商品類型名稱"] = "全部";
            dt商品類別.Rows.Add(row類別);
            dt商品類別.DefaultView.Sort = "商品類型ID";
            cmb商品類別.ValueMember = "商品類型ID";
            cmb商品類別.DisplayMember = "商品類型名稱";
            cmb商品類別.DataSource = dt商品類別;
            cmb商品類別.SelectedIndexChanged += (object s, EventArgs ev) => { this.Set_商品列表(); };
        }

        #region 事件

        private void Frm商品列表維護_Load(object sender, EventArgs e)
        {   
            if (SQLData.IsAdmin == (int)User_LV.User)
            {
                btnInsert.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }

            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            dv商品列表.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(); };
            dv商品列表.CellClick += (object s, DataGridViewCellEventArgs ev) => { _dtIndex = ev.RowIndex; };

            //_dt商品列表 = SQLData.db.商品列表.ToDataTable();
            this.Set_商品列表();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = dv商品列表.DataSource as DataTable;

            List<ReportDataSource> reportDatas = new List<ReportDataSource>()
            {
                new ReportDataSource("fn_商品列表", dt)
            };

            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("LoginID", SQLData.LoginID),
                new ReportParameter("IsAdmin", SQLData.IsAdmin.ToString())
            };

            FrmReport report = new FrmReport("商品列表清單");
            report.LoadSources(RdlcData.商品列表清單Path, reportDatas, reportParameters);
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm商品資料編輯 frm = new Frm商品資料編輯();
            frm.callback += CallInsert;
            frm.ShowDialog();
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ShowFrm商品資料編輯((int)Change_Mode.Update);
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.ShowFrm商品資料編輯((int)Change_Mode.Delete);
        }
        #endregion

        #region 方法
        private void ReloadData()
        {
            //_dt商品列表 = SQLData.db.商品列表.ToDataTable();
            this.Set_商品列表();
            this.ResetGridStyle();
        }

        private void ResetGridStyle()
        {
            if (dv商品列表.DataSource == null || dv商品列表.Rows.Count == 0 )
                return;

            dv商品列表.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10);
            
            for (int i = 0; i < dv商品列表.Rows.Count; i++)
            {
                DataGridViewRow row = dv商品列表.Rows[i];

                row.DefaultCellStyle.Font = new Font("微軟正黑體", 12);

                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void Set_商品列表()
        {
            int 廠商ID = Convert.ToInt32(cmb廠商.SelectedValue);
            int 商品類別ID = Convert.ToInt32(cmb商品類別.SelectedValue);

            //var q商品列表 = from 商品列表 in SQLData.db.fn_商品列表()
            //            select new
            //            {
            //                商品列表.廠商ID,
            //                商品列表.廠商名稱,
            //                商品列表.商品類型ID,
            //                商品列表.商品類型名稱,
            //                商品列表.商品ID,
            //                商品列表.商品名稱,
            //                商品列表.進貨價,
            //                商品列表.零售價
            //            };
            //var q商品列表 = SQLData.db.fn_商品列表().Select
            //                (
            //                    q => new
            //                    {
            //                        q.廠商ID,
            //                        q.廠商名稱,
            //                        q.商品類型ID,
            //                        q.商品類型名稱,
            //                        q.商品ID,
            //                        q.商品名稱,
            //                        q.進貨價,
            //                        q.零售價
            //                    }
            //                );
            var q商品列表 = SQLData.db.fn_商品列表();


            //if (廠商ID > 0)
            //{
            //    q商品列表 = from 商品列表 in q商品列表
            //                where 商品列表.廠商ID == 廠商ID
            //                select 商品列表;
            //}
            if (廠商ID > 0)
                q商品列表 = q商品列表.Where(q => q.廠商ID == 廠商ID);


            //if (商品類別ID > 0)
            //{
            //    q商品列表 = from 商品列表 in q商品列表
            //                where 商品列表.商品類型ID == 商品類別ID
            //                select 商品列表;
            //}
            if (商品類別ID > 0)
                q商品列表 = q商品列表.Where(q => q.商品類型ID == 商品類別ID);

            dv商品列表.DataSource = q商品列表.ToDataTable();

            if (SQLData.IsAdmin == (int)User_LV.User)
            {
                dv商品列表.Columns["廠商ID"].Visible = false;
                dv商品列表.Columns["商品類型ID"].Visible = false;
                dv商品列表.Columns["商品ID"].Visible = false;
            }

            this.ResetGridStyle();
        }

        private void ShowFrm商品資料編輯(int Mod)
        {
            if (_dtIndex < 0 || _dtIndex >= dv商品列表.Rows.Count)
                return;

            DataGridViewRow row = dv商品列表.Rows[_dtIndex];

            string 廠商 = row.Cells["廠商名稱"].Value.ToString().Trim();
            string 商品類型 = row.Cells["商品類型名稱"].Value.ToString().Trim();

            商品列表 data = new 商品列表();
            data.廠商ID =  Convert.ToByte(row.Cells["廠商ID"].Value);
            data.商品類型ID = Convert.ToByte(row.Cells["商品類型ID"].Value);
            data.商品ID = Convert.ToInt16(row.Cells["商品ID"].Value);
            data.商品名稱 = row.Cells["商品名稱"].Value.ToString().Trim();
            data.進貨價 = Convert.ToDecimal(row.Cells["進貨價"].Value);
            data.零售價 = Convert.ToDecimal(row.Cells["零售價"].Value);

            Frm商品資料編輯 frm = new Frm商品資料編輯(廠商, 商品類型, data, Mod);

            if (Mod == (int)Change_Mode.Update)
                frm.callback += CallUpdate;
            else if (Mod == (int)Change_Mode.Delete)
                frm.callback += CallDelete;

            frm.ShowDialog();
        }

        private void CallInsert(商品列表 data)
        {
            if (sqlProduct.Insert商品列表(data) <= 0)
            {
                MessageBox.Show("新增失敗");
                return;
            }

            var find1 = SQLData.db.商品列表.FirstOrDefault(o => o.廠商ID == data.廠商ID &&
                                                                o.商品類型ID ==  data.商品類型ID &&
                                                                o.商品ID == data.商品ID);
            SQLData.db.Entry(find1).Reload();
            this.ReloadData();
        }

        private void CallUpdate(商品列表 data)
        {
            if (sqlProduct.Update商品列表(data) <= 0)
            {
                MessageBox.Show("修改失敗");
                return;
            }

            var find1 = SQLData.db.商品列表.FirstOrDefault(o => o.廠商ID == data.廠商ID &&
                                                                o.商品類型ID ==  data.商品類型ID &&
                                                                o.商品ID == data.商品ID);
            SQLData.db.Entry(find1).Reload();
            this.ReloadData();
        }

        private void CallDelete(商品列表 data)
        {
            if (sqlProduct.Delete商品列表(data) <= 0)
            {
                MessageBox.Show("刪除失敗");
                return;
            }
            this.ReloadData();
        }
        #endregion        
    }
}
