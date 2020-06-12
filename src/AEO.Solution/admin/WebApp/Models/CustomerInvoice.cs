using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //客户开票信息
  public partial class Invoice : Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "发票名称", Description = "发票名称")]
    [MaxLength(80)]
    public string InvName { get; set; }
    [Display(Name = "发票类型", Description = "发票类型")]
    [MaxLength(100)]
    [Required]
    public string InvType { get; set; }
    
    [Display(Name = "发票国家", Description = "发票国家")]
    [MaxLength(100)]

    public string InvCountry { get; set; }

    [Display(Name = "发票税点", Description = "发票税点")]
    public decimal InvTax { get; set; }
    [Display(Name = "税务等级号", Description = "税务等级号")]
    [MaxLength(100)]
    public string TaxNo { get; set; }
    [Display(Name = "发票用途", Description = "发票用途")]
    [MaxLength(256)]
    public string InvUse { get; set; }

    [Display(Name = "备注说明", Description = "备注说明")]
    [MaxLength(256)]
    public string Remark { get; set; }

    [Display(Name = "客户编号", Description = "客户编号(保存时系统自动分配也可以手工选择)")]
    [MaxLength(20)]
    [Required]
    public string CustomerCode { get; set; }
    [Display(Name = "单位名称", Description = "单位名称")]
    [MaxLength(80)]
    [Required]
    public string CustomerName { get; set; }


    [Display(Name = "所属客户", Description = "所属客户")]
    public int CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    [Display(Name = "所属客户", Description = "所属客户")]
    public Customer Customer { get; set; }
  }
}