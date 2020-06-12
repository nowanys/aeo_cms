namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductAlias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductNo = c.String(maxLength: 50),
                        ProductName = c.String(maxLength: 200),
                        ThirdProductNo = c.String(maxLength: 50),
                        CustomerCode = c.String(nullable: false, maxLength: 20),
                        CustomerName = c.String(nullable: false, maxLength: 80),
                        CustomerType = c.String(maxLength: 50),
                        ProductEnName = c.String(maxLength: 200),
                        CnDescription = c.String(maxLength: 200),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Customers", "CustomMaster", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "CompanyCode", c => c.String(maxLength: 10));
            AddColumn("dbo.Customers", "CompanyName", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "CompanyId", c => c.Int());
            AddColumn("dbo.CustomerWarehouses", "WUser", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WDept", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WSex", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WPhone", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductPurchaseHistoricalPrices", "SupplierCode", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.ProductPurchaseHistoricalPrices", "ThirdProductNo", c => c.String(maxLength: 80));
            AddColumn("dbo.ProductRefCustomerPictures", "ThirdProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "ThirdProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "ThirdProductNature", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "ThirdUnit", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "ThirdProductType", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "ThirdProductName", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "ThirdProductEnName", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "ThirdAliasProductName", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "Group", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "ProductEnName", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "ProductNoAlias", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "CnDescription", c => c.String());
            AddColumn("dbo.Products", "EnDescription", c => c.String());
            AddColumn("dbo.Products", "Category", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "Group", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "InnerBoxQty", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Products", "ProductNoAlias2", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "ProductNoAlias3", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "CompanyCode", c => c.String(maxLength: 10));
            AddColumn("dbo.Products", "CompanyName", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "CompanyId", c => c.Int());
            AddColumn("dbo.ProductSalesHistoricalPrices", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.ProductSalesHistoricalPrices", "ThirdProductNo", c => c.String(maxLength: 80));
            AddColumn("dbo.ProductSalesHistoricalPrices", "SaluPric", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProductSalesHistoricalPrices", "Qty", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ProductSalesHistoricalPrices", "Source", c => c.String(maxLength: 10));
            AddColumn("dbo.ProductSalesHistoricalPrices", "DocNo", c => c.String(maxLength: 100));
            AddColumn("dbo.ProductSalesHistoricalPrices", "Remark", c => c.String());
            AddColumn("dbo.ReceiptManageFiles", "ReceiptManageId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductPurchaseHistoricalPrices", "ProductNo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ProductPurchaseHistoricalPrices", "ProductName", c => c.String(maxLength: 200));
            AlterColumn("dbo.Products", "Status", c => c.String(maxLength: 10));
            AlterColumn("dbo.Products", "Flag1", c => c.String(maxLength: 20));
            AlterColumn("dbo.Products", "Flag2", c => c.String(maxLength: 20));
            AlterColumn("dbo.Products", "Flag3", c => c.String(maxLength: 20));
            AlterColumn("dbo.ProductSalesHistoricalPrices", "ProductNo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ProductSalesHistoricalPrices", "ProductName", c => c.String(maxLength: 200));
            CreateIndex("dbo.CustomerAttentionProducts", "CustomerId");
            CreateIndex("dbo.CustomerBanks", "CustomerId");
            CreateIndex("dbo.CustomerContacts", "CustomerId");
            CreateIndex("dbo.CustomerFiles", "CustomerId");
            CreateIndex("dbo.CustomerFollows", "CustomerId");
            CreateIndex("dbo.CustomerSales", "CustomerId");
            CreateIndex("dbo.CustomerShares", "CustomerId");
            CreateIndex("dbo.CustomerWarehouses", "CustomerId");
            CreateIndex("dbo.Products", "ProductNo", unique: true);
            CreateIndex("dbo.ProductExtends", "ProductId");
            CreateIndex("dbo.ProductFiles", "ProductId");
            CreateIndex("dbo.ProductPacks", "ProductId");
            CreateIndex("dbo.ProductPrictures", "ProductId");
            CreateIndex("dbo.ProductPurchaseHistoricalPrices", "ProductId");
            CreateIndex("dbo.ProductRefCustomerPictures", "ProductId");
            CreateIndex("dbo.ProductRefCustomerPictures", "ProductRefCustomerId");
            CreateIndex("dbo.ProductRefCustomers", "ProductId");
            CreateIndex("dbo.ProductSalesHistoricalPrices", "ProductId");
            CreateIndex("dbo.ReceiptManageBankFLs", "ReceiptManageId");
            CreateIndex("dbo.ReceiptManageCharges", "ReceiptManageId");
            CreateIndex("dbo.ReceiptManageFiles", "ReceiptManageId");
            CreateIndex("dbo.ReceiptManageProducts", "ReceiptManageId");
            CreateIndex("dbo.ReceiptManageRecDetails", "ReceiptManageId");
            AddForeignKey("dbo.CustomerAttentionProducts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerBanks", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerContacts", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerFiles", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerFollows", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerSales", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerShares", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CustomerWarehouses", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductExtends", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductFiles", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductPacks", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductPrictures", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductPurchaseHistoricalPrices", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductRefCustomerPictures", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductRefCustomers", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductRefCustomerPictures", "ProductRefCustomerId", "dbo.ProductRefCustomers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.ProductSalesHistoricalPrices", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReceiptManageBankFLs", "ReceiptManageId", "dbo.ReceiptManages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReceiptManageCharges", "ReceiptManageId", "dbo.ReceiptManages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReceiptManageFiles", "ReceiptManageId", "dbo.ReceiptManages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReceiptManageProducts", "ReceiptManageId", "dbo.ReceiptManages", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ReceiptManageRecDetails", "ReceiptManageId", "dbo.ReceiptManages", "Id", cascadeDelete: true);
            DropColumn("dbo.CustomerBanks", "BankCode");
            DropColumn("dbo.CustomerBanks", "BankUser");
            DropColumn("dbo.CustomerBanks", "BankPhoneNumber");
            DropColumn("dbo.CustomerBanks", "BankFaxNumber");
            DropColumn("dbo.CustomerBanks", "Provinces");
            DropColumn("dbo.CustomerBanks", "City");
            DropColumn("dbo.CustomerBanks", "County");
            DropColumn("dbo.CustomerBanks", "BankAddress3");
            DropColumn("dbo.Customers", "BLNG_ETPS_VDCD");
            DropColumn("dbo.Customers", "BLNG_ETPS_NM");
            DropColumn("dbo.Customers", "BLNG_ETPS_SCCD");
            DropColumn("dbo.Customers", "CustomerType2");
            DropColumn("dbo.Customers", "CUSTOM_MASTER");
            DropColumn("dbo.Customers", "RefLevel");
            DropColumn("dbo.CustomerWarehouses", "AppOubound");
            DropColumn("dbo.CustomerWarehouses", "AppInbound");
            DropColumn("dbo.CustomerWarehouses", "EAddress2");
            DropColumn("dbo.CustomerWarehouses", "DOnTime");
            DropColumn("dbo.CustomerWarehouses", "DCloseTime");
            DropColumn("dbo.CustomerWarehouses", "DNWKTime");
            DropColumn("dbo.CustomerWarehouses", "OnStaA");
            DropColumn("dbo.CustomerWarehouses", "OnStaP");
            DropColumn("dbo.CustomerWarehouses", "OnStaN");
            DropColumn("dbo.CustomerWarehouses", "OnSunA");
            DropColumn("dbo.CustomerWarehouses", "OnSunP");
            DropColumn("dbo.CustomerWarehouses", "OnSunN");
            DropColumn("dbo.CustomerWarehouses", "OnStdA");
            DropColumn("dbo.CustomerWarehouses", "OnStdP");
            DropColumn("dbo.CustomerWarehouses", "OnStdN");
            DropColumn("dbo.CustomerWarehouses", "Remark2");
            DropColumn("dbo.CustomerWarehouses", "WUser1");
            DropColumn("dbo.CustomerWarehouses", "WDept1");
            DropColumn("dbo.CustomerWarehouses", "WTitle1");
            DropColumn("dbo.CustomerWarehouses", "WSex1");
            DropColumn("dbo.CustomerWarehouses", "WPhone1");
            DropColumn("dbo.CustomerWarehouses", "QQ1");
            DropColumn("dbo.CustomerWarehouses", "WX1");
            DropColumn("dbo.CustomerWarehouses", "WUser2");
            DropColumn("dbo.CustomerWarehouses", "WDept2");
            DropColumn("dbo.CustomerWarehouses", "WTitle2");
            DropColumn("dbo.CustomerWarehouses", "WSex2");
            DropColumn("dbo.CustomerWarehouses", "WPhone11");
            DropColumn("dbo.CustomerWarehouses", "WFax11");
            DropColumn("dbo.CustomerWarehouses", "WMPhone11");
            DropColumn("dbo.CustomerWarehouses", "WMPhone21");
            DropColumn("dbo.CustomerWarehouses", "QQ2");
            DropColumn("dbo.CustomerWarehouses", "WX2");
            DropColumn("dbo.CustomerWarehouses", "WEmail2");
            DropColumn("dbo.CustomerWarehouses", "WUser3");
            DropColumn("dbo.CustomerWarehouses", "WDept3");
            DropColumn("dbo.CustomerWarehouses", "WTitle3");
            DropColumn("dbo.CustomerWarehouses", "WSex3");
            DropColumn("dbo.CustomerWarehouses", "WPhone12");
            DropColumn("dbo.CustomerWarehouses", "WFax12");
            DropColumn("dbo.CustomerWarehouses", "WMPhone12");
            DropColumn("dbo.CustomerWarehouses", "WMPhone22");
            DropColumn("dbo.CustomerWarehouses", "QQ3");
            DropColumn("dbo.CustomerWarehouses", "WX3");
            DropColumn("dbo.CustomerWarehouses", "WEmail3");
            DropColumn("dbo.ProductPurchaseHistoricalPrices", "FactoryProductNo");
            DropColumn("dbo.ProductRefCustomerPictures", "RefProductNo");
            DropColumn("dbo.ProductRefCustomers", "BLNG_ETPS_VDCD");
            DropColumn("dbo.ProductRefCustomers", "BLNG_ETPS_NM");
            DropColumn("dbo.ProductRefCustomers", "CUSTOM_MASTER");
            DropColumn("dbo.ProductRefCustomers", "BLNG_ETPS_SCCD");
            DropColumn("dbo.ProductRefCustomers", "RefProductNo");
            DropColumn("dbo.ProductRefCustomers", "RefStatus");
            DropColumn("dbo.ProductRefCustomers", "RefProductNature");
            DropColumn("dbo.ProductRefCustomers", "RefERPUnit");
            DropColumn("dbo.ProductRefCustomers", "RefProductType");
            DropColumn("dbo.ProductRefCustomers", "RefProductName");
            DropColumn("dbo.ProductRefCustomers", "RefProductEName");
            DropColumn("dbo.ProductRefCustomers", "RefAliasProductName1");
            DropColumn("dbo.ProductRefCustomers", "RefAliasProductName2");
            DropColumn("dbo.ProductRefCustomers", "RefAliasProductName3");
            DropColumn("dbo.ProductRefCustomers", "CategoryName1");
            DropColumn("dbo.ProductRefCustomers", "CategoryName2");
            DropColumn("dbo.ProductRefCustomers", "Group1");
            DropColumn("dbo.ProductRefCustomers", "Group2");
            DropColumn("dbo.ProductRefCustomers", "Group3");
            DropColumn("dbo.ProductRefCustomers", "Group4");
            DropColumn("dbo.Products", "BLNG_ETPS_VDCD");
            DropColumn("dbo.Products", "BLNG_ETPS_NM");
            DropColumn("dbo.Products", "CUSTOM_MASTER");
            DropColumn("dbo.Products", "BLNG_ETPS_SCCD");
            DropColumn("dbo.Products", "FactoryCode");
            DropColumn("dbo.Products", "FactoryName");
            DropColumn("dbo.Products", "ERPUnit");
            DropColumn("dbo.Products", "ProductEName");
            DropColumn("dbo.Products", "AliasProductName1");
            DropColumn("dbo.Products", "AliasProductName2");
            DropColumn("dbo.Products", "AliasProductName3");
            DropColumn("dbo.Products", "EDesc");
            DropColumn("dbo.Products", "Desc");
            DropColumn("dbo.Products", "CategoryName");
            DropColumn("dbo.Products", "CategoryName1");
            DropColumn("dbo.Products", "CategoryName2");
            DropColumn("dbo.Products", "Group1");
            DropColumn("dbo.ProductSalesHistoricalPrices", "CustomerProductNo");
            DropColumn("dbo.ProductSalesHistoricalPrices", "Country");
            DropTable("dbo.ProductRefCustomerFiles");
            DropTable("dbo.ProductRefs");
            DropTable("dbo.ProductRefSupplierFiles");
            DropTable("dbo.ProductRefSupplierPictures");
            DropTable("dbo.ProductRefSuppliers");
            DropTable("dbo.ProductRefSupplierTrades");
        }
        
        public override void Down()
        {
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
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.ProductSalesHistoricalPrices", "Country", c => c.String(maxLength: 20));
            AddColumn("dbo.ProductSalesHistoricalPrices", "CustomerProductNo", c => c.String(maxLength: 80));
            AddColumn("dbo.Products", "Group1", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "CategoryName2", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "CategoryName1", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "CategoryName", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "Desc", c => c.String());
            AddColumn("dbo.Products", "EDesc", c => c.String());
            AddColumn("dbo.Products", "AliasProductName3", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "AliasProductName2", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "AliasProductName1", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "ProductEName", c => c.String(maxLength: 200));
            AddColumn("dbo.Products", "ERPUnit", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "FactoryName", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "FactoryCode", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "BLNG_ETPS_SCCD", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "CUSTOM_MASTER", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "BLNG_ETPS_NM", c => c.String(maxLength: 128));
            AddColumn("dbo.Products", "BLNG_ETPS_VDCD", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ProductRefCustomers", "Group4", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "Group3", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "Group2", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "Group1", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "CategoryName2", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "CategoryName1", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "RefAliasProductName3", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "RefAliasProductName2", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "RefAliasProductName1", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "RefProductEName", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "RefProductName", c => c.String(maxLength: 200));
            AddColumn("dbo.ProductRefCustomers", "RefProductType", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "RefERPUnit", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "RefProductNature", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "RefStatus", c => c.String(maxLength: 20));
            AddColumn("dbo.ProductRefCustomers", "RefProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductRefCustomers", "BLNG_ETPS_SCCD", c => c.String(maxLength: 128));
            AddColumn("dbo.ProductRefCustomers", "CUSTOM_MASTER", c => c.String(maxLength: 128));
            AddColumn("dbo.ProductRefCustomers", "BLNG_ETPS_NM", c => c.String(maxLength: 128));
            AddColumn("dbo.ProductRefCustomers", "BLNG_ETPS_VDCD", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.ProductRefCustomerPictures", "RefProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductPurchaseHistoricalPrices", "FactoryProductNo", c => c.String(maxLength: 80));
            AddColumn("dbo.CustomerWarehouses", "WEmail3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WX3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ3", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone22", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WFax12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhone12", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WSex3", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WTitle3", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WDept3", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WUser3", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WEmail2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WX2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone21", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WMPhone11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WFax11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhone11", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WSex2", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WTitle2", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WDept2", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WUser2", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "WX1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "QQ1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WPhone1", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "WSex1", c => c.String(maxLength: 10));
            AddColumn("dbo.CustomerWarehouses", "WTitle1", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WDept1", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerWarehouses", "WUser1", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "Remark2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "OnStdN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStdP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStdA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnSunA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaN", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaP", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "OnStaA", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "DNWKTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "DCloseTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "DOnTime", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerWarehouses", "EAddress2", c => c.String(maxLength: 256));
            AddColumn("dbo.CustomerWarehouses", "AppInbound", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerWarehouses", "AppOubound", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "RefLevel", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CUSTOM_MASTER", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "CustomerType2", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "BLNG_ETPS_SCCD", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "BLNG_ETPS_NM", c => c.String(maxLength: 128));
            AddColumn("dbo.Customers", "BLNG_ETPS_VDCD", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.CustomerBanks", "BankAddress3", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "County", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "City", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "Provinces", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "BankFaxNumber", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankPhoneNumber", c => c.String(maxLength: 100));
            AddColumn("dbo.CustomerBanks", "BankUser", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerBanks", "BankCode", c => c.String(maxLength: 100));
            DropForeignKey("dbo.ReceiptManageRecDetails", "ReceiptManageId", "dbo.ReceiptManages");
            DropForeignKey("dbo.ReceiptManageProducts", "ReceiptManageId", "dbo.ReceiptManages");
            DropForeignKey("dbo.ReceiptManageFiles", "ReceiptManageId", "dbo.ReceiptManages");
            DropForeignKey("dbo.ReceiptManageCharges", "ReceiptManageId", "dbo.ReceiptManages");
            DropForeignKey("dbo.ReceiptManageBankFLs", "ReceiptManageId", "dbo.ReceiptManages");
            DropForeignKey("dbo.ProductSalesHistoricalPrices", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductRefCustomerPictures", "ProductRefCustomerId", "dbo.ProductRefCustomers");
            DropForeignKey("dbo.ProductRefCustomers", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductRefCustomerPictures", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductPurchaseHistoricalPrices", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductPrictures", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductPacks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductFiles", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductExtends", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductAlias", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CustomerWarehouses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerShares", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerSales", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerFollows", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerFiles", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerContacts", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerBanks", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.CustomerAttentionProducts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.ReceiptManageRecDetails", new[] { "ReceiptManageId" });
            DropIndex("dbo.ReceiptManageProducts", new[] { "ReceiptManageId" });
            DropIndex("dbo.ReceiptManageFiles", new[] { "ReceiptManageId" });
            DropIndex("dbo.ReceiptManageCharges", new[] { "ReceiptManageId" });
            DropIndex("dbo.ReceiptManageBankFLs", new[] { "ReceiptManageId" });
            DropIndex("dbo.ProductSalesHistoricalPrices", new[] { "ProductId" });
            DropIndex("dbo.ProductRefCustomers", new[] { "ProductId" });
            DropIndex("dbo.ProductRefCustomerPictures", new[] { "ProductRefCustomerId" });
            DropIndex("dbo.ProductRefCustomerPictures", new[] { "ProductId" });
            DropIndex("dbo.ProductPurchaseHistoricalPrices", new[] { "ProductId" });
            DropIndex("dbo.ProductPrictures", new[] { "ProductId" });
            DropIndex("dbo.ProductPacks", new[] { "ProductId" });
            DropIndex("dbo.ProductFiles", new[] { "ProductId" });
            DropIndex("dbo.ProductExtends", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductNo" });
            DropIndex("dbo.ProductAlias", new[] { "ProductId" });
            DropIndex("dbo.CustomerWarehouses", new[] { "CustomerId" });
            DropIndex("dbo.CustomerShares", new[] { "CustomerId" });
            DropIndex("dbo.CustomerSales", new[] { "CustomerId" });
            DropIndex("dbo.CustomerFollows", new[] { "CustomerId" });
            DropIndex("dbo.CustomerFiles", new[] { "CustomerId" });
            DropIndex("dbo.CustomerContacts", new[] { "CustomerId" });
            DropIndex("dbo.CustomerBanks", new[] { "CustomerId" });
            DropIndex("dbo.CustomerAttentionProducts", new[] { "CustomerId" });
            AlterColumn("dbo.ProductSalesHistoricalPrices", "ProductName", c => c.String(maxLength: 80));
            AlterColumn("dbo.ProductSalesHistoricalPrices", "ProductNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Flag3", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Flag2", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Flag1", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "Status", c => c.String(maxLength: 20));
            AlterColumn("dbo.ProductPurchaseHistoricalPrices", "ProductName", c => c.String(maxLength: 80));
            AlterColumn("dbo.ProductPurchaseHistoricalPrices", "ProductNo", c => c.String(maxLength: 50));
            DropColumn("dbo.ReceiptManageFiles", "ReceiptManageId");
            DropColumn("dbo.ProductSalesHistoricalPrices", "Remark");
            DropColumn("dbo.ProductSalesHistoricalPrices", "DocNo");
            DropColumn("dbo.ProductSalesHistoricalPrices", "Source");
            DropColumn("dbo.ProductSalesHistoricalPrices", "Qty");
            DropColumn("dbo.ProductSalesHistoricalPrices", "SaluPric");
            DropColumn("dbo.ProductSalesHistoricalPrices", "ThirdProductNo");
            DropColumn("dbo.ProductSalesHistoricalPrices", "CustomerCode");
            DropColumn("dbo.Products", "CompanyId");
            DropColumn("dbo.Products", "CompanyName");
            DropColumn("dbo.Products", "CompanyCode");
            DropColumn("dbo.Products", "ProductNoAlias3");
            DropColumn("dbo.Products", "ProductNoAlias2");
            DropColumn("dbo.Products", "InnerBoxQty");
            DropColumn("dbo.Products", "Group");
            DropColumn("dbo.Products", "Category");
            DropColumn("dbo.Products", "EnDescription");
            DropColumn("dbo.Products", "CnDescription");
            DropColumn("dbo.Products", "ProductNoAlias");
            DropColumn("dbo.Products", "ProductEnName");
            DropColumn("dbo.ProductRefCustomers", "Group");
            DropColumn("dbo.ProductRefCustomers", "ThirdAliasProductName");
            DropColumn("dbo.ProductRefCustomers", "ThirdProductEnName");
            DropColumn("dbo.ProductRefCustomers", "ThirdProductName");
            DropColumn("dbo.ProductRefCustomers", "ThirdProductType");
            DropColumn("dbo.ProductRefCustomers", "ThirdUnit");
            DropColumn("dbo.ProductRefCustomers", "ThirdProductNature");
            DropColumn("dbo.ProductRefCustomers", "ThirdProductNo");
            DropColumn("dbo.ProductRefCustomerPictures", "ThirdProductNo");
            DropColumn("dbo.ProductPurchaseHistoricalPrices", "ThirdProductNo");
            DropColumn("dbo.ProductPurchaseHistoricalPrices", "SupplierCode");
            DropColumn("dbo.CustomerWarehouses", "WPhone");
            DropColumn("dbo.CustomerWarehouses", "WSex");
            DropColumn("dbo.CustomerWarehouses", "WTitle");
            DropColumn("dbo.CustomerWarehouses", "WDept");
            DropColumn("dbo.CustomerWarehouses", "WUser");
            DropColumn("dbo.Customers", "CompanyId");
            DropColumn("dbo.Customers", "CompanyName");
            DropColumn("dbo.Customers", "CompanyCode");
            DropColumn("dbo.Customers", "CustomMaster");
            DropTable("dbo.ProductAlias");
        }
    }
}
