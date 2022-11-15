using Project_Inventory_System_01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 庫存查詢DEMO;
using 進銷存系統.BaseData;

namespace 進銷存系統
{
    public partial class FrmMain : Form
    {
        private List<Form> FormList = null;

        private Frm_廠商維護_控制表 Frm廠商維護 = null;
        private Frm廠商列表維護 Frm廠商 = null;
        private Frm商品類別列表維護 Frm商品類別= null;
        private Frm商品列表維護 Frm商品 = null;
        private Frm進貨單維護 Frm進貨單 = null;
        private Form庫存 Frm庫存 = null;
        private Frm訂單查詢 Frm訂單 = null;
        private Frm查詢訂單 Frm出貨單維護 = null;

        private Frm_CustomerList Frm客戶維護系統 = null;
        private Frm經銷商 Frm經銷商編輯 = null;


        public FrmMain()
        {
            InitializeComponent();

            FormList = new List<Form>();            
        }

        #region 事件

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.ReLoad();
        }

        private void tSB真_廠商資料查詢編輯_Click(object sender, EventArgs e)
        {
            if (Frm廠商維護 == null || Frm廠商維護.IsDisposed == true)
            {
                Frm廠商維護 = new Frm_廠商維護_控制表();
                Frm廠商維護.MdiParent = this;
                Frm廠商維護.WindowState = FormWindowState.Maximized;
                Frm廠商維護.Show();

                FormList.Add(Frm廠商維護);
            }
            Frm廠商維護.BringToFront();

            
        }

        private void 廠商資料查詢編輯_Click(object sender, EventArgs e)
        {
            if(Frm廠商 == null || Frm廠商.IsDisposed == true)
            {
                Frm廠商 = new Frm廠商列表維護();
                Frm廠商.MdiParent = this;
                Frm廠商.WindowState = FormWindowState.Maximized;
                Frm廠商.Show();

                FormList.Add(Frm廠商);
            }
            Frm廠商.BringToFront();
        }

        private void 商品類別查詢編輯_Click(object sender, EventArgs e)
        {
            if (Frm商品類別 == null || Frm商品類別.IsDisposed == true)
            {
                Frm商品類別 = new Frm商品類別列表維護();
                Frm商品類別.MdiParent = this;
                Frm商品類別.WindowState = FormWindowState.Maximized;
                Frm商品類別.Show();

                FormList.Add(Frm商品類別);
            }
            Frm商品類別.BringToFront();
        }

        private void 商品資料查詢編輯_Click(object sender, EventArgs e)
        {
            if (Frm商品 == null || Frm商品.IsDisposed == true)
            {
                Frm商品 = new Frm商品列表維護();
                Frm商品.MdiParent = this;
                Frm商品.WindowState = FormWindowState.Maximized;
                Frm商品.Show();

                FormList.Add(Frm商品);
            }
            Frm商品.BringToFront();
        }

        private void tSB進貨單查詢編輯_Click(object sender, EventArgs e)
        {
            if (Frm進貨單 == null || Frm進貨單.IsDisposed == true)
            {
                Frm進貨單 = new Frm進貨單維護();
                Frm進貨單.MdiParent = this;
                Frm進貨單.WindowState = FormWindowState.Maximized;
                Frm進貨單.Show();

                FormList.Add(Frm進貨單);
            }
            Frm進貨單.BringToFront();
        }

        private void tSB庫存查詢_Click(object sender, EventArgs e)
        {
            if (Frm庫存 == null || Frm庫存.IsDisposed == true)
            {
                Frm庫存 = new Form庫存();
                Frm庫存.MdiParent = this;
                Frm庫存.WindowState = FormWindowState.Maximized;
                Frm庫存.Show();

                FormList.Add(Frm庫存);
            }
            Frm庫存.BringToFront();
        }

        private void tSB訂單查詢_Click(object sender, EventArgs e)
        {
            if (Frm訂單 == null || Frm訂單.IsDisposed == true)
            {
                Frm訂單 = new Frm訂單查詢();
                Frm訂單.MdiParent = this;
                Frm訂單.WindowState = FormWindowState.Maximized;
                Frm訂單.Show();

                FormList.Add(Frm訂單);
            }
            Frm訂單.BringToFront();
        }

        private void tSB出貨單維護_Click(object sender, EventArgs e)
        {
            if (Frm出貨單維護 == null || Frm出貨單維護.IsDisposed == true)
            {
                Frm出貨單維護 = new Frm查詢訂單();
                Frm出貨單維護.MdiParent = this;
                Frm出貨單維護.WindowState = FormWindowState.Maximized;
                Frm出貨單維護.Show();

                FormList.Add(Frm出貨單維護);
            }
            Frm出貨單維護.BringToFront();
        }

        private void tSB客戶維護系統_Click(object sender, EventArgs e)
        {
            if (Frm客戶維護系統 == null || Frm客戶維護系統.IsDisposed == true)
            {
                Frm客戶維護系統 = new Frm_CustomerList();
                Frm客戶維護系統.MdiParent = this;
                Frm客戶維護系統.WindowState = FormWindowState.Maximized;
                Frm客戶維護系統.Show();

                FormList.Add(Frm客戶維護系統);
            }
            Frm客戶維護系統.BringToFront();
        }

        private void tSB經銷商查詢編輯_Click(object sender, EventArgs e)
        {
            if (Frm經銷商編輯 == null || Frm經銷商編輯.IsDisposed == true)
            {
                Frm經銷商編輯 = new Frm經銷商();
                Frm經銷商編輯.MdiParent = this;
                Frm經銷商編輯.WindowState = FormWindowState.Maximized;
                Frm經銷商編輯.Show();

                FormList.Add(Frm經銷商編輯);
            }
            Frm經銷商編輯.BringToFront();
        }

        private void tSb關閉所有視窗_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要關閉所有視窗", "確認", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            this.CloseAllFrm();           
        }

        private void tSB登出_Click(object sender, EventArgs e)
        {
            this.ReLoad();
        }

        private void tSBExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region 方法

        private void CloseAllFrm()
        {
            foreach (Form form in FormList)
                form.Close();
            FormList.Clear();
        }

        private void ReLoad()
        {
            tSB登入人員.Visible = false;
            tSB真_廠商資料查詢編輯.Visible = false;
            tSB廠商資料查詢編輯.Visible = false;
            tSB商品類別查詢編輯.Visible = false;
            tSB商品資料查詢編輯.Visible = false;
            tSB進貨單查詢編輯.Visible = false;
            tSB庫存查詢.Visible = false;
            tSB客戶維護系統.Visible = false;
            tSB經銷商查詢編輯.Visible = false;
            tSB庫存查詢.Visible = false;
            tSB訂單查詢.Visible = false;
            tSB出貨單維護.Visible = false;
            tSb關閉所有視窗.Visible = false;
            tSB登出.Visible = false;
            tSBExit.Visible = false;

            this.CloseAllFrm();

            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }

            switch (SQLData.IsAdmin)
            {
                case (int)User_LV.User:
                    tSB商品資料查詢編輯.Visible = true;
                    tSB商品資料查詢編輯.Text = "商品資料查詢";
                    tSB進貨單查詢編輯.Visible = true;
                    tSB進貨單查詢編輯.Text = "進貨單查詢";
                    break;

                case (int)User_LV.Admin:
                    tSB真_廠商資料查詢編輯.Visible = true;
                    tSB廠商資料查詢編輯.Visible = true;
                    tSB商品類別查詢編輯.Visible = true;
                    tSB商品資料查詢編輯.Visible = true;
                    tSB進貨單查詢編輯.Visible = true;
                    tSB客戶維護系統.Visible = true;
                    tSB經銷商查詢編輯.Visible = true;
                    break;
            }
            tSB庫存查詢.Visible = true;
            tSB訂單查詢.Visible = true;
            tSB出貨單維護.Visible = true;
            tSb關閉所有視窗.Visible = true;
            tSB登出.Visible = true;
            tSBExit.Visible = true;

            tSB登入人員.Visible = true;
            tSB登入人員.Text = "登入人員： "  + SQLData.LoginID;
        }

        #endregion        
    }
}
