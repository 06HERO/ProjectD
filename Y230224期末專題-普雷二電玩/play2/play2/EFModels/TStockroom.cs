using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TStockroom
    {
        public TStockroom()
        {
            TPurchaseOrders = new HashSet<TPurchaseOrder>();
            TStockAmounts = new HashSet<TStockAmount>();
        }

        public int StockroomId { get; set; }
        public string Stockroom { get; set; } = null!;
        public string? Addrest { get; set; }

        public virtual ICollection<TPurchaseOrder> TPurchaseOrders { get; set; }
        public virtual ICollection<TStockAmount> TStockAmounts { get; set; }
    }
}
