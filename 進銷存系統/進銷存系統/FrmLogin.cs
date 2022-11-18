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

            // 隱藏 tab 頁標籤
            tabLogin.SizeMode=TabSizeMode.Fixed;  
            tabLogin.Appearance= TabAppearance.FlatButtons;
            tabLogin.ItemSize=new Size(0, 1);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tabLogin.SelectedIndex = 0;

            txtCheckCode.KeyPress += SqlFunBase.Text_KeyPress_INT;
            btnShowPW.Click += (object s, EventArgs ev) => { txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar; };
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                使用者列表 user = SQLData.db.使用者列表.Where(w => w.IsAdmin ==1).FirstOrDefault();

                if (user == null)
                    return;

                var find1 = SQLData.db.使用者列表.FirstOrDefault(f => f.LoginID == user.LoginID);
                SQLData.db.Entry(find1).Reload();
                user = SQLData.db.使用者列表.Where(w => w.IsAdmin == 1).FirstOrDefault();

                txtID.Text = user.LoginID;
                txtPW.Text = user.LoginPW;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
            try
            {
                使用者列表 user = SQLData.db.使用者列表.Where(w => w.IsAdmin ==0).FirstOrDefault();

                if (user == null)
                    return;

                var find1 = SQLData.db.使用者列表.FirstOrDefault(f => f.LoginID == user.LoginID);
                SQLData.db.Entry(find1).Reload();
                user = SQLData.db.使用者列表.Where(w => w.IsAdmin == 0).FirstOrDefault();

                txtID.Text = user.LoginID;
                txtPW.Text = user.LoginPW;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            //if (string.IsNullOrWhiteSpace(txtPW.Text))
            //{
            //    MessageBox.Show("請輸入密碼");
            //    txtID.Focus();
            //    return;
            //}

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
                    tabLogin.SelectedIndex = 1;

                    string PW = SQLData.db.使用者列表.Where(w => w.LoginID == SQLData.LoginID).Select(s => s.LoginPW).FirstOrDefault();
                    
                    if (string.IsNullOrWhiteSpace(PW) == false)
                        lblCheckCode.Text = "今日初次登入，請至設定EMAIL收取驗證碼後輸入!";
                    else
                        lblCheckCode.Text = "使用者初次登入，請至設定EMAIL收取驗證碼後輸入!";

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

                MessageBox.Show($"帳號或密碼不符!,登入錯誤{_PWErr}次，關閉程式");
                _IsLockClose = false;
                Application.Exit();

                return;
            }
            MessageBox.Show($"帳號或密碼不符!,登入錯誤{_PWErr}次");            
        }

        private void btnResetPW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("請輸入帳號");
                txtID.Focus();
                return;
            }

            if( 0 >= SQLData.db.Update使用者PW(txtID.Text.Trim(), string.Empty) )
            {
                MessageBox.Show("帳號不符");
                txtID.Focus();
                return;
            }

            tabLogin.SelectedIndex = 1;

            lblCheckCode.Text = "重設密碼，請至設定EMAIL收取驗證碼後輸入!";
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            if (txtCheckCode.Text.Trim().Length < 6)
            {
                lblCheckCode.Text = "驗證碼長度不足";
                txtCheckCode.Focus();
                return;
            }

            if( 0 <= _sqlFunUser.CheckCode(txtID.Text, txtCheckCode.Text.Trim()))
            {
                string PW = SQLData.db.使用者列表.Where(w => w.LoginID == SQLData.LoginID).Select(s => s.LoginPW).FirstOrDefault();

                if(string.IsNullOrWhiteSpace(PW) == false)
                {
                    MessageBox.Show("登入成功!");
                    _IsLockClose = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                {
                    tabLogin.SelectedIndex = 2;
                }
            }

            _PWErr++;
            if (_PWErr >= cErrMax)
            {
                _ErrTime = DateTime.Now;
                timErr.Interval = 500;
                timErr.Start();

                lblCheckCode.Text = $"驗證碼錯誤!,登入錯誤{_PWErr}次，關閉程式";
                btnCheckCode.Enabled = false;
                return;
            }
            lblCheckCode.Text = $"驗證碼錯誤!,登入錯誤{_PWErr}次";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _IsLockClose = false;
            Application.Exit();
        }

        private void btnUpdatePW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnNewPW.Text))
            {
                MessageBox.Show("請輸入密碼");
                txtnNewPW.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCheckPW.Text))
            {
                MessageBox.Show("請輸入確認密碼");
                txtCheckPW.Focus();
                return;
            }

            if(txtnNewPW.Text.Trim() != txtCheckPW.Text.Trim())
            {
                MessageBox.Show("密碼不一致");
                txtnNewPW.Focus();
                return;
            }

            if (0 >= SQLData.db.Update使用者PW(txtID.Text.Trim(), txtnNewPW.Text.Trim()))
            {
                MessageBox.Show("重設密碼失敗，請聯絡管理人員");
                txtID.Focus();
                return;
            }

            MessageBox.Show("重設密碼成功!");

            tabLogin.SelectedIndex = 0;
            txtPW.Text = txtnNewPW.Text.Trim();
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
            
            tabPage1.BackColor = this.BackColor;
            tabPage2.BackColor = this.BackColor;

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
