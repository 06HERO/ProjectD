using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View商品標籤表
    {
        public int? 商品標籤id { get; set; }
        public string? 商品標籤 { get; set; }
        public int? 商品id { get; set; }
        public string? 商品名稱 { get; set; }
        public string? 照片路徑 { get; set; }
        public decimal? 售價 { get; set; }
    }
}
