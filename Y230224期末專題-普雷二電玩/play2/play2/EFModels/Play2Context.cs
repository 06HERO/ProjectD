using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace play2.EFModels
{
    public partial class Play2Context : DbContext
    {
        public Play2Context()
        {
        }

        public Play2Context(DbContextOptions<Play2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TAreaComm> TAreaComms { get; set; } = null!;
        public virtual DbSet<TAreaList> TAreaLists { get; set; } = null!;
        public virtual DbSet<TCommodity> TCommodities { get; set; } = null!;
        public virtual DbSet<TCompanyMember> TCompanyMembers { get; set; } = null!;
        public virtual DbSet<TDeliveryDetail> TDeliveryDetails { get; set; } = null!;
        public virtual DbSet<TDeliveryOrder> TDeliveryOrders { get; set; } = null!;
        public virtual DbSet<TGameDatum> TGameData { get; set; } = null!;
        public virtual DbSet<THostDatum> THostData { get; set; } = null!;
        public virtual DbSet<TMember> TMembers { get; set; } = null!;
        public virtual DbSet<TNews> TNews { get; set; } = null!;
        public virtual DbSet<TNewsType> TNewsTypes { get; set; } = null!;
        public virtual DbSet<TOrderStateList> TOrderStateLists { get; set; } = null!;
        public virtual DbSet<TPurchaseDetail> TPurchaseDetails { get; set; } = null!;
        public virtual DbSet<TPurchaseOrder> TPurchaseOrders { get; set; } = null!;
        public virtual DbSet<TRegularMember> TRegularMembers { get; set; } = null!;
        public virtual DbSet<TRegularMemberAddrest> TRegularMemberAddrests { get; set; } = null!;
        public virtual DbSet<TRegularMemberBankAccount> TRegularMemberBankAccounts { get; set; } = null!;
        public virtual DbSet<TRepair> TRepairs { get; set; } = null!;
        public virtual DbSet<TService> TServices { get; set; } = null!;
        public virtual DbSet<TStockAmount> TStockAmounts { get; set; } = null!;
        public virtual DbSet<TStockroom> TStockrooms { get; set; } = null!;
        public virtual DbSet<TSupplier> TSuppliers { get; set; } = null!;
        public virtual DbSet<TSwiftCode> TSwiftCodes { get; set; } = null!;
        public virtual DbSet<TTagComm> TTagComms { get; set; } = null!;
        public virtual DbSet<TTagList> TTagLists { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;
        public virtual DbSet<View一般會員詳細資料> View一般會員詳細資料s { get; set; } = null!;
        public virtual DbSet<View一般會員資料表> View一般會員資料表s { get; set; } = null!;
        public virtual DbSet<View商品tagid> View商品tagids { get; set; } = null!;
        public virtual DbSet<View商品完整資訊> View商品完整資訊s { get; set; } = null!;
        public virtual DbSet<View商品專區表> View商品專區表s { get; set; } = null!;
        public virtual DbSet<View商品標籤表> View商品標籤表s { get; set; } = null!;
        public virtual DbSet<View商品總分類表> View商品總分類表s { get; set; } = null!;
        public virtual DbSet<View經銷商會員資料表> View經銷商會員資料表s { get; set; } = null!;
        public virtual DbSet<View訂單完整資訊> View訂單完整資訊s { get; set; } = null!;
        public virtual DbSet<View訂單明細品名對照> View訂單明細品名對照s { get; set; } = null!;
        public virtual DbSet<View進貨單> View進貨單s { get; set; } = null!;
        public virtual DbSet<View進貨單新增編輯> View進貨單新增編輯s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Play2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAreaComm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tAreaComm");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.HasOne(d => d.Area)
                    .WithMany()
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_tAreaComm_tAreaList");

                entity.HasOne(d => d.Commodity)
                    .WithMany()
                    .HasForeignKey(d => d.CommodityId)
                    .HasConstraintName("FK_tAreaComm_tCommodity");
            });

            modelBuilder.Entity<TAreaList>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_商品專區列表");

                entity.ToTable("tAreaList");

                entity.Property(e => e.AreaId)
                    .ValueGeneratedNever()
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(50);
            });

            modelBuilder.Entity<TCommodity>(entity =>
            {
                entity.HasKey(e => e.CommodityId)
                    .HasName("PK_商品列表");

                entity.ToTable("tCommodity");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.Categories)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CommodityName).HasMaxLength(50);

                entity.Property(e => e.IsShelves)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.PhotoPath).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(12, 0)");
            });

            modelBuilder.Entity<TCompanyMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("tCompanyMember");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.Addrest).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(20);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CreditLevel).HasMaxLength(10);

                entity.Property(e => e.Credits).HasMaxLength(10);

                entity.Property(e => e.FilePath).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PrincipalMan).HasMaxLength(20);

                entity.Property(e => e.SwiftCode).HasMaxLength(10);

                entity.Property(e => e.TaxIdnumber)
                    .HasMaxLength(10)
                    .HasColumnName("TaxIDNumber")
                    .IsFixedLength();

                entity.HasOne(d => d.Member)
                    .WithOne(p => p.TCompanyMember)
                    .HasForeignKey<TCompanyMember>(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCompanyMember_tMember");
            });

            modelBuilder.Entity<TDeliveryDetail>(entity =>
            {
                entity.HasKey(e => new { e.DelOrderId, e.CommodityId })
                    .HasName("PK_出貨單明細");

                entity.ToTable("tDeliveryDetail");

                entity.Property(e => e.DelOrderId).HasColumnName("DelOrderID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 0)");

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TDeliveryDetails)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDeliveryDetail_tCommodity");

                entity.HasOne(d => d.DelOrder)
                    .WithMany(p => p.TDeliveryDetails)
                    .HasForeignKey(d => d.DelOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDeliveryDetail_tDeliveryOrder");
            });

            modelBuilder.Entity<TDeliveryOrder>(entity =>
            {
                entity.HasKey(e => e.DelOrderId)
                    .HasName("PK_出貨單列表");

                entity.ToTable("tDeliveryOrder");

                entity.Property(e => e.DelOrderId).HasColumnName("DelOrderID");

                entity.Property(e => e.Adderst).HasMaxLength(50);

                entity.Property(e => e.Bankaccount).HasMaxLength(14);

                entity.Property(e => e.Carrier).HasMaxLength(20);

                entity.Property(e => e.ContactMan).HasMaxLength(20);

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.DeliveryPeriod).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Invoice).HasMaxLength(11);

                entity.Property(e => e.Ispay)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LogisticsCost).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.LogisticsMoney).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderMoney)
                    .HasColumnType("decimal(12, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(10);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TDeliveryOrders)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDeliveryOrder_tMember");

                entity.HasOne(d => d.OrderState)
                    .WithMany(p => p.TDeliveryOrders)
                    .HasForeignKey(d => d.OrderStateId)
                    .HasConstraintName("FK_tDeliveryOrder_tOrderStateList");
            });

            modelBuilder.Entity<TGameDatum>(entity =>
            {
                entity.HasKey(e => new { e.CommodityId, e.GameStation });

                entity.ToTable("tGameData");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.GameStation).HasMaxLength(20);

                entity.Property(e => e.Agent).HasMaxLength(50);

                entity.Property(e => e.Developer).HasMaxLength(50);

                entity.Property(e => e.GameType).HasMaxLength(20);

                entity.Property(e => e.PegiRating).HasMaxLength(20);

                entity.Property(e => e.PlayNumber).HasMaxLength(20);

                entity.Property(e => e.Publisher).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasMaxLength(20);

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TGameData)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tGameData_tCommodity");
            });

            modelBuilder.Entity<THostDatum>(entity =>
            {
                entity.HasKey(e => new { e.CommodityId, e.HostColor });

                entity.ToTable("tHostData");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.HostColor).HasMaxLength(20);

                entity.Property(e => e.HostHss)
                    .HasMaxLength(20)
                    .HasColumnName("HostHSS");

                entity.Property(e => e.HostStation).HasMaxLength(20);

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.THostData)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHostData_tCommodity");
            });

            modelBuilder.Entity<TMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK_顧客列表");

                entity.ToTable("tMember");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.IsCheck).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoginEmail).HasMaxLength(30);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(30)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.MemberType).HasMaxLength(10);
            });

            modelBuilder.Entity<TNews>(entity =>
            {
                entity.HasKey(e => e.FNewsId);

                entity.ToTable("tNews");

                entity.Property(e => e.FNewsId).HasColumnName("fNewsId");

                entity.Property(e => e.FNewsContent).HasColumnName("fNewsContent");

                entity.Property(e => e.FNewsDate)
                    .HasColumnType("date")
                    .HasColumnName("fNewsDate");

                entity.Property(e => e.FNewsPhotoPath)
                    .HasMaxLength(50)
                    .HasColumnName("fNewsPhotoPath");

                entity.Property(e => e.FNewsTitle)
                    .HasMaxLength(50)
                    .HasColumnName("fNewsTitle");

                entity.Property(e => e.FNewsType).HasColumnName("fNewsType");

                entity.HasOne(d => d.FNewsTypeNavigation)
                    .WithMany(p => p.TNews)
                    .HasForeignKey(d => d.FNewsType)
                    .HasConstraintName("FK_tNews_tNewsType");
            });

            modelBuilder.Entity<TNewsType>(entity =>
            {
                entity.HasKey(e => e.FNewsTypeId);

                entity.ToTable("tNewsType");

                entity.Property(e => e.FNewsTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("fNewsTypeId");

                entity.Property(e => e.FNewsTypeName)
                    .HasMaxLength(10)
                    .HasColumnName("fNewsTypeName");
            });

            modelBuilder.Entity<TOrderStateList>(entity =>
            {
                entity.HasKey(e => e.OrderStateId);

                entity.ToTable("tOrderStateList");

                entity.Property(e => e.OrderStateId).ValueGeneratedNever();

                entity.Property(e => e.OrderStateName).HasMaxLength(10);
            });

            modelBuilder.Entity<TPurchaseDetail>(entity =>
            {
                entity.HasKey(e => new { e.PurOrderId, e.CommodityId })
                    .HasName("PK_進貨單明細");

                entity.ToTable("tPurchaseDetail");

                entity.Property(e => e.PurOrderId).HasColumnName("PurOrderID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 0)");

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TPurchaseDetails)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tPurchaseDetail_tCommodity");

                entity.HasOne(d => d.PurOrder)
                    .WithMany(p => p.TPurchaseDetails)
                    .HasForeignKey(d => d.PurOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_進貨單明細_進貨單列表1");
            });

            modelBuilder.Entity<TPurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.PurOrderId)
                    .HasName("PK_進貨單列表");

                entity.ToTable("tPurchaseOrder");

                entity.Property(e => e.PurOrderId).HasColumnName("PurOrderID");

                entity.Property(e => e.LogisticsCost).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.PurchaseDate).HasMaxLength(20);

                entity.Property(e => e.StockroomId).HasColumnName("StockroomID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Stockroom)
                    .WithMany(p => p.TPurchaseOrders)
                    .HasForeignKey(d => d.StockroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_進貨單列表_庫存地點列表");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.TPurchaseOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_進貨單列表_廠商列表");
            });

            modelBuilder.Entity<TRegularMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("tRegularMember");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(30);

                entity.Property(e => e.PersonalNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.Member)
                    .WithOne(p => p.TRegularMember)
                    .HasForeignKey<TRegularMember>(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRegularMember_tMember");
            });

            modelBuilder.Entity<TRegularMemberAddrest>(entity =>
            {
                entity.ToTable("tRegularMemberAddrest");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addrest).HasMaxLength(50);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TRegularMemberAddrests)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRegularMemberAddrest_tRegularMember");
            });

            modelBuilder.Entity<TRegularMemberBankAccount>(entity =>
            {
                entity.ToTable("tRegularMemberBankAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAccount).HasMaxLength(20);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.SwiftCode).HasMaxLength(10);

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TRegularMemberBankAccounts)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tRegularMemberBankAccount_tRegularMember");
            });

            modelBuilder.Entity<TRepair>(entity =>
            {
                entity.ToTable("tRepair");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CloseOrpending)
                    .HasMaxLength(10)
                    .HasColumnName("closeORpending")
                    .IsFixedLength();

                entity.Property(e => e.Closedate)
                    .HasMaxLength(10)
                    .HasColumnName("closedate")
                    .IsFixedLength();

                entity.Property(e => e.Describe)
                    .HasMaxLength(50)
                    .HasColumnName("describe")
                    .IsFixedLength();

                entity.Property(e => e.Extention)
                    .HasMaxLength(10)
                    .HasColumnName("extention")
                    .IsFixedLength();

                entity.Property(e => e.Misprocesser)
                    .HasMaxLength(10)
                    .HasColumnName("MISprocesser")
                    .IsFixedLength();

                entity.Property(e => e.Misresponse)
                    .HasMaxLength(50)
                    .HasColumnName("MISresponse")
                    .IsFixedLength();

                entity.Property(e => e.Publisher)
                    .HasMaxLength(10)
                    .HasColumnName("publisher")
                    .IsFixedLength();

                entity.Property(e => e.Registerdate)
                    .HasMaxLength(10)
                    .HasColumnName("registerdate")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TService>(entity =>
            {
                entity.ToTable("tService");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer)
                    .HasMaxLength(100)
                    .HasColumnName("answer")
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength();

                entity.Property(e => e.Question)
                    .HasMaxLength(100)
                    .HasColumnName("question")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TStockAmount>(entity =>
            {
                entity.HasKey(e => new { e.StockroomId, e.CommodityId });

                entity.ToTable("tStockAmount");

                entity.Property(e => e.StockroomId).HasColumnName("StockroomID");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TStockAmounts)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tStockAmount_tCommodity");

                entity.HasOne(d => d.Stockroom)
                    .WithMany(p => p.TStockAmounts)
                    .HasForeignKey(d => d.StockroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_商品在庫數量_庫存地點列表1");
            });

            modelBuilder.Entity<TStockroom>(entity =>
            {
                entity.HasKey(e => e.StockroomId)
                    .HasName("PK_庫存地點列表");

                entity.ToTable("tStockroom");

                entity.Property(e => e.StockroomId)
                    .ValueGeneratedNever()
                    .HasColumnName("StockroomID");

                entity.Property(e => e.Addrest).HasMaxLength(50);

                entity.Property(e => e.Stockroom).HasMaxLength(30);
            });

            modelBuilder.Entity<TSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_廠商列表");

                entity.ToTable("tSupplier");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.BankName).HasMaxLength(20);

                entity.Property(e => e.CapitalAmount).HasMaxLength(50);

                entity.Property(e => e.Cooperation)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PrincipalMan).HasMaxLength(20);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TaxIdnumber)
                    .HasMaxLength(10)
                    .HasColumnName("TaxIDNumber");
            });

            modelBuilder.Entity<TSwiftCode>(entity =>
            {
                entity.ToTable("tSwiftCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BankName).HasMaxLength(10);

                entity.Property(e => e.SwiftCode).HasMaxLength(5);
            });

            modelBuilder.Entity<TTagComm>(entity =>
            {
                entity.HasKey(e => new { e.CommodityId, e.TagId });

                entity.ToTable("tTagComm");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Test)
                    .HasMaxLength(10)
                    .HasColumnName("test")
                    .IsFixedLength();

                entity.HasOne(d => d.Commodity)
                    .WithMany(p => p.TTagComms)
                    .HasForeignKey(d => d.CommodityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTagComm_tCommodity");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TTagComms)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_商品標籤_商品標籤列表");
            });

            modelBuilder.Entity<TTagList>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_商品標籤列表");

                entity.ToTable("tTagList");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagName).HasMaxLength(50);
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK_使用者列表");

                entity.ToTable("tUser");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(20)
                    .HasColumnName("LoginID");

                entity.Property(e => e.Admin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(20)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.Users).HasMaxLength(20);
            });

            modelBuilder.Entity<View一般會員詳細資料>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_一般會員詳細資料");

                entity.Property(e => e.Addrest).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(20);

                entity.Property(e => e.LoginEmail).HasMaxLength(30);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(30)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(30);

                entity.Property(e => e.MemberType).HasMaxLength(10);

                entity.Property(e => e.PersonalNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.SwiftCode).HasMaxLength(10);
            });

            modelBuilder.Entity<View一般會員資料表>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_一般會員資料表");

                entity.Property(e => e.LoginEmail).HasMaxLength(30);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(30)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(30);

                entity.Property(e => e.MemberType).HasMaxLength(10);

                entity.Property(e => e.PersonalNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Phone).HasMaxLength(20);
            });

            modelBuilder.Entity<View商品tagid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_商品tagid");

                entity.Property(e => e.Agent).HasMaxLength(50);

                entity.Property(e => e.Categories)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CommodityName).HasMaxLength(50);

                entity.Property(e => e.Developer).HasMaxLength(50);

                entity.Property(e => e.GameStation).HasMaxLength(20);

                entity.Property(e => e.IsShelves)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.PegiRating).HasMaxLength(20);

                entity.Property(e => e.PhotoPath).HasMaxLength(50);

                entity.Property(e => e.PlayNumber).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Publisher).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasMaxLength(20);

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagName).HasMaxLength(50);
            });

            modelBuilder.Entity<View商品完整資訊>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_商品完整資訊");

                entity.Property(e => e.Agent).HasMaxLength(50);

                entity.Property(e => e.Categories)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CommodityName).HasMaxLength(50);

                entity.Property(e => e.Developer).HasMaxLength(50);

                entity.Property(e => e.GameStation).HasMaxLength(20);

                entity.Property(e => e.GameType).HasMaxLength(20);

                entity.Property(e => e.HostColor).HasMaxLength(20);

                entity.Property(e => e.HostHss)
                    .HasMaxLength(20)
                    .HasColumnName("HostHSS");

                entity.Property(e => e.HostStation).HasMaxLength(20);

                entity.Property(e => e.IsShelves)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.PegiRating).HasMaxLength(20);

                entity.Property(e => e.PhotoPath).HasMaxLength(50);

                entity.Property(e => e.PlayNumber).HasMaxLength(20);

                entity.Property(e => e.Price).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.Publisher).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate).HasMaxLength(20);

                entity.Property(e => e.StockroomId).HasColumnName("StockroomID");
            });

            modelBuilder.Entity<View商品專區表>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_商品專區表");

                entity.Property(e => e.售價).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.商品id).HasColumnName("商品ID");

                entity.Property(e => e.商品名稱).HasMaxLength(50);

                entity.Property(e => e.商品專區).HasMaxLength(50);

                entity.Property(e => e.商品專區id).HasColumnName("商品專區ID");

                entity.Property(e => e.照片路徑).HasMaxLength(50);
            });

            modelBuilder.Entity<View商品標籤表>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_商品標籤表");

                entity.Property(e => e.售價).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.商品id).HasColumnName("商品ID");

                entity.Property(e => e.商品名稱).HasMaxLength(50);

                entity.Property(e => e.商品標籤).HasMaxLength(50);

                entity.Property(e => e.商品標籤id).HasColumnName("商品標籤ID");

                entity.Property(e => e.照片路徑).HasMaxLength(50);
            });

            modelBuilder.Entity<View商品總分類表>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_商品總分類表");

                entity.Property(e => e.售價).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.商品id).HasColumnName("商品ID");

                entity.Property(e => e.商品名稱).HasMaxLength(50);

                entity.Property(e => e.商品專區).HasMaxLength(50);

                entity.Property(e => e.商品專區id).HasColumnName("商品專區ID");

                entity.Property(e => e.商品標籤).HasMaxLength(50);

                entity.Property(e => e.商品標籤id).HasColumnName("商品標籤ID");

                entity.Property(e => e.照片路徑).HasMaxLength(50);
            });

            modelBuilder.Entity<View經銷商會員資料表>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_經銷商會員資料表");

                entity.Property(e => e.Addrest).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(20);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CreditLevel).HasMaxLength(10);

                entity.Property(e => e.Credits).HasMaxLength(10);

                entity.Property(e => e.FilePath).HasMaxLength(50);

                entity.Property(e => e.LoginEmail).HasMaxLength(30);

                entity.Property(e => e.LoginPw)
                    .HasMaxLength(30)
                    .HasColumnName("LoginPW");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberType).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PrincipalMan).HasMaxLength(20);

                entity.Property(e => e.SwiftCode).HasMaxLength(10);

                entity.Property(e => e.TaxIdnumber)
                    .HasMaxLength(10)
                    .HasColumnName("TaxIDNumber")
                    .IsFixedLength();
            });

            modelBuilder.Entity<View訂單完整資訊>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_訂單完整資訊");

                entity.Property(e => e.Adderst).HasMaxLength(50);

                entity.Property(e => e.Bankaccount).HasMaxLength(14);

                entity.Property(e => e.CompPhone).HasMaxLength(20);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContactMan).HasMaxLength(20);

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.DelOrderId).HasColumnName("DelOrderID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Ispay)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LogisticsMoney).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(30)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MemberName).HasMaxLength(30);

                entity.Property(e => e.MemberType).HasMaxLength(10);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderStateName).HasMaxLength(10);

                entity.Property(e => e.ReguPhone).HasMaxLength(20);

                entity.Property(e => e.SwiftCode).HasMaxLength(10);
            });

            modelBuilder.Entity<View訂單明細品名對照>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_訂單明細品名對照");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.CommodityName).HasMaxLength(50);

                entity.Property(e => e.DelOrderId).HasColumnName("DelOrderID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(12, 0)");
            });

            modelBuilder.Entity<View進貨單>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_進貨單");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.StockroomId).HasColumnName("StockroomID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.供應商名稱).HasMaxLength(50);

                entity.Property(e => e.倉庫別).HasMaxLength(30);

                entity.Property(e => e.商品名稱).HasMaxLength(50);

                entity.Property(e => e.單價).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.小計).HasColumnType("decimal(23, 0)");

                entity.Property(e => e.進貨日期).HasMaxLength(20);
            });

            modelBuilder.Entity<View進貨單新增編輯>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_進貨單新增編輯");

                entity.Property(e => e.CommodityId).HasColumnName("CommodityID");

                entity.Property(e => e.StockroomId).HasColumnName("StockroomID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.供應商名稱).HasMaxLength(50);

                entity.Property(e => e.倉庫別).HasMaxLength(30);

                entity.Property(e => e.商品名稱).HasMaxLength(50);

                entity.Property(e => e.單價).HasColumnType("decimal(12, 0)");

                entity.Property(e => e.小計).HasColumnType("decimal(23, 0)");

                entity.Property(e => e.進貨日期).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
