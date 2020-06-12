namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_update3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Logo", c => c.String());
            AddColumn("dbo.Products", "CategoryName", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "Logo", c => c.String());
            AddColumn("dbo.ProductRefCustomerTrades", "CustomerType", c => c.String(maxLength: 20));
            AddColumn("dbo.ProductRefCustomerTrades", "ThirdProductNo", c => c.String(maxLength: 50));
            CreateIndex("dbo.ProductRefCustomerTrades", "ProductId");
            CreateIndex("dbo.ProductRefCustomerTrades", "ProductRefCustomerId");
            AddForeignKey("dbo.ProductRefCustomerTrades", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductRefCustomerTrades", "ProductRefCustomerId", "dbo.ProductRefCustomers", "Id", cascadeDelete: false);
            DropColumn("dbo.Products", "Category");
            DropColumn("dbo.Products", "ProductPic");
            DropColumn("dbo.ProductRefCustomerTrades", "RefProductNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductRefCustomerTrades", "RefProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.Products", "ProductPic", c => c.String());
            AddColumn("dbo.Products", "Category", c => c.String(maxLength: 50));
            DropForeignKey("dbo.ProductRefCustomerTrades", "ProductRefCustomerId", "dbo.ProductRefCustomers");
            DropForeignKey("dbo.ProductRefCustomerTrades", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductRefCustomerTrades", new[] { "ProductRefCustomerId" });
            DropIndex("dbo.ProductRefCustomerTrades", new[] { "ProductId" });
            DropColumn("dbo.ProductRefCustomerTrades", "ThirdProductNo");
            DropColumn("dbo.ProductRefCustomerTrades", "CustomerType");
            DropColumn("dbo.Products", "Logo");
            DropColumn("dbo.Products", "CategoryName");
            DropColumn("dbo.Customers", "Logo");
        }
    }
}
