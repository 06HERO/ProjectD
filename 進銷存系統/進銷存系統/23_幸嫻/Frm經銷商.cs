using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 進銷存系統
{
    public partial class Frm經銷商 : Form
    {
        List<int> pKeys = null;  //加入fID索引
        public Frm經銷商()
        {
            InitializeComponent();
        }

        private void sqlexe(string Sql, List<SqlParameter> paras)  //編輯->重構->刪掉static修飾詞+void  //若有共同屬性的都要抓進來
        {
            SqlConnection con = new SqlConnection();       
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True"; //伺服器總管F4，查看屬性字串
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = Sql;
            if(paras != null)
                cmd.Parameters.AddRange(paras.ToArray());
            
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt經銷商ID.Text != "")
            {
                MessageBox.Show("請先清空資料");
                return;
            }
            if (txtName.Text == "" || txtContect.Text == "" || txtNum.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("請輸入完整資料");
                return;
            }
            string Sql = @"INSERT INTO [dbo].[經銷商列表]
                                    ([經銷商名稱],[統一編號],[聯絡人],[聯絡電話])
                                    VALUES(@名稱 , @統編,@聯絡人 ,@電話)";

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@名稱", txtName.Text));
            paras.Add(new SqlParameter("@統編", txtNum.Text));
            paras.Add(new SqlParameter("@聯絡人", txtContect.Text));
            paras.Add(new SqlParameter("@電話", txtPhone.Text));
            paras.Add(new SqlParameter("@經銷商ID", txt經銷商ID.Text));
            sqlexe(Sql,  paras);

            MessageBox.Show("資料新增成功!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt經銷商ID.Text == "")
            {
                MessageBox.Show("請先選取經銷商再做刪除");
                return;
            }
            int pk = Convert.ToInt32(txt經銷商ID.Text.Trim());
            string Sql = "DELETE FROM [經銷商列表] WHERE 經銷商ID=@經銷商ID"; 
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@經銷商ID", txt經銷商ID.Text));
            sqlexe(Sql,paras);

            MessageBox.Show("資料刪除成功!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtContect.Text == "" || txtNum.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("請輸入完整資料");
                return;

            }
            string Sql = "UPDATE [dbo].[經銷商列表]  " +
                                    "SET [經銷商名稱] = @名稱, [統一編號]= @統一編號, [聯絡人]= @聯絡人 ,[聯絡電話]= @電話 " +
                                    "WHERE [經銷商ID]= " + Convert.ToInt32(txt經銷商ID.Text);

            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@名稱", txtName.Text));
            paras.Add(new SqlParameter("@統一編號", txtNum.Text));
            paras.Add(new SqlParameter("@聯絡人", txtContect.Text));
            paras.Add(new SqlParameter("@電話", txtPhone.Text));
            //int pk = Convert.ToInt32(txtName.Text);
            //paras.Add(new SqlParameter("K_fID", (object)pk));
            sqlexe(Sql,paras);

            MessageBox.Show("資料更新成功!");
        }

        private void refresh()
        {
            pKeys = new List<int>();   //加入fID索引
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string Sql = "SELECT * FROM [經銷商列表] ";
            cmd.CommandText = Sql;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["經銷商名稱"]).ToString();
                pKeys.Add(Convert.ToInt32(reader["經銷商ID"]));   //加入fID索引 //加入pKeys的索引，但不顯示在listbox
            }
            reader.Close();
            con.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void displaycustomerinfobysql(string Sql, List<SqlParameter> paras, bool isClear)
        {
            if (isClear)
            {
                pKeys = new List<int>();
                listBox1.Items.Clear();
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Sql;
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txt經銷商ID.Text = reader["經銷商ID"].ToString();
                txtName.Text = reader["經銷商名稱"].ToString();
                txtNum.Text = reader["統一編號"].ToString();
                txtContect.Text = reader["聯絡人"].ToString();
                txtPhone.Text = reader["聯絡電話"].ToString();
                txtbank.Text = reader["機構代碼"].ToString();
                txtAccount.Text = reader["帳號"].ToString();
                txtgrade.Text = reader["信用評等"].ToString();
                txtcredit.Text = reader["信用額度"].ToString();
                txtmemo.Text = reader["備註"].ToString();


                if (isClear)
                {
                listBox1.Items.Add(reader["經銷商名稱"]).ToString();
                pKeys.Add(Convert.ToInt32(reader["經銷商ID"]));   //加入fID索引 //加入pKeys的索引，但不顯示在listbox
                }

            }

            reader.Close();
            con.Close();
        }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) //傳回值<0 ,do nothing
                return;
            int 經銷商ID = pKeys[listBox1.SelectedIndex]; //從pKeys的集合中找出listbox的項目索引
                                                         //string name = listBox1.SelectedItem.ToString();
            string Sql = "SELECT * FROM [經銷商列表] WHERE 經銷商ID=@經銷商ID";   //fID是int性質因此要轉型
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@經銷商ID", (object)經銷商ID));

            displaycustomerinfobysql(Sql, paras, false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm經銷商keyword f =new Frm經銷商keyword();
            f.ShowDialog();
            if(f.isOkButtonClicked == DialogResult.OK)
            {

                string Sql = "SELECT * FROM [經銷商列表] WHERE ";
                Sql += "經銷商名稱 LIKE @K_Keyword ";
                Sql += " OR 統一編號 LIKE @K_Keyword ";
                Sql += " OR 聯絡人 LIKE @K_Keyword ";
                Sql += " OR 聯絡電話 LIKE @K_Keyword ";

                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("K_Keyword", "%"+f.getkeyword()+ "%"));

                displaycustomerinfobysql(Sql, paras, true);
                }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            txt經銷商ID.Text = "";
            txtName.Text = "";
            txtNum.Text = "";
            txtContect.Text = "";
            txtPhone.Text = "";
        }

        private void txtbank_TextChanged(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM [銀行代碼列表] WHERE 機構代碼=@機構";   
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@機構",txtbank.Text.ToString()));


            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=普雷二電玩;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Sql;
            if (paras != null)
                cmd.Parameters.AddRange(paras.ToArray());

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblbank.Text = reader["金融機構"].ToString();
                    //listBox1.Items.Add(reader["經銷商名稱"]).ToString();
                    //pKeys.Add(Convert.ToInt32(reader["經銷商ID"]));   //加入fID索引 //加入pKeys的索引，但不顯示在listbox

            }

            reader.Close();
            con.Close();

        }
    }
}

