using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TPurchaseOrder
    {
        public TPurchaseOrder()
        {
            TPurchaseDetails = new HashSet<TPurchaseDetail>();
        }

        public int PurOrderId { get; set; }
        public int SupplierId { get; set; }
        public int StockroomId { get; set; }
        public string? PurchaseDate { get; set; }
        public decimal? LogisticsCost { get; set; }
        public string? Notes { get; set; }

        public virtual TStockroom Stockroom { get; set; } = null!;
        public virtual TSupplier Supplier { get; set; } = null!;
        public virtual ICollection<TPurchaseDetail> TPurchaseDetails { get; set; }
    }
}
