using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Task_1.POM
{
    class RegistrationPOM
    {
        IWebDriver _driver;
        public RegistrationPOM(IWebDriver driver)
        {
            _driver = driver;
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
        private readonly static By _loginBtn = By.XPath("//a[@class='ico-register']");
        private readonly static By _ClikonradioBtn = By.Id("gender-male");
        private readonly static By _firstNmae = By.XPath("//input[@id='FirstName']");
        private readonly static By _lastNmae = By.XPath("//input[@id='LastName']");
        private readonly static By _email = By.XPath("//input[@id='Email']");
        private readonly static By _password = By.XPath("//input[@id='Password']");
        private readonly static By _confirmPassword = By.XPath("//input[@id='ConfirmPassword']");
        private readonly static By _registerBtn = By.XPath("//input[@id='register-button']");
        public void clikOnBtn()
        {
            _driver.FindElement(_loginBtn).Click();
        }

        public void ClikonradioBtn()
        {
            _driver.FindElement(_ClikonradioBtn).Click();
        }

        public RegistrationPOM FirstName(string text)
        {
            _driver.FindElement(_firstNmae).SendKeys(text);
            return this;
        }

        public RegistrationPOM LastName(string text)
        {
            _driver.FindElement(_lastNmae).SendKeys(text);
            return this;
        }

        public RegistrationPOM Email(string text)
        {
            _driver.FindElement(_email).SendKeys(text);
            return this;
        }

        public RegistrationPOM Password(string text)
        {
            _driver.FindElement(_password).SendKeys(text);
            return this;
        }

        public RegistrationPOM confirmPassword(string text)
        {
            _driver.FindElement(_confirmPassword).SendKeys(text);
            return this;
        }

        public void regisrBtn()
        {
            _driver.FindElement(_registerBtn).Click();
        }
    }
}
