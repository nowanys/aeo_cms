﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;
using Z.EntityFramework.Plus;

namespace WebApp.Models
{
  public class StoreContext : DbContext
  {


   public StoreContext()
        : base("Name=DefaultConnection") {
      //获取登录用户信息,tenantid
      //QueryFilterManager.AllowPropertyFilter = true;
      //var claimsidentity = (ClaimsIdentity)HttpContext.Current.User?.Identity;
      //var tenantclaim = claimsidentity?.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid");
      //var tenantid = Convert.ToInt32(tenantclaim?.Value);
      //设置当对Work对象进行查询时默认添加过滤条件
      //QueryDbSetFilterManager.Filter<Work>(q => q.Where(x => x.TenantId == tenantid));
      //this.Filter<Work>(q => q.Where(x => x.TenantId == tenantid));
      //设置当对Order对象进行查询时默认添加过滤条件
      //QueryDbSetFilterManager.Filter<Order>(q => q.Where(x => x.TenantId == tenantid));
      //this.Filter<Order>(q => q.Where(x => x.TenantId == tenantid));
      //QueryDbSetFilterManager.InitilizeGlobalFilter(this);

    }
    //业务相关
   　
     public DbSet<Company> Companies { get; set; }
　

    public DbSet<Attachment> Attachments { get; set; }
    #region 产品库
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductPricture> ProductPrictures { get; set; }
    public DbSet<ProductExtend> ProductExtends { get; set; }
    public DbSet<ProductFile> ProductFiles { get; set; }
    public DbSet<ProductSalesHistoricalPrice>   ProductSalesHistoricalPrices { get; set; }
    public DbSet<ProductPurchaseHistoricalPrice> ProductPurchaseHistoricalPrices { get; set; }
    public DbSet<ProductAlias>  ProductAliases { get; set; }
    public DbSet<ProductPack> ProductPacks { get; set; }

    public DbSet<ProductRefCustomer> ProductRefCustomers { get; set; }
 
    public DbSet<ProductRefCustomerPicture> ProductRefCustomerPictures { get; set; }
    public DbSet<ProductRefCustomerTrade> ProductRefCustomerTrades { get; set; }

 


    #endregion

    #region 出口收汇
    public DbSet<ReceiptManage> ReceiptManages { get; set; }
    public DbSet<ReceiptManageBankFL> ReceiptManageBankFLs { get; set; }
    public DbSet<ReceiptManageCharge> ReceiptManageCharges { get; set; }
    public DbSet<ReceiptManageFile> ReceiptManageFiles { get; set; }
    public DbSet<ReceiptManageProduct> ReceiptManageProducts { get; set; }
    public DbSet<ReceiptManageRecDetail> ReceiptManageRecDetails { get; set; }
    #endregion
    #region 客户相关
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAttentionProduct> CustomerAttentionProducts { get; set; }
    public DbSet<CustomerBank> CustomerBanks { get; set; }
    public DbSet<CustomerContact> CustomerContacts { get; set; }
    public DbSet<CustomerFile> CustomerFiles { get; set; }
    public DbSet<CustomerFollow> CustomerFollows { get; set; }
    public DbSet<CustomerSales> CustomerSales { get; set; }
    public DbSet<CustomerShare> CustomerShares { get; set; }
    public DbSet<CustomerWarehouse> CustomerWarehouses { get; set; }

    #endregion

    //业务相关

    #region 系统必须
    public DbSet<CodeItem> CodeItems { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<RoleMenu> RoleMenus { get; set; }
    public DbSet<DataTableImportMapping> DataTableImportMappings { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    #endregion



    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
      var currentDateTime = DateTime.Now;
      var claimsidentity = (ClaimsIdentity)HttpContext.Current?.User.Identity;
      var tenantclaim = claimsidentity?.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid");
      var tenantid = Convert.ToInt32(tenantclaim?.Value);
      foreach (var auditableEntity in this.ChangeTracker.Entries<Entity>())
      {
        if (auditableEntity.State == EntityState.Added || auditableEntity.State == EntityState.Modified)
        {
          //auditableEntity.Entity.LastModifiedDate = currentDateTime;
          switch (auditableEntity.State)
          {
            case EntityState.Added:
              auditableEntity.Property("LastModifiedDate").IsModified = false;
              auditableEntity.Property("LastModifiedBy").IsModified = false;
              auditableEntity.Entity.CreatedDate = currentDateTime;
              auditableEntity.Entity.CreatedBy = claimsidentity.Name;
              auditableEntity.Entity.TenantId = tenantid;
              break;
            case EntityState.Modified:
              auditableEntity.Property("CreatedDate").IsModified = false;
              auditableEntity.Property("CreatedBy").IsModified = false;
              auditableEntity.Entity.LastModifiedDate = currentDateTime;
              auditableEntity.Entity.LastModifiedBy = claimsidentity.Name;
              auditableEntity.Entity.TenantId = tenantid;
              //if (auditableEntity.Property(p => p.Created).IsModified || auditableEntity.Property(p => p.CreatedBy).IsModified)
              //{
              //    throw new DbEntityValidationException(string.Format("Attempt to change created audit trails on a modified {0}", auditableEntity.Entity.GetType().FullName));
              //}
              break;
          }
        }
      }
      return base.SaveChangesAsync(cancellationToken);
    }

    public override int SaveChanges()
    {
      var currentDateTime = DateTime.Now;
      var claimsidentity =(ClaimsIdentity)HttpContext.Current?.User.Identity;
      var tenantclaim = claimsidentity?.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid");
      var tenantid = Convert.ToInt32(tenantclaim?.Value);
      foreach (var auditableEntity in this.ChangeTracker.Entries<Entity>())
      {
        if (auditableEntity.State == EntityState.Added || auditableEntity.State == EntityState.Modified)
        {
          auditableEntity.Entity.LastModifiedDate = currentDateTime;
          switch (auditableEntity.State)
          {
            case EntityState.Added:
              auditableEntity.Property("LastModifiedDate").IsModified = false;
              auditableEntity.Property("LastModifiedBy").IsModified = false;
              auditableEntity.Entity.CreatedDate = currentDateTime;
              auditableEntity.Entity.CreatedBy = claimsidentity.Name;
              auditableEntity.Entity.TenantId = tenantid;
              break;
            case EntityState.Modified:
              auditableEntity.Property("CreatedDate").IsModified = false;
              auditableEntity.Property("CreatedBy").IsModified = false;
              auditableEntity.Entity.LastModifiedDate = currentDateTime;
              auditableEntity.Entity.LastModifiedBy = claimsidentity.Name;
              auditableEntity.Entity.TenantId = tenantid;
              break;
          }
        }
      }
      return base.SaveChanges();
    }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //Oracle 表所有者，（SQL 改成 dbo(默认)，也可删除此设置）
      //this.ApplyAllConventionsIfOracle(modelBuilder);
      //modelBuilder.HasDefaultSchema(DbSchema);
      ////将数据列转换成大写
      //modelBuilder.Conventions.Add<UpperCaseColumnNameConvention>();
      ////将TableName转大写,TableName 指定的除外
      //modelBuilder.Conventions.Add<UpperCaseTableNameConvention>();

      #region 设置特殊格式以及浮点型长度
      //统一设置Decimal 长度（数据库实际位数可以缩短）
      //modelBuilder.Properties<decimal>().Configure(c => c.HasPrecision(18, 5));
　



      #endregion

      ////关闭一对多的级联删除。
      //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
      ////关闭多对多的级联删除。
      //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
      ////移除EF的表名公约  
      //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      ////移除对MetaData表的查询验证，否则每次都要访问Metadata这个表
      //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

      ////数据库不存在时重新创建数据库
      //Database.SetInitializer<StoreContext>(new CreateDatabaseIfNotExists<WebdbContext>());
      ////每次启动应用程序时创建数据库
      //Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<WebdbContext>());
      ////模型更改时重新创建数据库
      //Database.SetInitializer<StoreContext>(new DropCreateDatabaseIfModelChanges<WebdbContext>());
      ////从不创建数据库
      //Database.SetInitializer<StoreContext>(null);

      base.OnModelCreating(modelBuilder);
    }

  }



}