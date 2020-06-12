using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Repository.Pattern.Ef6;

namespace WebApp.Models
{
  //产品主档
  public partial class Product:Entity
  {
    [Key]
    public int Id { get; set; }
    [Display(Name = "货号", Description = "货号(自动生成,可手工修改)")]
    [MaxLength(50)]
    [Index(IsUnique =true)]
    public string ProductNo { get; set; }
    [Display(Name = "产品状态", Description = "产品状态")]
    [MaxLength(10)]
    public string Status { get; set; }
    
    [Display(Name = "物料性质", Description = "物料性质")]
    [MaxLength(50)]
    public string ProductNature { get; set; }
    
    [Display(Name = "产品名称", Description = "产品名称")]
    [MaxLength(200)]
    public string ProductName { get; set; }
    [Display(Name = "英文品名", Description = "英文品名")]
    [MaxLength(200)]
    public string ProductEnName { get; set; }

    [Display(Name = "物料别名", Description = "物料别名")]
    [MaxLength(128)]
    public string ProductNoAlias { get; set; }


    [Display(Name = "规格型号", Description = "规格型号")]
    [MaxLength(100)]
    public string Model { get; set; }
    [Display(Name = "中文描述", Description = "中文描述")]
    public string CnDescription { get; set; }
    [Display(Name = "英文描述", Description = "英文描述")]
    public string EnDescription { get; set; }
    
    [Display(Name = "备注", Description = "备注")]
    public string Remark { get; set; }

    [Display(Name = "产品类别", Description = "产品类别")]
    [MaxLength(50)]
    public string CategoryName { get; set; }
    
    [Display(Name = "保税/非报税", Description = "保税/非报税")]
    [MaxLength(20)]
    public string Flag1 { get; set; }
    [Display(Name = "主辅料", Description = "主辅料")]
    [MaxLength(20)]
    public string Flag2 { get; set; }
    [Display(Name = "ABC类", Description = "ABC类")]
    [MaxLength(20)]
    public string Flag3 { get; set; }
    [Display(Name = "物料组别", Description = "物料组别")]
    [MaxLength(50)]
    public string Group { get; set; }

    [Display(Name = "产品图片", Description = "产品图片")]
    public string Logo { get; set; }


    #region 贸易信息
    [Display(Name = "海关编码", Description = "海关编码")]
    [MaxLength(10)]
    public string HSCODE { get; set; }
    [Display(Name = "增值税率", Description = "增值税率")]
    public decimal? HSADDTAXRATE { get; set; }
    [Display(Name = "退税率", Description = "退税率")]
    public decimal? HSBACKTAXRATE { get; set; }
    [Display(Name = "销售指导价", Description = "销售指导价")]
    public decimal? GUIDEPRICE { get; set; }
    [Display(Name = "报关要素", Description = "报关要素")]
    public string CUSTBASIC { get; set; }
    [Display(Name = "所属国家", Description = "所属国家")]
    [MaxLength(128)]
    public string COUNTRY { get; set; }
    [Display(Name = "税务类型", Description = "所属国家")]
    [MaxLength(50)]
    public string TAXTYPE { get; set; }
    [Display(Name = "税分类", Description = "税分类")]
    [MaxLength(50)]
    public string TAXCLASS { get; set; }
    #endregion
    #region 包装箱信息
    [Display(Name = "包装方式", Description = "包装方式")]
    [MaxLength(10)]
    public string Package { get; set; }
    [Display(Name = "内装数量", Description = "内装数量")]
    [DefaultValue(null)]
    public decimal? InnerBoxQty { get; set; }
    [Display(Name = "单位", Description = "单位")]
    [MaxLength(10)]
    public string Unit { get; set; }
    [Display(Name = "毛重", Description = "毛重")]
    [DefaultValue(null)]
    public decimal? GWeight { get; set; }
    [Display(Name = "毛重单位", Description = "毛重单位")]
    [MaxLength(10)]
    [DefaultValue(null)]
    public string GWUnit { get; set; }
    [Display(Name = "净重", Description = "净重")]
    [DefaultValue(null)]
    public decimal? NWeight { get; set; }
    [Display(Name = "净重单位", Description = "净重单位")]
    [MaxLength(10)]
    [DefaultValue(null)]
    public string NWUnit { get; set; }
    [Display(Name = "体积", Description = "体积")]
    [DefaultValue(null)]
    public decimal? Volume { get; set; }
    [Display(Name = "体积单位", Description = "体积单位")]
    [MaxLength(10)]
    [DefaultValue(null)]
    public string VUnit { get; set; }
    [Display(Name = "长", Description = "长")]
    [DefaultValue(null)]
    public decimal? Length { get; set; }
    [Display(Name = "宽", Description = "宽")]
    [DefaultValue(null)]
    public decimal? Width { get; set; }
    [Display(Name = "高", Description = "高")]
    [DefaultValue(null)]
    public decimal? High { get; set; }
    [Display(Name = "单位", Description = "单位")]
    [MaxLength(10)]
    public string LUnit { get; set; }

    #endregion

    #region 扩展属性
    [Display(Name = "产品状态1", Description = "产品状态1")]
    [MaxLength(20)]
    public string Status1 { get; set; }
    [Display(Name = "产品状态2", Description = "产品状态2")]
    [MaxLength(20)]
    public string Status2 { get; set; }
    [Display(Name = "产品状态3", Description = "产品状态3")]
    [MaxLength(20)]
    public string Status3 { get; set; }
    [Display(Name = "物料属性1", Description = "物料属性1")]
    [MaxLength(128)]
    public string Attribute1 { get; set; }
    [Display(Name = "物料属性2", Description = "物料属性2")]
    [MaxLength(128)]
    public string Attribute2 { get; set; }
    [Display(Name = "物料属性3", Description = "物料属性3")]
    [MaxLength(128)]
    public string Attribute3 { get; set; }
    [Display(Name = "物料属性4", Description = "物料属性4")]
    [MaxLength(128)]
    public string Attribute4 { get; set; }
    [Display(Name = "物料属性5", Description = "物料属性5")]
    [MaxLength(128)]
    public string Attribute5 { get; set; }
    [Display(Name = "物料属性6", Description = "物料属性6")]
    [MaxLength(128)]
    public string Attribute6 { get; set; }
    [Display(Name = "物料属性7", Description = "物料属性7")]
    [MaxLength(128)]
    public string Attribute7 { get; set; }
    [Display(Name = "物料属性8", Description = "物料属性8")]
    [MaxLength(128)]
    public string Attribute8 { get; set; }

    [Display(Name = "物料别名2", Description = "物料别名2")]
    [MaxLength(200)]
    public string ProductNoAlias2 { get; set; }
    [Display(Name = "物料别名3", Description = "物料别名3")]
    [MaxLength(200)]
    public string ProductNoAlias3 { get; set; }
    [Display(Name = "产品组", Description = "产品组")]
    [MaxLength(50)]
    public string Group2 { get; set; }
    [Display(Name = "MRP组", Description = "MRP组")]
    [MaxLength(50)]
    public string Group3 { get; set; }
    [Display(Name = "外部组", Description = "外部组")]
    [MaxLength(50)]
    public string Group4 { get; set; }
    #endregion
    #region 归属
    [Display(Name = "归属企业代码", Description = "归属企业代码")]
    [MaxLength(10)]
    public string CompanyCode { get; set; }
    [Display(Name = "归属企业名称", Description = "归属企业名称")]
    [MaxLength(128)]
    public string CompanyName { get; set; }
    [Display(Name = "归属企业主键", Description = "归属企业主键")]
    [DefaultValue(null)]
    public int? CompanyId { get; set; }

     
   
    #endregion
  }
}