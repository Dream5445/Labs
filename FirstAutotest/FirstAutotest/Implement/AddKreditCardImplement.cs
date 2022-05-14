using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using FirstAutotest.POM;

namespace FirstAutotest.Implement
{
    class AddKreditCardImplement
    {
        IWebDriver _driver;

        public AddKreditCardImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GiftCard()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.clikonBtn();


        }

        public void product()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.product();
        }

        public void Hight()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Hight();
        }

        public void ClikOnBtn()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.btnAddToCartGiftn();
        }

        public void NameGift(string name)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Name(name);
        }

        public void clikonAddcard()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.clikonAddcard();
        }

        public void books()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.books();
        }

        public void computers()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.computers();
        }

        public void laptop()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.laptop();
        }

        public void jewelry()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.jewelry();
        }

        public void A_Z()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.A_Z();
        }

        public void shoppingCard()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.shoppingCard();
        }

        public void Chek()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Chek();
        }

        public void Checkout()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Checkout();
        }

        public void CountryId()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CountryId();
        }

        public void Value()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Value();
        }

        public void city(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.city(text);
        }

        public void address(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.address(text);
        }

        public void ZipPostalCode(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.ZipPostalCode(text);
        }

        public void PhoneNumber(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.PhoneNumber(text);
        }

        public void PickUpInStor()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.PickUpInStor();
        }

        public void BtnpickUp() {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.BtnpickUp();
        }

        public void stepButton()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.stepButton();
        }

        public void paymentmethod()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.paymentmethod();
        }

        public void paymentMethodBTN()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.paymentMethodBTN();
        }

        public void CreditCard()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CreditCard();
        }

        public void CredValue()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CardValue();
        }

        public void CardholderName(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CardholderName(text);
        }

        public void CardNumber(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CardNumber(text);
        }

        public void ExpireMonth()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.ExpireMonth();
        }

        public void ExpireMonthValue()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.ExpireMonthValue();
        }

        public void ExpireYear()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.ExpireYear();
        }

        public void ExpireYearValue()
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.ExpireYearValue();
        }

        public void CardCode(string text)
        {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.CardCode(text);
        }

        public void Clear() {
            AddKreditCardPOM add = new AddKreditCardPOM(_driver);
            add.Clear();
        }
    }
}
