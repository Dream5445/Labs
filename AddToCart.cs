using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Task2.Implement;

namespace Task2.Features
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

        [Given(@"Cklik on the button Log in  head site")]
        public void GivenCklikOnTheButtonLogInHeadSite()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter the requireds data in the fields")]
        public void ThenEnterTheRequiredsDataInTheFields(Table table)
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"Cklik on the button Log in below margins")]
        public void ThenCklikOnTheButtonLogInBelowMargins()
        {
            AuthorizationImplement auto = new AuthorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"Press the button on  first item Add to cart")]
        public void ThenPressTheButtonOnFirstItemAddToCart()
        {
            AddToCartImplement add = new AddToCartImplement(driver);
            add.Btncard();
        }

        [Then(@"fill in empty field")]
        public void ThenFillInEmptyField(Table table)
        {
            AddToCartImplement add = new AddToCartImplement(driver);
            add.addContact("Artem", "artem.oleynik.2126@gmail.com");
        }

        [Then(@"push on button add to cart")]
        public void ThenPushOnButtonAddToCart()
        {
            AddToCartImplement add = new AddToCartImplement(driver);
            add.Button();
        }
    }
}
