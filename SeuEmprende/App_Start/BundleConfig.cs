using SeuEmprende.Util.Optimization;
using System.Web;
using System.Web.Optimization;

namespace SeuEmprende
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
          "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                        "~/Content/AdminBSB/helpers.js",
                        "~/Content/AdminBSBMaterialDesign/plugins/node-waves/waves.js",
                        "~/Content/AdminBSBMaterialDesign/plugins/jquery-slimscroll/jquery.slimscroll.js",
                        "~/Content/AdminBSBMaterialDesign/plugins/multi-select/js/jquery.multi-select.js",
                        "~/Content/AdminBSBMaterialDesign/plugins/bootstrap-select/js/bootstrap-select.js",
                        "~/Content/AdminBSBMaterialDesign/plugins/autosize/autosize.js",
                        "~/Content/AdminBSBMaterialDesign/js/admin.js",
                        "~/Scripts/Content/TextArea.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-datatable")
                .Include(
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/jquery.dataTables.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/skin/bootstrap/js/dataTables.bootstrap.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/dataTables.buttons.min.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/buttons.flash.min.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/jszip.min.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/pdfmake.min.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/vfs_fonts.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/buttons.html5.min.js",
                    "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/extensions/export/buttons.print.min.js",
                    "~/Scripts/datatableOData/jquery.dataTables.odata.js"));

            bundles.Add(new StyleTransformerBundle("~/Content/css").Include(
                                  "~/Content/AdminBSBMaterialDesign/css/materialize.css",
                                  "~/Content/bootstrap.css",
                                  "~/Content/AdminBSBMaterialDesign/plugins/node-waves/waves.css",
                                  "~/Content/AdminBSBMaterialDesign/plugins/bootstrap-select/css/bootstrap-select.css",
                                  "~/Content/AdminBSBMaterialDesign/css/themes/theme-deep-purple.css",
                                  "~/Content/AdminBSBMaterialDesign/css/style.css",
                                  "~/Content/AdminBSBMaterialDesign/plugins/jquery-datatable/skin/bootstrap/css/dataTables.bootstrap.css",
                                  "~/Content/material-icons.css",
                                  "~/Content/Roboto-Regular.css",
                                  "~/Content/font-awesome.css",
                                  "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/editable-table").Include(
                "~/Content/AdminBSBMaterialDesign/plugins/editable-table/mindmup-editabletable.js",
                "~/Content/AdminBSBMaterialDesign/js/pages/tables/editable-table.js"));
        }
    }
}
