using System.Web;
using System.Web.Optimization;

namespace RiverRat2.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.easing.{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/agency.js",
                      "~/Scripts/classie.js",
                      "~/Scripts/cbpAnimatedHeader.js")); 

            bundles.UseCdn = true;

            //bundles.Add(new StyleBundle("~/bundles/googlemontserrat", "http://fonts.googleapis.com/css?family=Montserrat:400,700"));
            bundles.Add(new StyleBundle("~/bundles/googlemontserrat").Include("~/Content/googlemontserrat.css"));
            //bundles.Add(new StyleBundle("~/bundles/googlekaushan", "http://fonts.googleapis.com/css?family=Kaushan+Script"));
            bundles.Add(new StyleBundle("~/bundles/googlekaushan").Include("~/Content/googlekaushan.css"));
            //bundles.Add(new StyleBundle("~/bundles/googledroid", "http://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic"));
            bundles.Add(new StyleBundle("~/bundles/googledroid").Include("~/Content/googledroid.css"));
            //bundles.Add(new StyleBundle("~/bundles/googleroboto", "http://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700"));
            bundles.Add(new StyleBundle("~/bundles/googleroboto", "~/Content/googleroboto.css"));
                
                //Include(
                //      "http://fonts.googleapis.com/css?family=Montserrat:400,700",
                //      "http://fonts.googleapis.com/css?family=Kaushan+Script",
                //      "http://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic",
                //      "http://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.css",
                      "~/Content/Site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
