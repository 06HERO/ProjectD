using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TCompanyMember
    {
        public string MemberId { get; set; } = null!;
        public string? CompanyName { get; set; }
        public string? PrincipalMan { get; set; }
        public string? TaxIdnumber { get; set; }
        public string? Phone { get; set; }
        public string? Addrest { get; set; }
        public string? SwiftCode { get; set; }
        public string? BankAccount { get; set; }
        public string? FilePath { get; set; }
        public string? Credits { get; set; }
        public string? CreditLevel { get; set; }
        public string? Notes { get; set; }

        public virtual TMember Member { get; set; } = null!;
    }
}
