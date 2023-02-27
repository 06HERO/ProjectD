using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class THostDatum
    {
        public int CommodityId { get; set; }
        public string HostColor { get; set; } = null!;
        public string? HostStation { get; set; }
        public string? HostHss { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
    }
}
