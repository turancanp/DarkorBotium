using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botium
{
    public class CefSharpSchemeHandlerFactory : ISchemeHandlerFactory
    {
        public const string SchemeName = "https";




        public IResourceHandler Create(IBrowser browser, IFrame frame, string schemeName, IRequest request)
        {

            var uri = new Uri(request.Url);

            var fileName = uri.AbsolutePath;



            if (fileName == "/spacemap/main.swf")
            {

                var main = Properties.Resources.main;
                return ResourceHandler.FromByteArray(main, "application/x-shockwave-flash");

            }
            if (fileName == "/spacemap/preloader.swf")
            {
                var preloader = Properties.Resources.preloader;
                return ResourceHandler.FromByteArray(preloader, "application/x-shockwave-flash");
            }

            return null;
        }
    }
}
