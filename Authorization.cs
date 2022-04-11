using System;
using TechTalk.SpecFlow;
using Task_1.Implement;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task_1.Features
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
            driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/25-virtual-gift-card");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"Cklik on the button Sigh in")]
        public void GivenCklikOnTheButtonSighIn()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Fill in the data field")]
        public void ThenFillInTheDataField(Table table)
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"Cklik on the button sigh in")]
        public void ThenCklikOnTheButtonSighIn()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
    }
}
