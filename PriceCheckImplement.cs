using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task3.POM;

namespace Task3.Implement
{
    class PriceCheckImplement
    {
        IWebDriver _driver;

        public PriceCheckImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Click()
        {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.Clik();
        }

        public void ClickOnDeskTop()
        {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.ClikOnDeskTop();
        }

        public void ClikOnComb() {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.ClikOnComb();
        }

        public void ClikOmAlph() {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.ClikOnAlph();
        }

        public void ClikOnPC()
        {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.ClikOnPC();
        }

        public void ClikOnCompareList()
        {
            CheckPricePOM check = new CheckPricePOM(_driver);
            check.ClikOnCompareList();
        }

    }
}
