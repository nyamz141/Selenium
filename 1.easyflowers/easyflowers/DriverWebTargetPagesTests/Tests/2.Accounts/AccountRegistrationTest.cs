using System;
using DriverWebTargetPages.Pages.CreateNewAccount;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DriverWebTargetPagesTests.Tests.Accounts
{
	public class AccountRegistrationTest: IDisposable
	{
        IWebDriver driver;
        private readonly IRegisterAccount _registerAccount;

        public AccountRegistrationTest(IRegisterAccount registerAccount)
		{
            _registerAccount = registerAccount;
            driver = _registerAccount.getWebDriver;
        }

        [Fact]
        public void TestAccountCreation()
        {
            driver.Navigate().GoToUrl(_registerAccount.retrieveAccountsWebAddress);

            var registerHeader = _registerAccount.confirmCorrectHeader(driver);
            Assert.Contains("Create Account", registerHeader.Text);

            var inputName = _registerAccount.enterFirstName(driver);
            Assert.IsType<WebElement>(inputName);
            inputName.SendKeys("Munya");

            var inputLastName = _registerAccount.enterLastName(driver);
            Assert.IsType<WebElement>(inputLastName);
            inputLastName.SendKeys("Nyamatore");

            var phone = _registerAccount.telephoneNumber(driver);
            Assert.IsType<WebElement>(phone);
            phone.SendKeys("1234567890");

            var mobile = _registerAccount.mobileNumber(driver);
            Assert.IsType<WebElement>(mobile);
            mobile.SendKeys("0987654321");

            var address1 = _registerAccount.addressLine1(driver);
            Assert.IsType<WebElement>(address1);
            address1.SendKeys("1 Somthing Street");

            var address2 = _registerAccount.addressLine2(driver);
            Assert.IsType<WebElement>(address2);
            address2.SendKeys("Nearest City");

            var surbub = _registerAccount.enterSurbub(driver);
            Assert.IsType<WebElement>(surbub);
            surbub.SendKeys("Legit Surbub");

            var state = _registerAccount.enterState(driver);
            Assert.IsType<WebElement>(state);
            state.SendKeys("Qld");

            var postcode = _registerAccount.enterPostcode(driver);
            Assert.IsType<WebElement>(postcode);
            postcode.SendKeys("1000");

            var country = _registerAccount.enterCountry(driver);
            Assert.IsType<WebElement>(country);
            country.SendKeys("Australia");

            var email1 = _registerAccount.emailAddress(driver);
            Assert.IsType<WebElement>(email1);
            email1.SendKeys("legit@email.com");

            var email2 = _registerAccount.emailAddressConfirm(driver);
            Assert.IsType<WebElement>(email2);
            email2.SendKeys("legit@email.com");

            var password1 = _registerAccount.password(driver);
            Assert.IsType<WebElement>(password1);
            password1.SendKeys("P@ssword");

            var password2 = _registerAccount.passwordConfirm(driver);
            Assert.IsType<WebElement>(password2);
            password2.SendKeys("P@ssword");

            //ACCOUNT CREATION SIMULATION ONLY
            //Button and Capture are NOT actioned
            //to prevent spamming a legit business

            Dispose();
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}

