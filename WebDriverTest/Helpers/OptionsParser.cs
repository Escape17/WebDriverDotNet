using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Core;

namespace WebDriver.Specflow.Helpers
{
    public static class OptionsParser
    {
        public static List<string> ParseCustomBrowserArgs(WebDriverType driverType)
        {
            switch (driverType)
            {
                case WebDriverType.Chrome:
                        return ParseChromeArgs();

                case WebDriverType.FireFox:
                        return ParseFirefoxArgs();

                case WebDriverType.InternetExplorer:
                        return ParseInternetExplorerArgs();

                default: return new List<string>();
            }

        }

        private static List<string> ParseChromeArgs()
        {
            List<string> chromeArgs = new List<string>();
            if (bool.Parse(TestParams.UseHeadless))
            {
                chromeArgs.Add("--use-headless");
            }
            if (bool.Parse(TestParams.AllowInsecureContent))
            {
                chromeArgs.Add("--allow-running-insecure-content");
            }
            // TO DO: additional chrome args.
            return chromeArgs;
        }

        private static List<string> ParseFirefoxArgs()
        {
            // TO DO
            return new List<string>();
        }

        private static List<string> ParseInternetExplorerArgs()
        {
            // TO DO
            return new List<string>();
        }
    }
}
