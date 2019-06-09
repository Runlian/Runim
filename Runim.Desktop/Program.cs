using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromely.CefGlue;
using Chromely.Core;
using Chromely.Core.Host;

namespace Runim.Desktop
{
    class Program
    {
        static int Main(string[] args)
        {
            var startUrl = "https://www.baidu.com";
            var config = ChromelyConfiguration
                .Create()
                .WithHostMode(WindowState.Normal, true)
                .WithHostIconFile("")
                .WithAppArgs(args)
                .WithHostSize(1000, 600)
                .WithStartUrl(startUrl);
            using (var window = ChromelyWindow.Create(config))
            {
                return window.Run(args);
            }
        }
    }
}
