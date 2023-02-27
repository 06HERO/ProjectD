using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View進貨單新增編輯
    {
        public int 進貨單號 { get; set; }
        public string? 進貨日期 { get; set; }
        public string? 供應商名稱 { get; set; }
        public string? 商品名稱 { get; set; }
        public decimal? 單價 { get; set; }
        public int? 數量 { get; set; }
        public decimal? 小計 { get; set; }
        public string 倉庫別 { get; set; } = null!;
        public string? 備註 { get; set; }
        public int CommodityId { get; set; }
        public int SupplierId { get; set; }
        public int StockroomId { get; set; }
    }
}
