using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Equity1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //RegisterCustomRoutes(RouteTable.Routes);
            //RegisterCustomBundles(BundleTable.Bundles);
        }
        void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "MockupRoute",
                "Mockups/{categoryName}",
                "~/Index.aspx"
            );
        }
        /*void RegisterCustomBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/BOW/css").Include(
              "~/Content/bootstrap.css",
              "~/Content/site.css",
              "~/Content/BOW.css"));
            bundles.Add(new StyleBundle("~/black/css").Include(
              "~/Content/bootstrap.css",
              "~/Content/site.css",
              "~/Content/BOW.css"));
            bundles.Add(new StyleBundle("~/Rainbow/css").Include(
              "~/Content/bootstrap.css",
              "~/Content/site.css",
              "~/Content/BOW.css"));
            bundles.Add(new StyleBundle("~/BlkWht/css").Include(
              "~/Content/bootstrap.css",
              "~/Content/site.css",
              "~/Content/Rainbow.css"));
        }*/
    }
}
