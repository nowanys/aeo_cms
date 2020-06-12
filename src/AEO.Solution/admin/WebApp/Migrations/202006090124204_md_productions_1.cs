﻿namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_productions_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductPurchaseHistoricalPrices", "ProductNo", c => c.String(maxLength: 50));
            AddColumn("dbo.ProductSalesHistoricalPrices", "ProductNo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductSalesHistoricalPrices", "ProductNo");
            DropColumn("dbo.ProductPurchaseHistoricalPrices", "ProductNo");
        }
    }
}
