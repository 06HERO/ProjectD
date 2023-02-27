using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TOrderStateList
    {
        public TOrderStateList()
        {
            TDeliveryOrders = new HashSet<TDeliveryOrder>();
        }

        public int OrderStateId { get; set; }
        public string? OrderStateName { get; set; }

        public virtual ICollection<TDeliveryOrder> TDeliveryOrders { get; set; }
    }
}
