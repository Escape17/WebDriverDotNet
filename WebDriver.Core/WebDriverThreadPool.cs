using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebDriver.Core
{
    public sealed class WebDriverThreadPool
    {
        private static volatile WebDriverThreadPool _instance;
        public IList<ThreadLocal<IWebDriver>> Threads { get; set; }
        private static readonly object syncRoot = new Object();

        private WebDriverThreadPool()
        {
            Threads = new List<ThreadLocal<IWebDriver>>();
        }

        public static WebDriverThreadPool Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new WebDriverThreadPool();
                    }
                }
                return _instance;
            }
        }
    }
}
