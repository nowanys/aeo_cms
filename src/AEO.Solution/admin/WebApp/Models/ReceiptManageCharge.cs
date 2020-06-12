using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //费用及货款处理方式
  public partial class ReceiptManageCharge:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name ="类别",Description = "类别")]
    [MaxLength(20)]
    public string CHARGE_TYPE { get; set; }
    [Display(Name = "金额", Description = "金额")]
    public decimal AMOUNT { get; set; }
    [Display(Name = "币制", Description = "币制")]
    [MaxLength(10)]
    public string F_CURRENCY { get; set; }
    [Display(Name = "日期", Description = "日期")]
    public DateTime C_DATE { get; set; }

    [Display(Name = "银行", Description = "银行")]
    [MaxLength(128)]
    public string BANK { get; set; }
    [Display(Name = "银行账号", Description = "银行账号")]
    [MaxLength(128)]
    public string BANK_NO { get; set; }
    [Display(Name = "银行处理人", Description = "银行处理人")]
    [MaxLength(128)]
    public string BANK_USER { get; set; }
    [Display(Name = "备注", Description = "备注")]
    [MaxLength(128)]
    public string RMK { get; set; }

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