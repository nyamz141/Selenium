using System;
namespace DriverFramework.RetrieveDrivers
{
	public interface IFetchBrowserDriver
	{
        public IWebDriver returnWebDriver(string driver);
    }
}

