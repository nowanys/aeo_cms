﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //产品历史价格(销售)
  public partial class ProductSalesHistoricalPrice : Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "客户代码", Description = "客户商代码")]
    [MaxLength(20)]
    [Required]
    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
    [MaxLength(80)]
    public string CustomerName { get; set; }
    [Display(Name = "客户货号", Description = "客户货号")]
    [MaxLength(80)]
    public string ThirdProductNo { get; set; }
    [Display(Name = "询价时间", Description = "询价时间")]
    [DefaultValue("now")]
    public DateTime QuoteDate { get; set; }
    [Display(Name = "币种", Description = "币种")]
    [MaxLength(10)]
    [DefaultValue("CNY")]
    public string CUR { get; set; }
    [Display(Name = "单价", Description = "单价")]
    public decimal SaluPric { get; set; }
    [Display(Name = "数量", Description = "数量")]
    public decimal Qty { get; set; }
    [Display(Name = "来源", Description = "来源")]
    [MaxLength(10)]
    [DefaultValue("手工录入")]
    public string Source { get; set; }
    [Display(Name = "单据号", Description = "单据号")]
    [MaxLength(100)]
    public string DocNo { get; set; }
    [Display(Name = "备注", Description = "备注")]
    public string Remark { get; set; }
    [Display(Name = "货号", Description = "货号")]
    [MaxLength(50)]
    [Required]
    public string ProductNo { get; set; }
    [Display(Name = "产品名称", Description = "产品名称")]
    [MaxLength(200)]
    public string ProductName { get; set; }
    [Display(Name = "所属产品", Description = "所属产品")]
    public int ProductId { get; set; }
    [Display(Name = "所属产品", Description = "所属产品")]
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
  }
}