using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TRegularMemberAddrest
    {
        public int Id { get; set; }
        public string MemberId { get; set; } = null!;
        public string Addrest { get; set; } = null!;

        public virtual TRegularMember Member { get; set; } = null!;
    }
}
