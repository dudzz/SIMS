using System.Web;
using System.Web.Optimization;

namespace ACE.SIMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            */


            bundles.Add(new StyleBundle("~/Assets/css").Include(
                      "~/Assets/css/bootstrap.min.css",
                      "~/Assets/font-awesome/4.5.0/css/font-awesome.min.css",
                      "~/Assets/css/fonts.googleapis.com.css",
                      "~/Assets/css/ace.min.css",
                      "~/Assets/css/ace-skins.min.css",
                      "~/Assets/css/ace-rtl.min.css"
                      ));
            bundles.Add(new ScriptBundle("~/Assets/js").Include(
                      "~/Assets/js/ace-extra.min.js",
                      "~/Assets/js/jquery-2.1.4.min.js",
                      "~/Assets/js/jquery-ui.custom.min.js",
                      "~/Assets/js/jquery.ui.touch-punch.min.js",
                      "~/Assets/js/jquery.easypiechart.min.js",
                      "~/Assets/js/jquery.sparkline.index.min.js",
                      "~/Assets/js/jquery.flot.min.js",
                      "~/Assets/js/jquery.flot.pie.min.js",
                      "~/Assets/js/jquery.flot.resize.min.js",
                      "~/Assets/js/ace-elements.min.js",
                      "~/Assets/js/ace.min.js"
                      ));
        }
    }
}
