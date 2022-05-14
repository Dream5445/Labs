using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FirstAutotest.Implement;

//namespace FirstAutotest.Features
//{
//    [Binding]
//    public class CheckLinksSteps
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
//            //driver.Quit();
//        }

//        [Given(@"Click on Sign in in the header of the site")]
//        public void GivenClickOnSignInInTheHeaderOfTheSite()
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.ClikOnBtn();
//        }
        
//        [Then(@"Enter data in the fields")]
//        public void ThenEnterDataInTheFields()
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
//        }
        
//        [Then(@"click on the Sign in button below the fields")]
//        public void ThenClickOnTheSignInButtonBelowTheFields()
//        {
//            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
//            auto.ClikOnBtnSignIn();
//        }
        
//        [Then(@"in the footer of the site in the (.*)th column, click on the links YouTube, Twitter, Facebook")]
//        public void ThenInTheFooterOfTheSiteInTheThColumnClickOnTheLinksYouTubeTwitterFacebook(int p0)
//        {
//            CheckLinksImplement wev = new CheckLinksImplement(driver);
//            wev.ClikOnBtn();
//            wev.ClikOnBtnsecond();
//            wev.ClikOnBtnthird();
//        }
//    }
//}
