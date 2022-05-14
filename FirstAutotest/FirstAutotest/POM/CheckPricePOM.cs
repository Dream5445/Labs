using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace FirstAutotest.POM
{
    class CheckPricePOM
    {
        IWebDriver _driver;

        public CheckPricePOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _clik = By.XPath("//a[@href='/computers']");
        private readonly static By _clikOnPc = By.XPath("//a[@title='Show products in category Desktops']");
        private readonly static By _clikOnComb = By.Id("products-orderby");
        private readonly static By _clikOnAlph = By.XPath("//option[@value='http://demowebshop.tricentis.com/desktops?orderby=5']");
        private readonly static By _clikOnPC = By.XPath("//a[@href='/build-your-cheap-own-computer']");
        private readonly static By _clikOnCompareList = By.XPath("//input[@class='button-2 add-to-compare-list-button']");

        public void ClikOnCompareList()
        {
            _driver.FindElement(_clikOnCompareList).Click();
            Thread.Sleep(2000);
        }

        public void ClikOnPC()
        {
            _driver.FindElement(_clikOnPC).Click();
            Thread.Sleep(2000);
        }

        public void ClikOnComb() {
            _driver.FindElement(_clikOnComb).Click();
            Thread.Sleep(2000);
        }

        public void Clik()
        {
            _driver.FindElement(_clik).Click();
            Thread.Sleep(2000);
        }

        public void ClikOnDeskTop()
        {
            _driver.FindElement(_clikOnPc).Click();
            Thread.Sleep(2000);
        }

        public void ClikOnAlph() {
            _driver.FindElement(_clikOnAlph).Click();
            Thread.Sleep(2000);
        }

    }
}
