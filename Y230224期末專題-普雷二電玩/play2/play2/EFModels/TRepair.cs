using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TRepair
    {
        public int Id { get; set; }
        public string Publisher { get; set; } = null!;
        public string Extention { get; set; } = null!;
        public string Describe { get; set; } = null!;
        public string Registerdate { get; set; } = null!;
        public string? Misprocesser { get; set; }
        public string? Misresponse { get; set; }
        public string? CloseOrpending { get; set; }
        public string? Closedate { get; set; }
    }
}
