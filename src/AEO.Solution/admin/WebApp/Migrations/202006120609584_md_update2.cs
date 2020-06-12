namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerSales", "Salesman", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerContacts", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerFiles", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerFollows", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerSales", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerShares", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.CustomerWarehouses", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ProductRefCustomers", "CustomerCode", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Customers", "CustomerCode", unique: true);
            CreateIndex("dbo.Customers", "CustomerName", unique: true);
            DropColumn("dbo.Customers", "AbbName");
            DropColumn("dbo.Customers", "AbbCode");
            DropColumn("dbo.Customers", "CustomerProperty");
            DropColumn("dbo.Customers", "CRegion");
            DropColumn("dbo.Customers", "GRegion");
            DropColumn("dbo.Customers", "AbbEName");
            DropColumn("dbo.Customers", "CompanyId");
            DropColumn("dbo.CustomerSales", "SalesId");
            DropColumn("dbo.CustomerSales", "SalesName");
            DropColumn("dbo.CustomerSales", "SalesEName");
            DropColumn("dbo.ProductRefCustomers", "AbbName");
            DropColumn("dbo.ProductRefCustomers", "AbbCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductRefCustomers", "AbbCode", c => c.String(maxLength: 20));
            AddColumn("dbo.ProductRefCustomers", "AbbName", c => c.String(maxLength: 50));
            AddColumn("dbo.CustomerSales", "SalesEName", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesName", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerSales", "SalesId", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "CompanyId", c => c.Int());
            AddColumn("dbo.Customers", "AbbEName", c => c.String(maxLength: 50));
            AddColumn("dbo.Customers", "GRegion", c => c.String());
            AddColumn("dbo.Customers", "CRegion", c => c.String());
            AddColumn("dbo.Customers", "CustomerProperty", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "AbbCode", c => c.String(maxLength: 20));
            AddColumn("dbo.Customers", "AbbName", c => c.String(maxLength: 50));
            DropIndex("dbo.Customers", new[] { "CustomerName" });
            DropIndex("dbo.Customers", new[] { "CustomerCode" });
            AlterColumn("dbo.ProductRefCustomers", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerWarehouses", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerShares", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerSales", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerFollows", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerFiles", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerContacts", "CustomerCode", c => c.String(maxLength: 20));
            AlterColumn("dbo.Customers", "CustomerCode", c => c.String(maxLength: 20));
            DropColumn("dbo.CustomerSales", "Salesman");
        }
    }
}
