namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class md_recmgt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReceiptManageBankFLs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        F_CLIENT_NAME = c.String(maxLength: 128),
                        F_CLIENT_BANK = c.String(maxLength: 128),
                        F_CLIENT_BANK_NO = c.String(maxLength: 128),
                        F_ARL_NO = c.String(maxLength: 128),
                        B_ARL_NO = c.String(maxLength: 128),
                        B_ARL_IN_NO = c.String(maxLength: 128),
                        B_ARL_IN_DT = c.DateTime(),
                        B_ARL_IN_NAME = c.String(maxLength: 128),
                        DECL_NO = c.String(maxLength: 128),
                        B_ARL_IN_COMMENT = c.String(maxLength: 128),
                        B_ARL_IN_AMOUNT = c.String(maxLength: 128),
                        F_CURRENCY = c.String(maxLength: 10),
                        B_ORD_USER = c.String(maxLength: 128),
                        B_CHK_USER = c.String(maxLength: 128),
                        C_DATE = c.DateTime(nullable: false),
                        RMK = c.String(maxLength: 128),
                        SYS_NO = c.String(maxLength: 50),
                        ReceiptManageId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceiptManageCharges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CHARGE_TYPE = c.String(maxLength: 20),
                        AMOUNT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_CURRENCY = c.String(maxLength: 10),
                        C_DATE = c.DateTime(nullable: false),
                        BANK = c.String(maxLength: 128),
                        BANK_NO = c.String(maxLength: 128),
                        BANK_USER = c.String(maxLength: 128),
                        RMK = c.String(maxLength: 128),
                        SYS_NO = c.String(maxLength: 50),
                        ReceiptManageId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceiptManageFiles",
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
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceiptManageProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SLF_CTL_NO = c.String(maxLength: 50),
                        SPLIT_CTL_NO = c.String(maxLength: 50),
                        NEMS_BOND_INVT_NO = c.String(maxLength: 50),
                        F_ENTRY_ID = c.String(maxLength: 50),
                        P_TYPE = c.String(maxLength: 10),
                        MTPCK_ENDPRD_MARKCD = c.String(maxLength: 10),
                        F_COP_G_NO = c.String(maxLength: 128),
                        DANGNAME = c.String(maxLength: 128),
                        F_HS_CODE = c.String(maxLength: 10),
                        DCL_QTY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_UNIT = c.String(maxLength: 10),
                        F_G_PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_G_TOTAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_CURRENCY = c.String(maxLength: 10),
                        BANK_FL_NO = c.String(maxLength: 50),
                        SYS_NO = c.String(maxLength: 50),
                        ReceiptManageId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceiptManageRecDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        REC_NO = c.String(maxLength: 50),
                        REC_LNO = c.String(maxLength: 3),
                        REC_DATE = c.DateTime(nullable: false),
                        F_ORDERNO = c.String(maxLength: 50),
                        ORDER_NUM = c.String(maxLength: 50),
                        F_ASN_DN_NO = c.String(maxLength: 50),
                        F_ASN_DN_LINENO = c.String(maxLength: 50),
                        F_IO_NO = c.String(maxLength: 50),
                        F_IO_NO_LINENO = c.String(maxLength: 50),
                        P_TYPE = c.String(maxLength: 10),
                        MTPCK_ENDPRD_MARKCD = c.String(maxLength: 10),
                        F_COP_G_NO = c.String(maxLength: 128),
                        DANGNAME = c.String(maxLength: 128),
                        F_HS_CODE = c.String(maxLength: 10),
                        DCL_QTY = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_UNIT = c.String(maxLength: 10),
                        F_G_PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_G_TOTAL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        F_CURRENCY = c.String(maxLength: 10),
                        SYS_NO = c.String(maxLength: 50),
                        ReceiptManageId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 20),
                        LastModifiedDate = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 20),
                        TenantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReceiptManages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SYS_NO = c.String(nullable: false, maxLength: 50),
                        SLF_CTL_NO = c.String(maxLength: 50),
                        RECEIPT_NO = c.String(maxLength: 50),
                        BLNG_ETPS_VDCD = c.String(nullable: false, maxLength: 10),
                        BLNG_ETPS_NM = c.String(maxLength: 128),
                        OWNER_VDCD = c.String(nullable: false, maxLength: 10),
                        OWNER_NM = c.String(nullable: false, maxLength: 128),
                        EMS_NO = c.String(nullable: false, maxLength: 128),
                        POST_DT = c.DateTime(),
                        TOTAL_AMOUNT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TRADE_CURR = c.String(maxLength: 10),
                        PAYABLE_TYPE = c.String(maxLength: 10),
                        PERIOD = c.String(maxLength: 20),
                        BP = c.String(maxLength: 128),
                        OC = c.String(maxLength: 128),
                        REC_DATE = c.DateTime(),
                        PLAN_REC_DATE = c.DateTime(),
                        BANK = c.String(maxLength: 128),
                        SAFE = c.String(maxLength: 128),
                        CUSTOM_MASTER = c.String(maxLength: 128),
                        DEC_EXP_DT = c.DateTime(),
                        ORD_DT = c.DateTime(),
                        TRANS_MODE = c.String(maxLength: 20),
                        DES_COUNTRY = c.String(maxLength: 20),
                        CUSTOMS_CODE = c.String(maxLength: 10),
                        DCL_DATE = c.DateTime(),
                        ENT_PASS_DATE = c.DateTime(),
                        ENT_LEAVE_DATE = c.DateTime(),
                        CONTRACT_NO = c.String(maxLength: 50),
                        INVOICE_NO = c.String(maxLength: 50),
                        WMS_RECEIPT_NO = c.String(maxLength: 50),
                        STOR_DATE = c.DateTime(),
                        F_MAWB_NO = c.String(maxLength: 50),
                        BL_B_NO = c.String(maxLength: 50),
                        F_VESSELANDVOYAGE = c.String(maxLength: 50),
                        SLF_TRAF_MODE = c.String(maxLength: 50),
                        SCCD_NO = c.String(maxLength: 50),
                        BANK_WKNO = c.String(maxLength: 50),
                        BANK_FLNO = c.String(maxLength: 50),
                        ETPS_PREENT_NO1 = c.String(maxLength: 50),
                        ETPS_PREENT_NO2 = c.String(maxLength: 50),
                        ETPS_PREENT_NO3 = c.String(maxLength: 50),
                        ETPS_PREENT_NO4 = c.String(maxLength: 50),
                        RMK = c.String(maxLength: 250),
                        CUS_RMK = c.String(maxLength: 250),
                        ORG_RMK = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.SYS_NO, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ReceiptManages", new[] { "SYS_NO" });
            DropTable("dbo.ReceiptManages");
            DropTable("dbo.ReceiptManageRecDetails");
            DropTable("dbo.ReceiptManageProducts");
            DropTable("dbo.ReceiptManageFiles");
            DropTable("dbo.ReceiptManageCharges");
            DropTable("dbo.ReceiptManageBankFLs");
        }
    }
}
