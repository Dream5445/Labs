using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Task_1.POM;

namespace Task_1.Implement
{
    class RegistrationImplement
    {
        IWebDriver _driver;

        public RegistrationImplement(IWebDriver driver)
        {
            _driver = driver;
        }
        public void AutoRegistration(string firstName, string lastName, string email, string password, string confirmPassword)
        {
            RegistrationPOM registr = new RegistrationPOM(_driver);
            registr.ClikonradioBtn();
            registr.FirstName(firstName);
            registr.LastName(lastName);
            registr.Email(email);
            registr.Password(password);
            registr.confirmPassword(confirmPassword);
            registr.regisrBtn();

        }

        public void clikOnBtn()
        {
            RegistrationPOM reg = new RegistrationPOM(_driver);
            reg.clikOnBtn();
        }

        public void regisrBtn()
        {
            RegistrationPOM reg = new RegistrationPOM(_driver);
            reg.regisrBtn();
        }
    }
}
