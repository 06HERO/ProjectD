using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TTagComm
    {
        public int CommodityId { get; set; }
        public int TagId { get; set; }
        public string? Test { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
        public virtual TTagList Tag { get; set; } = null!;
    }
}
