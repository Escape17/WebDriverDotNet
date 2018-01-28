using OpenQA.Selenium;

namespace WebDriver.Core
{
    public interface IWebDriverFactory
    {
        IWebDriver InitializeWebDriver(IWebDriverSetup webDriverSetup);
    }
}
