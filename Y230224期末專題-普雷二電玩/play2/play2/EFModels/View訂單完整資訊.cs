using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View訂單完整資訊
    {
        public int DelOrderId { get; set; }
        public string MemberId { get; set; } = null!;
        public string? MemberName { get; set; }
        public string? ReguPhone { get; set; }
        public string? ContactMan { get; set; }
        public string? ContactPhone { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Adderst { get; set; }
        public int? OrderStateId { get; set; }
        public string? OrderStateName { get; set; }
        public string? Notes { get; set; }
        public string? MemberType { get; set; }
        public string? CompanyName { get; set; }
        public string? CompPhone { get; set; }
        public string? SwiftCode { get; set; }
        public string? Bankaccount { get; set; }
        public string? Email { get; set; }
        public decimal? LogisticsMoney { get; set; }
        public string? Ispay { get; set; }
    }
}
