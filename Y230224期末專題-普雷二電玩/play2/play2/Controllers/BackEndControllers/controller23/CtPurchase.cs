using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace play2.Controllers
{
    public class CtPurchase
    {
        public int 進貨單號 { get; set; }
        public string 進貨日期 { get; set; }
        public string 供應商名稱 { get; set; }
        public string 商品名稱 { get; set; }
        public int 筆數 { get; set; }
        public decimal 進貨總價 { get; set; }
        public string 倉庫別 { get; set; }
        public string 備註 { get; set; }
    }

    public class CtPurchaseEdit
    {
        public int 進貨單號 { get; set; }
        public string 進貨日期 { get; set; }
        [DisplayName ("供應商ID")]
        public int SupplierID { get; set; }
        public string 供應商名稱 { get; set; }
        public int 商品ID { get; set; }
        public string 商品名稱 { get; set; }
        public decimal 單價 { get; set; }
        public int 數量 { get; set; }
        public decimal 小計 { get; set; }
        public decimal 進貨總價 { get; set; }

        public int 筆數 { get; set; }

        public string 倉庫ID { get; set; }
        public string 倉庫別 { get; set; }
        public string 備註 { get; set; }
    }

    public class CKeywordViewModel
    {
        public string txtKeyword { get; set; }
    }



}
