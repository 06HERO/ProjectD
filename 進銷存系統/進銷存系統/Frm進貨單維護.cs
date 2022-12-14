using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;
using static System.Windows.Forms.AxHost;

namespace 進銷存系統
{
    public partial class Frm進貨單維護 : Form
    {
        private SqlFunProduct sqlProduct = null;

        private int _dt列表Index = -1;
        private int _dt明細Index = -1;
        private DateTime _dtDateStart = new DateTime(1, 1, 1);
        private DateTime _dtDateEnd = new DateTime(1, 1, 1);
        int _進貨單編號 = -1;

        public Frm進貨單維護()
        {
            InitializeComponent();

            sqlProduct = new SqlFunProduct();

            dv進貨單列表.RowHeadersVisible = false;
            dv進貨單列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv進貨單列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv進貨單列表.AllowUserToAddRows = false;
            dv進貨單列表.EnableHeadersVisualStyles = false;
            dv進貨單列表.ReadOnly = true;
            dv進貨單列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dv進貨單明細.RowHeadersVisible = false;
            dv進貨單明細.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv進貨單明細.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv進貨單明細.AllowUserToAddRows = false;
            dv進貨單明細.EnableHeadersVisualStyles = false;
            dv進貨單明細.ReadOnly = true;
            dv進貨單明細.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DataTable dt廠商 = SQLData.db.廠商列表.ToDataTable();
            DataRow row廠商 = dt廠商.NewRow();
            row廠商["廠商ID"] = 0;
            row廠商["廠商名稱"] = "全部";
            dt廠商.Rows.Add(row廠商);
            dt廠商.DefaultView.Sort = "廠商ID";
            cmb廠商.ValueMember = "廠商ID";
            cmb廠商.DisplayMember = "廠商名稱";
            cmb廠商.DataSource = dt廠商;

            DataTable dt庫存地點 = SQLData.db.庫存地點列表.ToDataTable();
            DataRow row地點 = dt庫存地點.NewRow();
            row地點["庫存地點ID"] = 0;
            row地點["庫存地點"] = "全部";
            dt庫存地點.Rows.Add(row地點);
            dt庫存地點.DefaultView.Sort = "庫存地點ID";
            cmb庫存地點.ValueMember = "庫存地點ID";
            cmb庫存地點.DisplayMember = "庫存地點";
            cmb庫存地點.DataSource = dt庫存地點;

            DataTable dt商品類別 = SQLData.db.商品類型列表.ToDataTable();
            DataRow row類別 = dt商品類別.NewRow();
            row類別["商品類型ID"] = 0;
            row類別["商品類型名稱"] = "全部";
            dt商品類別.Rows.Add(row類別);
            dt商品類別.DefaultView.Sort = "商品類型ID";
            cmb商品類別.ValueMember = "商品類型ID";
            cmb商品類別.DisplayMember = "商品類型名稱";
            cmb商品類別.DataSource = dt商品類別;
            cmb商品類別.Enabled = false;
            cmb商品類別.SelectedIndexChanged += (object s, EventArgs ev) => { this.Set_進貨單明細(); };
        }

        #region 事件

        private void Frm進貨單維護_Load(object sender, EventArgs e)
        {
            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };

            dv進貨單列表.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(dv進貨單列表); };
            dv進貨單明細.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(dv進貨單明細); };
            dv進貨單明細.CellClick += (object s, DataGridViewCellEventArgs ev) => { _dt明細Index = ev.RowIndex; };

            txt進貨單編號.KeyPress += SqlFunBase.Text_KeyPress_INT;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dv進貨單列表.DataSource = null;
            dv進貨單明細.DataSource = null;

            if (false == string.IsNullOrWhiteSpace(txt進貨單編號.Text))
            {
                int 編號 = Convert.ToInt32(txt進貨單編號.Text);
                if (false == SQLData.db.進貨單列表.Any(a => a.進貨單編號 == 編號))
                {
                    MessageBox.Show("無此進貨單編號資料!");
                    txt進貨單編號.Focus();
                    return;
                }
            }

            if (mskDtStart.Text != "    /  /" || mskDtEnd.Text != "    /  /")
            {
                if (!DateTime.TryParse(mskDtStart.Text, out _dtDateStart))
                {
                    MessageBox.Show("不是正確的日期格式型別！");
                    mskDtStart.Focus();
                    return;
                }

                if (!DateTime.TryParse(mskDtEnd.Text, out _dtDateEnd))
                {
                    MessageBox.Show("不是正確的日期格式型別！");
                    mskDtEnd.Focus();
                    return;
                }
            }

            this.Set_進貨單列表();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _dt列表Index = -1;
            _dt明細Index = -1;
            _dtDateStart = new DateTime(1, 1, 1);
            _dtDateEnd = new DateTime(1, 1, 1);
            _進貨單編號 = -1;

            txt進貨單編號.Clear();
            cmb廠商.SelectedIndex = 0;
            cmb庫存地點.SelectedIndex = 0;
            mskDtStart.Clear();
            mskDtEnd.Clear();

            dv進貨單列表.DataSource = null;
            dv進貨單明細.DataSource = null;
            cmb商品類別.Enabled = false;
        }

        private void dv進貨單列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_dt列表Index != e.RowIndex)
                cmb商品類別.SelectedIndex = 0;

            _dt列表Index = e.RowIndex;
            if (_dt列表Index < 0 || _dt列表Index >= dv進貨單列表.Rows.Count)
                return;

            DataGridViewRow row = dv進貨單列表.Rows[e.RowIndex];
            if (row == null)
                return;

            _進貨單編號 = Convert.ToInt32(row.Cells["進貨單編號"].Value);

            cmb商品類別.Enabled = false;
            if (SQLData.db.fn_進貨單明細().Any(a => a.進貨單編號 == _進貨單編號))
                cmb商品類別.Enabled = true;

            this.Set_進貨單明細();
        }

        private void txtKeyWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtKeyWord.Text) == false)
                    this.ResetGridStyle(dv進貨單明細, txtKeyWord.Text.Trim());
            }
        }

        private void btnInsert列表_Click(object sender, EventArgs e)
        {
            Frm進貨單編輯 frm = new Frm進貨單編輯();
            frm.callback列表 += CallInsert進貨單列表;
            frm.ShowDialog();
        }

        private void btnUpdate列表_Click(object sender, EventArgs e)
        {
            this.ShowFrm進貨單列表((int)Change_Mode.Update);
        }

        private void btnDelete列表_Click(object sender, EventArgs e)
        {
            if (SQLData.db.fn_進貨單明細().Any(a => a.進貨單編號 == _進貨單編號))
            {
                MessageBox.Show("請先刪除相關進貨單明細後再刪除列表");
                return;
            }
            this.ShowFrm進貨單列表((int)Change_Mode.Delete);
        }

        private void btnInsert明細_Click(object sender, EventArgs e)
        {
            if (_dt列表Index < 0 || _dt列表Index >= dv進貨單列表.Rows.Count)
                return;
            DataGridViewRow row = dv進貨單列表.Rows[_dt列表Index];

            fn_進貨單列表_Result data = new fn_進貨單列表_Result()
            {
                進貨單編號 = Convert.ToInt32(row.Cells["進貨單編號"].Value),
                廠商ID = Convert.ToByte(row.Cells["廠商ID"].Value),
                廠商名稱 = row.Cells["廠商名稱"].Value.ToString(),
                庫存地點  = row.Cells["庫存地點"].Value.ToString(),
                進貨日期 = Convert.ToDateTime(row.Cells["進貨日期"].Value),
                明細筆數 = Convert.ToByte(row.Cells["明細筆數"].Value)
            };

            Frm進貨單編輯 frm = new Frm進貨單編輯(data);
            frm.callback明細 += CallInsert進貨單明細;
            frm.ShowDialog();
        }

        private void btnUpdate明細_Click(object sender, EventArgs e)
        {
            this.ShowFrm進貨單明細((int)Change_Mode.Update);
        }

        private void btnDelete明細_Click(object sender, EventArgs e)
        {
            this.ShowFrm進貨單明細((int)Change_Mode.Delete);
        }
        #endregion

        #region 方法

        private void ShowFrm進貨單列表(int Mod)
        {
            if (_dt列表Index < 0 || _dt列表Index >= dv進貨單列表.Rows.Count)
                return;

            DataGridViewRow row = dv進貨單列表.Rows[_dt列表Index];

            string 廠商 = row.Cells["廠商名稱"].Value.ToString().Trim();

            進貨單列表 data = new 進貨單列表();
            data.進貨單編號 =  Convert.ToInt32(row.Cells["進貨單編號"].Value);
            data.庫存地點ID = Convert.ToInt32(row.Cells["庫存地點ID"].Value);
            data.進貨日期 = Convert.ToDateTime(row.Cells["進貨日期"].Value);
            data.明細筆數 = Convert.ToByte(row.Cells["明細筆數"].Value);

            Frm進貨單編輯 frm = new Frm進貨單編輯(廠商, data, Mod);

            if (Mod == (int)Change_Mode.Update)
                frm.callback列表 += CallUpdate進貨單列表;
            else if (Mod == (int)Change_Mode.Delete)
                frm.callback列表 += CallDelete進貨單列表;

            frm.ShowDialog();
        }

        private void ShowFrm進貨單明細(int Mod)
        {
            if (_dt列表Index < 0 || _dt列表Index >= dv進貨單列表.Rows.Count)
                return;
            DataGridViewRow row = dv進貨單列表.Rows[_dt列表Index];

            fn_進貨單列表_Result data列表 = new fn_進貨單列表_Result()
            {
                進貨單編號 = Convert.ToInt32(row.Cells["進貨單編號"].Value),
                廠商ID = Convert.ToByte(row.Cells["廠商ID"].Value),
                廠商名稱 = row.Cells["廠商名稱"].Value.ToString(),
                庫存地點  = row.Cells["庫存地點"].Value.ToString(),
                進貨日期 = Convert.ToDateTime(row.Cells["進貨日期"].Value),
                明細筆數 = Convert.ToByte(row.Cells["明細筆數"].Value)
            };

            if (_dt明細Index < 0 || _dt明細Index >= dv進貨單明細.Rows.Count)
                return;
            row = dv進貨單明細.Rows[_dt明細Index];

            string 商品類型名稱 = row.Cells["商品類型名稱"].Value.ToString().Trim();
            string 商品名稱 = row.Cells["商品名稱"].Value.ToString().Trim();

            進貨單明細 data明細 = new 進貨單明細();
            data明細.進貨單編號 =  Convert.ToInt32(row.Cells["進貨單編號"].Value);
            data明細.商品類型ID = Convert.ToByte(row.Cells["商品類型ID"].Value);
            data明細.商品ID = Convert.ToInt16(row.Cells["商品ID"].Value);
            data明細.商品數量 = Convert.ToInt16(row.Cells["商品數量"].Value);

            if(row.Cells["進貨成本"].Value != DBNull.Value)
                data明細.進貨成本 = Convert.ToDecimal(row.Cells["進貨成本"].Value);
            else
                data明細.進貨成本 = 0;

            data明細.備註 = row.Cells["備註"].Value.ToString().Trim();


            Frm進貨單編輯 frm = new Frm進貨單編輯(data列表, data明細, 商品類型名稱, 商品名稱, Mod);

            if (Mod == (int)Change_Mode.Update)
                frm.callback明細 += CallUpdate進貨單明細;
            else if (Mod == (int)Change_Mode.Delete)
                frm.callback明細 += CallDelete進貨單明細;

            frm.ShowDialog();
        }

        private void ReloadData()
        {
            this.Set_進貨單列表();
            this.ResetGridStyle(dv進貨單列表);

            this.Set_進貨單明細();
            this.ResetGridStyle(dv進貨單明細);
        }

        private void ResetGridStyle()
        {
            this.ResetGridStyle(dv進貨單列表);
            this.ResetGridStyle(dv進貨單明細);
        }

        private void ResetGridStyle(DataGridView DV, string KeyWord = null)
        {
            if (DV.DataSource == null || DV.Rows.Count == 0)
                return;

            DV.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10);

            for (int i = 0; i < DV.Rows.Count; i++)
            {
                DataGridViewRow row = DV.Rows[i];

                row.DefaultCellStyle.Font = new Font("微軟正黑體", 12);

                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;

                if (DV.Name == "dv進貨單明細")
                {
                    if (KeyWord == null)
                        continue;

                    DataGridViewCell cell = row.Cells["商品名稱"];
                    if (cell.Value.ToString().ToLower().Contains(KeyWord.Trim().ToLower()) == true)
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    int 進貨單編號 = Convert.ToInt32(row.Cells["進貨單編號"].Value);
                    int 明細筆數 = Convert.ToInt32(row.Cells["明細筆數"].Value);

                    if(明細筆數 !=  SQLData.db.進貨單明細.Count( c => c.進貨單編號 == 進貨單編號))
                    {
                        DataGridViewCell cell = row.Cells["明細筆數"];
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.Yellow;
                    }
                }
            }
        }

        private void Set_進貨單列表()
        {
            int 編號 = 0;
            int 廠商ID = Convert.ToInt32(cmb廠商.SelectedValue);
            int 庫存ID = Convert.ToInt32(cmb庫存地點.SelectedValue);

            if (false == string.IsNullOrWhiteSpace(txt進貨單編號.Text))
                編號 = Convert.ToInt32(txt進貨單編號.Text);

            var q進貨單列表 = SQLData.db.fn_進貨單列表();

            if (編號 > 0)
                q進貨單列表 = q進貨單列表.Where(q => q.進貨單編號 == 編號);

            if (廠商ID > 0)
                q進貨單列表 = q進貨單列表.Where(q => q.廠商ID == 廠商ID);

            if (庫存ID > 0)
                q進貨單列表 = q進貨單列表.Where(q => q.庫存地點ID == 庫存ID);

            if (_dtDateStart.Year > 1 &&  _dtDateEnd.Year > 1)
                q進貨單列表 = q進貨單列表.Where(q => q.進貨日期 >= _dtDateStart &&  q.進貨日期 <= _dtDateEnd);

            dv進貨單列表.DataSource = q進貨單列表.ToDataTable();

            if (SQLData.IsAdmin == (int)User_LV.User)
            {
                dv進貨單列表.Columns["廠商ID"].Visible = false;
                dv進貨單列表.Columns["庫存地點ID"].Visible = false;
            }

            this.ResetGridStyle(dv進貨單列表);
        }

        private void Set_進貨單明細()
        {
            int 商品類別ID = Convert.ToInt32(cmb商品類別.SelectedValue);

            var q進貨單明細 = SQLData.db.fn_進貨單明細();

            if (_進貨單編號 > 0)
                q進貨單明細 = q進貨單明細.Where(q => q.進貨單編號 == _進貨單編號);

            if (商品類別ID > 0)
                q進貨單明細 = q進貨單明細.Where(q => q.商品類型ID == 商品類別ID);

            dv進貨單明細.DataSource = q進貨單明細.ToDataTable();            

            if (SQLData.IsAdmin == (int)User_LV.User)
            {
                dv進貨單明細.Columns["商品類型ID"].Visible = false;
                dv進貨單明細.Columns["商品ID"].Visible = false;
            }

            this.ResetGridStyle(dv進貨單明細);

            _dt明細Index = 0;
        }

        private void CallInsert進貨單列表(進貨單列表 data)
        {
            if (sqlProduct.Insert進貨單列表(data) <= 0)
            {
                MessageBox.Show("新增失敗");
                return;
            }

            var find1 = SQLData.db.進貨單列表.FirstOrDefault(o => o.進貨單編號 == data.進貨單編號);
            SQLData.db.Entry(find1).Reload();
            this.ReloadData();
        }

        private void CallUpdate進貨單列表(進貨單列表 data)
        {
            using (DbContextTransaction transaction = SQLData.db.Database.BeginTransaction())
            {
                try
                {
                    DataTable table = SQLData.db.進貨單明細.Where(w => w.進貨單編號 == data.進貨單編號).ToDataTable();
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            進貨單明細 InData = new 進貨單明細();
                            InData.進貨單編號 = Convert.ToInt32(row["進貨單編號"].ToString());
                            InData.商品類型ID = Convert.ToByte(row["商品類型ID"].ToString());
                            InData.商品ID = Convert.ToInt16(row["商品ID"].ToString());
                            InData.商品數量 = Convert.ToInt16(row["商品數量"].ToString());
                            InData.進貨成本 = Convert.ToDecimal(row["進貨成本"].ToString());
                            InData.備註 = row["商品類型ID"].ToString();
                            sqlProduct.Delete進貨單明細(InData.進貨單編號, InData.商品類型ID, InData.商品ID);
                        }
                    }

                    if (sqlProduct.Update進貨單列表(data) <= 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show("修改失敗");
                        return;
                    }

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            進貨單明細 InData = new 進貨單明細();
                            InData.進貨單編號 = Convert.ToInt32(row["進貨單編號"].ToString());
                            InData.商品類型ID = Convert.ToByte(row["商品類型ID"].ToString());
                            InData.商品ID = Convert.ToInt16(row["商品ID"].ToString());
                            InData.商品數量 = Convert.ToInt16(row["商品數量"].ToString());
                            InData.進貨成本 = Convert.ToDecimal(row["進貨成本"].ToString());
                            InData.備註 = row["商品類型ID"].ToString();
                            sqlProduct.Insert進貨單明細(InData);
                        }
                    }

                    transaction.Commit();

                    var find1 = SQLData.db.進貨單列表.FirstOrDefault(o => o.進貨單編號 == data.進貨單編號);
                    SQLData.db.Entry(find1).Reload();
                    this.ReloadData();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }                      
        }

        private void CallDelete進貨單列表(進貨單列表 data)
        {
            if (sqlProduct.Delete進貨單列表(data.進貨單編號) <= 0)
            {
                MessageBox.Show("刪除失敗");
                return;
            }
            this.ReloadData();
        }

        private void CallInsert進貨單明細(進貨單明細 data)
        {
            if (sqlProduct.Insert進貨單明細(data) <= 0)
            {
                MessageBox.Show("新增失敗");
                return;
            }

            var find1 = SQLData.db.進貨單明細.FirstOrDefault(o => o.進貨單編號 == data.進貨單編號 &&
                                                                  o.商品類型ID == data.商品類型ID &&
                                                                  o.商品ID == data.商品ID);
            SQLData.db.Entry(find1).Reload();
            this.ReloadData();
        }

        private void CallUpdate進貨單明細(進貨單明細 data)
        {
            if (sqlProduct.Update進貨單明細(data) <= 0)
            {
                MessageBox.Show("修改失敗");
                return;
            }

            var find1 = SQLData.db.進貨單明細.FirstOrDefault(o => o.進貨單編號 == data.進貨單編號 &&
                                                                  o.商品類型ID == data.商品類型ID &&
                                                                  o.商品ID == data.商品ID);
            SQLData.db.Entry(find1).Reload();
            this.ReloadData();
        }

        private void CallDelete進貨單明細(進貨單明細 data)
        {
            if (sqlProduct.Delete進貨單明細(data.進貨單編號, data.商品類型ID, data.商品ID) <= 0)
            {
                MessageBox.Show("刪除失敗");
                return;
            }
            this.ReloadData();
        }
        #endregion
    }
}
