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
  //客户关注产品
  public partial class CustomerAttentionProduct:Entity
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "客户编号", Description = "客户编号(保存时系统自动分配也可以手工选择)")]
    [MaxLength(20)]

    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
    [MaxLength(80)]
    [Required]
    public string CustomerName { get; set; }

    [Display(Name = "产品编号", Description = "产品编号(自动生成,可手工修改)")]
    [MaxLength(50)]
    public string ProductNo { get; set; }
    [Display(Name = "中文品名", Description = "中文品名")]
    [MaxLength(200)]
    public string ProductName { get; set; }
    [Display(Name = "币种", Description = "币种")]
    [MaxLength(10)]
    [DefaultValue("CNY")]
    public string CUR { get; set; }
    [Display(Name = "单价", Description = "单价")]
    public decimal Pric { get; set; }
    [Display(Name = "报价次数", Description = "报价次数")]
    public int SummaryQuote { get; set; }
    [Display(Name = "订单次数", Description = "订单次数")]
    public int SummaryOrders { get; set; }

    [Display(Name = "所属客户", Description = "所属客户")]
    public int CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    [Display(Name = "所属客户", Description = "所属客户")]
    public Customer Customer { get; set; }
  }
}