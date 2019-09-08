using BundleTransformer.Core.Transformers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace SeuEmprende.Util.Optimization
{
    public class StyleTransformerBundle : StyleBundle
    {
        public StyleTransformerBundle(string virtualPath)
         : base(virtualPath)
        {
            this.Transforms.Add(new StyleTransformer());
        }
    }
}