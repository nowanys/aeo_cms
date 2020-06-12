using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //报价单
  public partial class Quotation:Entity
  {
    [Key]
    public int Id { get; set; }
    #region 公共信息
    [Display(Name = "报价单号", Description = "报价单号")]
    [MaxLength(20)]
    [Required]
    [Index(IsUnique =true)]
    public string QuotationNo { get; set; }

    [Display(Name = "业务员", Description = "业务员")]
    [MaxLength(20)]
    [Required]
    public string Salesman { get; set; }

    [Display(Name = "公司代码", Description = "公司代码")]
    [MaxLength(20)]
    [Required]
    public string CompanyCode { get; set; }
    [Display(Name = "公司名称", Description = "公司名称")]
    [MaxLength(128)]
    public string CompanyName { get; set; }
    #endregion

    #region 基本信息
    [Display(Name = "客户编号", Description = "客户编号")]
    [MaxLength(20)]
    [Required]
    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
    [MaxLength(80)]
    [Required]
    public string CustomerName { get; set; }
    [Display(Name = "国家地区", Description = "国家地区")]
    [MaxLength(50)]
    [DefaultValue("中国")]
    public string Country { get; set; }
    [Display(Name = "联系人", Description = "联系人")]
    [MaxLength(80)]
    [Required]
    public string ContactName { get; set; }
    [Display(Name = "联系方式", Description = "联系方式")]
    [MaxLength(128)]
    public string ContactInfo { get; set; }
    [Display(Name = "报价日期", Description = "报价日期")]
    [DefaultValue("now")]
    public DateTime QuoteDate { get; set; }
    [Display(Name = "有效日期", Description = "有效日期")]
    [DefaultValue("now")]
    public DateTime ExpiryDate { get; set; }
    [Display(Name = "装货港", Description = "装货港")]
    [MaxLength(128)]
    public string LoadingPort { get; set; }
    [Display(Name = "卸货港", Description = "卸货港")]
    [MaxLength(128)]
    public string DischargePort { get; set; }
    [Display(Name = "币种", Description = "币种")]
    [MaxLength(20)]
    [DefaultValue(null)]
    public string Cur { get; set; }
    [Display(Name = "汇率", Description = "汇率")]
    public decimal ExchangeRate { get; set; }
    [Display(Name = "价格条款", Description = "价格条款")]
    [MaxLength(20)]
    public string PriceTerm { get; set; }
    [Display(Name = "付款条件", Description = "付款条件")]
    [MaxLength(128)]
    public string PayModeDesc { get; set; }
    [Display(Name = "货值金额", Description = "货值金额")]
    public decimal Amount { get; set; }
    [Display(Name = "附加费", Description = "附加费")]
    public decimal ChargeAmount { get; set; }
    [Display(Name = "总费用", Description = "总费用")]
    public decimal TotalAmount { get; set; }
    [Display(Name = "报价单格式", Description = "报价单格式")]
    [MaxLength(20)]
    public string FormName { get; set; }
    [Display(Name = "备注", Description = "备注")]
    public string Remark { get; set; }
    #endregion
    [Display(Name = "询价单号", Description = "询价单号")]
    [MaxLength(20)]
    //[Required]
    public string InquiryNo { get; set; }
    [Display(Name = "任务单号", Description = "任务单号")]
    [MaxLength(20)]
    //[Required]
    public string TaskNo { get; set; }
    [Display(Name = "系统版本号", Description = "系统版本号")]
    public int Ver { get; set; } 
  }
}