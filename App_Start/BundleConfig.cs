using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AU_Tasks_App
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // create an object of ScriptBundle and 
            // specify bundle name (as virtual path) as constructor parameter 
            ScriptBundle scriptBndl = new ScriptBundle("~/bundles/bootstrap");


            //use Include() method to add all the script files with their paths 
            scriptBndl.Include(
                                "~/Scripts/bootstrap.js"
                                
                              );

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                                    "~/Content/bootstrap.css",
                                                                    "~/Content/site.css"
                                                                ));
            //Add the bundle into BundleCollection
            bundles.Add(scriptBndl);

            BundleTable.EnableOptimizations = true;
        }
    }
}