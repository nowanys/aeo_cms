namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_productions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductExtends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PurchasingDepartment = c.String(maxLength: 50),
                        Buyer = c.String(maxLength: 20),
                        MinPQty = c.Decimal(precision: 18, scale: 2),
                        MinDQty = c.Decimal(precision: 18, scale: 2),
                        PUnit = c.String(maxLength: 20),
                        PGroupPrice1 = c.String(maxLength: 20),
                        PGroupPrice2 = c.String(maxLength: 20),
                        PGroupPrice3 = c.String(maxLength: 20),
                        SalesDepartment = c.String(maxLength: 50),
                        Sales = c.String(maxLength: 20),
                        MinOQty = c.Decimal(precision: 18, scale: 2),
                        MinSQty = c.Decimal(precision: 18, scale: 2),
                        SUnit = c.String(maxLength: 20),
                        SGroupPrice1 = c.String(maxLength: 20),
                        SGroupPrice2 = c.String(maxLength: 20),
                        SGroupPrice3 = c.String(maxLength: 20),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 100),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Folder = c.String(maxLength: 20),
                        FileId = c.String(maxLength: 100),
                        Ext = c.String(maxLength: 100),
                        FilePath = c.String(),
                        RelativePath = c.String(),
                        RefKey = c.String(maxLength: 100),
                        Owner = c.String(maxLength: 20),
                        Upload = c.DateTime(nullable: false),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Package = c.String(nullable: false, maxLength: 10),
                        InnerBoxQty = c.Decimal(precision: 18, scale: 2),
                        Length = c.Decimal(precision: 18, scale: 2),
                        Width = c.Decimal(precision: 18, scale: 2),
                        Height = c.Decimal(precision: 18, scale: 2),
                        Unit = c.String(maxLength: 10),
                        GWeight = c.Decimal(precision: 18, scale: 2),
                        NWeight = c.Decimal(precision: 18, scale: 2),
                        Volume = c.Decimal(precision: 18, scale: 2),
                        TwentyQtc = c.Decimal(precision: 18, scale: 2),
                        FortyQtc = c.Decimal(precision: 18, scale: 2),
                        FortyHQQtc = c.Decimal(precision: 18, scale: 2),
                        Default = c.Boolean(nullable: false),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPrictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 100),
                        LineNo = c.Int(nullable: false),
                        Size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Folder = c.String(maxLength: 20),
                        FileId = c.String(maxLength: 100),
                        Ext = c.String(maxLength: 100),
                        FilePath = c.String(),
                        RelativePath = c.String(),
                        Owner = c.String(maxLength: 20),
                        Upload = c.DateTime(nullable: false),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductPurchaseHistoricalPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 80),
                        SupplierName = c.String(maxLength: 80),
                        FactoryProductNo = c.String(maxLength: 80),
                        QuoteDate = c.DateTime(nullable: false),
                        CUR = c.String(maxLength: 10),
                        SaluPric = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Source = c.String(maxLength: 10),
                        DocNo = c.String(maxLength: 100),
                        Remark = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        ProductEName = c.String(maxLength: 200),
                        CustomerType = c.String(maxLength: 50),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerProductNo = c.String(maxLength: 50),
                        Desc = c.String(maxLength: 200),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BLNG_ETPS_VDCD = c.String(nullable: false, maxLength: 10),
                        BLNG_ETPS_NM = c.String(maxLength: 128),
                        CUSTOM_MASTER = c.String(maxLength: 128),
                        BLNG_ETPS_SCCD = c.String(maxLength: 128),
                        ProductNo = c.String(maxLength: 50),
                        Status = c.String(maxLength: 20),
                        Status1 = c.String(maxLength: 20),
                        Status2 = c.String(maxLength: 20),
                        Status3 = c.String(maxLength: 20),
                        ProductNature = c.String(maxLength: 50),
                        FactoryCode = c.String(maxLength: 128),
                        FactoryName = c.String(maxLength: 128),
                        ERPUnit = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        ProductEName = c.String(maxLength: 200),
                        AliasProductName1 = c.String(maxLength: 200),
                        AliasProductName2 = c.String(maxLength: 200),
                        AliasProductName3 = c.String(maxLength: 200),
                        Model = c.String(maxLength: 100),
                        EDesc = c.String(),
                        Desc = c.String(),
                        Remark = c.String(),
                        CategoryName = c.String(maxLength: 50),
                        CategoryName1 = c.String(maxLength: 50),
                        CategoryName2 = c.String(maxLength: 50),
                        Flag1 = c.String(maxLength: 50),
                        Flag2 = c.String(maxLength: 50),
                        Flag3 = c.String(maxLength: 50),
                        Group1 = c.String(maxLength: 50),
                        Group2 = c.String(maxLength: 50),
                        Group3 = c.String(maxLength: 50),
                        Group4 = c.String(maxLength: 50),
                        Logo = c.String(),
                        HSCODE = c.String(maxLength: 10),
                        HSADDTAXRATE = c.Decimal(precision: 18, scale: 2),
                        HSBACKTAXRATE = c.Decimal(precision: 18, scale: 2),
                        GUIDEPRICE = c.Decimal(precision: 18, scale: 2),
                        CUSTBASIC = c.String(),
                        COUNTRY = c.String(maxLength: 128),
                        TAXTYPE = c.String(maxLength: 50),
                        TAXCLASS = c.String(maxLength: 50),
                        Package = c.String(maxLength: 10),
                        Unit = c.String(maxLength: 10),
                        GWeight = c.Decimal(precision: 18, scale: 2),
                        GWUnit = c.String(maxLength: 10),
                        NWeight = c.Decimal(precision: 18, scale: 2),
                        NWUnit = c.String(maxLength: 10),
                        Volume = c.Decimal(precision: 18, scale: 2),
                        VUnit = c.String(maxLength: 10),
                        Length = c.Decimal(precision: 18, scale: 2),
                        Width = c.Decimal(precision: 18, scale: 2),
                        High = c.Decimal(precision: 18, scale: 2),
                        LUnit = c.String(maxLength: 10),
                        Attribute1 = c.String(maxLength: 128),
                        Attribute2 = c.String(maxLength: 128),
                        Attribute3 = c.String(maxLength: 128),
                        Attribute4 = c.String(maxLength: 128),
                        Attribute5 = c.String(maxLength: 128),
                        Attribute6 = c.String(maxLength: 128),
                        Attribute7 = c.String(maxLength: 128),
                        Attribute8 = c.String(maxLength: 128),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSalesHistoricalPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 80),
                        CustomerName = c.String(maxLength: 80),
                        CustomerProductNo = c.String(maxLength: 80),
                        QuoteDate = c.DateTime(nullable: false),
                        Country = c.String(maxLength: 20),
                        CUR = c.String(maxLength: 10),
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
            DropTable("dbo.ProductSalesHistoricalPrices");
            DropTable("dbo.Products");
            DropTable("dbo.ProductRefs");
            DropTable("dbo.ProductPurchaseHistoricalPrices");
            DropTable("dbo.ProductPrictures");
            DropTable("dbo.ProductPacks");
            DropTable("dbo.ProductFiles");
            DropTable("dbo.ProductExtends");
        }
    }
}
