using OpenQA.Selenium;

namespace WebDriver.Core
{
    public class WebDriverLogLevel
    {
        public WebDriverLogLevel(string logType, LogLevel logLevel)
        {
            LogType = logType;
            LogLevel = logLevel;
        }
        public string LogType { get; set; } = "browser";
        public LogLevel LogLevel { get; set; } = LogLevel.All;
    }
}
