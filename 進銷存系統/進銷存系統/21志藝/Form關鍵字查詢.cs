using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 庫存查詢DEMO
{
    public partial class Form關鍵字查詢 : Form
    {
        public Form關鍵字查詢()
        {
            InitializeComponent();
        }
        private DialogResult clickresult;
        public DialogResult _isOKclick { get { return clickresult; } }
        public string keyword { get { return txtb關鍵字.Text; } }

        private void btn確定_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtb關鍵字.Text.Trim()))
            {
                clickresult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            clickresult = DialogResult.Cancel;
            this.Close();
        }
    }
}
