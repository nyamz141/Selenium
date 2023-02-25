using System;
using DriverWebTargetPages.Pages.HomePageModules;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DriverWebTargetPagesTests.Tests.HomePage
{
	public class HomePageTests: IDisposable
	{
        private readonly IHomePage _homePage;
        IWebDriver driver;

        public HomePageTests(IHomePage homePage)
		{
            _homePage = homePage;
            driver = _homePage.getWebDriver;
            driver.Navigate().GoToUrl(_homePage.retrieveWebAddress);
        }

        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void HomePageTest()
        {
            var homeicon = _homePage.checkHomeIcon(driver);
            Assert.IsType<WebElement>(homeicon);

            var centermenu = _homePage.desktopHorizontalCenterMenu(driver);
            Assert.IsType<WebElement>(centermenu);
            var children = centermenu.FindElements(By.ClassName("category-group"));
            Assert.Equal(5, children.Count);

            var rightmenu = _homePage.desktopHorizontalRightMenu(driver);
            Assert.IsType<WebElement>(rightmenu);

            var listing = _homePage.returnSiteProductListing(driver);
            Assert.IsType<WebElement>(listing);
            var products = listing.FindElements(By.ClassName("home-product"));
            Assert.InRange(products.Count(), 1, 100);

            var quickSelect = _homePage.getSiteFeatureQuickSelectFrame(driver);
            Assert.IsType<WebElement>(quickSelect);
            var quickSelectForm = quickSelect.FindElement(By.CssSelector(".form-inline"));
            var formElements = quickSelectForm.FindElements(By.ClassName("form-group"));
            Assert.Equal(4, formElements.Count);

            Dispose();
        }

    }
}

