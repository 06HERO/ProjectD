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
    public partial class Frm經銷商keyword : Form
    {


        private DialogResult _result;

        public Frm經銷商keyword()
        {
            InitializeComponent();
        }

        public string getkeyword()
        {
            return txtkeyword.Text;
        }

        public DialogResult  isOkButtonClicked
        {
            get { return _result; }
        }



        private void btnOK(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtkeyword.Text.Trim()))
            {
                _result = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel(object sender, EventArgs e)
        {
            _result = DialogResult.Cancel;
            this.Close();
        }
    }
}
