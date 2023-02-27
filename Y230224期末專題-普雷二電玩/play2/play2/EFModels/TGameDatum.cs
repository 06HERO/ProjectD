using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class TGameDatum
    {
        public int CommodityId { get; set; }
        public string GameStation { get; set; } = null!;
        public string? GameType { get; set; }
        public string? ReleaseDate { get; set; }
        public string? PlayNumber { get; set; }
        public string? PegiRating { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? Agent { get; set; }
        public string? OfficialWebsite { get; set; }
        public string? Profile { get; set; }

        public virtual TCommodity Commodity { get; set; } = null!;
    }
}
