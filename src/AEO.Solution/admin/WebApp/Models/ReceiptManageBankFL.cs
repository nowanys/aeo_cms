using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //银行结汇水单信息
  public partial class ReceiptManageBankFL:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name ="客户名称",Description = "客户名称")]
    [MaxLength(128)]
    public string F_CLIENT_NAME { get; set; }
    [Display(Name = "客户银行名称", Description = "客户银行名称")]
    [MaxLength(128)]
    public string F_CLIENT_BANK { get; set; }
    [Display(Name = "客户银行账号", Description = "客户银行账号")]
    [MaxLength(128)]
    public string F_CLIENT_BANK_NO { get; set; }
    [Display(Name = "核销单编号", Description = "核销单编号")]
    [MaxLength(128)]
    public string F_ARL_NO { get; set; }
    [Display(Name = "结汇编号", Description = "结汇编号")]
    [MaxLength(128)]
    public string B_ARL_NO { get; set; }
    [Display(Name = "汇入号", Description = "结汇编号")]
    [MaxLength(128)]
    public string B_ARL_IN_NO { get; set; }
    [Display(Name = "汇入日期", Description = "结汇编号")]
    public DateTime? B_ARL_IN_DT { get; set; }
    [Display(Name = "汇入人名", Description = "汇入人名")]
    [MaxLength(128)]
    public string B_ARL_IN_NAME { get; set; }

    [Display(Name = "申报单号", Description = "申报单号")]
    [MaxLength(128)]
    public string DECL_NO { get; set; }

    [Display(Name = "汇款留言", Description = "汇款留言")]
    [MaxLength(128)]
    public string B_ARL_IN_COMMENT { get; set; }
    [Display(Name = "汇款金额", Description = "汇款金额")]
    [MaxLength(128)]
    public string B_ARL_IN_AMOUNT { get; set; }
    [Display(Name = "币制", Description = "币制")]
    [MaxLength(10)]
    public string F_CURRENCY { get; set; }

    [Display(Name = "制票人", Description = "制票人")]
    [MaxLength(128)]
    public string B_ORD_USER { get; set; }
    [Display(Name = "复核人", Description = "复核人")]
    [MaxLength(128)]
    public string B_CHK_USER { get; set; }

    [Display(Name = "日期", Description = "日期")]
    public DateTime C_DATE { get; set; }

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