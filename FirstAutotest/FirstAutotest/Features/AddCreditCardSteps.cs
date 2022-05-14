using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using FirstAutotest.Implement;

namespace FirstAutotest.Features
{
    [Binding]
    public class AddCreditCardSteps
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
        //public void AfterScenario()
        //{
        //    driver.Quit();
        //}

        [Given(@"Click on the Sign In button in the header of the site")]
        public void GivenClickOnTheSignInButtonInTheHeaderOfTheSite()
        {
            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
            auto.ClikOnBtn();
        }
        
        [Then(@"Enter your details in the field")]
        public void ThenEnterYourDetailsInTheField()
        {
            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
            auto.Autho("artem.oleynik.2426@gmail.com", "qwerty");
        }
        
        [Then(@"Click on the Sign In button below the fields")]
        public void ThenClickOnTheSignInButtonBelowTheFields()
        {
            AutorigestrationImplement auto = new AutorigestrationImplement(driver);
            auto.ClikOnBtnSignIn();
        }
        
        [Then(@"in the category choose gift card")]
        public void ThenInTheCategoryChooseGiftCard()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.GiftCard();
        }
        
        [Then(@"Add a card with the name Click on the card with the name \$(.*) Physical Gift Card to the cart")]
        public void ThenAddACardWithTheNameClickOnTheCardWithTheNamePhysicalGiftCardToTheCart(int p0)
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.product();
            add.Hight();
            add.ClikOnBtn();
        }
        
        [Then(@"Enter a name in the Recipient's Name field and click on the Add to card button")]
        public void ThenEnterANameInTheRecipientSNameFieldAndClickOnTheAddToCardButton()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.NameGift("Artem");
        }
        
        [Then(@"click on category books")]
        public void ThenClickOnCategoryBooks()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.clikonAddcard();
        }
        
        [Then(@"add the first book to the cart")]
        public void ThenAddTheFirstBookToTheCart()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.books();
            add.ClikOnBtn();
        }
        
        [Then(@"Select a computer in the category")]
        public void ThenSelectAComputerInTheCategory()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.computers();
        }
        
        [Then(@"Click on laptop")]
        public void ThenClickOnLaptop()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.laptop();
        }
        
        [Then(@"Click on the Add to card button")]
        public void ThenClickOnTheAddToCardButton()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.ClikOnBtn();
        }
        
        [Then(@"In category choose Jewelery")]
        public void ThenInCategoryChooseJewelery()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.jewelry();
            add.product();
            add.A_Z();
        }
        
        [Then(@"Adding a product with the name Black & White Diamond Heart to the cart")]
        public void ThenAddingAProductWithTheNameBlackWhiteDiamondHeartToTheCart()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.ClikOnBtn();
        }
        
        [Then(@"Click in the header of the site on the Shopping cart")]
        public void ThenClickInTheHeaderOfTheSiteOnTheShoppingCart()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.shoppingCard();
        }
        
        [Then(@"We put a bird in front of the offer I agree with the terms of service and I adhere to them unconditionally \(read\)")]
        public void ThenWePutABirdInFrontOfTheOfferIAgreeWithTheTermsOfServiceAndIAdhereToThemUnconditionallyRead()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.Chek();
        }
        
        [Then(@"Click on the button Chekout")]
        public void ThenClickOnTheButtonChekout()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.Checkout();
        }
        
        [Then(@"fill in all required fields")]
        public void ThenFillInAllRequiredFields()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.CountryId();
            add.Value();
            add.city("Kharkiv");
            add.address("Symska street");
            add.ZipPostalCode("123456");
            add.PhoneNumber("+380123456789");
        }
        
        [Then(@"Put a tick in front of the offer In-Store Pickup")]
        public void ThenPutATickInFrontOfTheOfferIn_StorePickup()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.stepButton();
        }
        
        [Then(@"Click on the Continue button")]
        public void ThenClickOnTheContinueButton()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.PickUpInStor();
            add.BtnpickUp();
        }
        
        [Then(@"Choose a payment method Credit card")]
        public void ThenChooseAPaymentMethodCreditCard()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.paymentmethod();
            add.paymentMethodBTN();
        }
        
        [Then(@"select a credit card in the combobox")]
        public void ThenSelectACreditCardInTheCombobox()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.CreditCard();
            add.CredValue();
        }
        
        [Then(@"Fill in the fields with data from the credit card")]
        public void ThenFillInTheFieldsWithDataFromTheCreditCard()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.CardholderName("Artem");
            add.CardNumber("4148 1234 4321 1919");
            add.ExpireMonth();
            add.ExpireMonthValue();
            add.ExpireYear();
            add.ExpireYearValue();
            add.CardCode("123");
        }
        
        [Then(@"Removing data from fields")]
        public void ThenRemovingDataFromFields()
        {
            AddKreditCardImplement add = new AddKreditCardImplement(driver);
            add.Clear();
        }
    }
}
