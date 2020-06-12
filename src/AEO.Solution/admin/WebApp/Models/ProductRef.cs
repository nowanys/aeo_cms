using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //产品串料信息
  public partial class ProductAlias : Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "货号", Description = "货号(自动生成,可手工修改)")]
    [MaxLength(50)]
    public string ProductNo { get; set; }
    [Display(Name = "产品名称", Description = "产品名称")]
    [MaxLength(200)]
    public string ProductName { get; set; }
    [Display(Name = "客户货号", Description = "客户货号")]
    [MaxLength(50)]
    public string ThirdProductNo { get; set; }

    [Display(Name = "客户代码", Description = "客户代码")]
    [MaxLength(20)]
    [Required]
    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
    [MaxLength(80)]
    [Required]
    public string CustomerName { get; set; }
    [Display(Name = "客户类型", Description = "客户类型")]
    [MaxLength(50)]
    public string CustomerType { get; set; }
 
   
   
    [Display(Name = "英文品名", Description = "英文品名")]
    [MaxLength(200)]
    public string ProductEnName { get; set; }
    [Display(Name = "中文描述", Description = "中文描述")]
    [MaxLength(200)]
    public string CnDescription { get; set; }
    [Display(Name = "所属产品", Description = "所属产品")]
    public int ProductId { get; set; }
    [Display(Name = "所属产品", Description = "所属产品")]
    [ForeignKey("ProductId")]
    public Product Product { get; set; }

  }
}