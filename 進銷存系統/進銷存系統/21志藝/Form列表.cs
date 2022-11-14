using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 進銷存系統;
using 進銷存系統.BaseData;

namespace 庫存查詢DEMO
{
    public partial class Form列表 : Form
    {
        public Form列表()
        {
            InitializeComponent();
        }

        #region//全域變數
        DataTable dt = new DataTable();
        string _keyword1 = "";
        string _keyword2 = "";
        private bool isclick=false;
        public bool _isOKclick { get { return isclick; } }
        public string _placeormanf;       
        private string data1;
        public string _data1
        { get { return data1; } }
        private string data2;
        public string _data2
        { get { return data2; } }        
        #endregion


        private void Form列表_Load(object sender, EventArgs e)
        {
            Changeform();
            Showdata();
            Setsize();
        }
        private void btn查詢1_Click(object sender, EventArgs e)
        {
            _keyword1=txt1.Text;
            txt2.Clear();
            Showdata();
            _keyword1 = "";           
            Setsize();
        }
        private void btn查詢2_Click(object sender, EventArgs e)
        {
            _keyword2 = txt2.Text;
            txt1.Clear();
            Showdata();
            _keyword2 = "";         
            Setsize();
        }

        private void Showdata()
        {
            DataTable dtclear=new DataTable();
            dt = dtclear;
            if (_placeormanf == "place")
            {
                var addrest = (from a in SQLData.db.fn_庫存列表()
                               select new
                               {
                                   a.庫存地點ID,
                                   a.庫存地點,
                                   a.地址
                               }).Distinct();
                dataGridView1.DataSource = addrest.ToDataTable();
                dataGridView1.Columns["庫存地點ID"].Visible = false;

                if (_keyword1 != "" || _keyword2 != "")
                {
                    dt = dataGridView1.DataSource as DataTable;
                    DataTable dtNew = dt.Clone();
                    DataRow[] rows = dt.Select($"庫存地點 LIKE '%{_keyword1}%' AND 地址 LIKE '%{_keyword2}%'");
                    foreach (DataRow row in rows)
                        dtNew.ImportRow(row);
                    dataGridView1.DataSource = dtNew;
                }
            }
            else if(_placeormanf=="manf")
            {
                var manf = (from a in SQLData.db.fn_庫存列表()
                               select new
                               {
                                   a.廠商ID,
                                   a.統一編號,
                                   a.廠商名稱
                               }).Distinct();
                dataGridView1.DataSource = manf.ToDataTable();
                dataGridView1.Columns["廠商ID"].Visible = false;

                if (_keyword1 != "")
                {
                    dt = dataGridView1.DataSource as DataTable;
                    DataTable dtNew = dt.Clone();
                    DataRow[] rows = dt.Select($"統一編號 = '{_keyword1}'");
                    foreach (DataRow row in rows)
                        dtNew.ImportRow(row);
                    dataGridView1.DataSource = dtNew;
                }
                else if(_keyword2 != "")
                {
                    dt = dataGridView1.DataSource as DataTable;
                    DataTable dtNew = dt.Clone();
                    DataRow[] rows = dt.Select($"廠商名稱 LIKE '%{_keyword2}%'");
                    foreach (DataRow row in rows)
                        dtNew.ImportRow(row);
                    dataGridView1.DataSource = dtNew;
                }
            }
        }
        private void Changeform()
        {
            if(_placeormanf=="place")
            {
                lab1.Text = "倉  庫";
                lab2.Text = "倉 庫 地 址";
                this.Text = "倉庫列表";
            }
            else if(_placeormanf=="manf")
            {
                lab1.Text = "統 一 編 號";
                lab2.Text = "進  貨  商  名  稱";
                this.Text = "進貨商列表";
            }
        }
        private void Setsize()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
            }
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.32);
            dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.62);
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            isclick=true;
            if (_placeormanf == "place")
            {
                data1 = dataGridView1.Rows[e.RowIndex].Cells["庫存地點ID"].Value.ToString();
                data2 = dataGridView1.Rows[e.RowIndex].Cells["庫存地點"].Value.ToString();
            }
            else if(_placeormanf == "manf")
            {
                data1 = dataGridView1.Rows[e.RowIndex].Cells["廠商ID"].Value.ToString();
                data2 = dataGridView1.Rows[e.RowIndex].Cells["廠商名稱"].Value.ToString();
            }
            this.Close();
        }

        
    }
}
