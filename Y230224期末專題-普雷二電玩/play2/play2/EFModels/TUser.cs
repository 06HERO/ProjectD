using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TUser
    {
        public string LoginId { get; set; } = null!;
        public string LoginPw { get; set; } = null!;
        public string Users { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte? Admin { get; set; }
    }
}
