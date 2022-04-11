using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task7.POM;

namespace Task7.Implement
{
    class AuthorizationImplement
    {
        IWebDriver _driver;

        public AuthorizationImplement(IWebDriver driver)
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
