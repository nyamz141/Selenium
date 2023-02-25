using System;
using DriverFramework.RetrieveDrivers;
using OpenQA.Selenium;

namespace DriverWebTargetPages.Pages.CreateNewAccount
{
	public class RegisterAccount: IRegisterAccount
	{
		Uri webaddress = new Uri("https://www.easyflowers.com.au/members/create");
		IWebDriver _driver;

		public RegisterAccount(IFetchBrowserDriver browserDriver)
		{
			_driver = browserDriver.returnWebDriver("Chrome");
		}

		public Uri retrieveAccountsWebAddress => webaddress;
		public IWebDriver getWebDriver => _driver;

        public IWebElement addressLine1(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberAddressLine1"));
        }
        public IWebElement addressLine2(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberAddressLine2"));
        }
        public IWebElement checkRegistrationFormRows(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector(".member-details"));
        }
        public IWebElement confirmCorrectHeader(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("div[class='content-wrapper'] h1"));
        }
        public IWebElement emailAddress(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberEmail"));
        }
        public IWebElement emailAddressConfirm(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberEmailConfirm"));
        }
        public IWebElement enterCountry(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberCountry"));
        }
        public IWebElement enterFirstName(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberFirstName"));
        }
        public IWebElement enterLastName(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//input[@id='MemberSecondName']"));
        }
        public IWebElement enterPostcode(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberPostcode"));
        }
        public IWebElement enterState(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberState"));
        }
        public IWebElement enterSurbub(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberSuburb"));
        }
        public IWebElement mobileNumber(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberMobile"));
        }
        public IWebElement newsLetterCheckmark(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#Newsletter"));
        }
        public IWebElement password(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#Password"));
        }
        public IWebElement passwordConfirm(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#PasswordCheck"));
        }
        public IWebElement registerUserButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("div[class='easy-button standard-button green-button pull-right do-loading push-button'] div[class='button-label text-center no-icon']"));
        }
        public IWebElement telephoneNumber(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector("#MemberTelephone"));
        }
    }
}

