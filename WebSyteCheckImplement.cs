using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task7.POM;

namespace Task7.Implement
{
    class WebSyteCheckImplement
    {
        IWebDriver _driver;

        public WebSyteCheckImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClikOnBtn()
        {
            WebSyteCheckPOM wev = new WebSyteCheckPOM(_driver);
            wev.Clickfirst();
        }
        public void ClikOnBtnsecond()
        {
            WebSyteCheckPOM wev = new WebSyteCheckPOM(_driver);
            wev.Clicksecond();
        }
        public void ClikOnBtnthird()
        {
            WebSyteCheckPOM wev = new WebSyteCheckPOM(_driver);
            wev.Clickthird();
        }

    }
}
