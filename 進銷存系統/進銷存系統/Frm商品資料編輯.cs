using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;

namespace 進銷存系統
{
    public delegate void CallBack商品編輯(商品列表 data);

    public partial class Frm商品資料編輯 : Form
    {
        public event CallBack商品編輯 callback = null;

        private int _Mode = (int)Change_Mode.None;
        private byte _廠商ID = 0;
        private byte _商品類別ID = 0;
        private 商品列表 _data = null;

        public Frm商品資料編輯()
        {
            InitializeComponent();

            lbl標題.Text = "商品資料新增";

            DataTable dt廠商 = SQLData.db.廠商列表.ToDataTable();
            cmb廠商.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb廠商.ValueMember = "廠商ID";
            cmb廠商.DisplayMember = "廠商名稱";
            cmb廠商.DataSource = dt廠商;

            DataTable dt商品類別 = SQLData.db.商品類型列表.ToDataTable();
            cmb商品類別.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb商品類別.ValueMember = "商品類型ID";
            cmb商品類別.DisplayMember = "商品類型名稱";
            cmb商品類別.DataSource = dt商品類別;
            
            _Mode = (int)Change_Mode.Insert;
        }

        public Frm商品資料編輯(string 廠商, string 商品類型, 商品列表 data, int Mode)
        {
            InitializeComponent();

            _data = data;
            _Mode = Mode;

            if(Mode == (int)Change_Mode.Update)
                lbl標題.Text = "商品資料修改";
            else if(Mode == (int)Change_Mode.Delete)
                lbl標題.Text = "商品資料刪除";            

            cmb廠商.DropDownStyle = ComboBoxStyle.DropDown;
            cmb廠商.Text = 廠商;
            cmb廠商.Enabled =false;

            cmb商品類別.DropDownStyle = ComboBoxStyle.DropDown;
            cmb商品類別.Text = 商品類型;
            cmb商品類別.Enabled =false;

            txt商品ID.Text = data.商品ID.ToString();
            txt商品ID.Enabled = false;

            txt商品名稱.Text = data.商品名稱.ToString();
            txt進貨價.Text = data.進貨價.ToString("#.#");
            txt零售價.Text = data.零售價.ToString("#.#");
            
            if(Mode == (int)Change_Mode.Delete)
            {
                txt商品名稱.Enabled = false;
                txt進貨價.Enabled = false;
                txt零售價.Enabled = false;
            }
        }

        #region 事件
        private void 商品資料編輯_Load(object sender, EventArgs e)
        {
            txt商品ID.KeyPress += SqlFunBase.Text_KeyPress_INT;
            txt進貨價.KeyPress += SqlFunBase.Text_KeyPress_Decimal;
            txt零售價.KeyPress += SqlFunBase.Text_KeyPress_Decimal;

            cmb廠商.SelectedIndexChanged += (object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
            cmb商品類別.SelectedIndexChanged +=(object s, EventArgs ev) => { this.Cmb_SelectedIndexChanged(); };
            this.Cmb_SelectedIndexChanged();
        }        

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.CheckData() == false)
                return;

            if (this.callback != null)
            {
                switch(_Mode)
                {
                    case (int)Change_Mode.Insert:
                        _data = new 商品列表()
                        {
                            廠商ID = _廠商ID,
                            商品類型ID = _商品類別ID,
                            商品ID = Convert.ToInt16(txt商品ID.Text),
                            商品名稱 = txt商品名稱.Text.Trim(),
                            進貨價 = Convert.ToDecimal(txt進貨價.Text),
                            零售價 = Convert.ToDecimal(txt零售價.Text)
                        };
                        break;

                    case (int)Change_Mode.Update:
                        if (_data != null)
                        {
                            _data.商品名稱 = txt商品名稱.Text.Trim();
                            _data.進貨價 = Convert.ToDecimal(txt進貨價.Text);
                            _data.零售價 = Convert.ToDecimal(txt零售價.Text);
                        }
                        break;

                    case (int)Change_Mode.Delete:
                        break;
                }

                this.callback(_data);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.Cancel;
        }        
        #endregion

        #region 方法
        private void Cmb_SelectedIndexChanged()
        {
            if (txt商品ID.Enabled == false)
                return;

            _廠商ID = Convert.ToByte(cmb廠商.SelectedValue);
            _商品類別ID = Convert.ToByte(cmb商品類別.SelectedValue);

            short 商品IDMax = 0;
            if( SQLData.db.商品列表.Where(w => w.廠商ID == _廠商ID && w.商品類型ID == _商品類別ID).Count() > 0 )
            {
                商品IDMax = SQLData.db.商品列表.Where(w => w.廠商ID == _廠商ID && w.商品類型ID == _商品類別ID).
                                                      Select(s => s.商品ID).Max();
            }
            txt商品ID.Text = (商品IDMax+1).ToString();
        }

        private bool CheckData()
        {
            if (true == string.IsNullOrWhiteSpace(txt商品ID.Text))
            {
                MessageBox.Show("商品ID空白!");
                txt商品ID.Focus();
                return false;
            }

            short 商品ID = Convert.ToInt16(txt商品ID.Text);
            if (商品ID == 0)
            {
                MessageBox.Show("商品ID不可為 0!");
                txt商品ID.Focus();
                return false;
            }
            else if( true == SQLData.db.商品列表.Any(w => w.廠商ID == _廠商ID && w.商品類型ID == _商品類別ID && w.商品ID == 商品ID) )
            {
                MessageBox.Show("商品ID已存在!");
                txt商品ID.Focus();
                return false;
            }
            
            if (true == string.IsNullOrWhiteSpace(txt商品名稱.Text))
            {
                MessageBox.Show("商品名稱空白!");
                txt商品名稱.Focus();
                return false;
            }

            if (true == string.IsNullOrWhiteSpace(txt進貨價.Text))
            {
                MessageBox.Show("進貨價空白!");
                txt進貨價.Focus();
                return false;
            }
            if (true == string.IsNullOrWhiteSpace(txt零售價.Text))
            {
                MessageBox.Show("零售價空白!");
                txt零售價.Focus();
                return false;
            }

            decimal 進貨價 = Convert.ToDecimal(txt進貨價.Text);
            decimal 零售價 = Convert.ToDecimal(txt零售價.Text);
            if (進貨價 == 0m)
            {
                MessageBox.Show("進貨價不可為 0!");
                txt進貨價.Focus();
                return false;
            }
            if (零售價 == 0m)
            {
                MessageBox.Show("零售價不可為 0!");
                txt零售價.Focus();
                return false;
            }

            if (_Mode == (int)Change_Mode.Delete)
            {
                return true;
            }

            if (零售價 < 進貨價)
            {
                if( MessageBox.Show("零售價低於進貨價，確定要這樣嗎？", "確認", MessageBoxButtons.OKCancel, 
                                     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    return true;
                else
                    return false;
            }

            return true;
        }
        #endregion
    }
}
