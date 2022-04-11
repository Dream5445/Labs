using System;
using System.Collections.Generic;
using System.Text;
using Task2.POM;
using OpenQA.Selenium;

namespace Task2.Implement
{
    class AddToCartImplement
    {
        IWebDriver _driver;

        public AddToCartImplement(IWebDriver driver)
        {
            _driver = driver;
        }

        public void addContact(string name, string email)
        {
            AddToCartPOM add = new AddToCartPOM(_driver);
            add.Name(name);
            add.Email(email);
        }

        public void Btncard()
        {
            AddToCartPOM add = new AddToCartPOM(_driver);
            add.Btncard();
        }

        public void Button()
        {
            AddToCartPOM add = new AddToCartPOM(_driver);
            add.Button();
        }
    }
}
