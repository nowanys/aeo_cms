namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_addcus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerAttentionProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        CUR = c.String(maxLength: 10),
                        Pric = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SummaryQuote = c.Int(nullable: false),
                        SummaryOrders = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerBanks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bank = c.String(nullable: false, maxLength: 100),
                        AccountNo = c.String(nullable: false, maxLength: 100),
                        AccountName = c.String(nullable: false, maxLength: 100),
                        BankAddress = c.String(maxLength: 100),
                        BankPhoneNumber = c.String(maxLength: 100),
                        SWIFT = c.String(maxLength: 50),
                        CUR = c.String(maxLength: 10),
                        Remark = c.String(),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerContacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        Status = c.String(maxLength: 20),
                        EName = c.String(nullable: false, maxLength: 80),
                        Duty = c.String(nullable: false, maxLength: 80),
                        Sex = c.String(maxLength: 10),
                        Birthday = c.DateTime(),
                        Nation = c.String(),
                        Native = c.String(),
                        MobilePhone = c.String(maxLength: 50),
                        PhoneNumber1 = c.String(maxLength: 50),
                        PhoneNumber2 = c.String(maxLength: 50),
                        PhoneNumber3 = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 80),
                        QQ = c.String(maxLength: 50),
                        Wechat = c.String(maxLength: 50),
                        Work = c.String(maxLength: 50),
                        Feature = c.String(maxLength: 50),
                        Fan = c.String(maxLength: 50),
                        Demand = c.String(maxLength: 50),
                        IsLeave = c.Boolean(nullable: false),
                        Owner = c.String(maxLength: 20),
                        Remark = c.String(maxLength: 20),
                        Title = c.String(maxLength: 30),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Folder = c.String(maxLength: 20),
                        FilePath = c.String(),
                        RelativePath = c.String(),
                        Owner = c.String(maxLength: 20),
                        Upload = c.DateTime(nullable: false),
                        Ext = c.String(maxLength: 100),
                        FileId = c.String(maxLength: 100),
                        RefKey = c.String(maxLength: 100),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerFollows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        ContactName = c.String(nullable: false, maxLength: 80),
                        FollowType = c.String(maxLength: 20),
                        Status = c.String(maxLength: 20),
                        Owner = c.String(maxLength: 20),
                        FollowDate = c.DateTime(nullable: false),
                        Content = c.String(),
                        ReminderTime = c.DateTime(),
                        ReminderContent = c.String(),
                        ReminderTo = c.String(maxLength: 200),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        AbbName = c.String(maxLength: 50),
                        UpstreamFirm = c.String(maxLength: 80),
                        Company = c.String(maxLength: 80),
                        CustomerEName = c.String(nullable: false, maxLength: 80),
                        AbbEName = c.String(maxLength: 50),
                        Status = c.String(maxLength: 20),
                        CustomerType = c.String(maxLength: 50),
                        Overseas = c.Boolean(nullable: false),
                        Country = c.String(maxLength: 50),
                        GRegion = c.String(),
                        CRegion = c.String(),
                        Zone = c.String(maxLength: 150),
                        CustomCode = c.String(maxLength: 10),
                        Custom = c.String(maxLength: 10),
                        Level = c.Int(nullable: false),
                        Source = c.String(maxLength: 50),
                        Value = c.String(maxLength: 256),
                        PhoneNumber = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        Owner = c.String(nullable: false, maxLength: 20),
                        WebSite = c.String(maxLength: 256),
                        MainProduct = c.String(maxLength: 256),
                        Description = c.String(),
                        Address = c.String(maxLength: 256),
                        EnAddress = c.String(maxLength: 256),
                        InternAddress = c.String(maxLength: 256),
                        Province = c.String(maxLength: 50),
                        City = c.String(maxLength: 50),
                        County = c.String(maxLength: 50),
                        PostCode = c.String(maxLength: 10),
                        PayPeriod = c.Int(),
                        RecPeriod = c.Int(),
                        CreditLimit = c.Decimal(precision: 18, scale: 2),
                        CreditLevel = c.String(maxLength: 10),
                        DiscountRemark = c.String(maxLength: 256),
                        Remark = c.String(maxLength: 256),
                        LogoPic = c.String(maxLength: 256),
                        FollowState = c.String(maxLength: 20),
                        SalesStage = c.String(maxLength: 20),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        Status = c.String(maxLength: 20),
                        Sales = c.String(maxLength: 20),
                        SalesMail = c.String(maxLength: 120),
                        SalesPhoneNumber = c.String(maxLength: 120),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerShares",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(nullable: false, maxLength: 20),
                        Dept = c.String(maxLength: 20),
                        ShareTo = c.String(nullable: false, maxLength: 20),
                        Module = c.String(maxLength: 50),
                        Searchable = c.Boolean(nullable: false),
                        Editable = c.Boolean(nullable: false),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerWarehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Warehouse = c.String(maxLength: 20),
                        WAddress = c.String(maxLength: 256),
                        WUserName = c.String(maxLength: 256),
                        WPhoneNumber1 = c.String(maxLength: 256),
                        WPhoneNumber2 = c.String(maxLength: 256),
                        WPhoneNumber3 = c.String(maxLength: 256),
                        WEmail = c.String(maxLength: 256),
                        OnTime = c.String(maxLength: 20),
                        CloseTime = c.String(maxLength: 20),
                        OnSta = c.String(maxLength: 10),
                        OnSun = c.String(maxLength: 10),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerWarehouses");
            DropTable("dbo.CustomerShares");
            DropTable("dbo.CustomerSales");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerFollows");
            DropTable("dbo.CustomerFiles");
            DropTable("dbo.CustomerContacts");
            DropTable("dbo.CustomerBanks");
            DropTable("dbo.CustomerAttentionProducts");
        }
    }
}
