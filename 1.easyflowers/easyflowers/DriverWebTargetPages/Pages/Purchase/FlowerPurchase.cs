using System;
using DriverFramework.RetrieveDrivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DriverWebTargetPages.Pages.Purchase
{
	public class FlowerPurchase: IFlowerPurchase
	{
        IWebDriver _driver;
        private Uri homepageLink = new Uri("https://www.easyflowers.com.au/");
        Utilities utilities = new Utilities();

        public FlowerPurchase(IFetchBrowserDriver browserdriver)
		{
            _driver = browserdriver.returnWebDriver("Chrome");
        }

        public Uri getPurchaseAddress => homepageLink;
        public IWebDriver getWebDriver => _driver;

        public IWebElement confirmPageReachable(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("");
            return driver.FindElement(By.XPath("//a[@href='/']"));
        }

        public IWebElement purchaingProductExtras(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/additions");
            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement purchasingBuyerdetails(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/yourdetails");
            var salutaationddl = driver.FindElement(By.XPath("//select[@id='TitleId']"));
            Assert.IsType<WebElement>(salutaationddl);
            var selectedSalutation = new SelectElement(salutaationddl);
            selectedSalutation.SelectByValue(utilities.returnOccasaionDroDownValue(1, 5));

            var fname = driver.FindElement(By.XPath("//input[@id='SenderFirstName']"));
            Assert.IsType<WebElement>(fname);
            fname.SendKeys("Sender");

            var lname = driver.FindElement(By.XPath("//input[@id='SenderSecondName']"));
            Assert.IsType<WebElement>(lname);
            lname.SendKeys("McSenderface");

            var mobile = driver.FindElement(By.XPath("//input[@id='SenderMobile']"));
            Assert.IsType<WebElement>(mobile);
            mobile.SendKeys("12345678990");

            var phone = driver.FindElement(By.XPath("//input[@id='SenderTelephone']"));
            Assert.IsType<WebElement>(phone);
            phone.SendKeys("0987654321");

            var address1 = driver.FindElement(By.CssSelector("#SenderAddressLine1"));
            Assert.IsType<WebElement>(address1);
            address1.SendKeys("1 PO Box");

            var address2 = driver.FindElement(By.CssSelector("#SenderAddressLine2"));
            Assert.IsType<WebElement>(address2);
            address2.SendKeys("In My City");

            var surburb = driver.FindElement(By.XPath("//input[@id='SenderSuburb']"));
            Assert.IsType<WebElement>(surburb);
            surburb.SendKeys("Real Surburb");

            var state = driver.FindElement(By.XPath("//input[@id='SenderState']"));
            Assert.IsType<WebElement>(state);
            state.SendKeys(utilities.recipientState());

            var postcode = driver.FindElement(By.XPath("//input[@id='SenderPostcode']"));
            Assert.IsType<WebElement>(postcode);
            postcode.SendKeys("1000");

            var counrty = driver.FindElement(By.XPath("//input[@id='SenderCountry']"));
            Assert.IsType<WebElement>(counrty);
            counrty.SendKeys("Aussie");

            var email1 = driver.FindElement(By.XPath("//input[@id='SenderEmail']"));
            Assert.IsType<WebElement>(email1);
            email1.SendKeys("legit@email.com");

            var email2 = driver.FindElement(By.XPath("//input[@id='SenderEmailConfirm']"));
            Assert.IsType<WebElement>(email2);
            email2.SendKeys("legit@email.com");

            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement purchasingCardMessage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/message");
            var nomessage = driver.FindElement(By.XPath("(//div[@class='radio no-image'])[1]"));
            Assert.IsType<WebElement>(nomessage);
            nomessage.Click();
            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement purchasingDeliveryDate(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/deliverydetails");
            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement purchasingPreferences(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/yourpreferences");
            return driver.FindElement(By.XPath("//div[contains(@class,'do-loading push-button')]"));
        }

        public IWebElement purchasingProductName(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/product");
            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement purchasingReceipientDetails(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/order/recipientdetails");
            var recipientName = driver.FindElement(By.Id("RecipientName"));
            Assert.IsType<WebElement>(recipientName);
            recipientName.SendKeys("Friend");

            var mobile = driver.FindElement(By.XPath("//input[@id='RecipientMobile']"));
            Assert.IsType<WebElement>(mobile);
            mobile.SendKeys("0123456789");

            var phone = driver.FindElement(By.XPath("//input[@id='RecipientTelephone']"));
            Assert.IsType<WebElement>(phone);
            phone.SendKeys("0987654321");

            var occassionddl = driver.FindElement(By.XPath("//select[@id='Occasion']"));
            Assert.IsType<WebElement>(occassionddl);
            var occassionSelect = new SelectElement(occassionddl);
            occassionSelect.SelectByValue("1");

            var locationddl = driver.FindElement(By.CssSelector("#RecipientLocation"));
            Assert.IsType<WebElement>(locationddl);
            var locationSelect = new SelectElement(locationddl);
            locationSelect.SelectByValue("Residential");

            Task.Delay(15000).Wait(); //MANUALLY TYPE ADDRESS INTO SEARCH. 15 second wait

            return driver.FindElement(By.XPath("(//div[@class='button-inner'])[1]"));
        }

        public IWebElement selectFirstProductInList(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.easyflowers.com.au/");
            return driver.FindElement(By.CssSelector(".products.content-main.base-4"));
        }
    }
}

