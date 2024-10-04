using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestGridSelectFile.Models;

public partial class GmsContext : DbContext
{
    public GmsContext()
    {
    }

    public GmsContext(DbContextOptions<GmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CashCashInward> CashCashInwards { get; set; }

    public virtual DbSet<CashCashSummaryView> CashCashSummaryViews { get; set; }

    public virtual DbSet<CashCreditClearingBalanceView> CashCreditClearingBalanceViews { get; set; }

    public virtual DbSet<CustomerCustomer> CustomerCustomers { get; set; }

    public virtual DbSet<GoldBarGoldBarCredit> GoldBarGoldBarCredits { get; set; }

    public virtual DbSet<GoldBarGoldBarInventory> GoldBarGoldBarInventories { get; set; }

    public virtual DbSet<GoldBarGoldBarInventoryTransfer> GoldBarGoldBarInventoryTransfers { get; set; }

    public virtual DbSet<GoldBarGoldBarTransaction> GoldBarGoldBarTransactions { get; set; }

    public virtual DbSet<GoldBarGoldBarTransactionDetail> GoldBarGoldBarTransactionDetails { get; set; }

    public virtual DbSet<GoldBarInventoryBalanceView> GoldBarInventoryBalanceViews { get; set; }

    public virtual DbSet<GoldBarInventoryIssue> GoldBarInventoryIssues { get; set; }

    public virtual DbSet<GoldBarInventoryReceive> GoldBarInventoryReceives { get; set; }

    public virtual DbSet<JewelJewel> JewelJewels { get; set; }

    public virtual DbSet<JewelJewelAttachment> JewelJewelAttachments { get; set; }

    public virtual DbSet<JewelJewelInventory> JewelJewelInventories { get; set; }

    public virtual DbSet<JewelJewelInventoryBalanceView> JewelJewelInventoryBalanceViews { get; set; }

    public virtual DbSet<JewelJewelInventoryIssue> JewelJewelInventoryIssues { get; set; }

    public virtual DbSet<JewelJewelInventoryReceive> JewelJewelInventoryReceives { get; set; }

    public virtual DbSet<JewelJewelQuality> JewelJewelQualities { get; set; }

    public virtual DbSet<JewelJewelSize> JewelJewelSizes { get; set; }

    public virtual DbSet<JewelJewelTransaction> JewelJewelTransactions { get; set; }

    public virtual DbSet<JewelJewelTransactionDetail> JewelJewelTransactionDetails { get; set; }

    public virtual DbSet<MeltingMeltingTransaction> MeltingMeltingTransactions { get; set; }

    public virtual DbSet<MeltingMeltingView> MeltingMeltingViews { get; set; }

    public virtual DbSet<OrderOrder> OrderOrders { get; set; }

    public virtual DbSet<OrderOrderCredit> OrderOrderCredits { get; set; }

    public virtual DbSet<OrderOrderItem> OrderOrderItems { get; set; }

    public virtual DbSet<OrderOrderItemDetail> OrderOrderItemDetails { get; set; }

    public virtual DbSet<OrderOrderOverDueListView> OrderOrderOverDueListViews { get; set; }

    public virtual DbSet<ReferenceCategory> ReferenceCategories { get; set; }

    public virtual DbSet<ReferenceCounter> ReferenceCounters { get; set; }

    public virtual DbSet<ReferenceGoldPrice> ReferenceGoldPrices { get; set; }

    public virtual DbSet<ReferenceItemCategory> ReferenceItemCategories { get; set; }

    public virtual DbSet<ReferenceJewelType> ReferenceJewelTypes { get; set; }

    public virtual DbSet<ReferenceSalesPerson> ReferenceSalesPeople { get; set; }

    public virtual DbSet<ReferenceStore> ReferenceStores { get; set; }

    public virtual DbSet<ReferenceSubCategory> ReferenceSubCategories { get; set; }

    public virtual DbSet<ReportCode> ReportCodes { get; set; }

    public virtual DbSet<SecurityGroup> SecurityGroups { get; set; }

    public virtual DbSet<SecurityGroupPermission> SecurityGroupPermissions { get; set; }

    public virtual DbSet<SecurityLoginTicket> SecurityLoginTickets { get; set; }

    public virtual DbSet<SecurityPermission> SecurityPermissions { get; set; }

    public virtual DbSet<SecurityReportPermission> SecurityReportPermissions { get; set; }

    public virtual DbSet<SecurityUser> SecurityUsers { get; set; }

    public virtual DbSet<SecurityUserLoginHistory> SecurityUserLoginHistories { get; set; }

    public virtual DbSet<SmithGoldAtSmith> SmithGoldAtSmiths { get; set; }

    public virtual DbSet<SmithGoldBalanceView> SmithGoldBalanceViews { get; set; }

    public virtual DbSet<SmithSmith> SmithSmiths { get; set; }

    public virtual DbSet<SmithSmithTransaction> SmithSmithTransactions { get; set; }

    public virtual DbSet<StockItem> StockItems { get; set; }

    public virtual DbSet<StockItemAttachment> StockItemAttachments { get; set; }

    public virtual DbSet<StockItemDetail> StockItemDetails { get; set; }

    public virtual DbSet<StockPlatinum> StockPlatinums { get; set; }

    public virtual DbSet<StockRecondition> StockReconditions { get; set; }

    public virtual DbSet<SystemApplicationMenu> SystemApplicationMenus { get; set; }

    public virtual DbSet<SystemAuditTrail> SystemAuditTrails { get; set; }

    public virtual DbSet<SystemIntervalSetting> SystemIntervalSettings { get; set; }

    public virtual DbSet<SystemMonitor> SystemMonitors { get; set; }

    public virtual DbSet<SystemOption> SystemOptions { get; set; }

    public virtual DbSet<SystemProfile> SystemProfiles { get; set; }

    public virtual DbSet<SystemProfileDataView> SystemProfileDataViews { get; set; }

    public virtual DbSet<SystemProfileItem> SystemProfileItems { get; set; }

    public virtual DbSet<SystemReport> SystemReports { get; set; }

    public virtual DbSet<TransactionInvoice> TransactionInvoices { get; set; }

    public virtual DbSet<TransactionItemSale> TransactionItemSales { get; set; }

    public virtual DbSet<TransactionItemSalesCredit> TransactionItemSalesCredits { get; set; }

    public virtual DbSet<TransactionItemSalesDetail> TransactionItemSalesDetails { get; set; }

    public virtual DbSet<TransactionPlatinumSale> TransactionPlatinumSales { get; set; }

    public virtual DbSet<TransactionPurchase> TransactionPurchases { get; set; }

    public virtual DbSet<TransactionPurchaseDetail> TransactionPurchaseDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-251TL74;Database=GMS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CashCashInward>(entity =>
        {
            entity.ToTable("Cash_CashInward");

            entity.HasIndex(e => e.CashInwardCode, "IX_Cash_CashInward")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CashInwardCode).HasMaxLength(50);
            entity.Property(e => e.CashInwardDescription).HasMaxLength(250);
            entity.Property(e => e.CashInwardId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CashInwardID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<CashCashSummaryView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cash_CashSummaryView");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SaleDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<CashCreditClearingBalanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cash_CreditClearingBalanceView");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Description)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(250);
        });

        modelBuilder.Entity<CustomerCustomer>(entity =>
        {
            entity.ToTable("Customer_Customer");

            entity.HasIndex(e => e.CustomerCode, "IX_Customer_Customer")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.Fax).HasMaxLength(250);
            entity.Property(e => e.Mobile).HasMaxLength(250);
            entity.Property(e => e.Telephone).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.Website).HasMaxLength(250);
        });

        modelBuilder.Entity<GoldBarGoldBarCredit>(entity =>
        {
            entity.ToTable("GoldBar_GoldBarCredit");

            entity.HasIndex(e => e.GoldBarCreditCode, "IX_GoldBar_GoldBarCredit")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldBarCreditCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarCreditDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarCreditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldBarCreditID");
            entity.Property(e => e.GoldBarTransactionCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarTransactionId).HasColumnName("GoldBarTransactionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.GoldBarTransaction).WithMany(p => p.GoldBarGoldBarCredits)
                .HasForeignKey(d => d.GoldBarTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoldBar_GoldBarCredit_GoldBar_GoldBarTransaction");
        });

        modelBuilder.Entity<GoldBarGoldBarInventory>(entity =>
        {
            entity.ToTable("GoldBar_GoldBarInventory");

            entity.HasIndex(e => e.StoreId, "GoldBar_GoldBarInventory_StoreID").HasFillFactor(90);

            entity.HasIndex(e => e.GoldBarInventoryCode, "IX_GoldBar_GoldBarInventory")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldBarInventoryCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarInventoryDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarInventoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldBarInventoryID");
            entity.Property(e => e.GoldBarInventoryTransferCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarInventoryTransferDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarInventoryTransferId).HasColumnName("GoldBarInventoryTransferID");
            entity.Property(e => e.GoldBarTransactionDetailCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarTransactionDetailDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarTransactionDetailId).HasColumnName("GoldBarTransactionDetailID");
            entity.Property(e => e.InventoryIssueCode).HasMaxLength(50);
            entity.Property(e => e.InventoryIssueDescription).HasMaxLength(250);
            entity.Property(e => e.InventoryIssueId).HasColumnName("InventoryIssueID");
            entity.Property(e => e.InventoryReceiveCode).HasMaxLength(50);
            entity.Property(e => e.InventoryReceiveDescription).HasMaxLength(250);
            entity.Property(e => e.InventoryReceiveId).HasColumnName("InventoryReceiveID");
            entity.Property(e => e.Remark)
                .HasDefaultValue("-")
                .HasColumnType("ntext");
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");

            entity.HasOne(d => d.GoldBarInventoryTransfer).WithMany(p => p.GoldBarGoldBarInventories)
                .HasForeignKey(d => d.GoldBarInventoryTransferId)
                .HasConstraintName("FK_GoldBar_GoldBarInventory_GoldBar_GoldBarInventoryTransfer");

            entity.HasOne(d => d.GoldBarTransactionDetail).WithMany(p => p.GoldBarGoldBarInventories)
                .HasForeignKey(d => d.GoldBarTransactionDetailId)
                .HasConstraintName("FK_GoldBar_GoldBarInventory_GoldBar_GoldBarTransactionDetail");

            entity.HasOne(d => d.InventoryIssue).WithMany(p => p.GoldBarGoldBarInventories)
                .HasForeignKey(d => d.InventoryIssueId)
                .HasConstraintName("FK_GoldBar_GoldBarInventory_GoldBar_InventoryIssue");

            entity.HasOne(d => d.InventoryReceive).WithMany(p => p.GoldBarGoldBarInventories)
                .HasForeignKey(d => d.InventoryReceiveId)
                .HasConstraintName("FK_GoldBar_GoldBarInventory_GoldBar_InventoryReceive");

            entity.HasOne(d => d.Store).WithMany(p => p.GoldBarGoldBarInventories)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_GoldBar_GoldBarInventory_Reference_Store");
        });

        modelBuilder.Entity<GoldBarGoldBarInventoryTransfer>(entity =>
        {
            entity.ToTable("GoldBar_GoldBarInventoryTransfer");

            entity.HasIndex(e => e.GoldBarInventoryTransferCode, "IX_GoldBar_GoldBarInventoryTransfer").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.FromStoreCode).HasMaxLength(50);
            entity.Property(e => e.FromStoreDescription).HasMaxLength(50);
            entity.Property(e => e.FromStoreId).HasColumnName("FromStoreID");
            entity.Property(e => e.GoldBarInventoryTransferCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarInventoryTransferDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarInventoryTransferId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldBarInventoryTransferID");
            entity.Property(e => e.ToStoreCode).HasMaxLength(50);
            entity.Property(e => e.ToStoreDescription).HasMaxLength(50);
            entity.Property(e => e.ToStoreId).HasColumnName("ToStoreID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");

            entity.HasOne(d => d.FromStore).WithMany(p => p.GoldBarGoldBarInventoryTransferFromStores)
                .HasForeignKey(d => d.FromStoreId)
                .HasConstraintName("FK_GoldBar_GoldBarInventoryTransfer_From_Reference_Store");

            entity.HasOne(d => d.ToStore).WithMany(p => p.GoldBarGoldBarInventoryTransferToStores)
                .HasForeignKey(d => d.ToStoreId)
                .HasConstraintName("FK_GoldBar_GoldBarInventoryTransfer_To_Reference_Store");
        });

        modelBuilder.Entity<GoldBarGoldBarTransaction>(entity =>
        {
            entity.ToTable("GoldBar_GoldBarTransaction");

            entity.HasIndex(e => e.GoldBarTransactionCode, "IX_GoldBar_GoldBarTransaction")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldBarTransactionCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarTransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldBarTransactionID");
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.Remark).HasColumnType("ntext");
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Counter).WithMany(p => p.GoldBarGoldBarTransactions)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_GoldBar_GoldBarTransaction_Reference_Counter");

            entity.HasOne(d => d.Customer).WithMany(p => p.GoldBarGoldBarTransactions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_GoldBar_GoldBarTransaction_Customer_Customer");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.GoldBarGoldBarTransactions)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_GoldBar_GoldBarTransaction_Reference_SalesPerson");
        });

        modelBuilder.Entity<GoldBarGoldBarTransactionDetail>(entity =>
        {
            entity.ToTable("GoldBar_GoldBarTransactionDetail");

            entity.HasIndex(e => e.GoldBarTransactionDetailCode, "IX_GoldBar_GoldBarTransactionDetail")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BuyOrSell).HasDefaultValue(true);
            entity.Property(e => e.ChangedWeightKpy).HasColumnName("ChangedWeightKPY");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldBarTransactionCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarTransactionDetailCode).HasMaxLength(50);
            entity.Property(e => e.GoldBarTransactionDetailDescription).HasMaxLength(250);
            entity.Property(e => e.GoldBarTransactionDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldBarTransactionDetailID");
            entity.Property(e => e.GoldBarTransactionId).HasColumnName("GoldBarTransactionID");
            entity.Property(e => e.JointOption).HasComment("None,Add,Substract");
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");

            entity.HasOne(d => d.GoldBarTransaction).WithMany(p => p.GoldBarGoldBarTransactionDetails)
                .HasForeignKey(d => d.GoldBarTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GoldBar_GoldBarTransactionDetail_GoldBar_GoldBarTransaction");

            entity.HasOne(d => d.Store).WithMany(p => p.GoldBarGoldBarTransactionDetails)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_GoldBar_GoldBarTransactionDetail_Reference_Store");
        });

        modelBuilder.Entity<GoldBarInventoryBalanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GoldBar_InventoryBalanceView");

            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.TotalWeightKpy).HasColumnName("TotalWeightKPY");
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");
        });

        modelBuilder.Entity<GoldBarInventoryIssue>(entity =>
        {
            entity.ToTable("GoldBar_InventoryIssue");

            entity.HasIndex(e => e.InventoryIssueCode, "IX_GoldBar_InventoryIssue").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.InventoryIssueCode).HasMaxLength(50);
            entity.Property(e => e.InventoryIssueDescription).HasMaxLength(250);
            entity.Property(e => e.InventoryIssueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InventoryIssueID");
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");

            entity.HasOne(d => d.Store).WithMany(p => p.GoldBarInventoryIssues)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_GoldBar_InventoryIssue_Reference_Store");
        });

        modelBuilder.Entity<GoldBarInventoryReceive>(entity =>
        {
            entity.ToTable("GoldBar_InventoryReceive");

            entity.HasIndex(e => e.InventoryReceiveCode, "IX_GoldBar_InventoryReceive").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.InventoryReceiveCode).HasMaxLength(50);
            entity.Property(e => e.InventoryReceiveDescription).HasMaxLength(250);
            entity.Property(e => e.InventoryReceiveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InventoryReceiveID");
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");

            entity.HasOne(d => d.Store).WithMany(p => p.GoldBarInventoryReceives)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_GoldBar_InventoryReceive_Reference_Store");
        });

        modelBuilder.Entity<JewelJewel>(entity =>
        {
            entity.ToTable("Jewel_Jewel");

            entity.HasIndex(e => e.JewelCode, "IX_Jewel_Jewel")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelID");
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId).HasColumnName("JewelTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.JewelType).WithMany(p => p.JewelJewels)
                .HasForeignKey(d => d.JewelTypeId)
                .HasConstraintName("FK_Jewel_Jewel_Reference_JewelType");
        });

        modelBuilder.Entity<JewelJewelAttachment>(entity =>
        {
            entity.ToTable("Jewel_JewelAttachment");

            entity.HasIndex(e => e.JewelAttachmentCode, "IX_Jewel_JewelAttachment")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IsCover).HasDefaultValue(true);
            entity.Property(e => e.JewelAttachmentCode).HasMaxLength(50);
            entity.Property(e => e.JewelAttachmentDescription).HasMaxLength(250);
            entity.Property(e => e.JewelAttachmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelAttachmentID");
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId).HasColumnName("JewelID");
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Jewel).WithMany(p => p.JewelJewelAttachments)
                .HasForeignKey(d => d.JewelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jewel_JewelAttachment_Jewel_Jewel");
        });

        modelBuilder.Entity<JewelJewelInventory>(entity =>
        {
            entity.ToTable("Jewel_JewelInventory");

            entity.HasIndex(e => e.JewelInventoryCode, "IX_Jewel_JewelInventory").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId).HasColumnName("JewelID");
            entity.Property(e => e.JewelInventoryCode).HasMaxLength(50);
            entity.Property(e => e.JewelInventoryDescription).HasMaxLength(250);
            entity.Property(e => e.JewelInventoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelInventoryID");
            entity.Property(e => e.JewelInventoryIssueCode).HasMaxLength(50);
            entity.Property(e => e.JewelInventoryIssueDescription).HasMaxLength(250);
            entity.Property(e => e.JewelInventoryIssueId).HasColumnName("JewelInventoryIssueID");
            entity.Property(e => e.JewelInventoryReceiveCode).HasMaxLength(50);
            entity.Property(e => e.JewelInventoryReceiveDescription).HasMaxLength(250);
            entity.Property(e => e.JewelInventoryReceiveId).HasColumnName("JewelInventoryReceiveID");
            entity.Property(e => e.JewelSizeCode).HasMaxLength(50);
            entity.Property(e => e.JewelSizeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelSizeId).HasColumnName("JewelSizeID");
            entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Jewel).WithMany(p => p.JewelJewelInventories)
                .HasForeignKey(d => d.JewelId)
                .HasConstraintName("FK_Jewel_JewelInventory_Jewel_Jewel");

            entity.HasOne(d => d.JewelInventoryIssue).WithMany(p => p.JewelJewelInventories)
                .HasForeignKey(d => d.JewelInventoryIssueId)
                .HasConstraintName("FK_Jewel_JewelInventory_Jewel_JewelInventoryIssue");

            entity.HasOne(d => d.JewelInventoryReceive).WithMany(p => p.JewelJewelInventories)
                .HasForeignKey(d => d.JewelInventoryReceiveId)
                .HasConstraintName("FK_Jewel_JewelInventory_Jewel_JewelInventoryReceive");

            entity.HasOne(d => d.JewelSize).WithMany(p => p.JewelJewelInventories)
                .HasForeignKey(d => d.JewelSizeId)
                .HasConstraintName("FK_Jewel_JewelInventory_Jewel_JewelSize");
        });

        modelBuilder.Entity<JewelJewelInventoryBalanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Jewel_JewelInventoryBalanceView");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Jewel).HasMaxLength(250);
            entity.Property(e => e.JewelSize).HasMaxLength(250);
        });

        modelBuilder.Entity<JewelJewelInventoryIssue>(entity =>
        {
            entity.ToTable("Jewel_JewelInventoryIssue");

            entity.HasIndex(e => e.JewelInventoryIssueCode, "IX_Jewel_JewelInventoryIssue").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId).HasColumnName("JewelID");
            entity.Property(e => e.JewelInventoryIssueCode).HasMaxLength(50);
            entity.Property(e => e.JewelInventoryIssueDescription).HasMaxLength(250);
            entity.Property(e => e.JewelInventoryIssueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelInventoryIssueID");
            entity.Property(e => e.JewelSizeCode).HasMaxLength(50);
            entity.Property(e => e.JewelSizeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelSizeId).HasColumnName("JewelSizeID");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Jewel).WithMany(p => p.JewelJewelInventoryIssues)
                .HasForeignKey(d => d.JewelId)
                .HasConstraintName("FK_Jewel_JewelInventoryIssue_Jewel_Jewel");

            entity.HasOne(d => d.JewelSize).WithMany(p => p.JewelJewelInventoryIssues)
                .HasForeignKey(d => d.JewelSizeId)
                .HasConstraintName("FK_Jewel_JewelInventoryIssue_Jewel_JewelSize");

            entity.HasOne(d => d.Smith).WithMany(p => p.JewelJewelInventoryIssues)
                .HasForeignKey(d => d.SmithId)
                .HasConstraintName("FK_Jewel_JewelInventoryIssue_Smith_Smith");
        });

        modelBuilder.Entity<JewelJewelInventoryReceive>(entity =>
        {
            entity.ToTable("Jewel_JewelInventoryReceive");

            entity.HasIndex(e => e.JewelInventoryReceiveCode, "IX_Jewel_JewelInventoryReceive").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId).HasColumnName("JewelID");
            entity.Property(e => e.JewelInventoryReceiveCode).HasMaxLength(50);
            entity.Property(e => e.JewelInventoryReceiveDescription).HasMaxLength(250);
            entity.Property(e => e.JewelInventoryReceiveId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelInventoryReceiveID");
            entity.Property(e => e.JewelSizeCode).HasMaxLength(50);
            entity.Property(e => e.JewelSizeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelSizeId).HasColumnName("JewelSizeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Jewel).WithMany(p => p.JewelJewelInventoryReceives)
                .HasForeignKey(d => d.JewelId)
                .HasConstraintName("FK_Jewel_JewelInventoryReceive_Jewel_Jewel");

            entity.HasOne(d => d.JewelSize).WithMany(p => p.JewelJewelInventoryReceives)
                .HasForeignKey(d => d.JewelSizeId)
                .HasConstraintName("FK_Jewel_JewelInventoryReceive_Jewel_JewelSize");
        });

        modelBuilder.Entity<JewelJewelQuality>(entity =>
        {
            entity.ToTable("Jewel_JewelQuality");

            entity.HasIndex(e => e.JewelQualityCode, "IX_Jewel_JewelQuality")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelQualityCode).HasMaxLength(50);
            entity.Property(e => e.JewelQualityDescription).HasMaxLength(250);
            entity.Property(e => e.JewelQualityId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelQualityID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<JewelJewelSize>(entity =>
        {
            entity.ToTable("Jewel_JewelSize");

            entity.HasIndex(e => e.JewelSizeCode, "IX_Jewel_JewelSize").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelSizeCode).HasMaxLength(50);
            entity.Property(e => e.JewelSizeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelSizeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelSizeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<JewelJewelTransaction>(entity =>
        {
            entity.ToTable("Jewel_JewelTransaction");

            entity.HasIndex(e => e.JewelTransactionCode, "IX_Jewel_JewelTransaction")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTransactionCode).HasMaxLength(50);
            entity.Property(e => e.JewelTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelTransactionID");
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Counter).WithMany(p => p.JewelJewelTransactions)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_Jewel_JewelTransaction_Reference_Counter");

            entity.HasOne(d => d.Customer).WithMany(p => p.JewelJewelTransactions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Jewel_JewelTransaction_Customer_Customer");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.JewelJewelTransactions)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Jewel_JewelTransaction_Reference_SalesPerson");
        });

        modelBuilder.Entity<JewelJewelTransactionDetail>(entity =>
        {
            entity.ToTable("Jewel_JewelTransactionDetail");

            entity.HasIndex(e => e.JewelTransactionDetailCode, "IX_Jewel_JewelTransactionDetail").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BuyOrSell).HasDefaultValue(true);
            entity.Property(e => e.ChangedWeightKpy).HasColumnName("ChangedWeightKPY");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelCode).HasMaxLength(50);
            entity.Property(e => e.JewelDescription).HasMaxLength(250);
            entity.Property(e => e.JewelId).HasColumnName("JewelID");
            entity.Property(e => e.JewelSizeCode).HasMaxLength(50);
            entity.Property(e => e.JewelSizeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelSizeId).HasColumnName("JewelSizeID");
            entity.Property(e => e.JewelTransactionCode).HasMaxLength(50);
            entity.Property(e => e.JewelTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTransactionDetailCode).HasMaxLength(50);
            entity.Property(e => e.JewelTransactionDetailDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTransactionDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelTransactionDetailID");
            entity.Property(e => e.JewelTransactionId).HasColumnName("JewelTransactionID");
            entity.Property(e => e.JointOption).HasComment("None,Add,Substract");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Jewel).WithMany(p => p.JewelJewelTransactionDetails)
                .HasForeignKey(d => d.JewelId)
                .HasConstraintName("FK_Jewel_JewelTransactionDetail_Jewel_Jewel");

            entity.HasOne(d => d.JewelSize).WithMany(p => p.JewelJewelTransactionDetails)
                .HasForeignKey(d => d.JewelSizeId)
                .HasConstraintName("FK_Jewel_JewelTransactionDetail_Jewel_JewelSize");

            entity.HasOne(d => d.JewelTransaction).WithMany(p => p.JewelJewelTransactionDetails)
                .HasForeignKey(d => d.JewelTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Jewel_JewelTransactionDetail_Jewel_JewelTransaction");
        });

        modelBuilder.Entity<MeltingMeltingTransaction>(entity =>
        {
            entity.ToTable("Melting_MeltingTransaction");

            entity.HasIndex(e => e.MeltingTransactionCode, "IX_Melting_MeltingTransaction").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.MeltingTransactionCode).HasMaxLength(50);
            entity.Property(e => e.MeltingTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.MeltingTransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MeltingTransactionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<MeltingMeltingView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Melting_MeltingView");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MeltWeightKpy).HasColumnName("MeltWeightKPY");
            entity.Property(e => e.OtherWeightKpy).HasColumnName("OtherWeightKPY");
            entity.Property(e => e.RenewWeightKpy).HasColumnName("RenewWeightKPY");
        });

        modelBuilder.Entity<OrderOrder>(entity =>
        {
            entity.ToTable("Order_Order");

            entity.HasIndex(e => e.OrderCode, "IX_Order_Order")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.OrderCode).HasMaxLength(50);
            entity.Property(e => e.OrderDescription).HasMaxLength(250);
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(250);
            entity.Property(e => e.Remark).HasColumnType("ntext");
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Counter).WithMany(p => p.OrderOrders)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_Order_Order_Reference_Counter");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Order_Order_Customer_Customer");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.OrderOrders)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Order_Order_Reference_SalesPerson");
        });

        modelBuilder.Entity<OrderOrderCredit>(entity =>
        {
            entity.ToTable("Order_OrderCredit");

            entity.HasIndex(e => e.OrderCreditCode, "IX_Order_OrderCredit")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.OrderCode).HasMaxLength(50);
            entity.Property(e => e.OrderCreditCode).HasMaxLength(50);
            entity.Property(e => e.OrderCreditDescription).HasMaxLength(250);
            entity.Property(e => e.OrderCreditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderCreditID");
            entity.Property(e => e.OrderDescription).HasMaxLength(250);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderOrderCredits)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderCredit_Order_Order");
        });

        modelBuilder.Entity<OrderOrderItem>(entity =>
        {
            entity.ToTable("Order_OrderItem");

            entity.HasIndex(e => e.OrderItemCode, "IX_Order_OrderItem")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerPayGoldWeightKpy).HasColumnName("CustomerPayGoldWeightKPY");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.ItemName).HasMaxLength(250);
            entity.Property(e => e.ItemWeightKpy).HasColumnName("ItemWeightKPY");
            entity.Property(e => e.JewelWeightKpy).HasColumnName("JewelWeightKPY");
            entity.Property(e => e.OrderCode).HasMaxLength(50);
            entity.Property(e => e.OrderDescription).HasMaxLength(250);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderItemCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemDescription).HasMaxLength(250);
            entity.Property(e => e.OrderItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderItemID");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.TotalGoldWeightKpy).HasColumnName("TotalGoldWeightKPY");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WasteKpy).HasColumnName("WasteKPY");

            entity.HasOne(d => d.Category).WithMany(p => p.OrderOrderItems)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Order_OrderItem_Reference_Category");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderOrderItems)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderItem_Order_Order");

            entity.HasOne(d => d.Smith).WithMany(p => p.OrderOrderItems)
                .HasForeignKey(d => d.SmithId)
                .HasConstraintName("FK_Order_OrderItem_Smith_Smith");
        });

        modelBuilder.Entity<OrderOrderItemDetail>(entity =>
        {
            entity.ToTable("Order_OrderItemDetail");

            entity.HasIndex(e => e.OrderItemDetailCode, "IX_Order_OrderItemDetail")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId).HasColumnName("JewelTypeID");
            entity.Property(e => e.JewelYatiPyi).HasDefaultValue(0f);
            entity.Property(e => e.Kpy).HasColumnName("KPY");
            entity.Property(e => e.OrderItemCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemDescription).HasMaxLength(250);
            entity.Property(e => e.OrderItemDetailCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemDetailDescription).HasMaxLength(250);
            entity.Property(e => e.OrderItemDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderItemDetailID");
            entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.JewelType).WithMany(p => p.OrderOrderItemDetails)
                .HasForeignKey(d => d.JewelTypeId)
                .HasConstraintName("FK_Order_OrderItemDetail_Reference_JewelType");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.OrderOrderItemDetails)
                .HasForeignKey(d => d.OrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_OrderItemDetail_Order_OrderItem");
        });

        modelBuilder.Entity<OrderOrderOverDueListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Order_OrderOverDueListView");

            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerPayGoldWeightKpy).HasColumnName("CustomerPayGoldWeightKPY");
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.ItemName).HasMaxLength(250);
            entity.Property(e => e.ItemWeightKpy).HasColumnName("ItemWeightKPY");
            entity.Property(e => e.JewelWeightKpy).HasColumnName("JewelWeightKPY");
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.OrderCode).HasMaxLength(50);
            entity.Property(e => e.OrderDescription).HasMaxLength(250);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderItemCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemDescription).HasMaxLength(250);
            entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(250);
            entity.Property(e => e.Remark).HasColumnType("ntext");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.TotalGoldWeightKpy).HasColumnName("TotalGoldWeightKPY");
            entity.Property(e => e.WasteKpy).HasColumnName("WasteKPY");
        });

        modelBuilder.Entity<ReferenceCategory>(entity =>
        {
            entity.ToTable("Reference_Category");

            entity.HasIndex(e => e.CategoryCode, "IX_Reference_Category")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<ReferenceCounter>(entity =>
        {
            entity.ToTable("Reference_Counter");

            entity.HasIndex(e => e.CounterCode, "IX_Reference_Counter")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<ReferenceGoldPrice>(entity =>
        {
            entity.ToTable("Reference_GoldPrice");

            entity.HasIndex(e => e.GoldPriceCode, "IX_Reference_GoldPrice")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.TransactionDate, "Reference_GoldPrice_TransactionDate").HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.C22kprice).HasColumnName("C22KPrice");
            entity.Property(e => e.C23kprice).HasColumnName("C23KPrice");
            entity.Property(e => e.C24kprice).HasColumnName("C24KPrice");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldPriceCode).HasMaxLength(50);
            entity.Property(e => e.GoldPriceDescription).HasMaxLength(250);
            entity.Property(e => e.GoldPriceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldPriceID");
            entity.Property(e => e.TransactionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<ReferenceItemCategory>(entity =>
        {
            entity.ToTable("Reference_ItemCategory");

            entity.HasIndex(e => new { e.ItemCategoryCode, e.SubCategoryId }, "IX_Reference_ItemCategory")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ItemCategoryCode).HasMaxLength(50);
            entity.Property(e => e.ItemCategoryDescription).HasMaxLength(250);
            entity.Property(e => e.ItemCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemCategoryID");
            entity.Property(e => e.SubCategoryCode).HasMaxLength(50);
            entity.Property(e => e.SubCategoryDescription).HasMaxLength(250);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Category).WithMany(p => p.ReferenceItemCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Reference_ItemCategory_Reference_Category");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.ReferenceItemCategories)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Reference_ItemCategory_Reference_SubCategory");
        });

        modelBuilder.Entity<ReferenceJewelType>(entity =>
        {
            entity.ToTable("Reference_JewelType");

            entity.HasIndex(e => e.JewelTypeCode, "IX_Reference_JewelType")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("JewelTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.YatiPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ReferenceSalesPerson>(entity =>
        {
            entity.ToTable("Reference_SalesPerson");

            entity.HasIndex(e => e.SalesPersonCode, "IX_Reference_SalesPerson").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<ReferenceStore>(entity =>
        {
            entity.ToTable("Reference_Store");

            entity.HasIndex(e => e.StoreCode, "IX_Reference_Store")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId)
                .ValueGeneratedOnAdd()
                .HasColumnName("StoreID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<ReferenceSubCategory>(entity =>
        {
            entity.ToTable("Reference_SubCategory");

            entity.HasIndex(e => e.SubCategoryCode, "IX_Reference_SubCategory")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.SubCategoryCode).HasMaxLength(50);
            entity.Property(e => e.SubCategoryDescription).HasMaxLength(250);
            entity.Property(e => e.SubCategoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SubCategoryID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Category).WithMany(p => p.ReferenceSubCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Reference_SubCategory_Reference_Category");
        });

        modelBuilder.Entity<ReportCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReportCode");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<SecurityGroup>(entity =>
        {
            entity.ToTable("Security_Group");

            entity.HasIndex(e => e.GroupCode, "IX_Security_Group")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupDescription).HasMaxLength(250);
            entity.Property(e => e.GroupId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GroupID");
            entity.Property(e => e.PermissionPeriodEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.PermissionPeriodStart).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SecurityGroupPermission>(entity =>
        {
            entity.ToTable("Security_GroupPermission");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupDescription).HasMaxLength(250);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.PermissionCode).HasMaxLength(50);
            entity.Property(e => e.PermissionDescription).HasMaxLength(250);
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Group).WithMany(p => p.SecurityGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_GroupPermission_Security_Group");

            entity.HasOne(d => d.Permission).WithMany(p => p.SecurityGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_GroupPermission_Security_Permission");
        });

        modelBuilder.Entity<SecurityLoginTicket>(entity =>
        {
            entity.ToTable("Security_LoginTicket");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.LastActivity).HasColumnType("smalldatetime");
            entity.Property(e => e.LoggedIn).HasColumnType("smalldatetime");
            entity.Property(e => e.LoginTicketId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LoginTicketID");
            entity.Property(e => e.TokenId)
                .HasMaxLength(250)
                .HasColumnName("TokenID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserDescription).HasMaxLength(250);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityLoginTickets)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_LoginTicket_Security_User");
        });

        modelBuilder.Entity<SecurityPermission>(entity =>
        {
            entity.ToTable("Security_Permission");

            entity.HasIndex(e => e.PermissionCode, "IX_Security_Permission")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.PermissionCode).HasMaxLength(50);
            entity.Property(e => e.PermissionDescription).HasMaxLength(250);
            entity.Property(e => e.PermissionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PermissionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SecurityReportPermission>(entity =>
        {
            entity.ToTable("Security_ReportPermission");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupDescription).HasMaxLength(250);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.ReportCode).HasMaxLength(50);
            entity.Property(e => e.ReportDescription).HasMaxLength(250);
            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Group).WithMany(p => p.SecurityReportPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_ReportPermission_Security_Group");

            entity.HasOne(d => d.Report).WithMany(p => p.SecurityReportPermissions)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_ReportPermission_System_Report");
        });

        modelBuilder.Entity<SecurityUser>(entity =>
        {
            entity.ToTable("Security_User");

            entity.HasIndex(e => e.UserCode, "IX_Security_User")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GroupCode).HasMaxLength(50);
            entity.Property(e => e.GroupDescription).HasMaxLength(250);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.LockoutEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.PasswordExpireDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PermissionPeriodEnd).HasColumnType("smalldatetime");
            entity.Property(e => e.PermissionPeriodStart).HasColumnType("smalldatetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(256);
            entity.Property(e => e.ReferId)
                .HasMaxLength(250)
                .HasColumnName("ReferID");
            entity.Property(e => e.Remark).HasColumnType("text");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserDescription).HasMaxLength(250);
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserID");

            entity.HasOne(d => d.Group).WithMany(p => p.SecurityUsers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_Security_User_Security_Group");
        });

        modelBuilder.Entity<SecurityUserLoginHistory>(entity =>
        {
            entity.ToTable("Security_UserLoginHistory");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.AccessDescription)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ComputerName).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.LogTime).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserDescription).HasMaxLength(250);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserLoginHistoryId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UserLoginHistoryID");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityUserLoginHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Security_UserLoginHistory_Security_User");
        });

        modelBuilder.Entity<SmithGoldAtSmith>(entity =>
        {
            entity.ToTable("Smith_GoldAtSmith");

            entity.HasIndex(e => e.GoldAtSmithCode, "IX_Smith_GoldAtSmith").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldAtSmithCode).HasMaxLength(50);
            entity.Property(e => e.GoldAtSmithDescription).HasMaxLength(250);
            entity.Property(e => e.GoldAtSmithId)
                .ValueGeneratedOnAdd()
                .HasColumnName("GoldAtSmithID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WeightKpy).HasColumnName("WeightKPY");
        });

        modelBuilder.Entity<SmithGoldBalanceView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Smith_GoldBalanceView");

            entity.Property(e => e.BalanceWeightKpy).HasColumnName("BalanceWeightKPY");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SmithSmith>(entity =>
        {
            entity.ToTable("Smith_Smith");

            entity.HasIndex(e => e.SmithCode, "IX_Smith_Smith")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SmithID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SmithSmithTransaction>(entity =>
        {
            entity.ToTable("Smith_SmithTransaction");

            entity.HasIndex(e => e.SmithTransactionCode, "IX_Smith_SmithTransaction")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.BalanceWeightKpy).HasColumnName("BalanceWeightKPY");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ExceedWeightKpy).HasColumnName("ExceedWeightKPY");
            entity.Property(e => e.OrderItemCode).HasMaxLength(50);
            entity.Property(e => e.OrderItemDescription).HasMaxLength(250);
            entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");
            entity.Property(e => e.PayWeightKpy).HasColumnName("PayWeightKPY");
            entity.Property(e => e.ReturnWeightKpy).HasColumnName("ReturnWeightKPY");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.SmithTransactionCode).HasMaxLength(50);
            entity.Property(e => e.SmithTransactionDescription).HasMaxLength(250);
            entity.Property(e => e.SmithTransactionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("SmithTransactionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.OrderItem).WithMany(p => p.SmithSmithTransactions)
                .HasForeignKey(d => d.OrderItemId)
                .HasConstraintName("FK_Smith_SmithTransaction_Order_OrderItem");

            entity.HasOne(d => d.Smith).WithMany(p => p.SmithSmithTransactions)
                .HasForeignKey(d => d.SmithId)
                .HasConstraintName("FK_Smith_SmithTransaction_Smith_Smith");
        });

        modelBuilder.Entity<StockItem>(entity =>
        {
            entity.ToTable("Stock_Item");

            entity.HasIndex(e => e.ItemCode, "IX_Stock_Item")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.ItemStatus, e.RegDate }, "Stock_Item_ItemStatus_RegDate");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.ItemCategoryCode).HasMaxLength(50);
            entity.Property(e => e.ItemCategoryDescription).HasMaxLength(250);
            entity.Property(e => e.ItemCategoryId).HasColumnName("ItemCategoryID");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemDescription).HasMaxLength(250);
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemStatus).HasComment("New,Sold,Melt,SampleOut");
            entity.Property(e => e.ItemWeightKpy).HasColumnName("ItemWeightKPY");
            entity.Property(e => e.JewelWeightKpy).HasColumnName("JewelWeightKPY");
            entity.Property(e => e.OtherDescription).HasMaxLength(250);
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.SmithWasteKpy).HasColumnName("SmithWasteKPY");
            entity.Property(e => e.StoreCode).HasMaxLength(50);
            entity.Property(e => e.StoreDescription).HasMaxLength(250);
            entity.Property(e => e.StoreId).HasColumnName("StoreID");
            entity.Property(e => e.SubCategoryCode).HasMaxLength(50);
            entity.Property(e => e.SubCategoryDescription).HasMaxLength(250);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.TotalGoldWeightKpy).HasColumnName("TotalGoldWeightKPY");
            entity.Property(e => e.TransactionDate).HasComment("Update Date when item was sold or melt");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WasteKpy).HasColumnName("WasteKPY");

            entity.HasOne(d => d.Category).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Stock_Item_Reference_Category");

            entity.HasOne(d => d.ItemCategory).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.ItemCategoryId)
                .HasConstraintName("FK_Stock_Item_Reference_ItemCategory");

            entity.HasOne(d => d.Smith).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.SmithId)
                .HasConstraintName("FK_Stock_Item_Smith_Smith");

            entity.HasOne(d => d.Store).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.StoreId)
                .HasConstraintName("FK_Stock_Item_Reference_Store");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.StockItems)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Stock_Item_Reference_SubCategory");
        });

        modelBuilder.Entity<StockItemAttachment>(entity =>
        {
            entity.ToTable("Stock_ItemAttachment");

            entity.HasIndex(e => e.ItemAttachmentCode, "IX_Stock_ItemAttachment")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IsCover).HasDefaultValue(true);
            entity.Property(e => e.ItemAttachmentCode).HasMaxLength(50);
            entity.Property(e => e.ItemAttachmentDescription).HasMaxLength(250);
            entity.Property(e => e.ItemAttachmentId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemAttachmentID");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemDescription).HasMaxLength(250);
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Photo).HasMaxLength(250);
            entity.Property(e => e.Remark).HasColumnType("ntext");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Item).WithMany(p => p.StockItemAttachments)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_ItemAttachment_Stock_Item");
        });

        modelBuilder.Entity<StockItemDetail>(entity =>
        {
            entity.ToTable("Stock_ItemDetail");

            entity.HasIndex(e => e.ItemDetailCode, "IX_Stock_ItemDetail")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Dimension).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemDescription).HasMaxLength(250);
            entity.Property(e => e.ItemDetailCode).HasMaxLength(50);
            entity.Property(e => e.ItemDetailDescription).HasMaxLength(250);
            entity.Property(e => e.ItemDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemDetailID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId).HasColumnName("JewelTypeID");
            entity.Property(e => e.Kpy).HasColumnName("KPY");
            entity.Property(e => e.Shape).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Item).WithMany(p => p.StockItemDetails)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_ItemDetail_Stock_Item");

            entity.HasOne(d => d.JewelType).WithMany(p => p.StockItemDetails)
                .HasForeignKey(d => d.JewelTypeId)
                .HasConstraintName("FK_Stock_ItemDetail_Reference_JewelType");
        });

        modelBuilder.Entity<StockPlatinum>(entity =>
        {
            entity.ToTable("Stock_Platinum");

            entity.HasIndex(e => e.PlatinumCode, "IX_Stock_Platinum")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CategoryCode).HasMaxLength(50);
            entity.Property(e => e.CategoryDescription).HasMaxLength(250);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ItemSummary).HasMaxLength(250);
            entity.Property(e => e.PlatinumCode).HasMaxLength(50);
            entity.Property(e => e.PlatinumDescription).HasMaxLength(250);
            entity.Property(e => e.PlatinumId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PlatinumID");
            entity.Property(e => e.TransactionDate).HasComment("Update Date when item was sold or melt");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Category).WithMany(p => p.StockPlatinums)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Stock_Platinum_Reference_Category");
        });

        modelBuilder.Entity<StockRecondition>(entity =>
        {
            entity.ToTable("Stock_Recondition");

            entity.HasIndex(e => e.ReconditionCode, "IX_Stock_Recondition")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.PayWeightKpy).HasColumnName("PayWeightKPY");
            entity.Property(e => e.ReconditionCode).HasMaxLength(50);
            entity.Property(e => e.ReconditionDescription).HasMaxLength(250);
            entity.Property(e => e.ReconditionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReconditionID");
            entity.Property(e => e.SmithCode).HasMaxLength(50);
            entity.Property(e => e.SmithDescription).HasMaxLength(250);
            entity.Property(e => e.SmithId).HasColumnName("SmithID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Smith).WithMany(p => p.StockReconditions)
                .HasForeignKey(d => d.SmithId)
                .HasConstraintName("FK_Stock_Recondition_Smith_Smith");
        });

        modelBuilder.Entity<SystemApplicationMenu>(entity =>
        {
            entity.ToTable("System_ApplicationMenu");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ApplicationMenuCode).HasMaxLength(50);
            entity.Property(e => e.ApplicationMenuDescription).HasMaxLength(250);
            entity.Property(e => e.ApplicationMenuId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ApplicationMenuID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.MenuOrder).HasDefaultValue(1);
            entity.Property(e => e.Module).HasMaxLength(250);
            entity.Property(e => e.RequiresAuthenication).HasDefaultValue(true);
            entity.Property(e => e.Route).HasMaxLength(250);
            entity.Property(e => e.SubMenuOrder).HasDefaultValue(1);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SystemAuditTrail>(entity =>
        {
            entity.ToTable("System_AuditTrail");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Actions).HasMaxLength(1);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ChangedColumns).HasMaxLength(1000);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.EntityId).HasColumnName("EntityID");
            entity.Property(e => e.NewData).HasColumnType("xml");
            entity.Property(e => e.OldData).HasColumnType("xml");
            entity.Property(e => e.RevisionStamp).HasColumnType("smalldatetime");
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SystemIntervalSetting>(entity =>
        {
            entity.ToTable("System_IntervalSetting");

            entity.HasIndex(e => e.IntervalSettingCode, "IX_System_IntervalSetting")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.IntervalSettingCode).HasMaxLength(50);
            entity.Property(e => e.IntervalSettingDescription).HasMaxLength(250);
            entity.Property(e => e.IntervalSettingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IntervalSettingID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SystemMonitor>(entity =>
        {
            entity.ToTable("System_Monitor");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ParentDocument).HasMaxLength(250);
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.TimeStamp).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserDescription).HasMaxLength(250);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SystemMonitors)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_System_Monitor_Security_User");
        });

        modelBuilder.Entity<SystemOption>(entity =>
        {
            entity.ToTable("System_Option");

            entity.HasIndex(e => new { e.OptionCode, e.UserId }, "IX_System_Option")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.OptionCategory).HasMaxLength(250);
            entity.Property(e => e.OptionCode).HasMaxLength(250);
            entity.Property(e => e.OptionDataType).HasMaxLength(250);
            entity.Property(e => e.OptionDescription).HasMaxLength(250);
            entity.Property(e => e.OptionGroup).HasMaxLength(250);
            entity.Property(e => e.OptionModule).HasMaxLength(250);
            entity.Property(e => e.OptionValueCode).HasMaxLength(250);
            entity.Property(e => e.OptionValueDescription).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.UserCode).HasMaxLength(50);
            entity.Property(e => e.UserDescription).HasMaxLength(250);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.SystemOptions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_System_Option_Security_User");
        });

        modelBuilder.Entity<SystemProfile>(entity =>
        {
            entity.ToTable("System_Profile");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.DataValueCode).HasMaxLength(250);
            entity.Property(e => e.DataValueDescription).HasMaxLength(250);
            entity.Property(e => e.ProfileId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProfileID");
            entity.Property(e => e.ProfileItemCode).HasMaxLength(50);
            entity.Property(e => e.ProfileItemDescription).HasMaxLength(250);
            entity.Property(e => e.ProfileItemId).HasColumnName("ProfileItemID");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.ProfileItem).WithMany(p => p.SystemProfiles)
                .HasForeignKey(d => d.ProfileItemId)
                .HasConstraintName("FK_System_Profile_System_ProfileItem");
        });

        modelBuilder.Entity<SystemProfileDataView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("System_ProfileDataView");

            entity.Property(e => e.DataValueCode).HasMaxLength(250);
            entity.Property(e => e.DataValueDescription).HasMaxLength(250);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProfileCategory).HasMaxLength(250);
            entity.Property(e => e.ProfileItemCode).HasMaxLength(50);
            entity.Property(e => e.ProfileItemDescription).HasMaxLength(250);
            entity.Property(e => e.ProfileItemId).HasColumnName("ProfileItemID");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
        });

        modelBuilder.Entity<SystemProfileItem>(entity =>
        {
            entity.ToTable("System_ProfileItem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.ProfileCategory).HasMaxLength(250);
            entity.Property(e => e.ProfileItemCode).HasMaxLength(50);
            entity.Property(e => e.ProfileItemDescription).HasMaxLength(250);
            entity.Property(e => e.ProfileItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProfileItemID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<SystemReport>(entity =>
        {
            entity.ToTable("System_Report");

            entity.HasIndex(e => e.ReportCode, "IX_System_Report")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.ReportCode).HasMaxLength(50);
            entity.Property(e => e.ReportDataSourceName).HasMaxLength(250);
            entity.Property(e => e.ReportDescription).HasMaxLength(250);
            entity.Property(e => e.ReportFileName).HasMaxLength(250);
            entity.Property(e => e.ReportGroup).HasMaxLength(250);
            entity.Property(e => e.ReportId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ReportID");
            entity.Property(e => e.ReportLocalPath).HasMaxLength(250);
            entity.Property(e => e.ReportServerPath).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
        });

        modelBuilder.Entity<TransactionInvoice>(entity =>
        {
            entity.ToTable("Transaction_Invoice");

            entity.HasIndex(e => e.InvoiceCode, "IX_Transaction_Invoice")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.PlatinumTotal, "Transaction_Invoice_PlatinumTotal");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerDescription).HasMaxLength(250);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.InvoiceDescription).HasMaxLength(250);
            entity.Property(e => e.InvoiceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InvoiceID");
            entity.Property(e => e.NormalCustomer).HasMaxLength(250);
            entity.Property(e => e.Phone).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Customer).WithMany(p => p.TransactionInvoices)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Transaction_Invoice_Customer_Customer");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.TransactionInvoices)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Transaction_Invoice_Reference_SalesPerson");
        });

        modelBuilder.Entity<TransactionItemSale>(entity =>
        {
            entity.ToTable("Transaction_ItemSales");

            entity.HasIndex(e => e.ItemSalesCode, "IX_Transaction_ItemSales")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.SalesDate, "Transaction_ItemSales_SalesDate");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.ChangedWeightKpy).HasColumnName("ChangedWeightKPY");
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.InvoiceDescription).HasMaxLength(250);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemDescription).HasMaxLength(250);
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemSalesCode).HasMaxLength(50);
            entity.Property(e => e.ItemSalesDescription).HasMaxLength(250);
            entity.Property(e => e.ItemSalesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemSalesID");
            entity.Property(e => e.ItemWeightKpy).HasColumnName("ItemWeightKPY");
            entity.Property(e => e.JewelWeightKpy).HasColumnName("JewelWeightKPY");
            entity.Property(e => e.JointOption).HasComment("None,Add,Substract");
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.TotalGoldWeightKpy).HasColumnName("TotalGoldWeightKPY");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);
            entity.Property(e => e.WasteKpy).HasColumnName("WasteKPY");

            entity.HasOne(d => d.Counter).WithMany(p => p.TransactionItemSales)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_Transaction_ItemSales_Reference_Counter");

            entity.HasOne(d => d.Invoice).WithMany(p => p.TransactionItemSales)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_ItemSales_Transaction_Invoice");

            entity.HasOne(d => d.Item).WithMany(p => p.TransactionItemSales)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK_Transaction_ItemSales_Stock_Item");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.TransactionItemSales)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Transaction_ItemSales_Reference_SalesPerson");
        });

        modelBuilder.Entity<TransactionItemSalesCredit>(entity =>
        {
            entity.ToTable("Transaction_ItemSalesCredit");

            entity.HasIndex(e => e.ItemSalesCreditCode, "IX_Transaction_ItemSalesCredit")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.InvoiceDescription).HasMaxLength(250);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemSalesCreditCode).HasMaxLength(50);
            entity.Property(e => e.ItemSalesCreditDescription).HasMaxLength(250);
            entity.Property(e => e.ItemSalesCreditId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemSalesCreditID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Invoice).WithMany(p => p.TransactionItemSalesCredits)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_ItemSalesCredit_Transaction_Invoice");
        });

        modelBuilder.Entity<TransactionItemSalesDetail>(entity =>
        {
            entity.ToTable("Transaction_ItemSalesDetail");

            entity.HasIndex(e => e.ItemSalesDetailCode, "IX_Transaction_ItemSalesDetail")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ItemSalesId, "Transaction_ItemSalesDetail_ItemSalesID");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Dimension).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.ItemSalesCode).HasMaxLength(50);
            entity.Property(e => e.ItemSalesDescription).HasMaxLength(250);
            entity.Property(e => e.ItemSalesDetailCode).HasMaxLength(50);
            entity.Property(e => e.ItemSalesDetailDescription).HasMaxLength(250);
            entity.Property(e => e.ItemSalesDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ItemSalesDetailID");
            entity.Property(e => e.ItemSalesId).HasColumnName("ItemSalesID");
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId).HasColumnName("JewelTypeID");
            entity.Property(e => e.Kpy).HasColumnName("KPY");
            entity.Property(e => e.Shape).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.ItemSales).WithMany(p => p.TransactionItemSalesDetails)
                .HasForeignKey(d => d.ItemSalesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_ItemSalesDetail_Transaction_ItemSales");

            entity.HasOne(d => d.JewelType).WithMany(p => p.TransactionItemSalesDetails)
                .HasForeignKey(d => d.JewelTypeId)
                .HasConstraintName("FK_Transaction_ItemSalesDetail_Reference_JewelType");
        });

        modelBuilder.Entity<TransactionPlatinumSale>(entity =>
        {
            entity.ToTable("Transaction_PlatinumSales");

            entity.HasIndex(e => e.PlatinumSalesCode, "IX_Transaction_PlatinumSales")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.InvoiceDescription).HasMaxLength(250);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.PlatinumCode).HasMaxLength(50);
            entity.Property(e => e.PlatinumDescription).HasMaxLength(250);
            entity.Property(e => e.PlatinumId).HasColumnName("PlatinumID");
            entity.Property(e => e.PlatinumSalesCode).HasMaxLength(50);
            entity.Property(e => e.PlatinumSalesDescription).HasMaxLength(250);
            entity.Property(e => e.PlatinumSalesId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PlatinumSalesID");
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Counter).WithMany(p => p.TransactionPlatinumSales)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_Transaction_PlatinumSales_Reference_Counter");

            entity.HasOne(d => d.Invoice).WithMany(p => p.TransactionPlatinumSales)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_PlatinumSales_Transaction_Invoice");

            entity.HasOne(d => d.Platinum).WithMany(p => p.TransactionPlatinumSales)
                .HasForeignKey(d => d.PlatinumId)
                .HasConstraintName("FK_Transaction_PlatinumSales_Stock_Platinum");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.TransactionPlatinumSales)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Transaction_PlatinumSales_Reference_SalesPerson");
        });

        modelBuilder.Entity<TransactionPurchase>(entity =>
        {
            entity.ToTable("Transaction_Purchase");

            entity.HasIndex(e => e.PurchaseCode, "IX_Transaction_Purchase")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Category).HasMaxLength(250);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterDescription).HasMaxLength(250);
            entity.Property(e => e.CounterId).HasColumnName("CounterID");
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.GoldWeightKpy).HasColumnName("GoldWeightKPY");
            entity.Property(e => e.InvoiceCode).HasMaxLength(50);
            entity.Property(e => e.InvoiceDescription).HasMaxLength(250);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemWeightKpy).HasColumnName("ItemWeightKPY");
            entity.Property(e => e.JewelWeightKpy).HasColumnName("JewelWeightKPY");
            entity.Property(e => e.PurchaseCode).HasMaxLength(50);
            entity.Property(e => e.PurchaseDescription).HasMaxLength(250);
            entity.Property(e => e.PurchaseId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PurchaseID");
            entity.Property(e => e.RecycleType).HasDefaultValueSql("('-')");
            entity.Property(e => e.Remark).HasColumnType("ntext");
            entity.Property(e => e.SalesPersonCode).HasMaxLength(50);
            entity.Property(e => e.SalesPersonDescription).HasMaxLength(250);
            entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.Counter).WithMany(p => p.TransactionPurchases)
                .HasForeignKey(d => d.CounterId)
                .HasConstraintName("FK_Transaction_Purchase_Reference_Counter");

            entity.HasOne(d => d.Invoice).WithMany(p => p.TransactionPurchases)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Purchase_Transaction_Invoice");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.TransactionPurchases)
                .HasForeignKey(d => d.SalesPersonId)
                .HasConstraintName("FK_Transaction_Purchase_Reference_SalesPerson");
        });

        modelBuilder.Entity<TransactionPurchaseDetail>(entity =>
        {
            entity.ToTable("Transaction_PurchaseDetail");

            entity.HasIndex(e => e.PurchaseDetailCode, "IX_Transaction_PurchaseDetail")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newsequentialid())")
                .HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CreatedUser).HasMaxLength(250);
            entity.Property(e => e.Custom1).HasMaxLength(250);
            entity.Property(e => e.Custom2).HasMaxLength(250);
            entity.Property(e => e.Custom3).HasMaxLength(250);
            entity.Property(e => e.Custom4).HasMaxLength(250);
            entity.Property(e => e.Custom5).HasMaxLength(250);
            entity.Property(e => e.Enabled).HasDefaultValue(true);
            entity.Property(e => e.JewelTypeCode).HasMaxLength(50);
            entity.Property(e => e.JewelTypeDescription).HasMaxLength(250);
            entity.Property(e => e.JewelTypeId).HasColumnName("JewelTypeID");
            entity.Property(e => e.Kpy).HasColumnName("KPY");
            entity.Property(e => e.PurchaseCode).HasMaxLength(50);
            entity.Property(e => e.PurchaseDescription).HasMaxLength(250);
            entity.Property(e => e.PurchaseDetailCode).HasMaxLength(50);
            entity.Property(e => e.PurchaseDetailDescription).HasMaxLength(250);
            entity.Property(e => e.PurchaseDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PurchaseDetailID");
            entity.Property(e => e.PurchaseId).HasColumnName("PurchaseID");
            entity.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UpdatedUser).HasMaxLength(250);

            entity.HasOne(d => d.JewelType).WithMany(p => p.TransactionPurchaseDetails)
                .HasForeignKey(d => d.JewelTypeId)
                .HasConstraintName("FK_Transaction_PurchaseDetail_Reference_JewelType");

            entity.HasOne(d => d.Purchase).WithMany(p => p.TransactionPurchaseDetails)
                .HasForeignKey(d => d.PurchaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_PurchaseDetail_Transaction_Purchase");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
