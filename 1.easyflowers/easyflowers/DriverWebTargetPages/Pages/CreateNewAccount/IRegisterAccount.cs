using System;
using OpenQA.Selenium;

namespace DriverWebTargetPages.Pages.CreateNewAccount
{
	public interface IRegisterAccount
	{
        public Uri retrieveAccountsWebAddress { get; }
        public IWebDriver getWebDriver { get; }

        public IWebElement confirmCorrectHeader(IWebDriver driver);
        public IWebElement checkRegistrationFormRows(IWebDriver driver);

        public IWebElement enterFirstName(IWebDriver driver);
        public IWebElement enterLastName(IWebDriver driver);
        public IWebElement telephoneNumber(IWebDriver driver);
        public IWebElement mobileNumber(IWebDriver driver);
        public IWebElement addressLine1(IWebDriver driver);
        public IWebElement addressLine2(IWebDriver driver);
        public IWebElement enterSurbub(IWebDriver driver);
        public IWebElement enterState(IWebDriver driver);
        public IWebElement enterPostcode(IWebDriver driver);
        public IWebElement enterCountry(IWebDriver driver);
        public IWebElement emailAddress(IWebDriver driver);
        public IWebElement emailAddressConfirm(IWebDriver driver);
        public IWebElement password(IWebDriver driver);
        public IWebElement passwordConfirm(IWebDriver driver);
        public IWebElement newsLetterCheckmark(IWebDriver driver);
        public IWebElement registerUserButton(IWebDriver driver);
    }
}

