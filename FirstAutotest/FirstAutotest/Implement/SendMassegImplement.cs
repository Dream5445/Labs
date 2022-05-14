using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using FirstAutotest.POM;

namespace FirstAutotest.Implement
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
