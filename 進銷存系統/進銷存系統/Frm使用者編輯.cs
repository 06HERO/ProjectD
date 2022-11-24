using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 進銷存系統.BaseData;

namespace 進銷存系統
{
    public delegate void CallBack使用者編輯(使用者列表 user);

    public partial class Frm使用者編輯 : Form
    {
        public event CallBack使用者編輯 callback = null;
        private 使用者列表 _user = null;

        private int _Mode = (int)Change_Mode.None;

        public Frm使用者編輯()
        {
            InitializeComponent();

            _Mode = (int)Change_Mode.Insert;

            lbl標題.Text = "使用者新增";

            cmb管理權限.Items.Add("無");
            cmb管理權限.Items.Add("有");
            cmb管理權限.SelectedIndex = 0;
        }

        public Frm使用者編輯(使用者列表 user, int Mode)
        {
            InitializeComponent();

            _user = user;
            _Mode = Mode;

             if (Mode == (int)Change_Mode.Update)
                lbl標題.Text = "使用者資料修改";
            else if (Mode == (int)Change_Mode.Delete)
                lbl標題.Text = "使用者資料刪除";

            cmb管理權限.Items.Add("無");
            cmb管理權限.Items.Add("有");
            cmb管理權限.SelectedIndex = 0;

            txtID.Text = _user.LoginID;
            txtID.Enabled = false;
            txtPW.Text = _user.LoginPW;
            txtEMail.Text = _user.Email;
            cmb管理權限.SelectedIndex = _user.IsAdmin;
            chk已驗證.Checked = Convert.ToBoolean(_user.IsCheck);

            if (Mode == (int)Change_Mode.Delete)
            {
                txtPW.Enabled = false;
                txtEMail.Enabled = false;
                cmb管理權限.Enabled = false;
                chk已驗證.Enabled = false;
            }
        }

        #region 事件

        private void Frm使用者編輯_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (false == this.CheckData())
                return;

            if (this.callback != null)
            {
                switch (_Mode)
                {
                    case (int)Change_Mode.Insert:
                        _user = new 使用者列表()
                        {
                            LoginID = txtID.Text.Trim(),
                            LoginPW = txtPW.Text.Trim(),
                            Email = txtEMail.Text.Trim(),
                            IsAdmin = (short)cmb管理權限.SelectedIndex
                        };                        
                        break;

                    case (int)Change_Mode.Update:
                        if (_user != null)
                        {
                            _user.LoginPW = txtPW.Text.Trim();
                            _user.Email = txtEMail.Text.Trim();
                            _user.IsAdmin = (short)cmb管理權限.SelectedIndex;
                        }                        
                        break;

                    case (int)Change_Mode.Delete:
                        break;
                }

                if (chk已驗證.Checked)
                    _user.IsCheck = 1;
                else
                    _user.IsCheck = 0;

                this.callback(_user);
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region 方法

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

            bool IDCheck = SQLData.db.fn_使用者列表().Any(a => a.使用者ID == txtID.Text.Trim());
            if (_Mode == (int)Change_Mode.Insert)
            {
                if(IDCheck)
                {
                    MessageBox.Show("已有重複使用者ID");
                    txtID.Focus();
                    return false;
                }
            }
            else
            {
                if (!IDCheck)
                {
                    MessageBox.Show("無此使用者ID");
                    txtID.Focus();
                    return false;
                }

            }

            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                if (MessageBox.Show("如不設定密碼，驗證狀態必須為「 否」，是否要新增使用者", "確認", MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return false;
                }
                chk已驗證.Checked = false;
            }

            return true;
        }

        #endregion        
    }
}
