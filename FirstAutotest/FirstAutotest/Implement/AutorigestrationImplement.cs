using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using FirstAutotest.POM;

namespace FirstAutotest.Implement
{
    class AutorigestrationImplement
    {
        IWebDriver _driver;

        public AutorigestrationImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Autho(string email, string password)
        {
            AutorigestrationPOM autho = new AutorigestrationPOM(_driver);
            autho.email(email);
            autho.password(password);
        }

        public void ClikOnBtn()
        {
            AutorigestrationPOM autho = new AutorigestrationPOM(_driver);
            autho.clikonBtn();
        }

        public void ClikOnBtnSignIn()
        {
            AutorigestrationPOM autho = new AutorigestrationPOM(_driver);
            autho.clikonBtnLoginn();
        }
    }
}
