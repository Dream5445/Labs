using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task3.POM;

namespace Task3.Implement
{
    class AutorizationImplement
    {
        IWebDriver _driver;

        public AutorizationImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Autho(string email, string password)
        {
            AutorizationPOM autho = new AutorizationPOM(_driver);
            autho.email(email);
            autho.password(password);
        }

        public void ClikOnBtn()
        {
            AutorizationPOM autho = new AutorizationPOM(_driver);
            autho.clikonBtn();
        }

        public void ClikOnBtnSignIn()
        {
            AutorizationPOM autho = new AutorizationPOM(_driver);
            autho.clikonBtnLoginn();
        }
    }
}
