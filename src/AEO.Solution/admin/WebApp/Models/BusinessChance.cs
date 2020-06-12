using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //商机管理
  public partial class BusinessChance : Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "商机名称", Description = "商机名称")]
    [MaxLength(128)]
    [Required]
    public string Name { get; set; }
    [Display(Name = "负责人", Description = "负责人")]
    [MaxLength(20)]
    [Required]
    public string Owner { get; set; }
    [Display(Name = "客户代码", Description = "客户代码(保存时系统自动分配也可以手工选择)")]
    [MaxLength(20)]

    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
    [MaxLength(80)]
    [Required]
    public string CustomerName { get; set; }
    [Display(Name = "联系人", Description = "联系人")]
    [MaxLength(80)]
    [Required]
    public string ContactName { get; set; }
    [Display(Name = "发现日期", Description = "发现日期")]
    [DefaultValue("now")]
    public string ChanceDate { get; set; }
    [Display(Name = "提供人", Description = "提供人")]
    [MaxLength(80)]
    public string Provider { get; set; }
    [Display(Name = "机会来源", Description = "机会来源")]
    [MaxLength(80)]
    public string ChanceSource { get; set; }
    [Display(Name = "市场活动", Description = "市场活动")]
    [MaxLength(80)]
    public string MarketAction { get; set; }
    [Display(Name = "跟进状态", Description = "跟进状态")]
    [MaxLength(20)]
    public string FollwSatus { get; set; }
    [Display(Name = "预测签约日期", Description = "预测签约日期")]
    [DefaultValue(null)]
    public DateTime? PredictDate { get; set; }

    [Display(Name = "预计成交金额", Description = "预计成交金额")]
    [DefaultValue(null)]
    public decimal? PredictAmount { get; set; }
    [Display(Name = "币种", Description = "币种")]
    [MaxLength(20)]
    public string Cur { get; set; }
    [Display(Name = "商机内容", Description = "商机内容")]
    public string Demand { get; set; }
    [Display(Name = "当前阶段", Description = "当前阶段")]
    [MaxLength(20)]
    public string Stage { get; set; }
    [Display(Name = "备注", Description = "备注")]
    public string Remark { get; set; }

  }
}