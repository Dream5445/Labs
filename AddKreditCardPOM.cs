using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Task5_6.POM
{
    class AddKreditCardPOM
{
        IWebDriver _driver;
        public AddKreditCardPOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _giftcard = By.XPath("//a[@href='/gift-cards']");
        private readonly static By _btnAddToCartGift = By.XPath("//input[@class='button-2 product-box-add-to-cart-button']");
        private readonly static By _NamegiftCard = By.Id("giftcard_4_RecipientName");
        private readonly static By _clikonAddcard = By.Id("add-to-cart-button-4");
        private readonly static By _books = By.XPath("//a[@href='/books']");
        private readonly static By _computers = By.XPath("//a[@href='/computers']");
        private readonly static By _laptop = By.XPath("//a[@title='/Show products in category Notebooks']");
        private readonly static By _jewelry = By.XPath("//a[@href='/jewelry']");
        private readonly static By _shoppingCard = By.XPath("//span[@class='cart-label']");
        private readonly static By _Chek = By.Id("termsofservice");
        private readonly static By _Checkout = By.Id("checkout");
        private readonly static By _CountryId = By.Id("BillingNewAddress_CountryId");
        private readonly static By _Value = By.XPath("option[@value='78']");
        private readonly static By _city = By.Id("BillingNewAddress_City");
        private readonly static By _address = By.Id("BillingNewAddress_Address1");
        private readonly static By _ZipPostalCode = By.Id("BillingNewAddress_ZipPostalCode");
        private readonly static By _PhoneNumber = By.Id("BillingNewAddress_PhoneNumber");
        private readonly static By _stepButton = By.XPath("//input[@class='button-1 new-address-next-step-button']");
        private readonly static By _PickUpInStor = By.Id("PickUpInStore");
        private readonly static By _paymentmethod = By.Id("paymentmethod-2");
        private readonly static By paymentMethod = By.XPath("//input[@class='button-1 payment-method-next-step-button']");
        private readonly static By _CreditCard = By.Id("CreditCardType");
        private readonly static By _CardholderName = By.Id("CardholderName");
        private readonly static By _CardNumber = By.Id("CardNumber");
        private readonly static By _ExpireMonth = By.Id("ExpireMonth");
        private readonly static By _ExpireMonthValue = By.XPath("select[@value='1']");
        private readonly static By _ExpireYear = By.Id("ExpireYear");
        private readonly static By _ExpireYearValue = By.XPath("select[@value='2024']");
        private readonly static By _CardCode = By.Id("CardCode");

        public void clikonBtn()
        {
            _driver.FindElement(_giftcard).Click();
            Thread.Sleep(2000);
        }

        public void btnAddToCartGiftn()
        {
            _driver.FindElement(_btnAddToCartGift).Click();
            Thread.Sleep(2000);
        }

        public AddKreditCardPOM NamegiftCard(string text)
        {
            _driver.FindElement(_btnAddToCartGift).SendKeys(text));
            Thread.Sleep(2000);
            return this;
        }

        public void clikonAddcard()
        {
            _driver.FindElement(_clikonAddcard).Click();
            Thread.Sleep(2000);
        }

        public void books()
        {
            _driver.FindElement(_books).Click();
            Thread.Sleep(2000);
        }

        public void computers()
        {
            _driver.FindElement(_computers).Click();
            Thread.Sleep(2000);
        }

        public void laptop()
        {
            _driver.FindElement(_laptop).Click();
            Thread.Sleep(2000);
        }

        public void jewelry()
        {
            _driver.FindElement(_jewelry).Click();
            Thread.Sleep(2000);
        }

        public void shoppingCard()
        {
            _driver.FindElement(_shoppingCard).Click();
            Thread.Sleep(2000);
        }

        public void Chek()
        {
            _driver.FindElement(_Chek).Click();
            Thread.Sleep(2000);
        }
        public void Checkout()
        {
            _driver.FindElement(_Checkout).Click();
            Thread.Sleep(2000);
        }

        public void CountryId()
        {
            _driver.FindElement(_CountryId).Click();
            Thread.Sleep(2000);
        }

        public void Value()
        {
            _driver.FindElement(_Value).Click();
            Thread.Sleep(2000);
        }

        public AddKreditCardPOM city(string text)
        {
            _driver.FindElement(_city).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AddKreditCardPOM address(string text)
        {
            _driver.FindElement(_address).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AddKreditCardPOM ZipPostalCode(string text)
        {
            _driver.FindElement(_ZipPostalCode).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AddKreditCardPOM PhoneNumber(string text)
        {
            _driver.FindElement(_PhoneNumber).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public void PickUpInStor()
        {
            _driver.FindElement(_PickUpInStor).Click();
            Thread.Sleep(2000);
        }

        public void stepButton()
        {
            _driver.FindElement(_stepButton).Click();
            Thread.Sleep(2000);
        }

        public void paymentmethod()
        {
            _driver.FindElement(_paymentmethod).Click();
            Thread.Sleep(2000);
        }

        public void paymentMethodBTN()
        {
            _driver.FindElement(paymentMethod).Click();
            Thread.Sleep(2000);
        }

        public void CreditCard()
        {
            _driver.FindElement(_CreditCard).Click();
            Thread.Sleep(2000);
        }

        public AddKreditCardPOM CardholderName(string text)
        {
            _driver.FindElement(_CardholderName).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AddKreditCardPOM CardNumber(string text)
        {
            _driver.FindElement(_CardNumber).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public void ExpireMonth()
        {
            _driver.FindElement(_ExpireMonth).Click();
            Thread.Sleep(2000);
        }

        public void ExpireMonthValue()
        {
            _driver.FindElement(_ExpireMonthValue).Click();
            Thread.Sleep(2000);
        }

        public void ExpireYear()
        {
            _driver.FindElement(_ExpireYear).Click();
            Thread.Sleep(2000);
        }

        public void ExpireYearValue()
        {
            _driver.FindElement(_ExpireYearValue).Click();
            Thread.Sleep(2000);
        }

        public AddKreditCardPOM CardCode(string text)
        {
            _driver.FindElement(_CardCode).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }


    }
}
