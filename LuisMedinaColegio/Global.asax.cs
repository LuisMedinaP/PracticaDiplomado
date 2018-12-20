using LuisMedinaColegio.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace LuisMedinaColegio
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DB db = new DB();
            //createPermisos(db);
            db.Dispose();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void createPermisos(DB db)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            if (!roleManager.RoleExists("SuperUsuario"))
            {
                roleManager.Create(new IdentityRole("SuperUsuario"));
            }
            if (!roleManager.RoleExists("Usuario"))
            {
                roleManager.Create(new IdentityRole("Usuario"));
            }
        }
    }
}
