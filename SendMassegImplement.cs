using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task4.POM;

namespace Task4.Implement
{
    class SendMassegImplement
    {
        IWebDriver _driver;

        public SendMassegImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClikOnBtn()
        {
            SendMessengPOM send = new SendMessengPOM(_driver);
            send.Contact();
        }

        public void Sumbit()
        {
            SendMessengPOM send = new SendMessengPOM(_driver);
            send.Sumbit();
        }

    }
}
