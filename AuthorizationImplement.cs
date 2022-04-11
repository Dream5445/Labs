using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task_1.POM;

namespace Task_1.Implement
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
            AuthorizationPOM autho = new AuthorizationPOM(_driver);
            autho.email(email);
            autho.password(password);
        }

        public void ClikOnBtn()
        {
            AuthorizationPOM autho = new AuthorizationPOM(_driver);
            autho.clikonBtn();
        }

        public void ClikOnBtnSignIn()
        {
            AuthorizationPOM autho = new AuthorizationPOM(_driver);
            autho.clikonBtnLoginn();
        }
    }
}
