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

namespace 進銷存系統
{
    public delegate void CallBack進貨單編輯(進貨單列表 data);

    public partial class Frm進貨單編輯 : Form
    {
        public event CallBack進貨單編輯 callback = null;

        private int _Mode = (int)Change_Mode.None;        
        private byte _廠商ID = 0;
        private int _庫存地點ID = 0;
        private 進貨單列表 _進貨單列表data = null;
        private DateTime _dt進貨日期 = DateTime.Now;


        public Frm進貨單編輯()
        {
            InitializeComponent();

            lbl標題.Text = "進貨單新增";

            DataTable dt廠商 = SQLData.db.廠商列表.ToDataTable();            
            cmb廠商.ValueMember = "廠商ID";
            cmb廠商.DisplayMember = "廠商名稱";
            cmb廠商.DataSource = dt廠商;

            DataTable dt庫存地點 = SQLData.db.庫存地點列表.ToDataTable();            
            cmb庫存地點.ValueMember = "庫存地點ID";
            cmb庫存地點.DisplayMember = "庫存地點";
            cmb庫存地點.DataSource = dt庫存地點;

            msk進貨日期.Text = _dt進貨日期.ToString("yyyy/MM/dd");

            _Mode = (int)Change_Mode.Insert;
        }

        #region 事件

        private void Frm進貨單編輯_Load(object sender, EventArgs e)
        {
            txt進貨單編號.KeyPress += SqlFunBase.Text_KeyPress_INT;
            txt明細筆數.KeyPress += SqlFunBase.Text_KeyPress_INT;
            txt進貨成本.KeyPress += SqlFunBase.Text_KeyPress_Decimal;

            cmb廠商.SelectedIndexChanged += (object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
            cmb庫存地點.SelectedIndexChanged +=(object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
            this.Cmb_SelectedIndexChanged();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckData() == false)
                return;

            MessageBox.Show("OK！");
        }

        #endregion

        #region 方法

        private void Cmb_SelectedIndexChanged()
        {
            if (txt進貨單編號.Enabled == false)
                return;

            _廠商ID = Convert.ToByte(cmb廠商.SelectedValue);
            _庫存地點ID = Convert.ToByte(cmb庫存地點.SelectedValue);

            int 進貨單編號Max = SQLData.db.進貨單列表.Select(s => s.進貨單編號).Max();

            txt進貨單編號.Text = (進貨單編號Max+1).ToString();
        }

        private bool CheckData()
        {
            if (true == string.IsNullOrWhiteSpace(txt進貨單編號.Text))
            {
                MessageBox.Show("進貨單編號空白!");
                txt進貨單編號.Focus();
                return false;
            }

            int 進貨單編號 = Convert.ToInt32(txt進貨單編號.Text);
            if (進貨單編號 == 0)
            {
                MessageBox.Show("進貨單編號不可為 0!");
                txt進貨單編號.Focus();
                return false;
            }
            else if (true == SQLData.db.進貨單列表.Any(w => w.進貨單編號 == 進貨單編號))
            {
                MessageBox.Show("進貨單編號已存在!");
                txt進貨單編號.Focus();
                return false;
            }

            if (!DateTime.TryParse(msk進貨日期.Text, out _dt進貨日期))
            {
                MessageBox.Show("進貨日期不是正確的日期格式型別！");
                msk進貨日期.Focus();
                return false;
            }

            if (_dt進貨日期 >  DateTime.Now)
            {
                MessageBox.Show("進貨日期大於今日！");
                msk進貨日期.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txt明細筆數.Text))
            {
                MessageBox.Show("明細筆數空白!");
                txt明細筆數.Focus();
                return false;
            }

            byte 明細筆數 = Convert.ToByte(txt明細筆數.Text);
            if (明細筆數 == 0)
            {
                MessageBox.Show("明細筆數不可為 0!");
                txt進貨單編號.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txt進貨成本.Text))
            {
                MessageBox.Show("進貨成本空白!");
                txt進貨成本.Focus();
                return false;
            }

            decimal 進貨成本 = Convert.ToDecimal(txt進貨成本.Text);
            if (進貨成本 == 0)
            {
                MessageBox.Show("進貨成本 0!");
                txt進貨單編號.Focus();
                return false;
            }


            return true;
        }

        #endregion        
    }
}
