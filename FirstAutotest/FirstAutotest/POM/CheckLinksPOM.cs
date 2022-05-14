using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FirstAutotest.POM
{
    class CheckLinksPOM
    {
        IWebDriver _driver;
        public CheckLinksPOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _clikonBtnFerst = By.XPath("//a[@href='http://www.facebook.com/nopCommerce']");
        private readonly static By _clikonBtnSecond = By.XPath("//a[@href='https://twitter.com/nopCommerce']");
        private readonly static By _clikonBtnThird = By.XPath("//a[@href='http://www.youtube.com/user/nopCommerce']");

        public void Clickfirst()
        {
            _driver.FindElement(_clikonBtnFerst).Click();
        }

        public void Clicksecond()
        {
            _driver.FindElement(_clikonBtnSecond).Click();
        }

        public void Clickthird()
        {
            _driver.FindElement(_clikonBtnThird).Click();
        }
    }
}
