using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TPurchaseDetail
    {
        public int PurOrderId { get; set; }
        public int CommodityId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
        public virtual TPurchaseOrder PurOrder { get; set; } = null!;
    }
}
