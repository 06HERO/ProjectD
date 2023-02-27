using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TCommodity
    {
        public TCommodity()
        {
            TDeliveryDetails = new HashSet<TDeliveryDetail>();
            TGameData = new HashSet<TGameDatum>();
            THostData = new HashSet<THostDatum>();
            TPurchaseDetails = new HashSet<TPurchaseDetail>();
            TStockAmounts = new HashSet<TStockAmount>();
            TTagComms = new HashSet<TTagComm>();
        }

        public int CommodityId { get; set; }
        public string? CommodityName { get; set; }
        public string? PhotoPath { get; set; }
        public decimal? Price { get; set; }
        public string? IsShelves { get; set; }
        public string? Categories { get; set; }

        public virtual ICollection<TDeliveryDetail> TDeliveryDetails { get; set; }
        public virtual ICollection<TGameDatum> TGameData { get; set; }
        public virtual ICollection<THostDatum> THostData { get; set; }
        public virtual ICollection<TPurchaseDetail> TPurchaseDetails { get; set; }
        public virtual ICollection<TStockAmount> TStockAmounts { get; set; }
        public virtual ICollection<TTagComm> TTagComms { get; set; }
    }
}
