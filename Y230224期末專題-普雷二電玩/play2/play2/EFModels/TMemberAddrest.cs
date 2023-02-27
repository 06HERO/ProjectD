using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TMemberAddrest
    {
        public string MemberId { get; set; } = null!;
        public string Addrest { get; set; } = null!;

        public virtual TMember Member { get; set; } = null!;
    }
}
