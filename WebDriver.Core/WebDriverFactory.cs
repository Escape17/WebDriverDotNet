using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Linq;

namespace WebDriver.Core
{
    public class WebDriverFactory : IWebDriverFactory
    {
        public IWebDriver InitializeWebDriver(IWebDriverSetup webDriverSetup)
        {
            switch (webDriverSetup.DriverType)
            {
                case WebDriverType.Chrome:
                    return InitializeChromeDriver(webDriverSetup);

                case WebDriverType.FireFox:
                    return InitializeFireFoxDriver(webDriverSetup);

                case WebDriverType.InternetExplorer:
                    return InitializeInternetExplorerDriver(webDriverSetup);

                default:
                    return InitializeChromeDriver(webDriverSetup);
            }
        }

        protected IWebDriver InitializeChromeDriver(IWebDriverSetup setup)
        {
            var chromeOptions = new ChromeOptions();

            if (setup.BrowserArgs.Any())
            {
                foreach (string arg in setup.BrowserArgs)
                {
                    chromeOptions.AddArgument(arg);
                }
            }
            chromeOptions.SetLoggingPreference(setup.WebDriverLogLevel.LogType, setup.WebDriverLogLevel.LogLevel);
            chromeOptions.AcceptInsecureCertificates = setup.AcceptInsecureCertificates;

            return GetDriver<ChromeDriver>(chromeOptions, setup);
        }

        protected IWebDriver InitializeFireFoxDriver(IWebDriverSetup setup)
        {
            var fireFoxOptions = new FirefoxOptions();

            if (setup.BrowserArgs.Any())
            {
                foreach (string arg in setup.BrowserArgs)
                {
                    fireFoxOptions.AddArgument(arg);
                }
            }

            fireFoxOptions.SetLoggingPreference(setup.WebDriverLogLevel.LogType, setup.WebDriverLogLevel.LogLevel);
            fireFoxOptions.AcceptInsecureCertificates = setup.AcceptInsecureCertificates;

            return GetDriver<FirefoxDriver>(fireFoxOptions, setup);
        }

        protected IWebDriver InitializeInternetExplorerDriver(IWebDriverSetup setup)
        {
            var ieOptions = new InternetExplorerOptions();

            ieOptions.SetLoggingPreference(setup.WebDriverLogLevel.LogType, setup.WebDriverLogLevel.LogLevel);
            ieOptions.AcceptInsecureCertificates = setup.AcceptInsecureCertificates;

            return GetDriver<InternetExplorerDriver>(ieOptions, setup);
        }

        protected IWebDriver GetDriver<TWebDriver>(DriverOptions options, IWebDriverSetup setup) where TWebDriver : IWebDriver
        {
            var webDriver = setup.UseRemoteRunning
                ? new RemoteWebDriver(options)
                : Activator.CreateInstance(typeof(TWebDriver), setup.DriverLocation) as IWebDriver;
            return webDriver;
        }
    }
}
