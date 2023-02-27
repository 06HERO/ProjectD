using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TMember
    {
        public TMember()
        {
            TDeliveryOrders = new HashSet<TDeliveryOrder>();
        }

        public string MemberId { get; set; } = null!;
        public string LoginEmail { get; set; } = null!;
        public string LoginPw { get; set; } = null!;
        public string MemberType { get; set; } = null!;
        public int? IsCheck { get; set; }

        public virtual TCompanyMember? TCompanyMember { get; set; }
        public virtual TRegularMember? TRegularMember { get; set; }
        public virtual ICollection<TDeliveryOrder> TDeliveryOrders { get; set; }
    }
}
