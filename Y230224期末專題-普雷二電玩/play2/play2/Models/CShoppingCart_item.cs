using play2.EFModels;
using System.Runtime.CompilerServices;

namespace play2.Models
{
    public class CShoppingCart_item
    {
        
        public CShoppingCart_item() {
         
        }
        public int CommodityId { get; set; }
        public decimal cost { get; set; }
        public decimal price { get;set; }
        public int qty { get; set; }
        public decimal freight { get; set; }
        public decimal total_price { get; set; }
        
        public View商品完整資訊 product{ get; set; }//引用物件
        public View商品標籤表 plist { get; set; }//引用商品標籤
        
        public int note { get; set; }
        public int iDelOrderId { get; set; }
        public List<View訂單明細品名對照> items_List { get; set; }
        public List<View訂單完整資訊> items_Order { get; set; }
        public List<View商品tagid> tags_List { get; set; }
        public string member_id { get; set; }
        public string member_address { get; set; }
        public string member_name { get; set; }
        public string member_phone { get; set;}
        public string member_email { get; set; }
        public string member_Bank_num { get; set; }
        public string member_Card_Num { get; set;}
    
    }
}
