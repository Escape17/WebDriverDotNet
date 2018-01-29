using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using WebDriver.Core;

namespace WebDriver.Specflow.Helpers
{
    public class SeleniumContext
    {
        public IWebDriver WebDriver { get; set; }
        public IWebDriverSetup Setup { get; set; }
        public SeleniumContext()
        {
            Setup = new WebDriverSetup
            {
                DriverType = TestParams.Browser,
                BaseUrl = TestParams.BaseUrl,
                UseRemoteRunning = bool.Parse(TestParams.UseRemoteRunning),
                BrowserArgs = OptionsParser.ParseCustomBrowserArgs(TestParams.Browser),
                AcceptInsecureCertificates = true,
                WebDriverLogLevel = new WebDriverLogLevel(TestParams.Browser.ToString(), TestParams.BrowserLogLevel.ToEnum<LogLevel>())
            };

            WebDriver = new WebDriverFactory().InitializeWebDriver(Setup);
        }
    }
}
