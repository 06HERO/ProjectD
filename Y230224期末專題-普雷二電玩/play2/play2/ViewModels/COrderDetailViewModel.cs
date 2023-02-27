using play2.EFModels;

namespace play2.ViewModels
{
    public class COrderDetailViewModel
    {

        private View訂單完整資訊 _View訂單完整資訊;




        public COrderDetailViewModel()
        {
            _View訂單完整資訊 = new View訂單完整資訊();

        }
        public View訂單完整資訊 View訂單完整資訊
        {
            get { return _View訂單完整資訊; }
            set { _View訂單完整資訊 = value; }
        }
        public int DelOrderId
        {
            get { return _View訂單完整資訊.DelOrderId; }
            set { _View訂單完整資訊.DelOrderId = value; }
        }
        public string MemberId
        {
            get { return _View訂單完整資訊.MemberId; }
            set { _View訂單完整資訊.MemberId = value; }
        }
        public string? MemberName
        {
            get { return _View訂單完整資訊.MemberName; }
            set { _View訂單完整資訊.MemberName = value; }
        }
    
        public string? ReguPhone
        {
            get { return _View訂單完整資訊.ReguPhone; }
            set { _View訂單完整資訊.ReguPhone = value; }
        }
        public string? ContactMan
        {
            get { return _View訂單完整資訊.ContactMan; }
            set { _View訂單完整資訊.ContactMan = value; }
        }
        public string? ContactPhone
        {
            get { return _View訂單完整資訊.ContactPhone; }
            set { _View訂單完整資訊.ContactPhone = value; }
        }
        public DateTime? DeliveryDate
        {
            get { return _View訂單完整資訊.DeliveryDate; }
            set { _View訂單完整資訊.DeliveryDate = value; }
        }
        public DateTime? OrderDate
        {
            get { return _View訂單完整資訊.OrderDate; }
            set { _View訂單完整資訊.OrderDate = value; }
        }
        public string? Adderst
        {
            get { return _View訂單完整資訊.Adderst; }
            set { _View訂單完整資訊.Adderst = value; }
        }

        public int? OrderStateId
        {
            get { return _View訂單完整資訊.OrderStateId; }
            set { _View訂單完整資訊.OrderStateId = value; }
        }
        public string? OrderStateName
        {
            get { return _View訂單完整資訊.OrderStateName; }
            set { _View訂單完整資訊.OrderStateName = value; }
        }
        public string? Notes
        {
            get { return _View訂單完整資訊.Notes; }
            set { _View訂單完整資訊.Notes = value; }
        }
        public string? MemberType
        {
            get { return _View訂單完整資訊.MemberType; }
            set { _View訂單完整資訊.MemberType = value; }
        }
        public string? CompanyName
        {
            get { return _View訂單完整資訊.CompanyName; }
            set { _View訂單完整資訊.CompanyName = value; }
        }
        public string? CompPhone
        {
            get { return _View訂單完整資訊.CompPhone; }
            set { _View訂單完整資訊.CompPhone = value; }
        }

        public decimal? LogisticsMoney
        {
            get { return _View訂單完整資訊.LogisticsMoney; }
            set { _View訂單完整資訊.LogisticsMoney = value; }
        }



        public List<View訂單明細品名對照> OrderDetails{get;set;}


    }
}
