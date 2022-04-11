using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task4.POM
{
    class AutorizationPOM
    {
        IWebDriver _driver;
        public AutorizationPOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _clikonBtn = By.XPath("//a[@class='ico-login']");
        private readonly static By _email = By.Id("Email");
        private readonly static By _password = By.Id("Password");
        private readonly static By _clikonBtnLogin = By.XPath("//input[@class='button-1 login-button']");

        public void clikonBtn()
        {
            _driver.FindElement(_clikonBtn).Click();
            Thread.Sleep(2000);
        }

        public AutorizationPOM email(string text)
        {
            _driver.FindElement(_email).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public AutorizationPOM password(string text)
        {
            _driver.FindElement(_password).SendKeys(text);
            Thread.Sleep(2000);
            return this;
        }

        public void clikonBtnLoginn()
        {
            _driver.FindElement(_clikonBtnLogin).Click();
            Thread.Sleep(2000);
        }
    }
}
