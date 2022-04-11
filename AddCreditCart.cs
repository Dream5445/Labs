using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Task5_6.Implement;

namespace Task5_6.Features
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

        [Given(@"Click on the Sign In button in the header of the site")]
        public void GivenClickOnTheSignInButtonInTheHeaderOfTheSite()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter your details in the field")]
        public void ThenEnterYourDetailsInTheField()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.Autho("artem.oleynik.2126@gmail.com", "qwerty");
        }
        
        [Then(@"Click on the Sign In button below the fields")]
        public void ThenClickOnTheSignInButtonBelowTheFields()
        {
            AutorizationImplement auto = new AutorizationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"in the category choose gift card")]
        public void ThenInTheCategoryChooseGiftCard()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.ClikOnBtn();
        }
        
        [Then(@"Add a card with the name Click on the card with the name \$(.*) Physical Gift Card to the cart")]
        public void ThenAddACardWithTheNameClickOnTheCardWithTheNamePhysicalGiftCardToTheCart(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Enter a name in the Recipient's Name field and click on the Add to card button")]
        public void ThenEnterANameInTheRecipientSNameFieldAndClickOnTheAddToCardButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on category books")]
        public void ThenClickOnCategoryBooks()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"add the first book to the cart")]
        public void ThenAddTheFirstBookToTheCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Select a computer in the category")]
        public void ThenSelectAComputerInTheCategory()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on laptop")]
        public void ThenClickOnLaptop()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on the Add to card button")]
        public void ThenClickOnTheAddToCardButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"In category choose Jewelery")]
        public void ThenInCategoryChooseJewelery()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Adding a product with the name Black & White Diamond Heart to the cart")]
        public void ThenAddingAProductWithTheNameBlackWhiteDiamondHeartToTheCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click in the header of the site on the Shopping cart")]
        public void ThenClickInTheHeaderOfTheSiteOnTheShoppingCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"We put a bird in front of the offer I agree with the terms of service and I adhere to them unconditionally \(read\)")]
        public void ThenWePutABirdInFrontOfTheOfferIAgreeWithTheTermsOfServiceAndIAdhereToThemUnconditionallyRead()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on the button Chekout")]
        public void ThenClickOnTheButtonChekout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"fill in all required fields")]
        public void ThenFillInAllRequiredFields()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Put a tick in front of the offer In-Store Pickup")]
        public void ThenPutATickInFrontOfTheOfferIn_StorePickup()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Click on the Continue button")]
        public void ThenClickOnTheContinueButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Choose a payment method Credit card")]
        public void ThenChooseAPaymentMethodCreditCard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"select a credit card in the combobox")]
        public void ThenSelectACreditCardInTheCombobox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Fill in the fields with data from the credit card")]
        public void ThenFillInTheFieldsWithDataFromTheCreditCard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Removing data from fields")]
        public void ThenRemovingDataFromFields()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
