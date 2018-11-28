using System.Web;
using System.Web.Optimization;

namespace OnlineShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jscore").Include(
                        "~/Assest/client/js/jquery-1.11.3.min.js",
                        "~/Assest/client/js/jquery-ui.js",
                        "~/Assest/client/js/bootstrap.min.js",
                         "~/Assest/client/js/move-top.js",
                         "~/Assest/client/js/easing.js",
                         "~/Assest/client/js/startstop-slider.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/controller").Include(
                "~/Assest/client/js/controller/baseController.js"
                ));

            bundles.Add(new StyleBundle("~/bundles/core").Include(
                      "~/Assest/client/css/bootstrap.css",
                      "~/Assest/client/css/bootstrap-social.css",
                      "~/Assest/client/css/fontawesome.min.css",
                      "~/Assest/client/css/bootstrap-theme.css",
                      "~/Assest/client/css/jquery-ui.css",
                      "~/Assest/client/css/style.css",
                      "~/Assest/client/css/slider.css"
                      ));
            BundleTable.EnableOptimizations = true;
        }   
    }
}
