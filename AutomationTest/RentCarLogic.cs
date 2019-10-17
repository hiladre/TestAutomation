using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Interfaces;
using OpenQA.Selenium;
using Pages;

namespace AutomationTest
{
    public class RentCarLogic :IPageLogic
    {
        private RentCarPage rentCarPage;
        protected IWebDriver driver;
        public bool IsCarPage;
        public RentCarLogic (IWebDriver driver)
        {
            this.driver = driver;
            rentCarPage = new RentCarPage(driver);
        }

        public void RentCarFullFlow()
        {
            driver.Navigate().GoToUrl("https://www.phptravels.net/");
            rentCarPage.ClickCarTab();
            rentCarPage.SetPickUpLocation();
            rentCarPage.SetDropDownLocation();
            rentCarPage.SelectPickUpDate();
            rentCarPage.SelectDropOffDate();
            rentCarPage.ClickSearchButton();
            IsCarPage = rentCarPage.IsCarPageDisplayed();
        }
        
        public void TakeSnapshot()
        {
            
        }
    }
}
