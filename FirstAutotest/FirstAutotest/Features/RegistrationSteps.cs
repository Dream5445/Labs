using System;
using TechTalk.SpecFlow;
using FirstAutotest.Implement;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstAutotest.Features
{
    [Binding]
    //public class RegistrationSteps
    //{
    //    public IWebDriver driver;

    //    [BeforeScenario]
    //    public void BeforeScenario()
    //    {
    //        driver = new ChromeDriver();
    //        driver.Manage().Window.Maximize();
    //        driver.Navigate().GoToUrl("http://demowebshop.tricentis.com/25-virtual-gift-card");
    //    }

    //    [AfterScenario]
    //    public void AfterScenario()
    //    {
    //        //driver.Quit();
    //    }

    //    [Given(@"Clik on the button Registration")]
    //    public void GivenClikOnTheButtonRegistration()
    //    {
    //        RegistrationImplement reg = new RegistrationImplement(driver);
    //        reg.clikOnBtn();
    //    }
        
    //    [Then(@"Fill in the data fields")]
    //    public void ThenFillInTheDataFields(Table table)
    //    {
    //        RegistrationImplement reg = new RegistrationImplement(driver);
    //        reg.AutoRegistration("Artem", "Oleynik", "artem.oleynik.2426@gmail.com", "qwerty", "qwerty");
    //    }
        
    //    [Then(@"Click on the Registers")]
    //    public void ThenClickOnTheRegisters()
    //    {
    //        RegistrationImplement reg = new RegistrationImplement(driver);
    //        reg.regisrBtn();
    //    }
    //}
}
