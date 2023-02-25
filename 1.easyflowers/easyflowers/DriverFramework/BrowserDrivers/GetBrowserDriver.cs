using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace DriverFramework.BrowserDrivers
{
	public class GetBrowserDriver: IGetBrowserDriver
	{
        private IWebDriver returnChhromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            return new ChromeDriver();
        }
        private IWebDriver returnFirefoxDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            return new FirefoxDriver();
        }
        private IWebDriver returnEdgeDriver()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            return new EdgeDriver();
        }
        private IWebDriver returnSafariDriver()
        {
            return new SafariDriver();
        }

        public IWebDriver getChromeDriver => returnChhromeDriver();

        public IWebDriver getFirefoxDriver => returnFirefoxDriver();

        public IWebDriver getSafariDriver => returnSafariDriver();

        public IWebDriver getEdgeDriver => returnEdgeDriver();
    }
}

