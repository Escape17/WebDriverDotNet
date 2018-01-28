using System;
using System.Collections.Generic;
using System.IO;

namespace WebDriver.Core
{
    public class WebDriverSetup : IWebDriverSetup
    {
        public WebDriverType DriverType { get; set; }
        public string BaseUrl { get; set; }
        public bool UseRemoteRunning { get; set; } = true;
        public bool AcceptInsecureCertificates { get; set; }
        public IList<string> BrowserArgs { get; set; }
        public WebDriverLogLevel WebDriverLogLevel { get; set; }
        public string DriverLocation { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets/");
    }
}
