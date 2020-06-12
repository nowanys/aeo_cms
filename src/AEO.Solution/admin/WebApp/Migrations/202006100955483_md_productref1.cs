namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_productref1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductRefCustomerFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
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
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefCustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefCustomerPictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
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
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefCustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        AbbName = c.String(maxLength: 50),
                        AbbCode = c.String(maxLength: 20),
                        CustomerType = c.String(maxLength: 20),
                        Overseas = c.Boolean(nullable: false),
                        Zone = c.String(maxLength: 150),
                        Country = c.String(maxLength: 50),
                        BLNG_ETPS_VDCD = c.String(nullable: false, maxLength: 10),
                        BLNG_ETPS_NM = c.String(maxLength: 128),
                        CUSTOM_MASTER = c.String(maxLength: 128),
                        BLNG_ETPS_SCCD = c.String(maxLength: 128),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
                        RefStatus = c.String(maxLength: 20),
                        RefProductNature = c.String(maxLength: 50),
                        RefERPUnit = c.String(maxLength: 50),
                        RefProductType = c.String(maxLength: 50),
                        RefProductName = c.String(maxLength: 200),
                        RefProductEName = c.String(maxLength: 200),
                        RefAliasProductName1 = c.String(maxLength: 200),
                        RefAliasProductName2 = c.String(maxLength: 200),
                        RefAliasProductName3 = c.String(maxLength: 200),
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
                        TAXTYPE = c.String(maxLength: 50),
                        TAXCLASS = c.String(maxLength: 50),
                        HSADDTAXRATE = c.Decimal(precision: 18, scale: 2),
                        HSBACKTAXRATE = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefCustomerTrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
                        ERP_MATERIALPROP = c.String(maxLength: 50),
                        MTPCKENDPROMARK = c.String(maxLength: 50),
                        CUSTOMS_CODE = c.String(maxLength: 50),
                        F_EMS_NO = c.String(maxLength: 50),
                        EMS_TYPE = c.String(maxLength: 50),
                        CUS_GDS_SEQNO = c.String(maxLength: 50),
                        CPLX_EMS_SEQNO = c.String(maxLength: 50),
                        GDECD = c.String(maxLength: 50),
                        CIQ_CODE = c.String(maxLength: 50),
                        CST_CTRL_MARK = c.String(maxLength: 50),
                        CIQ_CTRL_MARK = c.String(maxLength: 50),
                        NEMS_BOND_INVT_NO = c.String(maxLength: 50),
                        F_UNIT = c.String(maxLength: 50),
                        LAWF_UNITCD = c.String(maxLength: 50),
                        SECD_LAWF_UNITCD = c.String(maxLength: 50),
                        GDS_SPCF_MODEL_DESC = c.String(maxLength: 50),
                        GDS_SPCF_MODEL_CUS = c.String(maxLength: 50),
                        GDS_MODEL = c.String(maxLength: 50),
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefCustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefSupplierFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(maxLength: 20),
                        SupplierName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
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
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefSupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefSupplierPictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(maxLength: 20),
                        SupplierName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
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
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefSupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefSuppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(maxLength: 20),
                        SupplierName = c.String(nullable: false, maxLength: 80),
                        AbbName = c.String(maxLength: 50),
                        AbbCode = c.String(maxLength: 20),
                        SupplierType = c.String(maxLength: 20),
                        Overseas = c.Boolean(nullable: false),
                        Zone = c.String(maxLength: 150),
                        Country = c.String(maxLength: 50),
                        BLNG_ETPS_VDCD = c.String(nullable: false, maxLength: 10),
                        BLNG_ETPS_NM = c.String(maxLength: 128),
                        CUSTOM_MASTER = c.String(maxLength: 128),
                        BLNG_ETPS_SCCD = c.String(maxLength: 128),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
                        RefStatus = c.String(maxLength: 20),
                        RefProductNature = c.String(maxLength: 50),
                        RefERPUnit = c.String(maxLength: 50),
                        RefProductType = c.String(maxLength: 50),
                        RefProductName = c.String(maxLength: 200),
                        RefProductEName = c.String(maxLength: 200),
                        RefAliasProductName1 = c.String(maxLength: 200),
                        RefAliasProductName2 = c.String(maxLength: 200),
                        RefAliasProductName3 = c.String(maxLength: 200),
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
                        TAXTYPE = c.String(maxLength: 50),
                        TAXCLASS = c.String(maxLength: 50),
                        HSADDTAXRATE = c.Decimal(precision: 18, scale: 2),
                        HSBACKTAXRATE = c.Decimal(precision: 18, scale: 2),
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductRefSupplierTrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(maxLength: 20),
                        SupplierName = c.String(nullable: false, maxLength: 80),
                        ProductNo = c.String(maxLength: 50),
                        RefProductNo = c.String(maxLength: 50),
                        ERP_MATERIALPROP = c.String(maxLength: 50),
                        MTPCKENDPROMARK = c.String(maxLength: 50),
                        CUSTOMS_CODE = c.String(maxLength: 50),
                        F_EMS_NO = c.String(maxLength: 50),
                        EMS_TYPE = c.String(maxLength: 50),
                        CUS_GDS_SEQNO = c.String(maxLength: 50),
                        CPLX_EMS_SEQNO = c.String(maxLength: 50),
                        GDECD = c.String(maxLength: 50),
                        CIQ_CODE = c.String(maxLength: 50),
                        CST_CTRL_MARK = c.String(maxLength: 50),
                        CIQ_CTRL_MARK = c.String(maxLength: 50),
                        NEMS_BOND_INVT_NO = c.String(maxLength: 50),
                        F_UNIT = c.String(maxLength: 50),
                        LAWF_UNITCD = c.String(maxLength: 50),
                        SECD_LAWF_UNITCD = c.String(maxLength: 50),
                        GDS_SPCF_MODEL_DESC = c.String(maxLength: 50),
                        GDS_SPCF_MODEL_CUS = c.String(maxLength: 50),
                        GDS_MODEL = c.String(maxLength: 50),
                        Remark = c.String(),
                        ProductId = c.Int(nullable: false),
                        ProductRefSupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerBanks", "AccountType", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankCode", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankCountry", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankUse", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankUser", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "BankFaxNumber", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "Provinces", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "County", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "BankAddress1", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankAddress2", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankAddress3", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerContacts", "Dept", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Customers", "BLNG_ETPS_VDCD", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Customers", "BLNG_ETPS_NM", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "BLNG_ETPS_SCCD", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "AbbCode", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CustomerType2", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CustomerProperty", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CustomerType3", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Capital", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Customers", "CURR", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "TaxProperty", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "ParentOrg", c => c.String(maxLength: 80));
            AddColumn("dbo.Customers", "CUSTOM_MASTER", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "TradeCode", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "Scale", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CreditRating", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "RefLevel", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Industry", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "Cash", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Customers", "CashCURR", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "SDesc", c => c.String());
            AddColumn("dbo.Customers", "CProvinces1", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CCity1", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CCounty1", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CAddress1", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "CProvinces2", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CCity2", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CCounty2", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "CAddress2", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "EAddress1", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "EAddress2", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "BusinessScope", c => c.String());
            AddColumn("dbo.Customers", "Remark1", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "Status1", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Status2", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Status3", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Status4", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "Status5", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesId", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesName", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesEName", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "Dept", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "StopCase", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerSales", "Remark", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerSales", "Assigner", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "AssignDate", c => c.DateTime());
            AddColumn("dbo.CustomerWarehouses", "WarehouseCode", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WarehouseName", c => c.String(maxLength: 128));
            AddColumn("dbo.CustomerWarehouses", "WarehouseType", c => c.String(maxLength: 128));
            AddColumn("dbo.CustomerWarehouses", "AppOubound", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerWarehouses", "AppInbound", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerWarehouses", "FactoryGuard", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerWarehouses", "Remark", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "Provinces", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "County", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "EAddress1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "EAddress2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "Remark1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "DOnTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "DCloseTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "DNWKTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStdA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStdP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStdN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "Remark2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WUser1", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WDept1", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WTitle1", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WSex1", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WPhone1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WFax", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WX1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WEmail1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WUser2", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WDept2", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WTitle2", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WSex2", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WPhone11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WFax11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone21", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WX2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WEmail2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WUser3", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WDept3", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WTitle3", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WSex3", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WPhone12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WFax12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone22", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WX3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WEmail3", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductExtends", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductFiles", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductPacks", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductPrictures", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductPurchaseHistoricalPrices", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductRefs", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.ProductSalesHistoricalPrices", "ProductId", c => c.Int(nullable: false));
            AlterColumn("dbo.CustomerBanks", "Bank", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "CustomerEName", c => c.String(maxLength: 80));
            AlterColumn("dbo.Customers", "CustomerType", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "Level", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "Remark", c => c.String());
            DropColumn("dbo.CustomerBanks", "BankAddress");
            DropColumn("dbo.CustomerContacts", "Birthday");
            DropColumn("dbo.CustomerContacts", "Nation");
            DropColumn("dbo.CustomerContacts", "Native");
            DropColumn("dbo.CustomerContacts", "QQ");
            DropColumn("dbo.CustomerContacts", "Wechat");
            DropColumn("dbo.CustomerContacts", "Work");
            DropColumn("dbo.CustomerContacts", "Feature");
            DropColumn("dbo.CustomerContacts", "Fan");
            DropColumn("dbo.CustomerContacts", "Demand");
            DropColumn("dbo.CustomerContacts", "IsLeave");
            DropColumn("dbo.CustomerContacts", "Owner");
            DropColumn("dbo.CustomerContacts", "Title");
            DropColumn("dbo.Customers", "UpstreamFirm");
            DropColumn("dbo.Customers", "Company");
            DropColumn("dbo.Customers", "CustomCode");
            DropColumn("dbo.Customers", "Custom");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Fax");
            DropColumn("dbo.Customers", "Owner");
            DropColumn("dbo.Customers", "MainProduct");
            DropColumn("dbo.Customers", "Description");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "EnAddress");
            DropColumn("dbo.Customers", "InternAddress");
            DropColumn("dbo.Customers", "Province");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "County");
            DropColumn("dbo.Customers", "PayPeriod");
            DropColumn("dbo.Customers", "RecPeriod");
            DropColumn("dbo.Customers", "CreditLimit");
            DropColumn("dbo.Customers", "CreditLevel");
            DropColumn("dbo.Customers", "DiscountRemark");
            DropColumn("dbo.Customers", "LogoPic");
            DropColumn("dbo.Customers", "FollowState");
            DropColumn("dbo.Customers", "SalesStage");
            DropColumn("dbo.CustomerSales", "Sales");
            DropColumn("dbo.CustomerSales", "SalesMail");
            DropColumn("dbo.CustomerSales", "SalesPhoneNumber");
            DropColumn("dbo.CustomerWarehouses", "Warehouse");
            DropColumn("dbo.CustomerWarehouses", "WUserName");
            DropColumn("dbo.CustomerWarehouses", "WPhoneNumber1");
            DropColumn("dbo.CustomerWarehouses", "WPhoneNumber2");
            DropColumn("dbo.CustomerWarehouses", "WPhoneNumber3");
            DropColumn("dbo.CustomerWarehouses", "WEmail");
            DropColumn("dbo.CustomerWarehouses", "OnTime");
            DropColumn("dbo.CustomerWarehouses", "CloseTime");
            DropColumn("dbo.CustomerWarehouses", "OnSta");
            DropColumn("dbo.CustomerWarehouses", "OnSun");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerWarehouses", "OnSun", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "OnSta", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "CloseTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WEmail", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhoneNumber3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhoneNumber2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhoneNumber1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WUserName", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "Warehouse", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesPhoneNumber", c => c.String(maxLength: 120));
            AddColumn("dbo.CustomerSales", "SalesMail", c => c.String(maxLength: 120));
            AddColumn("dbo.CustomerSales", "Sales", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "SalesStage", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "FollowState", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "LogoPic", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "DiscountRemark", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "CreditLevel", c => c.String(maxLength: 10));
            AddColumn("dbo.Customers", "CreditLimit", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Customers", "RecPeriod", c => c.Int());
            AddColumn("dbo.Customers", "PayPeriod", c => c.Int());
            AddColumn("dbo.Customers", "County", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "Province", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "InternAddress", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "EnAddress", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "Address", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "Description", c => c.String());
            AddColumn("dbo.Customers", "MainProduct", c => c.String(maxLength: 256));
            AddColumn("dbo.Customers", "Owner", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Customers", "Fax", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "Custom", c => c.String(maxLength: 10));
            AddColumn("dbo.Customers", "CustomCode", c => c.String(maxLength: 10));
            AddColumn("dbo.Customers", "Company", c => c.String(maxLength: 80));
            AddColumn("dbo.Customers", "UpstreamFirm", c => c.String(maxLength: 80));
            AddColumn("dbo.CustomerContacts", "Title", c => c.String(maxLength: 30));
            AddColumn("dbo.CustomerContacts", "Owner", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerContacts", "IsLeave", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerContacts", "Demand", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "Fan", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "Feature", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "Work", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "Wechat", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "QQ", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerContacts", "Native", c => c.String());
            AddColumn("dbo.CustomerContacts", "Nation", c => c.String());
            AddColumn("dbo.CustomerContacts", "Birthday", c => c.DateTime());
            AddColumn("dbo.CustomerBanks", "BankAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "Remark", c => c.String(maxLength: 256));
            AlterColumn("dbo.Customers", "Level", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerType", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "CustomerEName", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.CustomerBanks", "Bank", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.ProductSalesHistoricalPrices", "ProductId");
            DropColumn("dbo.ProductRefs", "ProductId");
            DropColumn("dbo.ProductPurchaseHistoricalPrices", "ProductId");
            DropColumn("dbo.ProductPrictures", "ProductId");
            DropColumn("dbo.ProductPacks", "ProductId");
            DropColumn("dbo.ProductFiles", "ProductId");
            DropColumn("dbo.ProductExtends", "ProductId");
            DropColumn("dbo.CustomerWarehouses", "WEmail3");
            DropColumn("dbo.CustomerWarehouses", "WX3");
            DropColumn("dbo.CustomerWarehouses", "QQ3");
            DropColumn("dbo.CustomerWarehouses", "WMPhone22");
            DropColumn("dbo.CustomerWarehouses", "WMPhone12");
            DropColumn("dbo.CustomerWarehouses", "WFax12");
            DropColumn("dbo.CustomerWarehouses", "WPhone12");
            DropColumn("dbo.CustomerWarehouses", "WSex3");
            DropColumn("dbo.CustomerWarehouses", "WTitle3");
            DropColumn("dbo.CustomerWarehouses", "WDept3");
            DropColumn("dbo.CustomerWarehouses", "WUser3");
            DropColumn("dbo.CustomerWarehouses", "WEmail2");
            DropColumn("dbo.CustomerWarehouses", "WX2");
            DropColumn("dbo.CustomerWarehouses", "QQ2");
            DropColumn("dbo.CustomerWarehouses", "WMPhone21");
            DropColumn("dbo.CustomerWarehouses", "WMPhone11");
            DropColumn("dbo.CustomerWarehouses", "WFax11");
            DropColumn("dbo.CustomerWarehouses", "WPhone11");
            DropColumn("dbo.CustomerWarehouses", "WSex2");
            DropColumn("dbo.CustomerWarehouses", "WTitle2");
            DropColumn("dbo.CustomerWarehouses", "WDept2");
            DropColumn("dbo.CustomerWarehouses", "WUser2");
            DropColumn("dbo.CustomerWarehouses", "WEmail1");
            DropColumn("dbo.CustomerWarehouses", "WX1");
            DropColumn("dbo.CustomerWarehouses", "QQ1");
            DropColumn("dbo.CustomerWarehouses", "WMPhone2");
            DropColumn("dbo.CustomerWarehouses", "WMPhone1");
            DropColumn("dbo.CustomerWarehouses", "WFax");
            DropColumn("dbo.CustomerWarehouses", "WPhone1");
            DropColumn("dbo.CustomerWarehouses", "WSex1");
            DropColumn("dbo.CustomerWarehouses", "WTitle1");
            DropColumn("dbo.CustomerWarehouses", "WDept1");
            DropColumn("dbo.CustomerWarehouses", "WUser1");
            DropColumn("dbo.CustomerWarehouses", "Remark2");
            DropColumn("dbo.CustomerWarehouses", "OnStdN");
            DropColumn("dbo.CustomerWarehouses", "OnStdP");
            DropColumn("dbo.CustomerWarehouses", "OnStdA");
            DropColumn("dbo.CustomerWarehouses", "OnSunN");
            DropColumn("dbo.CustomerWarehouses", "OnSunP");
            DropColumn("dbo.CustomerWarehouses", "OnSunA");
            DropColumn("dbo.CustomerWarehouses", "OnStaN");
            DropColumn("dbo.CustomerWarehouses", "OnStaP");
            DropColumn("dbo.CustomerWarehouses", "OnStaA");
            DropColumn("dbo.CustomerWarehouses", "DNWKTime");
            DropColumn("dbo.CustomerWarehouses", "DCloseTime");
            DropColumn("dbo.CustomerWarehouses", "DOnTime");
            DropColumn("dbo.CustomerWarehouses", "Remark1");
            DropColumn("dbo.CustomerWarehouses", "EAddress2");
            DropColumn("dbo.CustomerWarehouses", "EAddress1");
            DropColumn("dbo.CustomerWarehouses", "County");
            DropColumn("dbo.CustomerWarehouses", "City");
            DropColumn("dbo.CustomerWarehouses", "Provinces");
            DropColumn("dbo.CustomerWarehouses", "Remark");
            DropColumn("dbo.CustomerWarehouses", "FactoryGuard");
            DropColumn("dbo.CustomerWarehouses", "AppInbound");
            DropColumn("dbo.CustomerWarehouses", "AppOubound");
            DropColumn("dbo.CustomerWarehouses", "WarehouseType");
            DropColumn("dbo.CustomerWarehouses", "WarehouseName");
            DropColumn("dbo.CustomerWarehouses", "WarehouseCode");
            DropColumn("dbo.CustomerSales", "AssignDate");
            DropColumn("dbo.CustomerSales", "Assigner");
            DropColumn("dbo.CustomerSales", "Remark");
            DropColumn("dbo.CustomerSales", "StopCase");
            DropColumn("dbo.CustomerSales", "Dept");
            DropColumn("dbo.CustomerSales", "SalesEName");
            DropColumn("dbo.CustomerSales", "SalesName");
            DropColumn("dbo.CustomerSales", "SalesId");
            DropColumn("dbo.Customers", "Status5");
            DropColumn("dbo.Customers", "Status4");
            DropColumn("dbo.Customers", "Status3");
            DropColumn("dbo.Customers", "Status2");
            DropColumn("dbo.Customers", "Status1");
            DropColumn("dbo.Customers", "Remark1");
            DropColumn("dbo.Customers", "BusinessScope");
            DropColumn("dbo.Customers", "EAddress2");
            DropColumn("dbo.Customers", "EAddress1");
            DropColumn("dbo.Customers", "CAddress2");
            DropColumn("dbo.Customers", "CCounty2");
            DropColumn("dbo.Customers", "CCity2");
            DropColumn("dbo.Customers", "CProvinces2");
            DropColumn("dbo.Customers", "CAddress1");
            DropColumn("dbo.Customers", "CCounty1");
            DropColumn("dbo.Customers", "CCity1");
            DropColumn("dbo.Customers", "CProvinces1");
            DropColumn("dbo.Customers", "SDesc");
            DropColumn("dbo.Customers", "CashCURR");
            DropColumn("dbo.Customers", "Cash");
            DropColumn("dbo.Customers", "Industry");
            DropColumn("dbo.Customers", "RefLevel");
            DropColumn("dbo.Customers", "CreditRating");
            DropColumn("dbo.Customers", "Scale");
            DropColumn("dbo.Customers", "TradeCode");
            DropColumn("dbo.Customers", "CUSTOM_MASTER");
            DropColumn("dbo.Customers", "ParentOrg");
            DropColumn("dbo.Customers", "TaxProperty");
            DropColumn("dbo.Customers", "CURR");
            DropColumn("dbo.Customers", "Capital");
            DropColumn("dbo.Customers", "CustomerType3");
            DropColumn("dbo.Customers", "CustomerProperty");
            DropColumn("dbo.Customers", "CustomerType2");
            DropColumn("dbo.Customers", "AbbCode");
            DropColumn("dbo.Customers", "BLNG_ETPS_SCCD");
            DropColumn("dbo.Customers", "BLNG_ETPS_NM");
            DropColumn("dbo.Customers", "BLNG_ETPS_VDCD");
            DropColumn("dbo.CustomerContacts", "Dept");
            DropColumn("dbo.CustomerBanks", "BankAddress3");
            DropColumn("dbo.CustomerBanks", "BankAddress2");
            DropColumn("dbo.CustomerBanks", "BankAddress1");
            DropColumn("dbo.CustomerBanks", "County");
            DropColumn("dbo.CustomerBanks", "City");
            DropColumn("dbo.CustomerBanks", "Provinces");
            DropColumn("dbo.CustomerBanks", "BankFaxNumber");
            DropColumn("dbo.CustomerBanks", "BankUser");
            DropColumn("dbo.CustomerBanks", "BankUse");
            DropColumn("dbo.CustomerBanks", "BankCountry");
            DropColumn("dbo.CustomerBanks", "BankCode");
            DropColumn("dbo.CustomerBanks", "AccountType");
            DropTable("dbo.ProductRefSupplierTrades");
            DropTable("dbo.ProductRefSuppliers");
            DropTable("dbo.ProductRefSupplierPictures");
            DropTable("dbo.ProductRefSupplierFiles");
            DropTable("dbo.ProductRefCustomerTrades");
            DropTable("dbo.ProductRefCustomers");
            DropTable("dbo.ProductRefCustomerPictures");
            DropTable("dbo.ProductRefCustomerFiles");
        }
    }
}
