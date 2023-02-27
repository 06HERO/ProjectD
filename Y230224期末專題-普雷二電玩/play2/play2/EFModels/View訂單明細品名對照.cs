using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View訂單明細品名對照
    {
        public int DelOrderId { get; set; }
        public int CommodityId { get; set; }
        public string? CommodityName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int OrderQty { get; set; }
        public int? PickQty { get; set; }
        public int? CancelQty { get; set; }
    }
}
