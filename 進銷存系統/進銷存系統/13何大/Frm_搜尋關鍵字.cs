using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 進銷存系統
{
    public partial class Frm_搜尋關鍵字 : Form
    {
        public Frm_搜尋關鍵字()
        {
            InitializeComponent();
        }

        private void tB_查詢列_TextChanged(object sender, EventArgs e)
        {

        }

        private DialogResult _result;//判斷回饋
        public string getkeyword()//全域變數 回應資料
        {
            return tB_查詢列.Text;
        }
        public DialogResult bTn_Click
        {
            get { return _result; }
        }
        private void bTn_確定_Click(object sender, EventArgs e)
        {
            _result = DialogResult.OK;
            Close();
        }

        private void bTn_取消_Click(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            Close();
        }
    }
}
