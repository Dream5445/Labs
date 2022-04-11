using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task4.Implement;
using Task4.POM;

namespace Task4.Features
{
    [Binding]
    public class CalculatorSteps
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);
            driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Then(@"Click on the Log in button")]
        public void ThenClickOnTheLogInButton()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter information into fields")]
        public void ThenEnterInformationIntoFields()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"Click on the Sign in button below the fields")]
        public void ThenClickOnTheSignInButtonBelowTheFields()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"In the footer of the site, click on the link Contact us")]
        public void ThenInTheFooterOfTheSiteClickOnTheLinkContactUs()
        {
            SendMassegImplement send = new SendMassegImplement(driver);
            send.ClikOnBtn();
        }
        
        [Then(@"Write a message in the Inquiry field")]
        public void ThenWriteAMessageInTheInquiryField()
        {
            SendMessengPOM send = new SendMessengPOM(driver);
            send.Enq();
        }
        
        [Then(@"Click on the Submit button")]
        public void ThenClickOnTheSubmitButton()
        {
            SendMassegImplement send = new SendMassegImplement(driver);
            send.Sumbit();
        }
    }
}
