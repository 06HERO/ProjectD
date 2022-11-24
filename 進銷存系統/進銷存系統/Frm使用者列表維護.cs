using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;

namespace 進銷存系統
{
    public partial class Frm使用者列表維護 : Form
    {
        SqlFunUser _sqlFunUser = null;

        private int _dtIndex = -1;

        public Frm使用者列表維護()
        {
            InitializeComponent();

            _sqlFunUser = new SqlFunUser();

            dv使用者列表.RowHeadersVisible = false;
            dv使用者列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv使用者列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv使用者列表.AllowUserToAddRows = false;
            dv使用者列表.EnableHeadersVisualStyles = false;
            dv使用者列表.ReadOnly = true;
            dv使用者列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmb管理權限.Items.Add("無");
            cmb管理權限.Items.Add("有");
            cmb管理權限.SelectedIndex = 0;
        }

        #region 事件

        private void Frm使用者編輯維護_Load(object sender, EventArgs e)
        {
            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            dv使用者列表.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(); };
            dv使用者列表.CellClick += (object s, DataGridViewCellEventArgs ev) => { _dtIndex = ev.RowIndex; };

            dv使用者列表.DataSource = SQLData.db.fn_使用者列表().ToDataTable();
        }

        private void dv使用者列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dv使用者列表.Rows.Count)
                return;

            DataGridViewRow row = dv使用者列表.Rows[e.RowIndex];

            txtID.Text = row.Cells["使用者ID"].Value.ToString();
            txtPW.Text = row.Cells["密碼"].Value.ToString();
            txtEMail.Text = row.Cells["Email"].Value.ToString();
            cmb管理權限.SelectedIndex =  Convert.ToInt32(row.Cells["IsAdmin"].Value);
            chk已驗證.Checked = Convert.ToBoolean(row.Cells["IsCheck"].Value);
        }        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Frm使用者編輯 frm = new Frm使用者編輯();
            frm.callback += CallInsert;
            frm.ShowDialog();           
        }

        private void ShowFrm使用者資料編輯(int Mod)
        {
            if (_dtIndex < 0 || _dtIndex >= dv使用者列表.Rows.Count)
                return;

            DataGridViewRow row = dv使用者列表.Rows[_dtIndex];

            使用者列表 user = new 使用者列表();

            user.LoginID = row.Cells["使用者ID"].Value.ToString();
            user.LoginPW = row.Cells["密碼"].Value.ToString();
            user.Email = row.Cells["Email"].Value.ToString();
            user.IsAdmin =  Convert.ToInt16(row.Cells["IsAdmin"].Value);
            user.IsCheck = Convert.ToByte(row.Cells["IsCheck"].Value);

            Frm使用者編輯 frm = new Frm使用者編輯(user, Mod);

            if (Mod == (int)Change_Mode.Update)
                frm.callback += CallUpdate;
            else if (Mod == (int)Change_Mode.Delete)
                frm.callback += CallDelete;

            frm.ShowDialog();           
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ShowFrm使用者資料編輯((int)Change_Mode.Update);            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.ShowFrm使用者資料編輯((int)Change_Mode.Delete);           
        }

        #endregion

        #region 方法
        private void ResetGridStyle()
        {
            if (dv使用者列表.DataSource == null || dv使用者列表.Rows.Count == 0)
                return;

            dv使用者列表.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 12);
            

            for (int i = 0; i < dv使用者列表.Rows.Count; i++)
            {
                DataGridViewRow row = dv使用者列表.Rows[i];

                row.DefaultCellStyle.Font = new Font("微軟正黑體", 12);

                if (i % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.White;
                else
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;

                dv使用者列表.Columns["IsAdmin"].Visible = false;
                dv使用者列表.Columns["IsCheck"].Visible = false;
            }
        }

        private void ReloadData()
        {
            dv使用者列表.DataSource = SQLData.db.fn_使用者列表().ToDataTable();
            this.ResetGridStyle();

            txtID.Text = string.Empty;
            txtPW.Text = string.Empty;
            txtEMail.Text = string.Empty;
            cmb管理權限.SelectedIndex = 0;
            chk已驗證.Checked = false;
        }

        private bool CheckData()
        {
            if (true == string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("使用者ID空白");
                txtID.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txtEMail.Text))
            {
                MessageBox.Show("Email信箱空白");
                txtEMail.Focus();
                return false;
            }
            return true;
        }

        private void CallInsert(使用者列表 user)
        {
            if (_sqlFunUser.Insert使用者列表(user) <= 0)
            {
                MessageBox.Show("新增失敗!");
                return;
            }
            this.ReloadData();            
        }

        private void CallUpdate(使用者列表 user)
        {
            if (_sqlFunUser.Update使用者列表(user) <= 0)
            {
                MessageBox.Show("修改失敗!");
                return;
            }
            this.ReloadData();
        }

        private void CallDelete(使用者列表 user)
        {
            if (_sqlFunUser.Delete使用者列表(user.LoginID) <= 0)
            {
                MessageBox.Show("刪除失敗!");
                return;
            }
            this.ReloadData();
        }
        #endregion        
    }
}
