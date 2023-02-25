using System;
using OpenQA.Selenium;

namespace DriverWebTargetPages.Pages.Purchase
{
	public interface IFlowerPurchase
	{
		public Uri getPurchaseAddress { get; }
		public IWebDriver getWebDriver { get; }

		public IWebElement confirmPageReachable(IWebDriver driver);
		public IWebElement selectFirstProductInList(IWebDriver driver);
		public IWebElement purchasingProductName(IWebDriver driver);
		public IWebElement purchaingProductExtras(IWebDriver driver);
		public IWebElement purchasingReceipientDetails(IWebDriver driver);
		public IWebElement purchasingDeliveryDate(IWebDriver driver);
        public IWebElement purchasingCardMessage(IWebDriver driver);
        public IWebElement purchasingBuyerdetails(IWebDriver driver);
        public IWebElement purchasingPreferences(IWebDriver driver);
    }
}

