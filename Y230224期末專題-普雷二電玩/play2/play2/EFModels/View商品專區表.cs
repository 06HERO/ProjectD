using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View商品專區表
    {
        public int? 商品專區id { get; set; }
        public string? 商品專區 { get; set; }
        public int? 商品id { get; set; }
        public string? 商品名稱 { get; set; }
        public string? 照片路徑 { get; set; }
        public decimal? 售價 { get; set; }
    }
}
