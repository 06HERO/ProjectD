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
using 進銷存系統.BaseData;
using 進銷存系統.SqlFun;

namespace 進銷存系統
{
    public partial class FrmLogin : Form
    {
        private bool _IsLockClose = true;
        private int _PWErr = 0;
        private DateTime _ErrTime;
        private const int cErrMax = 3;
        private const int cAutoCloseTime = 5;

        SqlFunUser _sqlFunUser = null; 

        //string _sql = string.Empty;

        public FrmLogin()
        {
            InitializeComponent();

            _sqlFunUser = new SqlFunUser();

            _PWErr = 0;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            btnCheckCode.Enabled = false;
            txtCheckCode.Enabled = false;

            //txtCheckCode.KeyPress += SqlFunBase.Text_KeyPress_INT;
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                使用者列表 user = SQLData.db.使用者列表.Where(w => w.IsAdmin ==1).FirstOrDefault();

                if (user == null)
                    return;

                txtID.Text = user.LoginID;
                txtPW.Text = user.LoginPW;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            try
            {
                使用者列表 user = SQLData.db.使用者列表.Where(w => w.IsAdmin ==0).FirstOrDefault();

                if (user == null)
                    return;

                txtID.Text = user.LoginID;
                txtPW.Text = user.LoginPW;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("請輸入帳號");
                txtID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                MessageBox.Show("請輸入密碼");
                txtID.Focus();
                return;
            }

            bool IsAuthenticated = false;
            IsAuthenticated = _sqlFunUser.Login(txtID.Text.Trim(), txtPW.Text.Trim());
            if (true == IsAuthenticated)
            {
                if(SQLData.IsCheck == true)
                {
                    MessageBox.Show("登入成功!");
                    _IsLockClose = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("今日初次登入，請至設定EMAIL收取驗證碼後輸入!");
                    btnLogin.Enabled = false;
                    btnCheckCode.Enabled = true;
                    txtCheckCode.Enabled = true;
                    txtCheckCode.Focus();

                    _PWErr = 0;
                }
                return;
            }

            _PWErr++;
            if (_PWErr >= cErrMax)
            {
                _ErrTime = DateTime.Now;
                timErr.Interval = 500;
                timErr.Start();

                MessageBox.Show($"帳號與密碼不符!,登入錯誤{_PWErr}次，關閉程式");
                _IsLockClose = false;
                Application.Exit();

                return;
            }
            MessageBox.Show($"帳號與密碼不符!,登入錯誤{_PWErr}次");            
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            if (txtCheckCode.Text.Trim().Length < 6)
            {
                MessageBox.Show("驗證碼長度不足");
                txtCheckCode.Focus();
                return;
            }

            if( 0 <= _sqlFunUser.CheckCode(SQLData.LoginID, txtCheckCode.Text.Trim()))
            {
                MessageBox.Show("登入成功!");
                _IsLockClose = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            _PWErr++;
            if (_PWErr >= cErrMax)
            {
                _ErrTime = DateTime.Now;
                timErr.Interval = 500;
                timErr.Start();

                MessageBox.Show($"驗證碼錯誤!,登入錯誤{_PWErr}次，關閉程式");
                _IsLockClose = false;
                Application.Exit();

                return;
            }
            MessageBox.Show($"驗證碼錯誤!,登入錯誤{_PWErr}次");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _IsLockClose = false;
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _IsLockClose;
        }

        private void timErr_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Control)
                this.BackColor = Color.Red;
            else
                this.BackColor = SystemColors.Control;

            DateTime time = DateTime.Now;
            TimeSpan ts = time.Subtract(_ErrTime);
            if (ts.TotalSeconds >= cAutoCloseTime)
            {
                _IsLockClose = false;
                Application.Exit();
            }
        }        
    }
}
