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
  //客户图片
  public partial class CustomerPicture:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "图片名称", Description = "图片名称")]
    [MaxLength(100)]
    [Required]
    public string FileName { get; set; }
    [Display(Name = "图片类型", Description = "图片类型")]
    [MaxLength(256)]
    public string Description { get; set; }
    [Display(Name = "顺序", Description = "顺序")]
    public int LineNo { get; set; }

    [Display(Name = "大小", Description = "大小")]
    public decimal Size { get; set; }
    [Display(Name = "目录", Description = "目录")]
    [MaxLength(20)]
    [DefaultValue("图片")]
    public string Folder { get; set; }
    [Display(Name = "文件ID", Description = "文件ID")]
    [MaxLength(100)]
    public string FileId { get; set; }
    [Display(Name = "附件类型", Description = "附件类型")]
    [MaxLength(100)]

    public string Ext { get; set; }
    [Display(Name = "保存路径", Description = "保存路径")]
    public string FilePath { get; set; }
    [Display(Name = "相对路径", Description = "相对路径")]
    public string RelativePath { get; set; }

    [Display(Name = "上传用户", Description = "上传用户")]
    [MaxLength(20)]
    public string Owner { get; set; }
    [Display(Name = "上传时间", Description = "上传时间")]
    public DateTime Upload { get; set; }
    [Display(Name = "客户编号", Description = "客户编号")]
    [MaxLength(20)]

    public string CustomerCode { get; set; }
    [Display(Name = "客户名称", Description = "客户名称")]
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