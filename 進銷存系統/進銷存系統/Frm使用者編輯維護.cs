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

namespace 進銷存系統
{
    public partial class Frm使用者編輯維護 : Form
    {
        public Frm使用者編輯維護()
        {
            InitializeComponent();

            dv使用者列表.RowHeadersVisible = false;
            dv使用者列表.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dv使用者列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dv使用者列表.AllowUserToAddRows = false;
            dv使用者列表.EnableHeadersVisualStyles = false;
            dv使用者列表.ReadOnly = true;
            dv使用者列表.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cmb管理權限.Items.Add("無");
            cmb管理權限.Items.Add("有");
        }

        private void Frm使用者編輯維護_Load(object sender, EventArgs e)
        {
            this.Activated += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            this.Resize += (object s, EventArgs ev) => { this.ResetGridStyle(); };
            dv使用者列表.ColumnHeaderMouseClick += (object s, DataGridViewCellMouseEventArgs ev) => { this.ResetGridStyle(); };

            dv使用者列表.DataSource = SQLData.db.fn_使用者列表().ToDataTable();
        }


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

        private void dv使用者列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.RowIndex >= dv使用者列表.Rows.Count)
                return;

            DataGridViewRow row = dv使用者列表.Rows[e.RowIndex];

            txtID.Text = row.Cells["使用者ID"].Value.ToString();
            txtPW.Text = row.Cells["密碼"].Value.ToString();
            txtEMail.Text = row.Cells["Email"].Value.ToString();
            cmb管理權限.SelectedIndex =  Convert.ToInt32(row.Cells["IsAdmin"].Value);
            chk已驗證.Checked = Convert.ToBoolean(row.Cells["IsCheck"].Value);
        }
    }
}
