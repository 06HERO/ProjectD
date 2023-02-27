using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TRegularMember
    {
        public TRegularMember()
        {
            TRegularMemberAddrests = new HashSet<TRegularMemberAddrest>();
            TRegularMemberBankAccounts = new HashSet<TRegularMemberBankAccount>();
        }

        public string MemberId { get; set; } = null!;
        public string? MemberName { get; set; }
        public string? PersonalNumber { get; set; }
        public string? Phone { get; set; }

        public virtual TMember Member { get; set; } = null!;
        public virtual ICollection<TRegularMemberAddrest> TRegularMemberAddrests { get; set; }
        public virtual ICollection<TRegularMemberBankAccount> TRegularMemberBankAccounts { get; set; }
    }
}
