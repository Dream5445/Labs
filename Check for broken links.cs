using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task7.Implement;

namespace Task7.Features
{
    [Binding]
    public class Check_for_broken_links
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/25-virtual-gift-card");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }

        [Given(@"Click on Sign in in the header of the site")]
        public void GivenClickOnSignInInTheHeaderOfTheSite()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter data in the fields")]
        public void ThenEnterDataInTheFields()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"click on the Sign in button below the fields")]
        public void ThenClickOnTheSignInButtonBelowTheFields()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"in the footer of the site in the (.*)th column, click on the links YouTube, Twitter, Facebook")]
        public void ThenInTheFooterOfTheSiteInTheThColumnClickOnTheLinksYouTubeTwitterFacebook(int p0)
        {
            WebSyteCheckImplement wev = new WebSyteCheckImplement(driver);
            wev.ClikOnBtn();
            wev.ClikOnBtnsecond();
            wev.ClikOnBtnthird();
        }
    }
}
