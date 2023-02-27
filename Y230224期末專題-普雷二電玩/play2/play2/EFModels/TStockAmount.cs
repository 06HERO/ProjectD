using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TStockAmount
    {
        public int StockroomId { get; set; }
        public int CommodityId { get; set; }
        public int? StockQty { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
        public virtual TStockroom Stockroom { get; set; } = null!;
    }
}
