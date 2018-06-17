using System.Web;
using System.Web.Optimization;

namespace ConvertIt
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundle/master").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/css/layout.css",
                "~/Content/css/loader.css"
            ));

            bundles.Add(new ScriptBundle("~/bundle/scripts").Include(
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/bootstrap.js"
            ));

            bundles.Add(new ScriptBundle("~/bundle/home").Include(
                "~/Scripts/Carousel/jquery.waterwheelCarousel.js",
                "~/Scripts/Application/home.js"
            ));

            bundles.Add(new StyleBundle("~/bundle/homeStyles").Include(
                "~/Content/css/home.css"
            ));

            bundles.Add(new ScriptBundle("~/bundle/conversions").Include(
                "~/Scripts/Application/conversions.js"
            ));

            bundles.Add(new StyleBundle("~/bundle/conversionStyles").Include(
                "~/Content/css/conversions.css"
            ));

            bundles.Add(new ScriptBundle("~/bundle/formulas").Include(
                "~/Scripts/Application/formulas.js",
                "~/Scripts/jquery-ui.js"
            ));

            bundles.Add(new ScriptBundle("~/bundle/formulasStyles").Include(
                "~/Content/css/formulas.css"
            ));
        }
    }
}
