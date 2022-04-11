using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Task2.POM
{
    class AddToCartPOM
    {
        IWebDriver _driver;

        public AddToCartPOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _Btncard = By.XPath("//input[@class='button-2 product-box-add-to-cart-button']");
        private readonly static By _Name = By.Id("giftcard_2_RecipientName");
        private readonly static By _Email = By.Id("giftcard_2_RecipientEmail");
        private readonly static By _Btn = By.Id("add-to-cart-button-2");


        public void Btncard()
        {
            _driver.FindElement(_Btncard).Click();
            Thread.Sleep(2000);
        }

        public AddToCartPOM Name(string text)
        {
            _driver.FindElement(_Name).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AddToCartPOM Email(string text)
        {
            _driver.FindElement(_Email).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public void Button()
        {
            _driver.FindElement(_Btn).Click();
            Thread.Sleep(2000);
        }

    }
}
