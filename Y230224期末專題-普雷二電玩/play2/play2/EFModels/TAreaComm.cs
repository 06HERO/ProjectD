using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TAreaComm
    {
        public int? AreaId { get; set; }
        public int? CommodityId { get; set; }

        public virtual TAreaList? Area { get; set; }
        public virtual TCommodity? Commodity { get; set; }
    }
}
