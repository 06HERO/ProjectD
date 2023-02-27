using System;
using System.Collections.Generic;

namespace play2.EFModels
{
    public partial class View商品完整資訊
    {
        public int CommodityId { get; set; }
        public string? CommodityName { get; set; }
        public string? PhotoPath { get; set; }
        public decimal? Price { get; set; }
        public string? IsShelves { get; set; }
        public string? Categories { get; set; }
        public int? StockroomId { get; set; }
        public int? StockQty { get; set; }
        public string? GameStation { get; set; }
        public string? GameType { get; set; }
        public string? ReleaseDate { get; set; }
        public string? PlayNumber { get; set; }
        public string? PegiRating { get; set; }
        public string? Developer { get; set; }
        public string? Publisher { get; set; }
        public string? Agent { get; set; }
        public string? OfficialWebsite { get; set; }
        public string? Profile { get; set; }
        public string? HostColor { get; set; }
        public string? HostStation { get; set; }
        public string? HostHss { get; set; }
    }
}
