﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
  public static class KeyGenerator
  {
    private static readonly SqlSugar.ISqlSugarClient db = SqlSugarFactory.CreateSqlSugarClient();
   //获取自定义流水号
    public static string GetNextCustomsKey()
    {
      //通过MS SQL Sequence产生递增序列
      var result = db.Ado.GetInt("SELECT NEXT VALUE FOR [dbo].[NoSequence]");
      return Convert.ToInt32(result).ToString("00000000");


    }
  }
}