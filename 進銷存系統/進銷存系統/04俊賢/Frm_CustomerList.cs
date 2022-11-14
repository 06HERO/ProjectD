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
using System.Xml.Linq;

namespace Project_Inventory_System_01
{
    public partial class Frm_CustomerList : Form
    {
        public Frm_CustomerList()
        {
            InitializeComponent();
        }

        private void Frm_CustomerList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select*from 經銷商列表", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource=ds.Tables[0];
        }

        private void Insert(object sender, EventArgs e)
        {
            string sql = "INSERT INTO 經銷商列表 (經銷商ID,經銷商名稱,聯絡人,統一編號,聯絡電話,地址,備註)";
            sql += $"VALUES ('{txtID.Text}','{txtName.Text}','{txtCP.Text}','{txtTaxNo.Text}','{txtPhone.Text}','{txtAds.Text}','{txtNote.Text}')";
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("新增資料成功");

        }

        private void Update(object sender, EventArgs e)
        {
            //string sql = "UPDATE 經銷商列表 SET (聯絡人,經銷商名稱,統一編號,聯絡電話,地址,備註 WHERE 經銷商ID=)";
            //sql += $"VALUES ('{txtCP.Text}''{txtName.Text}','{txtTaxNo.Text}','{txtPhone.Text}','{txtAds.Text}','{txtNote.Text}')";

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();

            //con.Close();
            //MessageBox.Show("修改資料成功");
        }

        private void Delete(object sender, EventArgs e)
        {
            //string sql = "DELETE FROM 經銷商列表 WHERE 經銷商Id=txtID.Text";
         
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = sql;
            //cmd.ExecuteNonQuery();

            //con.Close();
            //MessageBox.Show("刪除資料成功");

        }

        private void Refresh(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //string sql = "SELECT * FROM  經銷商列表   WHERE 經銷商Id";
            //cmd.CommandText = sql;
        }
    }
}
