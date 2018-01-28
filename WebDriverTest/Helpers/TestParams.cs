using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WebDriver.Core;

namespace WebDriver.Specflow.Helpers
{
    public static class TestParams
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings[nameof(BaseUrl)];
        public static readonly WebDriverType Browser = ConfigurationManager.AppSettings[nameof(Browser)].ToEnum<WebDriverType>();
        public static readonly string UseRemoteRunning = ConfigurationManager.AppSettings[nameof(UseRemoteRunning)] ?? "false";
        public static readonly string BrowserLogLevel = ConfigurationManager.AppSettings[nameof(BrowserLogLevel)];
        public static readonly string UseHeadless = ConfigurationManager.AppSettings[nameof(UseHeadless)] ?? "false";
        public static readonly string AllowInsecureContent = ConfigurationManager.AppSettings[nameof(AllowInsecureContent)] ?? "false";
    }
}
