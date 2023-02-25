using System;
using OpenQA.Selenium;

namespace DriverFramework.BrowserDrivers
{
	public interface IGetBrowserDriver
	{
		public IWebDriver getChromeDriver { get; }
		public IWebDriver getFirefoxDriver { get; }
		public IWebDriver getSafariDriver { get; }
		public IWebDriver getEdgeDriver { get; }
	}
}

