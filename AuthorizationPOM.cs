using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task_1.POM
{
    class AuthorizationPOM
    {
        IWebDriver _driver;
        public AuthorizationPOM(IWebDriver driver)
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
        }

        public AuthorizationPOM email(string text)
        {
            _driver.FindElement(_email).SendKeys(text);
            return this;
        }

        public AuthorizationPOM password(string text)
        {
            _driver.FindElement(_password).SendKeys(text);
            return this;
        }

        public void clikonBtnLoginn()
        {
            _driver.FindElement(_clikonBtnLogin).Click();
        }
    }
}
