using System.Collections.Generic;

namespace WebDriver.Core
{
    public interface IWebDriverSetup
    {
        WebDriverType DriverType { get; set; }

        string BaseUrl { get; set; }

        bool UseRemoteRunning { get; set; }

        bool AcceptInsecureCertificates { get; set; }

        IList<string> BrowserArgs { get; set; }

        WebDriverLogLevel WebDriverLogLevel { get; set; }

        string DriverLocation { get; set; }
    }
}
