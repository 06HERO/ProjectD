using System.ComponentModel;
using play2.EFModels;




namespace play2.ViewModels
{

    public class CProductViewModel
    {
        private TCommodity _TCommodity;
        private TGameDatum _TGameData;
        private TStockAmount _TStockAmount;
        private TTagComm _TTagComm;
        private THostDatum _THostData;  
        public CProductViewModel()
        {
            _TCommodity = new TCommodity();
            _TGameData = new TGameDatum();
            _TStockAmount = new TStockAmount();
            _TTagComm = new TTagComm();
            _THostData=new THostDatum();
        }


        public THostDatum THostData
        {
            get { return _THostData; }
            set { _THostData = value; }
        }

        public TCommodity Commodity
        {
            get { return _TCommodity; }
            set { _TCommodity = value; }
        }

        public TGameDatum GameData
        {
            get { return _TGameData; }
            set { _TGameData = value; }
        }
        public TStockAmount StockAmount
        {
            get { return _TStockAmount; }
            set { _TStockAmount = value; }
        }
        public TTagComm TagComm
        {
            get { return _TTagComm; }
            set { _TTagComm = value; }
        }

        public List<TTagComm> TagComms { get;set; }


        public int CommodityId
        {
            get { return _TCommodity.CommodityId; }
            set { _TCommodity.CommodityId = value; }
        }
        public string? CommodityName
        {
            get { return _TCommodity.CommodityName; }
            set { _TCommodity.CommodityName = value; }
        }
        public decimal? Price
        {
            get { return _TCommodity.Price; }
            set { _TCommodity.Price = value; }
        }


        public string? IsShelves
        {
            get { return _TCommodity.IsShelves; }
            set { _TCommodity.IsShelves = value; }
        }

        public string? Categories
        {
            get { return _TCommodity.Categories; }
            set { _TCommodity.Categories = value; }
        }

        public string? PhotoPath
        {
            get { return _TCommodity.PhotoPath; }
            set { _TCommodity.PhotoPath = value; }
        }

        public int? StockQty
        {
            get { return _TStockAmount.StockQty; }
            set { _TStockAmount.StockQty = value; }
        }

        public string? GameStation
        {
            get { return _TGameData.GameStation; }
            set { _TGameData.GameStation = value; }
        }
        public string? GameType
        {
            get { return _TGameData.GameType; }
            set { _TGameData.GameType = value; }
        }

        public string? ReleaseDate
        {
            get { return _TGameData.ReleaseDate; }
            set { _TGameData.ReleaseDate = value; }
        }

        public string? PlayNumber
        {
            get { return _TGameData.PlayNumber; }
            set { _TGameData.PlayNumber = value; }
        }

        public string? PegiRating
        {
            get { return _TGameData.PegiRating; }
            set { _TGameData.PegiRating = value; }
        }

        public string? Developer
        {
            get { return _TGameData.Developer; }
            set { _TGameData.Developer = value; }
        }

        public string? Publisher
        {
            get { return _TGameData.Publisher; }
            set { _TGameData.Publisher = value; }
        }
        public string? Agent
        {
            get { return _TGameData.Agent; }
            set { _TGameData.Agent = value; }
        }
        public string? OfficialWebsite
        {
            get { return _TGameData.OfficialWebsite; }
            set { _TGameData.OfficialWebsite = value; }
        }

        public string? Profile
        {
            get { return _TGameData.Profile; }
            set { _TGameData.Profile = value; }
        }
        public int CommodityIdForComm
        {
            get { return _TTagComm.CommodityId; }
            set { _TTagComm.CommodityId = value; }
        }
        public int TagId
        {
            get { return _TTagComm.TagId; }
            set { _TTagComm.TagId = value; }
        }
        public string HostColor
        {
            get { return _THostData.HostColor; }
            set { _THostData.HostColor = value; }
        }
        public string? HostStation
        {
            get { return _THostData.HostStation; }
            set { _THostData.HostStation = value; }
        }
        public string? HostHss
        {
            get { return _THostData.HostHss; }
            set { _THostData.HostHss = value; }
        }
        public IFormFile photo { get; set; }

       
 
}
    
}
