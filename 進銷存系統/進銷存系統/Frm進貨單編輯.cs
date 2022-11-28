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
    public delegate void CallBack進貨單列表(進貨單列表 data);
    public delegate void CallBack進貨單明細(進貨單明細 data);

    public partial class Frm進貨單編輯 : Form
    {
        private const int Type_進貨單列表 = 0;
        private const int Type_進貨單明細 = 1;

        public event CallBack進貨單列表 callback列表 = null;
        public event CallBack進貨單明細 callback明細 = null;

        private int _Type = Type_進貨單列表;
        private int _Mode = (int)Change_Mode.None;

        private byte _廠商ID = 0;
        private int _庫存地點ID = 0;
        private 進貨單列表 _進貨單列表data = null;
        private DateTime _dt進貨日期 = DateTime.Now;

        private byte _商品類型ID;
        private short _商品ID;
        private 進貨單明細 _進貨單明細data = null;


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

            pan明細.Hide();

            _Type = Type_進貨單列表;
            _Mode = (int)Change_Mode.Insert;
            this.Height = 300;
        }

        public Frm進貨單編輯(string 廠商, 進貨單列表 data, int Mode)
        {
            InitializeComponent();

            _Type = Type_進貨單列表;
            _進貨單列表data = data;
            _Mode = Mode;            

            if (Mode == (int)Change_Mode.Update)
                lbl標題.Text = "進貨單修改";
            else if (Mode == (int)Change_Mode.Delete)
                lbl標題.Text = "進貨單刪除";

            txt進貨單編號.Text = data.進貨單編號.ToString();
            txt進貨單編號.Enabled = false;

            cmb廠商.DropDownStyle = ComboBoxStyle.DropDown;
            cmb廠商.Text = 廠商;
            cmb廠商.Enabled =false;

            DataTable dt庫存地點 = SQLData.db.庫存地點列表.ToDataTable();
            cmb庫存地點.ValueMember = "庫存地點ID";
            cmb庫存地點.DisplayMember = "庫存地點";
            cmb庫存地點.DataSource = dt庫存地點;
            cmb庫存地點.SelectedValue = _進貨單列表data.庫存地點ID;

            msk進貨日期.Text = _進貨單列表data.進貨日期.ToString("yyyy/MM/dd");
            txt明細筆數.Text = _進貨單列表data.明細筆數.ToString();

            pan明細.Hide();

            if (Mode == (int)Change_Mode.Delete)
            {
                cmb庫存地點.Enabled = false;
                msk進貨日期.Enabled = false;
                txt明細筆數.Enabled = false;
            }

            this.Height = 300;
        }

        public Frm進貨單編輯(fn_進貨單列表_Result data)
        {
            InitializeComponent();

            lbl標題.Text = "進貨明細新增";

            txt進貨單編號.Text = data.進貨單編號.ToString();
            txt進貨單編號.Enabled = false;

            _廠商ID = data.廠商ID;

            cmb廠商.DropDownStyle = ComboBoxStyle.DropDown;
            cmb廠商.Text = data.廠商名稱;
            cmb廠商.Enabled =false;            

            cmb庫存地點.DropDownStyle = ComboBoxStyle.DropDown;
            cmb庫存地點.Text = data.庫存地點;
            cmb庫存地點.Enabled =false;

            btnOK列表.Hide();
            btnCancel列表.Hide();

            msk進貨日期.Text = data.進貨日期.ToString("yyyy/MM/dd");
            msk進貨日期.Enabled = false;

            txt明細筆數.Text = data.明細筆數.ToString();
            txt明細筆數.Enabled = false;

            DataTable dt商品類別 = SQLData.db.商品類型列表.ToDataTable();            
            cmb商品類別.ValueMember = "商品類型ID";
            cmb商品類別.DisplayMember = "商品類型名稱";
            cmb商品類別.DataSource = dt商品類別;            
            
            rabAuto.Checked = true;
            txt進貨成本.Text = "0"; 
            txt進貨成本.Enabled = false;

            _Type = Type_進貨單明細;
            _Mode = (int)Change_Mode.Insert;
        }

        public Frm進貨單編輯(fn_進貨單列表_Result data列表, 進貨單明細 data明細,
                             string 商品類型名稱,  string 廠商名稱, int Mode)
        {
            InitializeComponent();

            _Type = Type_進貨單明細;
            _進貨單明細data = data明細;
            _Mode = Mode;

            if (Mode == (int)Change_Mode.Update)
                lbl標題.Text = "進貨明細修改";
            else if (Mode == (int)Change_Mode.Delete)
                lbl標題.Text = "進貨明細刪除";            

            txt進貨單編號.Text = data列表.進貨單編號.ToString();
            txt進貨單編號.Enabled = false;

            _廠商ID = data列表.廠商ID;

            cmb廠商.DropDownStyle = ComboBoxStyle.DropDown;
            cmb廠商.Text = data列表.廠商名稱;
            cmb廠商.Enabled =false;

            cmb庫存地點.DropDownStyle = ComboBoxStyle.DropDown;
            cmb庫存地點.Text = data列表.庫存地點;
            cmb庫存地點.Enabled =false;

            btnOK列表.Hide();
            btnCancel列表.Hide();

            msk進貨日期.Text = data列表.進貨日期.ToString("yyyy/MM/dd");
            msk進貨日期.Enabled = false;

            txt明細筆數.Text = data列表.明細筆數.ToString();
            txt明細筆數.Enabled = false;

            _商品類型ID = _進貨單明細data.商品類型ID;
            cmb商品類別.DropDownStyle = ComboBoxStyle.DropDown;
            cmb商品類別.Text = 商品類型名稱;
            cmb商品類別.Enabled = false;

            _商品ID = _進貨單明細data.商品ID;
            cmb商品名稱.DropDownStyle = ComboBoxStyle.DropDown;
            cmb商品名稱.Text = 廠商名稱;
            cmb商品名稱.Enabled = false;

            txt商品數量.Text = _進貨單明細data.商品數量.ToString();

            rabManual.Checked = true;

            txt進貨成本.Text = Convert.ToDecimal(_進貨單明細data.進貨成本).ToString("0.#");
            txt備註.Text = _進貨單明細data.備註.ToString();

            if (Mode == (int)Change_Mode.Delete)
            {
                txt商品數量.Enabled = false;
                gb計算成本.Enabled = false;
                txt進貨成本.Enabled = false;
                txt備註.Enabled = false;
            }
        }

        #region 事件
        private void Frm進貨單編輯_Load(object sender, EventArgs e)
        {
            if (_Type == Type_進貨單列表)
            {
                txt進貨單編號.KeyPress += SqlFunBase.Text_KeyPress_INT;
                txt明細筆數.KeyPress += SqlFunBase.Text_KeyPress_INT;
                cmb廠商.SelectedIndexChanged += (object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
                cmb庫存地點.SelectedIndexChanged += (object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
                this.Cmb_SelectedIndexChanged();
            }
            else
            {
                txt商品數量.KeyPress += SqlFunBase.Text_KeyPress_INT;
                txt進貨成本.KeyPress += SqlFunBase.Text_KeyPress_Decimal;
                cmb商品名稱.SelectedIndexChanged += (object s, EventArgs ev) => { _商品ID = Convert.ToInt16(cmb商品名稱.SelectedValue); };

                rabAuto.Click += (object s, EventArgs ev) => { txt進貨成本.Text = "0"; txt進貨成本.Enabled = false; };
                rabManual.Click += (object s, EventArgs ev) => { txt進貨成本.Enabled = true; };                
            }            
        }        

        private void btnOK明細_Click(object sender, EventArgs e)
        {
            if (this.CheckData() == false)
                return;

            if (this.callback明細 != null)
            {
                switch (_Mode)
                {
                    case (int)Change_Mode.Insert:
                        _進貨單明細data = new 進貨單明細()
                        {
                            進貨單編號 = Convert.ToInt32(txt進貨單編號.Text),
                            商品類型ID = _商品類型ID,
                            商品ID = _商品ID,
                            商品數量 = Convert.ToInt16(txt商品數量.Text),
                            進貨成本 = Convert.ToDecimal(txt進貨成本.Text),
                            備註 = txt備註.Text.ToString()
                        };
                        break;

                    case (int)Change_Mode.Update:
                        if (_進貨單明細data != null)
                        {
                            _進貨單明細data.商品數量 = Convert.ToInt16(txt商品數量.Text);
                            _進貨單明細data.進貨成本 = Convert.ToDecimal(txt進貨成本.Text);
                            _進貨單明細data.備註 = txt備註.Text.ToString();
                        }
                        break;

                    case (int)Change_Mode.Delete:
                        break;
                }

                this.callback明細(_進貨單明細data);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.Cancel;
        }        

        private void btnOK列表_Click(object sender, EventArgs e)
        {
            if (this.CheckData() == false)
                return;

            if (this.callback列表 != null)
            {
                switch (_Mode)
                {
                    case (int)Change_Mode.Insert:
                        _進貨單列表data = new 進貨單列表()
                        {
                            進貨單編號 = Convert.ToInt32(txt進貨單編號.Text),
                            廠商ID = _廠商ID,
                            庫存地點ID = _庫存地點ID,
                            進貨日期 = Convert.ToDateTime(msk進貨日期.Text),
                            明細筆數 = Convert.ToByte(txt明細筆數.Text)
                        };
                        break;

                    case (int)Change_Mode.Update:
                        if (_進貨單列表data != null)
                        {
                            _進貨單列表data.庫存地點ID = _庫存地點ID;
                            _進貨單列表data.進貨日期 = Convert.ToDateTime(msk進貨日期.Text);
                            _進貨單列表data.明細筆數 = Convert.ToByte(txt明細筆數.Text);
                        }
                        break;

                    case (int)Change_Mode.Delete:
                        break;
                }

                this.callback列表(_進貨單列表data);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmb商品類別_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb商品名稱.DataSource = null;

            _商品類型ID =  Convert.ToByte(cmb商品類別.SelectedValue.ToString());

            DataTable dt商品名稱 = SQLData.db.商品列表.Where(w => w.廠商ID == _廠商ID &&
                                                              w.商品類型ID ==  _商品類型ID).ToDataTable();

            cmb商品名稱.ValueMember = "商品ID";
            cmb商品名稱.DisplayMember = "商品名稱";
            cmb商品名稱.DataSource = dt商品名稱;

            _商品ID = Convert.ToInt16(cmb商品名稱.SelectedValue);
        }

        #endregion

        #region 方法

        private void Cmb_SelectedIndexChanged()
        {
            _廠商ID = Convert.ToByte(cmb廠商.SelectedValue);
            _庫存地點ID = Convert.ToByte(cmb庫存地點.SelectedValue);

            if (txt進貨單編號.Enabled == false)
                return;

            int 進貨單編號Max = SQLData.db.進貨單列表.Select(s => s.進貨單編號).Max();

            txt進貨單編號.Text = (進貨單編號Max+1).ToString();
        }

        private bool CheckData()
        {
            if(_Type == Type_進貨單列表)
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

                if (_Mode == (int)Change_Mode.Insert &&
                    true == SQLData.db.進貨單列表.Any(w => w.進貨單編號 == 進貨單編號))
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
                    txt明細筆數.Focus();
                    return false;
                }
            }
            else
            {
                int 商品數量 = Convert.ToInt32(txt商品數量.Text);
                if (商品數量 == 0)
                {
                    MessageBox.Show("商品數量不可為 0 !");
                    txt商品數量.Focus();
                    return false;
                }

                if(rabManual.Checked == true)
                {
                    decimal 進貨成本 = Convert.ToInt32(txt進貨成本.Text);
                    if (進貨成本 == 0m)
                    {
                        MessageBox.Show("手動輸入進貨成本不可為 0 !");
                        txt商品數量.Focus();
                        return false;
                    }
                }
            }            
            return true;
        }
        #endregion
    }
}
