namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_recmgt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceiptManages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ReceiptManages", "CreatedBy", c => c.String(maxLength: 20));
            AddColumn("dbo.ReceiptManages", "LastModifiedDate", c => c.DateTime());
            AddColumn("dbo.ReceiptManages", "LastModifiedBy", c => c.String(maxLength: 20));
            AddColumn("dbo.ReceiptManages", "TenantId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReceiptManages", "TenantId");
            DropColumn("dbo.ReceiptManages", "LastModifiedBy");
            DropColumn("dbo.ReceiptManages", "LastModifiedDate");
            DropColumn("dbo.ReceiptManages", "CreatedBy");
            DropColumn("dbo.ReceiptManages", "CreatedDate");
        }
    }
}
