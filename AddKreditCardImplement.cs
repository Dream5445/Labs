using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task5_6.POM;

namespace Task5_6.Implement
{
    class AddKreditCardImplement
{
        IWebDriver _driver;

        public AddKreditCardImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GiftCard()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.clikonBtn();


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
