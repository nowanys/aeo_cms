﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //外汇核销单-货物信息
  public partial class ReceiptManageProduct:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "接单编号", Description = "接单编号")]
    [MaxLength(50)]
    public string SLF_CTL_NO { get; set; }
    [Display(Name = "拆分编号", Description = "拆分编号")]
    [MaxLength(50)]
    public string SPLIT_CTL_NO { get; set; }
    [Display(Name = "核注清单编号", Description = "核注清单编号")]
    [MaxLength(50)]
    public string NEMS_BOND_INVT_NO { get; set; }
    [Display(Name = "报关单号码", Description = "报关单号码")]
    [MaxLength(50)]
    public string F_ENTRY_ID { get; set; }
    [Display(Name = "类型", Description = "类型")]
    [MaxLength(10)]
    public string P_TYPE { get; set; }
    [Display(Name = "料件性质", Description = "料件性质")]
    [MaxLength(10)]
    public string MTPCK_ENDPRD_MARKCD { get; set; }

    [Display(Name = "料号", Description = "料号")]
    [MaxLength(128)]
    public string F_COP_G_NO { get; set; }

    [Display(Name = "货物名称", Description = "货物名称")]
    [MaxLength(128)]
    public string DANGNAME { get; set; }
    [Display(Name = "H.S.编码", Description = "H.S.编码")]
    [MaxLength(10)]
    public string F_HS_CODE { get; set; }

    [Display(Name = "申报数量", Description = "申报数量")]
 
    public decimal DCL_QTY { get; set; }

    [Display(Name = "申报单位", Description = "申报单位")]
    [MaxLength(10)]
    public string F_UNIT { get; set; }
    [Display(Name = "单价", Description = "单价")]

    public decimal F_G_PRICE { get; set; }
    [Display(Name = "总价", Description = "总价")]

    public decimal F_G_TOTAL { get; set; }
    [Display(Name = "币制", Description = "币制")]
    [MaxLength(10)]
    public string F_CURRENCY { get; set; }
    [Display(Name = "银行结汇水单", Description = "银行结汇水单")]
    [MaxLength(50)]
    public string BANK_FL_NO { get; set; }
    [Display(Name = "出口收汇单系统编号", Description = "出口收汇单系统编号")]
    [MaxLength(50)]
    public string SYS_NO { get; set; }
    [Display(Name = "出口收汇单", Description = "出口收汇单")]
    public int ReceiptManageId { get; set; }
    [ForeignKey("ReceiptManageId")]
    [Display(Name = "出口收汇单", Description = "出口收汇单")]
    public ReceiptManage ReceiptManage { get; set; }
  }
}