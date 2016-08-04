using System.Web;
using System.Web.Optimization;

namespace Alya.Template.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Scripts/jquery-{version}.js",
                 "~/Scripts/jquery.corner.js",
                 "~/Scripts/jquery.magnific-popup.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/alya").Include(
                        "~/Scripts/alyaSpa.js"));

            bundles.Add(new ScriptBundle("~/bundles/design").Include(
                 "~/Scripts/classie.js",
                 "~/Scripts/html5shiv.js",
                 "~/Scripts/owl.carousel.js",
                 "~/Scripts/uiMorphingButton_inflow.js",
                 "~/Scripts/script.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/animate.css",
                 "~/Content/bootstrap.css",
                 "~/Content/custom.css",
                 "~/Content/general.css",
                 "~/Content/magnific-popup.css",
                 "~/Content/owl.carousel.css",
                 "~/Content/owl.theme.css",
                 "~/Content/style.css",
                 "~/Content/Site.css"));
        }
    }
}
