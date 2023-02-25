using System;
using DriverWebTargetPages.Pages.Purchase;
using OpenQA.Selenium;

namespace DriverWebTargetPagesTests.Tests.MockPurchase
{
	public class PurchaseBouquet: IDisposable
	{
        IWebDriver driver;
        private readonly IFlowerPurchase _flowerPurchase;

        public PurchaseBouquet(IFlowerPurchase flowerPurchase)
		{
            _flowerPurchase = flowerPurchase;
            driver = _flowerPurchase.getWebDriver;
        }

        [Fact]
        public void SimulatePurchase()
        {
            var listing = _flowerPurchase.selectFirstProductInList(driver);
            Assert.IsType<WebElement>(listing);
            var products = listing.FindElements(By.ClassName("home-product"));
            Assert.InRange(products.Count(), 1, 100);

            var firstProduct = products[0];
            var productButtonElement = firstProduct.FindElement(By.XPath("(//a[@title='Charlene - Click to order'])[3]"));
            Assert.IsType<WebElement>(productButtonElement);
            var productPrice = productButtonElement.FindElement(By.XPath("//a[@title='Charlene - Click to order']//div[@class='home-product-price']"));
            Assert.IsType<WebElement>(productPrice);
            productPrice.Click();

            var productName = _flowerPurchase.purchasingProductName(driver);
            Assert.IsType<WebElement>(productPrice);
            productName.Click();

            var extras = _flowerPurchase.purchaingProductExtras(driver);
            Assert.IsType<WebElement>(extras);
            extras.Click();

            var recipient = _flowerPurchase.purchasingReceipientDetails(driver);
            Assert.IsType<WebElement>(recipient);
            recipient.Click();

            var delivery = _flowerPurchase.purchasingDeliveryDate(driver);
            Assert.IsType<WebElement>(delivery);
            delivery.Click();

            var message = _flowerPurchase.purchasingCardMessage(driver);
            Assert.IsType<WebElement>(message);
            message.Click();

            var sender = _flowerPurchase.purchasingBuyerdetails(driver);
            Assert.IsType<WebElement>(sender);
            sender.Click();

            var preferences = _flowerPurchase.purchasingPreferences(driver);
            Assert.IsType<WebElement>(preferences);
            preferences.Click();

            Task.Delay(5000).Wait();

            Dispose();
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}

