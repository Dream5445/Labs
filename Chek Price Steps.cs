using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task3.Implement;

namespace Task3.Features
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

        [Given(@"Cklik on the button Log in  head site")]
        public void GivenCklikOnTheButtonLogInHeadSite()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter the requireds data in the fields")]
        public void ThenEnterTheRequiredsDataInTheFields()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"Cklik on the button Log in below margins")]
        public void ThenCklikOnTheButtonLogInBelowMargins()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"In the category section, select Computer")]
        public void ThenInTheCategorySectionSelectComputer()
        {
            PriceCheckImplement price = new PriceCheckImplement(driver);
            price.Click();
        }
        
        [Then(@"Click on DeskTops")]
        public void ThenClickOnDeskTops()
        {
            PriceCheckImplement price = new PriceCheckImplement(driver);
            price.ClickOnDeskTop();
        }
        
        [Then(@"Sort PC alphabetically")]
        public void ThenSortPCAlphabetically()
        {
            PriceCheckImplement price = new PriceCheckImplement(driver);
            price.ClikOnComb();
            price.ClikOmAlph();

        }
        
        [Then(@"Click on the first PC")]
        public void ThenClickOnTheFirstPC()
        {
            PriceCheckImplement price = new PriceCheckImplement(driver);
            price.ClikOnPC();
        }
        
        [Then(@"Click on the button Add to compare list")]
        public void ThenClickOnTheButtonAddToCompareList()
        {
            PriceCheckImplement price = new PriceCheckImplement(driver);
            price.ClikOnCompareList();
        }
    }
}
