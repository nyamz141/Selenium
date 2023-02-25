using System;
using DriverFramework.BrowserDrivers;

namespace DriverFramework.RetrieveDrivers
{
	public class FetchBrowserDriver: IFetchBrowserDriver
    {
        private readonly IGetBrowserDriver _browserDriver;

		public FetchBrowserDriver(IGetBrowserDriver browserDriver)
		{
            _browserDriver = browserDriver;
        }
        public IWebDriver returnWebDriver(string driver)
        {
            switch (driver)
            {
                case "Chrome":
                    return _browserDriver.getChromeDriver;
                case "Firefox":
                    return _browserDriver.getFirefoxDriver;
                case "Edge":
                    return _browserDriver.getEdgeDriver;
                case "Safari":
                    return _browserDriver.getSafariDriver;
                default:break;
            }
            return _browserDriver.getChromeDriver;
        }
    }
}

