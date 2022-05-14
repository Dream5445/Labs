using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using FirstAutotest.POM;

namespace FirstAutotest.Implement
{
    class CheckLinksImplement
    {
        IWebDriver _driver;

        public CheckLinksImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClikOnBtn()
        {
            CheckLinksPOM wev = new CheckLinksPOM(_driver);
            wev.Clickfirst();
        }
        public void ClikOnBtnsecond()
        {
            CheckLinksPOM wev = new CheckLinksPOM(_driver);
            wev.Clicksecond();
        }
        public void ClikOnBtnthird()
        {
            CheckLinksPOM wev = new CheckLinksPOM(_driver);
            wev.Clickthird();
        }
    }
}
