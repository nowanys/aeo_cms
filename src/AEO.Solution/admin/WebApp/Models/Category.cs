using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //产品类别
  public partial class Category:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "产品类别", Description = "产品类别")]
    [MaxLength(50)]
    public string Name { get; set; }
    [Display(Name = "英文名称", Description = "英文名称")]
    [MaxLength(200)]
    public string EName { get; set; }

    [Display(Name = "保存路径", Description = "保存路径")]
    public int? ParentId { get; set; }
    [ForeignKey("ParentId")]
    public Category Parent { get; set; }
  }
}