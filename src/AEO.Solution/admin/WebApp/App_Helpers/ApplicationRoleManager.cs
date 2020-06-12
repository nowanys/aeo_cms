﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp
{
  /// <summary>
  /// Please add this code to Startup.Auth.cs registration class
  /// app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);
  /// </summary>
  public class ApplicationRoleManager : RoleManager<ApplicationRole>
  {
    public ApplicationRoleManager(IRoleStore<ApplicationRole, string> store)
        : base(store)
    {
    }
    public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
    {
      var manager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(context.Get<ApplicationDbContext>()));
      manager.RoleValidator = new RoleValidator<ApplicationRole, string>(manager);
      if (!manager.Roles.Any(r => r.Name == "admin"))
      {
        manager.Create(new ApplicationRole
        {
          Name = "admin"
        });
      }
      if (!manager.Roles.Any(r => r.Name == "users"))
      {
        manager.Create(new ApplicationRole
        {
          Name = "users"
        });
      }
      return manager;
    }
  }

  public class ApplicationRole : IdentityRole
  {
  }
}