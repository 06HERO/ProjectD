using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TDeliveryOrder
    {
        public TDeliveryOrder()
        {
            TDeliveryDetails = new HashSet<TDeliveryDetail>();
        }

        public int DelOrderId { get; set; }
        public string MemberId { get; set; } = null!;
        public string? ContactMan { get; set; }
        public string? ContactPhone { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? PayDate { get; set; }
        public string? DeliveryPeriod { get; set; }
        public string? Adderst { get; set; }
        public int? OrderStateId { get; set; }
        public decimal? OrderMoney { get; set; }
        public decimal? LogisticsMoney { get; set; }
        public decimal? LogisticsCost { get; set; }
        public string? Invoice { get; set; }
        public string? Carrier { get; set; }
        public string? Notes { get; set; }
        public string? SwiftCode { get; set; }
        public string? Bankaccount { get; set; }
        public string? Email { get; set; }
        public string? Ispay { get; set; }

        public virtual TMember Member { get; set; } = null!;
        public virtual TOrderStateList? OrderState { get; set; }
        public virtual ICollection<TDeliveryDetail> TDeliveryDetails { get; set; }
    }
}
