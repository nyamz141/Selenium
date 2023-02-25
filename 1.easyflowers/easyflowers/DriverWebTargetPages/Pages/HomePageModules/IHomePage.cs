using System;
using OpenQA.Selenium;

namespace DriverWebTargetPages.Pages.HomePageModules
{
	public interface IHomePage
	{
        public Uri retrieveWebAddress { get; }
        public IWebDriver getWebDriver { get; }

        public IWebElement checkHomeIcon(IWebDriver driver);
        public IWebElement desktopHorizontalCenterMenu(IWebDriver driver);
        public IWebElement desktopHorizontalRightMenu(IWebDriver driver);
        public IWebElement returnSiteProductListing(IWebDriver driver);
        public IWebElement getSiteFeatureQuickSelectFrame(IWebDriver driver);
    }
}

