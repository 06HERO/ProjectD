﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class 普雷二電玩Entities : DbContext
    {
        public 普雷二電玩Entities()
            : base("name=普雷二電玩Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<商品列表> 商品列表 { get; set; }
        public virtual DbSet<商品類型列表> 商品類型列表 { get; set; }
        public virtual DbSet<廠商列表> 廠商列表 { get; set; }
        public virtual DbSet<進貨單列表> 進貨單列表 { get; set; }
        public virtual DbSet<進貨單明細> 進貨單明細 { get; set; }
        public virtual DbSet<庫存地點列表> 庫存地點列表 { get; set; }
        public virtual DbSet<商品在庫數量> 商品在庫數量 { get; set; }
        public virtual DbSet<使用者列表> 使用者列表 { get; set; }
    
        public virtual int Insert廠商列表(Nullable<byte> 廠商ID, string 廠商名稱, string 統一編號, string 代表人姓名, Nullable<decimal> 資本總額, string 聯絡電話, string 顯示與否)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 廠商名稱Parameter = 廠商名稱 != null ?
                new ObjectParameter("廠商名稱", 廠商名稱) :
                new ObjectParameter("廠商名稱", typeof(string));
    
            var 統一編號Parameter = 統一編號 != null ?
                new ObjectParameter("統一編號", 統一編號) :
                new ObjectParameter("統一編號", typeof(string));
    
            var 代表人姓名Parameter = 代表人姓名 != null ?
                new ObjectParameter("代表人姓名", 代表人姓名) :
                new ObjectParameter("代表人姓名", typeof(string));
    
            var 資本總額Parameter = 資本總額.HasValue ?
                new ObjectParameter("資本總額", 資本總額) :
                new ObjectParameter("資本總額", typeof(decimal));
    
            var 聯絡電話Parameter = 聯絡電話 != null ?
                new ObjectParameter("聯絡電話", 聯絡電話) :
                new ObjectParameter("聯絡電話", typeof(string));
    
            var 顯示與否Parameter = 顯示與否 != null ?
                new ObjectParameter("顯示與否", 顯示與否) :
                new ObjectParameter("顯示與否", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert廠商列表", 廠商IDParameter, 廠商名稱Parameter, 統一編號Parameter, 代表人姓名Parameter, 資本總額Parameter, 聯絡電話Parameter, 顯示與否Parameter);
        }
    
        public virtual int Delete廠商列表(Nullable<byte> 廠商ID)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete廠商列表", 廠商IDParameter);
        }
    
        public virtual int Update廠商列表(Nullable<byte> 廠商ID, string 廠商名稱, string 統一編號, string 代表人姓名, Nullable<decimal> 資本總額, string 聯絡電話, string 顯示與否)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 廠商名稱Parameter = 廠商名稱 != null ?
                new ObjectParameter("廠商名稱", 廠商名稱) :
                new ObjectParameter("廠商名稱", typeof(string));
    
            var 統一編號Parameter = 統一編號 != null ?
                new ObjectParameter("統一編號", 統一編號) :
                new ObjectParameter("統一編號", typeof(string));
    
            var 代表人姓名Parameter = 代表人姓名 != null ?
                new ObjectParameter("代表人姓名", 代表人姓名) :
                new ObjectParameter("代表人姓名", typeof(string));
    
            var 資本總額Parameter = 資本總額.HasValue ?
                new ObjectParameter("資本總額", 資本總額) :
                new ObjectParameter("資本總額", typeof(decimal));
    
            var 聯絡電話Parameter = 聯絡電話 != null ?
                new ObjectParameter("聯絡電話", 聯絡電話) :
                new ObjectParameter("聯絡電話", typeof(string));
    
            var 顯示與否Parameter = 顯示與否 != null ?
                new ObjectParameter("顯示與否", 顯示與否) :
                new ObjectParameter("顯示與否", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update廠商列表", 廠商IDParameter, 廠商名稱Parameter, 統一編號Parameter, 代表人姓名Parameter, 資本總額Parameter, 聯絡電話Parameter, 顯示與否Parameter);
        }
    
        public virtual int Delete商品類型列表(Nullable<byte> 商品類型ID)
        {
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete商品類型列表", 商品類型IDParameter);
        }
    
        public virtual int Insert商品類型列表(Nullable<byte> 商品類型ID, string 商品類型名稱)
        {
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            var 商品類型名稱Parameter = 商品類型名稱 != null ?
                new ObjectParameter("商品類型名稱", 商品類型名稱) :
                new ObjectParameter("商品類型名稱", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert商品類型列表", 商品類型IDParameter, 商品類型名稱Parameter);
        }
    
        public virtual int Update商品類型列表(Nullable<byte> 商品類型ID, string 商品類型名稱)
        {
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            var 商品類型名稱Parameter = 商品類型名稱 != null ?
                new ObjectParameter("商品類型名稱", 商品類型名稱) :
                new ObjectParameter("商品類型名稱", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update商品類型列表", 商品類型IDParameter, 商品類型名稱Parameter);
        }
    
        public virtual int Delete商品列表(Nullable<byte> 廠商ID, Nullable<byte> 商品類型ID, Nullable<short> 商品ID)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            var 商品IDParameter = 商品ID.HasValue ?
                new ObjectParameter("商品ID", 商品ID) :
                new ObjectParameter("商品ID", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete商品列表", 廠商IDParameter, 商品類型IDParameter, 商品IDParameter);
        }
    
        public virtual int Insert商品列表(Nullable<byte> 廠商ID, Nullable<byte> 商品類型ID, Nullable<short> 商品ID, string 商品名稱, Nullable<decimal> 進貨價, Nullable<decimal> 零售價)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            var 商品IDParameter = 商品ID.HasValue ?
                new ObjectParameter("商品ID", 商品ID) :
                new ObjectParameter("商品ID", typeof(short));
    
            var 商品名稱Parameter = 商品名稱 != null ?
                new ObjectParameter("商品名稱", 商品名稱) :
                new ObjectParameter("商品名稱", typeof(string));
    
            var 進貨價Parameter = 進貨價.HasValue ?
                new ObjectParameter("進貨價", 進貨價) :
                new ObjectParameter("進貨價", typeof(decimal));
    
            var 零售價Parameter = 零售價.HasValue ?
                new ObjectParameter("零售價", 零售價) :
                new ObjectParameter("零售價", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert商品列表", 廠商IDParameter, 商品類型IDParameter, 商品IDParameter, 商品名稱Parameter, 進貨價Parameter, 零售價Parameter);
        }
    
        public virtual int Update商品列表(Nullable<byte> 廠商ID, Nullable<byte> 商品類型ID, Nullable<short> 商品ID, string 商品名稱, Nullable<decimal> 進貨價, Nullable<decimal> 零售價)
        {
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 商品類型IDParameter = 商品類型ID.HasValue ?
                new ObjectParameter("商品類型ID", 商品類型ID) :
                new ObjectParameter("商品類型ID", typeof(byte));
    
            var 商品IDParameter = 商品ID.HasValue ?
                new ObjectParameter("商品ID", 商品ID) :
                new ObjectParameter("商品ID", typeof(short));
    
            var 商品名稱Parameter = 商品名稱 != null ?
                new ObjectParameter("商品名稱", 商品名稱) :
                new ObjectParameter("商品名稱", typeof(string));
    
            var 進貨價Parameter = 進貨價.HasValue ?
                new ObjectParameter("進貨價", 進貨價) :
                new ObjectParameter("進貨價", typeof(decimal));
    
            var 零售價Parameter = 零售價.HasValue ?
                new ObjectParameter("零售價", 零售價) :
                new ObjectParameter("零售價", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update商品列表", 廠商IDParameter, 商品類型IDParameter, 商品IDParameter, 商品名稱Parameter, 進貨價Parameter, 零售價Parameter);
        }
    
        [DbFunction("普雷二電玩Entities", "fn_商品列表")]
        public virtual IQueryable<fn_商品列表_Result> fn_商品列表()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_商品列表_Result>("[普雷二電玩Entities].[fn_商品列表]()");
        }
    
        [DbFunction("普雷二電玩Entities", "fn_庫存列表")]
        public virtual IQueryable<fn_庫存列表_Result> fn_庫存列表()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_庫存列表_Result>("[普雷二電玩Entities].[fn_庫存列表]()");
        }
    
        [DbFunction("普雷二電玩Entities", "fn_進貨單列表")]
        public virtual IQueryable<fn_進貨單列表_Result> fn_進貨單列表()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_進貨單列表_Result>("[普雷二電玩Entities].[fn_進貨單列表]()");
        }
    
        [DbFunction("普雷二電玩Entities", "fn_進貨單明細")]
        public virtual IQueryable<fn_進貨單明細_Result> fn_進貨單明細()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_進貨單明細_Result>("[普雷二電玩Entities].[fn_進貨單明細]()");
        }
    
        [DbFunction("普雷二電玩Entities", "fn_總商品庫存表")]
        public virtual IQueryable<fn_總商品庫存表_Result> fn_總商品庫存表()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_總商品庫存表_Result>("[普雷二電玩Entities].[fn_總商品庫存表]()");
        }
    
        public virtual int Delete進貨單列表(Nullable<int> 進貨單編號)
        {
            var 進貨單編號Parameter = 進貨單編號.HasValue ?
                new ObjectParameter("進貨單編號", 進貨單編號) :
                new ObjectParameter("進貨單編號", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete進貨單列表", 進貨單編號Parameter);
        }
    
        public virtual int Insert進貨單列表(Nullable<int> 進貨單編號, Nullable<byte> 廠商ID, Nullable<int> 庫存地點ID, Nullable<System.DateTime> 進貨日期, Nullable<byte> 明細筆數)
        {
            var 進貨單編號Parameter = 進貨單編號.HasValue ?
                new ObjectParameter("進貨單編號", 進貨單編號) :
                new ObjectParameter("進貨單編號", typeof(int));
    
            var 廠商IDParameter = 廠商ID.HasValue ?
                new ObjectParameter("廠商ID", 廠商ID) :
                new ObjectParameter("廠商ID", typeof(byte));
    
            var 庫存地點IDParameter = 庫存地點ID.HasValue ?
                new ObjectParameter("庫存地點ID", 庫存地點ID) :
                new ObjectParameter("庫存地點ID", typeof(int));
    
            var 進貨日期Parameter = 進貨日期.HasValue ?
                new ObjectParameter("進貨日期", 進貨日期) :
                new ObjectParameter("進貨日期", typeof(System.DateTime));
    
            var 明細筆數Parameter = 明細筆數.HasValue ?
                new ObjectParameter("明細筆數", 明細筆數) :
                new ObjectParameter("明細筆數", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert進貨單列表", 進貨單編號Parameter, 廠商IDParameter, 庫存地點IDParameter, 進貨日期Parameter, 明細筆數Parameter);
        }
    
        public virtual int Update進貨單列表(Nullable<int> 進貨單編號, Nullable<int> 庫存地點ID, Nullable<System.DateTime> 進貨日期, Nullable<byte> 明細筆數)
        {
            var 進貨單編號Parameter = 進貨單編號.HasValue ?
                new ObjectParameter("進貨單編號", 進貨單編號) :
                new ObjectParameter("進貨單編號", typeof(int));
    
            var 庫存地點IDParameter = 庫存地點ID.HasValue ?
                new ObjectParameter("庫存地點ID", 庫存地點ID) :
                new ObjectParameter("庫存地點ID", typeof(int));
    
            var 進貨日期Parameter = 進貨日期.HasValue ?
                new ObjectParameter("進貨日期", 進貨日期) :
                new ObjectParameter("進貨日期", typeof(System.DateTime));
    
            var 明細筆數Parameter = 明細筆數.HasValue ?
                new ObjectParameter("明細筆數", 明細筆數) :
                new ObjectParameter("明細筆數", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update進貨單列表", 進貨單編號Parameter, 庫存地點IDParameter, 進貨日期Parameter, 明細筆數Parameter);
        }
    
        public virtual int Update使用者PW(string loginID, string loginPW)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var loginPWParameter = loginPW != null ?
                new ObjectParameter("LoginPW", loginPW) :
                new ObjectParameter("LoginPW", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update使用者PW", loginIDParameter, loginPWParameter);
        }
    
        public virtual int 使用者LoginByPW(string loginID, string loginPW, ObjectParameter isAdmin, ObjectParameter isCheck)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var loginPWParameter = loginPW != null ?
                new ObjectParameter("LoginPW", loginPW) :
                new ObjectParameter("LoginPW", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("使用者LoginByPW", loginIDParameter, loginPWParameter, isAdmin, isCheck);
        }
    
        public virtual int 使用者LoginByCheckCode(string loginID, string checkCode)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var checkCodeParameter = checkCode != null ?
                new ObjectParameter("CheckCode", checkCode) :
                new ObjectParameter("CheckCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("使用者LoginByCheckCode", loginIDParameter, checkCodeParameter);
        }
    
        public virtual int Delete使用者列表(string loginID)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete使用者列表", loginIDParameter);
        }
    
        public virtual int Insert使用者列表(string loginID, string loginPW, Nullable<short> isAdmin, string email, Nullable<byte> isCheck)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var loginPWParameter = loginPW != null ?
                new ObjectParameter("LoginPW", loginPW) :
                new ObjectParameter("LoginPW", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(short));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isCheckParameter = isCheck.HasValue ?
                new ObjectParameter("IsCheck", isCheck) :
                new ObjectParameter("IsCheck", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert使用者列表", loginIDParameter, loginPWParameter, isAdminParameter, emailParameter, isCheckParameter);
        }
    
        public virtual int Update使用者列表(string loginID, string loginPW, Nullable<short> isAdmin, string email, Nullable<byte> isCheck)
        {
            var loginIDParameter = loginID != null ?
                new ObjectParameter("LoginID", loginID) :
                new ObjectParameter("LoginID", typeof(string));
    
            var loginPWParameter = loginPW != null ?
                new ObjectParameter("LoginPW", loginPW) :
                new ObjectParameter("LoginPW", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(short));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isCheckParameter = isCheck.HasValue ?
                new ObjectParameter("IsCheck", isCheck) :
                new ObjectParameter("IsCheck", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update使用者列表", loginIDParameter, loginPWParameter, isAdminParameter, emailParameter, isCheckParameter);
        }
    
        [DbFunction("普雷二電玩Entities", "fn_使用者列表")]
        public virtual IQueryable<fn_使用者列表_Result> fn_使用者列表()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_使用者列表_Result>("[普雷二電玩Entities].[fn_使用者列表]()");
        }
    }
}
