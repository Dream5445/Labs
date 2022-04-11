using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Task4.Helper;

namespace Task4.POM
{
    class SendMessengPOM
    {
        IWebDriver _driver;
        public SendMessengPOM(IWebDriver driver)
        {
            _driver = driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        private readonly static By _ContactUs = By.XPath("//a[@href='/contactus']");
        private readonly static By _Enquiry = By.Id("Enquiry");
        private readonly static By _Submit = By.XPath("//input[@name='send-email']");

        public void Contact()
        {
            _driver.FindElement(_ContactUs).Click();
            Thread.Sleep(2000);
        }

        public void Enq() {
            HelperHelp hel = new HelperHelp();
            string randomWord = " ";
            hel.Random(ref randomWord);
            _driver.FindElement(_Enquiry).SendKeys(randomWord);
            Thread.Sleep(2000);
        }

        public void Sumbit()
        {
            _driver.FindElement(_Submit).Click();
            Thread.Sleep(2000);
        }
    }
}
