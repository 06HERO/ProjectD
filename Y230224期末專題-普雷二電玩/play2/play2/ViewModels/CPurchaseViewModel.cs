namespace play2.ViewModels
{
    public class CPurchaseViewModel
    {
        public int PurOrderId { get; set; }
        public int SupplierId { get; set; }
        public int StockroomId { get; set; }
        public string? PurchaseDate { get; set; }
        public decimal? PurchaseCost { get; set; }
        public decimal? LogisticsCost { get; set; }
        public string? Notes { get; set; }
        public int CommodityId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Qty { get; set; }
        public decimal? Sum { get; set; }
    }
}
