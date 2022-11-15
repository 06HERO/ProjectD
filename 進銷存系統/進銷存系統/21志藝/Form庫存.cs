using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 進銷存系統.BaseData;

namespace 庫存查詢DEMO
{
    public partial class Form庫存 : Form
    {
        public Form庫存()
        {
            InitializeComponent();
        }

        #region//全域變數
        SqlCommandBuilder cmd = new SqlCommandBuilder();
        SqlDataAdapter adapt = null;
        DataTable dt = new DataTable();        
        bool _firstGenerateNum=false;
        bool _top10=false;
        bool _all=false;
        string _keyword = "";        
        #endregion


        private void Form庫存_Load(object sender, EventArgs e)
        {        
            Options();           
        }

        #region//按鈕事件
        private void btn倉庫列表_Click(object sender, EventArgs e)
        {

            Form列表 f = new Form列表();
            f._placeormanf = "place";
            f.ShowDialog();
            if (f._isOKclick == true && f._data1 != null && f._data2 != null)
            {
                cbo地點.SelectedValue = f._data1;
                cbo地點.SelectedText = f._data2;
                cbo地點.Text = f._data2;
            }
        }
        private void btn進貨商列表_Click(object sender, EventArgs e)
        {

            Form列表 f = new Form列表();
            f._placeormanf = "manf";
            f.ShowDialog();
            if (f._isOKclick == true && f._data1 != null && f._data2 != null)
            {
                cbo廠商.SelectedValue = f._data1;
                cbo廠商.SelectedText = f._data2;
                cbo廠商.Text = f._data2;
            }
        }
        private void btn輸入_Click(object sender, EventArgs e)
        {       
            Showdata();
            Setsize();
            Setcolor();
        }
        private void btn關鍵字_Click(object sender, EventArgs e)
        {
            Form關鍵字查詢 f = new Form關鍵字查詢();
            f.ShowDialog();
            if (f._isOKclick == DialogResult.OK)
            {
                _keyword = f.keyword;
                Showdata();
                _keyword = "";
                Setsize();
                Setcolor();
            }
        }
        private void btnTOP10_Click(object sender, EventArgs e)
        {
            _top10 = true;
            Showdata();
            _top10 = false;
            Setsize();
            Setcolor();
        }
        private void btnALL_Click(object sender, EventArgs e)
        {          
            _all = true;
            Showdata();
            _all = false;
            Setsize();
            Setcolor();
        }
        #endregion


        #region//方法

        private void Options()
        {         
            var place = (from a in SQLData.db.fn_庫存列表() select new { a.庫存地點ID, a.庫存地點 }).Distinct().ToList();        
            place.Insert(0, new { 庫存地點ID = 0, 庫存地點 = "全部" });
            cbo地點.ValueMember = "庫存地點ID";
            cbo地點.DisplayMember = "庫存地點";
            cbo地點.DataSource = place;         

            var type = (from a in SQLData.db.fn_庫存列表() select new { a.商品類型ID, a.商品類型名稱 }).Distinct().ToList();         
            type.Insert(0, new { 商品類型ID = Convert.ToByte(0), 商品類型名稱 = "全部" });
            cbo類型.ValueMember = "商品類型ID";
            cbo類型.DisplayMember = "商品類型名稱";
            cbo類型.DataSource = type;            

            var manf = (from a in SQLData.db.fn_庫存列表() select new { a.廠商ID, a.廠商名稱 }).Distinct().ToList();
            manf.Insert(0, new { 廠商ID = Convert.ToByte(0), 廠商名稱 = "全部" });            
            cbo廠商.ValueMember = "廠商ID";          
            cbo廠商.DisplayMember = "廠商名稱";
            cbo廠商.DataSource = manf; 
        }               
  
        private void Showdata()
        {
            DataTable dtclear = new DataTable();
            dataGridView1.DataSource = dtclear;
            if (_top10)
            {
                var q = (from a in SQLData.db.fn_總商品庫存表()
                         orderby a.總庫存量 descending
                         select a).Take(10).ToDataTable();
                dataGridView1.DataSource = q;
            }
            else if(_all)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = SQLData.資料庫路徑;                    
                con.Open();

                adapt = new SqlDataAdapter("SELECT * FROM fn_總商品庫存表()", con);
                cmd.DataAdapter = adapt;

                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                try
                {
                    Convert.ToInt32(cbo地點.SelectedValue);
                    Convert.ToInt32(cbo類型.SelectedValue);
                    Convert.ToInt32(cbo廠商.SelectedValue);
                }
                catch (System.NullReferenceException )
                {
                    MessageBox.Show("請使用下拉式選單");
                    return;
                }
                catch ( System.FormatException)
                {
                    MessageBox.Show("請使用下拉式選單");
                    return;
                }                
                int splace = Convert.ToInt32(cbo地點.SelectedValue);
                int stype = Convert.ToInt32(cbo類型.SelectedValue);
                int smanf = Convert.ToInt32(cbo廠商.SelectedValue);
                var data = from a in SQLData.db.fn_庫存列表() select a;
                if (splace == 0)
                {
                    if (stype == 0)
                    {                      
                        if (smanf == 0)
                        {  }
                        else
                            data = data.Where(q => q.廠商ID == smanf);
                    }
                    else
                    {
                        data = data.Where(q => q.商品類型ID == stype);
                        if (smanf == 0)
                        {  }
                        else                        
                            data = data.Where(q => q.廠商ID == smanf);                        
                    }
                }
                else
                {
                    data = data.Where(q => q.庫存地點ID == splace);
                    if (stype == 0)
                    {                        
                        if (smanf == 0)
                        { }
                        else
                            data = data.Where(q => q.廠商ID == smanf);
                    }
                    else
                    {
                        data = data.Where(q => q.商品類型ID == stype);
                        if (smanf == 0)
                        { }
                        else
                            data = data.Where(q => q.廠商ID == smanf);
                    }
                }
                var dataselect = from b in data
                                 select new
                                 {
                                     b.庫存地點,
                                     b.商品類型名稱,
                                     b.廠商名稱,
                                     b.商品ID,
                                     b.商品名稱,
                                     b.商品數量                                  
                                 };
                dataGridView1.DataSource = dataselect.ToDataTable();
                

                if (_keyword != "")
                {                    
                    dt = dataGridView1.DataSource as DataTable;
                    DataTable dtNew = dt.Clone();
                    DataRow[] rows = dt.Select("商品名稱 LIKE '%" + _keyword + "%'");                   
                    foreach (DataRow row in rows)
                        dtNew.ImportRow(row);
                    dataGridView1.DataSource = dtNew;
                }
            }
            Setsize();
            GenerateNum();
        }       

        private void GenerateNum() 
        {
            if (!_firstGenerateNum)
            {
                DataGridViewTextBoxColumn numcol = new DataGridViewTextBoxColumn();
                numcol.Name = "序";
                numcol.ValueType = typeof(int);
                dataGridView1.Columns.Insert(0, numcol);
                _firstGenerateNum = true;
            }            

            for (int i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i - 1].Cells[0].Value = i.ToString();
            }
        }

        private void Setcolor()
        {     
            bool isChange = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.DefaultCellStyle.BackColor = Color.Moccasin;
                if (isChange)
                    r.DefaultCellStyle.BackColor = Color.White;
                isChange = !isChange;
            }         
        }

        private void Setsize()
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            if (dataGridView1.ColumnCount == 4)
            {
                dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.05);
                dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.11);
                dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.30);
                dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.10);
            }

            else if (dataGridView1.ColumnCount == 7)
            {
                dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.05);
                dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.12);
                dataGridView1.Columns[2].Width = (int)(dataGridView1.Width * 0.12);
                dataGridView1.Columns[3].Width = (int)(dataGridView1.Width * 0.12);
                dataGridView1.Columns[4].Width = (int)(dataGridView1.Width * 0.10);
                dataGridView1.Columns[5].Width = (int)(dataGridView1.Width * 0.30);
                dataGridView1.Columns[6].Width = (int)(dataGridView1.Width * 0.07);
            }           
        }

        #endregion


        #region//調整

        private void Form庫存_SizeChanged(object sender, EventArgs e)
        {
            Setsize();
        }     

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            for (int i = 1; i <= dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i - 1].Cells[0].Value = i.ToString();
            }       
            Setcolor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        #endregion


    }
}
