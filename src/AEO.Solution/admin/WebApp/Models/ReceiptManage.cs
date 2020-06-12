using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.RightsManagement;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //出口收汇结算单
  public partial class ReceiptManage:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "系统编号", Description = "系统编号(可手工编辑)")]
    [MaxLength(50)]
    [Required]
    [Index(IsUnique =true)]
    public string SYS_NO { get; set; }

    [Display(Name = "关务接单编号", Description = "关务接单编号")]
    [MaxLength(50)]
    public string SLF_CTL_NO { get; set; }
    [Display(Name = "外汇核销单编号", Description = "外汇核销单编号")]
    [MaxLength(50)]
    public string RECEIPT_NO { get; set; }
    [Display(Name = "归属企业代码", Description = "归属企业代码")]
    [MaxLength(10)]
    [Required]
    public string BLNG_ETPS_VDCD { get; set; }
    [Display(Name = "归属企业名称", Description = "归属企业名称")]
    [MaxLength(128)]
    public string BLNG_ETPS_NM { get; set; }
    [Display(Name = "进口单位代码", Description = "进口单位代码")]
    [MaxLength(10)]
    [Required]
    public string OWNER_VDCD { get; set; }
    [Display(Name = "进口单位代码", Description = "进口单位代码")]
    [MaxLength(128)]
    [Required]
    public string OWNER_NM { get; set; }
    [Display(Name = "账册号", Description = "账册号")]
    [MaxLength(128)]
    [Required]
    public string EMS_NO { get; set; }
    [Display(Name = "寄单日期", Description = "寄单日期")]
    public DateTime? POST_DT { get; set; }
    [Display(Name = "进口总价", Description = "进口总价")]
    public decimal TOTAL_AMOUNT { get; set; }
    [Display(Name = "币制", Description = "币制")]
    [MaxLength(10)]
    public string TRADE_CURR { get; set; }
    
      [Display(Name = "结汇方式", Description = "结汇方式")]
    [MaxLength(10)]
    public string PAYABLE_TYPE { get; set; }
    [Display(Name = "收款周期", Description = "收款周期")]
    [MaxLength(20)]
    public string PERIOD { get; set; }
    [Display(Name = "BP号", Description = "BP号")]
    [MaxLength(128)]
    public string BP { get; set; }
    [Display(Name = "OC号", Description = "OC号")]
    [MaxLength(128)]
    public string OC { get; set; }
    [Display(Name = "收汇日期", Description = "收汇日期")]
    public DateTime? REC_DATE { get; set; }
    [Display(Name = "预计收款日期", Description = "预计收款日期")]
    public DateTime? PLAN_REC_DATE { get; set; }
    [Display(Name = "银行名称", Description = "银行名称")]
    [MaxLength(128)]
    public string BANK { get; set; }

    [Display(Name = "外汇局名称", Description = "外汇局名称")]
    [MaxLength(128)]
    public string SAFE { get; set; }
    [Display(Name = "主管海关", Description = "主管海关")]
    [MaxLength(128)]
    public string CUSTOM_MASTER { get; set; }
    [Display(Name = "报关截至有效期", Description = "报关截至有效期")]
    public DateTime? DEC_EXP_DT { get; set; }
    [Display(Name = "接单日期", Description = "接单日期")]
    [DefaultValue(null)]
    public DateTime? ORD_DT { get; set; }
    [Display(Name = "成交方式", Description = "成交方式")]
    [MaxLength(20)]
    public string TRANS_MODE { get; set; }

    [Display(Name = "目的国", Description = "目的国")]
    [MaxLength(20)]
    public string DES_COUNTRY { get; set; }
    [Display(Name = "申报海关", Description = "申报海关")]
    [MaxLength(10)]
    public string CUSTOMS_CODE { get; set; }
    [Display(Name = "报关申报日期", Description = "报关申报日期")]
    public DateTime? DCL_DATE { get; set; }
    [Display(Name = "报关放行日期", Description = "报关放行日期")]
    public DateTime? ENT_PASS_DATE { get; set; }
    [Display(Name = "离境日期", Description = "离境日期")]
    public DateTime? ENT_LEAVE_DATE { get; set; }
    [Display(Name = "合同号", Description = "合同号")]
    [MaxLength(50)]
    public string CONTRACT_NO { get; set; }
    [Display(Name = "发票号", Description = "发票号")]
    [MaxLength(50)]
    public string INVOICE_NO { get; set; }
    [Display(Name = "仓库入库单号", Description = "仓库入库单号")]
    [MaxLength(50)]
    public string WMS_RECEIPT_NO { get; set; }
    [Display(Name = "仓库日期", Description = "仓库日期")]
    [DefaultValue(null)]
    public DateTime? STOR_DATE { get; set; }
    [Display(Name = "主单", Description = "主单")]
    [MaxLength(50)]
    public string F_MAWB_NO { get; set; }
    [Display(Name = "分单", Description = "分单")]
    [MaxLength(50)]
    public string BL_B_NO { get; set; }
    [Display(Name = "船名及航次", Description = "船名及航次")]
    [MaxLength(50)]
    public string F_VESSELANDVOYAGE { get; set; }
    [Display(Name = "运输方式", Description = "运输方式")]
    [MaxLength(50)]
    public string SLF_TRAF_MODE { get; set; }
    [Display(Name = "信用证号码", Description = "信用证号码")]
    [MaxLength(50)]
    public string SCCD_NO { get; set; }
    [Display(Name = "财务作业编号", Description = "财务作业编号")]
    [MaxLength(50)]
    public string BANK_WKNO { get; set; }
    [Display(Name = "银行结汇水单号", Description = "银行结汇水单号")]
    [MaxLength(50)]
    public string BANK_FLNO { get; set; }
    [Display(Name = "内部编号1", Description = "内部编号1")]
    [MaxLength(50)]
    public string ETPS_PREENT_NO1 { get; set; }
    [Display(Name = "内部编号2", Description = "内部编号2")]
    [MaxLength(50)]
    public string ETPS_PREENT_NO2 { get; set; }
    [Display(Name = "内部编号3", Description = "内部编号3")]
    [MaxLength(50)]
    public string ETPS_PREENT_NO3 { get; set; }
    [Display(Name = "内部编号4", Description = "内部编号4")]
    [MaxLength(50)]
    public string ETPS_PREENT_NO4 { get; set; }
    [Display(Name = "备注", Description = "备注")]
    [MaxLength(250)]
    public string RMK { get; set; }
    [Display(Name = "海关批注", Description = "海关批注")]
    [MaxLength(250)]
    public string CUS_RMK { get; set; }
    [Display(Name = "外管局批注", Description = "外管局批注")]
    [MaxLength(250)]
    public string ORG_RMK { get; set; }
  }
}