using System;
using TechTalk.SpecFlow;
using FirstAutotest.Implement;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//namespace FirstAutotest.Features
//{
//    [Binding]
//    public class AutoregistrationSteps
//    {
//        public IWebDriver driver;

//        [BeforeScenario]
//        public void BeforeScenario()
//        {
//            driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/25-virtual-gift-card");
//        }

//        [AfterScenario]
//        public void AfterScenario()
//        {
//            driver.Quit();
//        }

//        [Given(@"Cklik on the button Sigh in")]
//        public void GivenCklikOnTheButtonSighIn()
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.ClikOnBtn();
//        }

//        [Then(@"Fill in the data field")]
//        public void ThenFillInTheDataField(Table table)
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
//        }

//        [Then(@"Cklik on the button sigh in")]
//        public void ThenCklikOnTheButtonSighIn()
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.ClikOnBtnSignIn();
//        }
//    }
//}
