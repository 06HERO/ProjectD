using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 進銷存系統.SqlFun
{
    static public class SqlFunBase
    {
        //public SqlConnection _con = null;
        //public SqlCommand _cmd = null;

        //virtual public SqlDataReader ReaderSql(string sql, List<SqlParameter> paras = null)
        //{
        //    _cmd = new SqlCommand(sql, _con);

        //    if (paras != null)
        //        _cmd.Parameters.AddRange(paras.ToArray());

        //    return _cmd.ExecuteReader();
        //}

        //virtual public int ExecuteSql(string sql, List<SqlParameter> paras = null)
        //{
        //    _cmd = new SqlCommand(sql, _con);
        //    _cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //    if (paras != null)
        //        _cmd.Parameters.AddRange(paras.ToArray());

        //    return _cmd.ExecuteNonQuery();
        //}

        static public void Text_KeyPress_INT(object sender, KeyPressEventArgs e)
        {
            //判斷按鍵是不是要輸入的類型。
            if ((e.KeyChar <  '0' || e.KeyChar > '9') &&
                e.KeyChar != (Char)8 &&                     //Backpace
                e.KeyChar != (Char)13)                      //Enter鍵
                e.Handled = true;
        }

        static public void Text_KeyPress_Decimal(object sender, KeyPressEventArgs e)
        {            
            //判斷按鍵是不是要輸入的類型。
            if ((e.KeyChar <  '0' || e.KeyChar > '9') &&
                e.KeyChar != (Char)8 &&                     //Backpace
                e.KeyChar != (Char)13 &&                    //Enter鍵 
                e.KeyChar != (Char)46)                      //小數點
                e.Handled = true;

            //小數點的處理。
            if ((int)e.KeyChar == 46)                       //小數點
            {
                Control control = (Control)sender;              

                if (control.Text.Length <= 0)
                    e.Handled = true;   //小數點不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(control.Text, out oldf);
                    b2 = float.TryParse(control.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
    }
}
