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
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            try
            {
                使用者列表 user = SQLData.db.使用者列表.Where(w => w.IsAdmin ==1).FirstOrDefault();
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

                MessageBox.Show($"帳號與密碼不符!,登入錯誤{_PWErr}次，關閉程式");
                _IsLockClose = false;
                Application.Exit();

                return;
            }
            MessageBox.Show($"帳號與密碼不符!,登入錯誤{_PWErr}次");            
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
