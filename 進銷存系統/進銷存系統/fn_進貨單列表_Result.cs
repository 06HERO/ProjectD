//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 進銷存系統
{
    using System;
    
    public partial class fn_進貨單列表_Result
    {
        public int 進貨單編號 { get; set; }
        public byte 廠商ID { get; set; }
        public string 廠商名稱 { get; set; }
        public int 庫存地點ID { get; set; }
        public string 庫存地點 { get; set; }
        public System.DateTime 進貨日期 { get; set; }
        public byte 明細筆數 { get; set; }
        public Nullable<decimal> 進貨成本 { get; set; }
    }
}
