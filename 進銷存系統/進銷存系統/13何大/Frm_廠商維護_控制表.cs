using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 進銷存系統.BaseData;

namespace 進銷存系統
{


    public partial class Frm_廠商維護_控制表 : Form
    {
        public Frm_廠商維護_控制表()
        {
            InitializeComponent();
        }


        int _postion = -1;
        string y = "y";
        string n = "n";
        string yn = "yn";

        private void bTn_新增_Click(object sender, EventArgs e)
        {

        }

        private void tSB_新增(object sender, EventArgs e)
        {
            Frm_廠商維護_新增表 frm_New = new Frm_廠商維護_新增表();
            frm_New.ShowDialog();
            if (frm_New.bTn_Click != DialogResult.OK)
                return;
            普雷二電玩Entities dB = new 普雷二電玩Entities();

            //有空來製作防呆

            dB.廠商列表.Add(new 廠商列表
            {
                廠商名稱 = frm_New.cCampany.廠商名稱,
                統一編號 = frm_New.cCampany.統一編號,
                代表人姓名 = frm_New.cCampany.代表人姓名,
                資本總額 = Convert.ToDecimal(frm_New.cCampany.資本總額),
                聯絡電話 = frm_New.cCampany.聯絡電話,
                顯示與否 = "y"
            });
            dB.SaveChanges();
            //新增項目
            var q = from c in dB.廠商列表
                    select c;
            dGV_廠商維護_控制單.DataSource = q.ToList();
            resetGridStyle();
        }
        private void resetGridStyle()//表格變色功能
        {//寬度調整
            if (dGV_廠商維護_控制單.ColumnCount < 0)
                return;
            dGV_廠商維護_控制單.Columns[0].Width = 40;//廠商ID
            dGV_廠商維護_控制單.Columns[1].Width = 400;//廠商名稱
            dGV_廠商維護_控制單.Columns[2].Width = 120;//統一編號
            dGV_廠商維護_控制單.Columns[3].Width = 250;//代表人姓名
            dGV_廠商維護_控制單.Columns[4].Width = 150;//資本總額
            dGV_廠商維護_控制單.Columns[5].Width = 160;//聯絡電話

            bool isChange = false;
            foreach (DataGridViewRow r in dGV_廠商維護_控制單.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 15);
                r.DefaultCellStyle.BackColor = Color.LightCoral;
                if (isChange)
                    r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isChange = !isChange;

            }


        }

        private void Frm_廠商維護_控制表_Load(object sender, EventArgs e)
        {
            Reload_更新(yn);
        }

        private void dGV_廠商維護_控制單_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_廠商維護_控制單.SelectedRows.Count >= 0)
                _postion = e.RowIndex;
        }

        private void tSB_修改_Click(object sender, EventArgs e)
        {
            普雷二電玩Entities dB = new 普雷二電玩Entities();

            string choose1 = dGV_廠商維護_控制單.CurrentCell.Value.ToString();
            if (choose1 == null)
                return;

            IQueryable<廠商列表> qdB = from change in dB.廠商列表
                                   where change.廠商名稱 == choose1
                                   select change;

            dGV_廠商維護_控制單.DataSource = qdB.ToList();
                     


            resetGridStyle();
            if (MessageBox.Show("是否要改動這間廠商是請按 '確定'" + "\n" + "如果不是請按 '取消'", "問題", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                Reload_更新(y);
                return;
            }
            else if (qdB == null)
            {
                MessageBox.Show("未選取到廠商");
                Reload_更新(y);
                return;
            }


            if (qdB.ToList().Count >= 0)
            {
                Frm_廠商維護_新增表 frmChange = new Frm_廠商維護_新增表();
                frmChange.ShowDialog();
                if (frmChange.bTn_Click != DialogResult.OK)
                {
                    Reload_更新(y);
                    return;
                }

                var qCate = from c in dB.廠商列表
                            where c.廠商名稱 == choose1
                            select c;
                foreach (廠商列表 item in qCate)
                {
                    item.廠商名稱 = frmChange.cCampany.廠商名稱;
                    item.統一編號 = frmChange.cCampany.統一編號;
                    item.代表人姓名 = frmChange.cCampany.代表人姓名;
                    item.資本總額 = Convert.ToDecimal(frmChange.cCampany.資本總額);
                    item.聯絡電話 = frmChange.cCampany.聯絡電話;
                };
                dB.SaveChanges();
                Reload_更新(y);
            }
            Reload_更新(y);
            return;

        }

        private void tSB_更新_Click(object sender, EventArgs e)
        {
            Reload_更新(yn);
        }

        private void Reload_更新(string T)
        {
            #region 更新列表

            普雷二電玩Entities dB = new 普雷二電玩Entities();

            if (T == "y")
            {
                var q = from c in dB.廠商列表
                        where c.顯示與否 == "y"
                        select new
                        {
                            廠商ID = c.廠商ID,
                            廠商名稱 = c.廠商名稱,
                            統一編號 = c.統一編號,
                            代表人姓名 = c.代表人姓名,
                            資本總額 = c.資本總額,
                            聯絡電話 = c.聯絡電話
                        };
                dGV_廠商維護_控制單.DataSource = q.ToDataTable();
            }
            else if (T == "n")
            {
                var q = from c in dB.廠商列表
                        where c.顯示與否 == "n"
                        select new
                        {
                            廠商ID = c.廠商ID,
                            廠商名稱 = c.廠商名稱,
                            統一編號 = c.統一編號,
                            代表人姓名 = c.代表人姓名,
                            資本總額 = c.資本總額,
                            聯絡電話 = c.聯絡電話
                        };
                if (q.ToList().Count < 0)
                {
                    MessageBox.Show("沒有被隱蔽的廠家");
                    return;
                }
                else if (q.ToList().Count > 0)
                {
                    dGV_廠商維護_控制單.DataSource = q.ToDataTable();
                }

            }
            else if (T == "yn")
            {
                var q = from c in dB.廠商列表
                        select new
                        {
                            廠商ID = c.廠商ID,
                            廠商名稱 = c.廠商名稱,
                            統一編號 = c.統一編號,
                            代表人姓名 = c.代表人姓名,
                            資本總額 = c.資本總額,
                            聯絡電話 = c.聯絡電話,
                            顯示與否 = c.顯示與否
                        };
                dGV_廠商維護_控制單.DataSource = q.ToDataTable();

            }

            resetGridStyle();//更換顏色
            #endregion  更新列表
        }

        private void Frm_廠商維護_控制表_StyleChanged(object sender, EventArgs e)
        {
            Reload_更新(yn);
        }

        private void tSB_刪除_Click(object sender, EventArgs e)
        {
            普雷二電玩Entities dB = new 普雷二電玩Entities();
            string choose1 = dGV_廠商維護_控制單.CurrentCell.Value.ToString();
            if (choose1 == null)
                return;

            IQueryable<廠商列表> qdB = from change in dB.廠商列表
                                   where change.廠商名稱 == choose1
                                   select change;

            dGV_廠商維護_控制單.DataSource = qdB.ToList();
           

            resetGridStyle();
            if (MessageBox.Show("是否要刪除該筆廠商資料是請按 '確定'" + "\n" + "如果不是請按 '取消'", "問題", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Reload_更新(y);
                return;
            }
            else if (qdB == null)
            {
                MessageBox.Show("未選取到廠商");
                Reload_更新(y);
                return;
            }
            #region 原刪除功能
            //if (qdB.ToList().Count > 0)
            //{
            //    var qCate = (from c in dB.廠商列表
            //                where c.廠商名稱 == choose1
            //                select c).First();
            //    dB.廠商列表.Remove(qCate);/*刪除資料*/
            //    if (MessageBox.Show("是否刪除該筆資料？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        Reload_更新(y);
            //        return;
            //    }
            //    dB.SaveChanges();
            //    Reload_更新(y);
            //}
            #endregion

            #region 遮蔽功能
            if (qdB.ToList().Count > 0)
            {
                var qCate = (from c in dB.廠商列表
                             where c.廠商名稱 == choose1
                             select c).First();
                qCate.顯示與否 = "n";
                if (MessageBox.Show("是否刪除該筆資料？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Reload_更新(y);
                    return;
                }
                dB.SaveChanges();
                Reload_更新(y);
            }
            #endregion
            Reload_更新(y);
            return;

        }


        private void tSB_查詢_Click(object sender, EventArgs e)
        {
            Frm_搜尋關鍵字 fkw = new Frm_搜尋關鍵字();
            fkw.ShowDialog();

            Reload_更新("yn");
            if (fkw.getkeyword() != "null")
            {
                if (fkw.bTn_Click == DialogResult.OK)
                {


                    DataTable _dt_搜尋欄位 = dGV_廠商維護_控制單.DataSource as DataTable;
                    DataTable _dt_搜尋欄位_New = _dt_搜尋欄位.Clone();
                    DataRow[] rows = _dt_搜尋欄位.Select("廠商名稱 LIKE'%" + fkw.getkeyword() + "%' or 統一編號 LIKE'%" + fkw.getkeyword() + "%'");
                    if (rows.Length <= 0)
                    {
                        MessageBox.Show("查無關鍵字請從新搜尋");
                        return;
                    }
                    foreach (DataRow row in rows)
                        _dt_搜尋欄位_New.ImportRow(row);
                    dGV_廠商維護_控制單.DataSource = _dt_搜尋欄位_New;

                }
            }
            resetGridStyle();

        }

        private void tSB_恢復_Click(object sender, EventArgs e)
        {
            Reload_更新(yn);
            DataTable _全部資料 = dGV_廠商維護_控制單.DataSource as DataTable;
            int index = 0;

            foreach (DataRow row in _全部資料.Rows)
            {
                string 顯示 = row.ToString();
                if (顯示 == "n")
                    dGV_廠商維護_控制單.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                index++;
            }



        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            普雷二電玩Entities dB = new 普雷二電玩Entities();
            string choose1 = dGV_廠商維護_控制單.CurrentCell.Value.ToString();
            if (choose1 == null)
                return;

            IQueryable<廠商列表> qdB = from change in dB.廠商列表
                                   where change.廠商名稱 == choose1
                                   select change;

            dGV_廠商維護_控制單.DataSource = qdB.ToList();

            resetGridStyle();
            if (MessageBox.Show("是否要恢復該筆廠商資料是請按 '確定'" + "\n" + "如果不是請按 '取消'", "問題", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                Reload_更新(yn);
                return;
            }
            else if (qdB == null)
            {
                MessageBox.Show("未選取到廠商");
                Reload_更新(yn);
                return;
            }
            #region 原刪除功能
            //if (qdB.ToList().Count > 0)
            //{
            //    var qCate = (from c in dB.廠商列表
            //                where c.廠商名稱 == choose1
            //                select c).First();
            //    dB.廠商列表.Remove(qCate);/*刪除資料*/
            //    if (MessageBox.Show("是否刪除該筆資料？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        Reload_更新(y);
            //        return;
            //    }
            //    dB.SaveChanges();
            //    Reload_更新(y);
            //}
            #endregion

            #region 恢復功能
            if (qdB.ToList().Count > 0)
            {
                var qCate = (from c in dB.廠商列表
                             where c.廠商名稱 == choose1
                             select c).First();
                qCate.顯示與否 = "y";
                if (MessageBox.Show("是否恢復該筆資料？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Reload_更新(yn);
                    return;
                }
                dB.SaveChanges();
                Reload_更新(yn);
            }
            #endregion
            Reload_更新(yn);
            return;
        }

        

        private void dGV_廠商維護_控制單_Click(object sender, EventArgs e)
        {
            resetGridStyle();
        }

        private void dGV_廠商維護_控制單_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resetGridStyle();
        }

        private void tSB_Print_Click(object sender, EventArgs e)
        {
            DataTable dt = dGV_廠商維護_控制單.DataSource as DataTable;

            List<ReportDataSource> reportDatas = new List<ReportDataSource>()
            {
                new ReportDataSource("DS廠商列表", dt)
            };

            List<ReportParameter> reportParameters = new List<ReportParameter>()
            {
                new ReportParameter("LoginID", SQLData.LoginID)
            };

            FrmReport report = new FrmReport("廠商列表清單");
            report.LoadSources(RdlcData.廠商列表清單Path, reportDatas, reportParameters);
            report.WindowState = FormWindowState.Maximized;
            report.Show();
        }
    }
}
