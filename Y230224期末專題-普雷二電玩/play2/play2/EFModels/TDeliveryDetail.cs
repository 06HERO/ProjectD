using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TDeliveryDetail
    {
        public int DelOrderId { get; set; }
        public int CommodityId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int OrderQty { get; set; }
        public int? PickQty { get; set; }
        public int? CancelQty { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
        public virtual TDeliveryOrder DelOrder { get; set; } = null!;
    }
}
