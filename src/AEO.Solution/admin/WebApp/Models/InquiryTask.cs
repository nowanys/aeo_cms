﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //询价任务
  public partial class InquiryTask:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "任务单号",Description = "任务单号")]
    [MaxLength(20)]
    [Required]
    public string TaskNo { get; set; }
    [Display(Name = "状态", Description = "状态")]
    [MaxLength(20)]
    [Required]
    [DefaultValue("草拟")]
    public string Status { get; set; }
    [Display(Name = "业务员", Description = "业务员")]
    [MaxLength(20)]
    [Required]
    public string Salesman { get; set; }
    [Display(Name = "公司", Description = "公司")]
    [MaxLength(20)]
    [Required]
    public string CompanyCode { get; set; }
    [Display(Name = "公司名称", Description = "公司名称")]
    [MaxLength(128)]
    public string CompanyName { get; set; }

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
    [Display(Name = "币种", Description = "币种")]
    [MaxLength(20)]
    [DefaultValue(null)]
    public string Cur { get; set; }
    [Display(Name = "汇率", Description = "汇率")]
    public decimal ExchangeRate { get; set; }
    [Display(Name = "联系人", Description = "联系人")]
    [MaxLength(80)]
    [Required]
    public string ContactName { get; set; }
    [Display(Name = "联系方式", Description = "联系方式")]
    [MaxLength(128)]
    public string ContactInfo { get; set; }
    [Display(Name = "开始日期", Description = "开始日期")]
    [DefaultValue("now")]
    public DateTime BeginDate { get; set; }
    [Display(Name = "结束日期", Description = "结束日期")]
    [DefaultValue("now")]
    public DateTime Enddate { get; set; }
    [Display(Name = "紧急程度", Description = "紧急程度")]
    [MaxLength(20)]
    public string Urgency { get; set; }
    [Display(Name = "询价要求", Description = "询价要求")]
    public string Demande { get; set; }
    [Display(Name = "到期提醒", Description = "到期提醒")]
    public int PreRemind { get; set; }
    [Display(Name = "创建人", Description = "创建人")]
    [DefaultValue(false)]
    public bool Check1 { get; set; }
    [Display(Name = "执行人", Description = "执行人")]
    [DefaultValue(false)]
    public bool Check2 { get; set; }
    [Display(Name = "责任人", Description = "责任人")]
    [DefaultValue(false)]
    public bool Check3 { get; set; }
    #endregion
  }
}