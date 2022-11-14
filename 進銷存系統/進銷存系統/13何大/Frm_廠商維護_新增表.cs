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
    
    public partial class Frm_廠商維護_新增表 : Form
    {
        public Frm_廠商維護_新增表()
        {
            InitializeComponent();
        }

        private DialogResult _result;
        private cCampany _cCampany;
        public DialogResult bTn_Click
        { 
            get { return _result; } 
        }
        public cCampany cCampany
        {
            get { return _cCampany; }
            set { _cCampany = value; }
        }
        

        private void bTn_確定_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            if(this.cCampany == null)
                this.cCampany = new cCampany();
            if (tB_廠商名稱.Text == null || tB_統一編號.Text == null
                || tB_代表人姓名.Text == null)
                return;
            this.cCampany.廠商名稱 = tB_廠商名稱.Text;
            this.cCampany.統一編號 = tB_統一編號.Text;
            this.cCampany.代表人姓名 = tB_代表人姓名.Text;
            this.cCampany.資本總額 = tB_資本總額.Text;
            this.cCampany.聯絡電話 = tB_聯絡電話.Text;
            this.Close();
        }

        private void bTn_取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
