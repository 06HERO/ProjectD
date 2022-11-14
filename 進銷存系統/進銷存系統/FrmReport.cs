using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        public FrmReport(string FromText)
        {
            InitializeComponent();

            this.Text = FromText;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            
        }        

        public void LoadSources(string RdlcPath, List<ReportDataSource> reportDatas, List<ReportParameter> reportParameters)
        {
            if (string.IsNullOrWhiteSpace(RdlcPath))
            {
                MessageBox.Show("報表檔路徑為空白");
                return;
            }
            if (reportDatas == null || reportDatas.Count == 0)
            {
                MessageBox.Show("資料集為空白");
                return;
            }
            if (reportParameters == null || reportParameters.Count == 0)
            {
                MessageBox.Show("參數為空白");
                return;
            }

            try
            {
                this.reportViewer.LocalReport.ReportEmbeddedResource = RdlcPath;
                
                this.reportViewer.LocalReport.DataSources.Clear();
                foreach (ReportDataSource ds in reportDatas)
                    this.reportViewer.LocalReport.DataSources.Add(ds);

                this.reportViewer.LocalReport.SetParameters(reportParameters);

                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"報表載入失敗，錯誤訊息：{ex.ToString()}");
                return;
            }
        }
    }
}
