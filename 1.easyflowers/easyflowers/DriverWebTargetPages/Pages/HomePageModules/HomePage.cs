using System;
using DriverFramework.RetrieveDrivers;
using OpenQA.Selenium;

namespace DriverWebTargetPages.Pages.HomePageModules
{
	public class HomePage: IHomePage
	{
		IWebDriver _driver;
		private Uri homepageLink = new Uri("https://www.easyflowers.com.au/");

        public HomePage(IFetchBrowserDriver driver)
		{
			_driver = driver.returnWebDriver("Chrome");
		}

        public Uri retrieveWebAddress => homepageLink;
		public IWebDriver getWebDriver => _driver;

        public IWebElement checkHomeIcon(IWebDriver driver)
		{
            return driver.FindElement(By.XPath("//a[@href='/']"));
        }

		public IWebElement desktopHorizontalCenterMenu(IWebDriver driver)
		{
			return driver.FindElement(By.XPath("//div[@id='category-menu']//ul[@class='desktop-menu']"));
		}

		public IWebElement desktopHorizontalRightMenu(IWebDriver driver)
		{
			return driver.FindElement(By.CssSelector(".menu.right-menu.hidden-xs.hidden-sm.col-xs-12.col-sm-12.col-md-3.col-lg-3"));
		}

		public IWebElement returnSiteProductListing(IWebDriver driver)
		{
			return driver.FindElement(By.CssSelector(".products.content-main.base-4"));
		}

		public IWebElement getSiteFeatureQuickSelectFrame(IWebDriver driver)
		{
			return driver.FindElement(By.XPath("//div[@class='easy-slide-heading quick-select quick-select-static']"));
		}
    }
}

