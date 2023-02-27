using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TRegularMemberBankAccount
    {
        public int Id { get; set; }
        public string MemberId { get; set; } = null!;
        public string SwiftCode { get; set; } = null!;
        public string BankAccount { get; set; } = null!;

        public virtual TRegularMember Member { get; set; } = null!;
    }
}
