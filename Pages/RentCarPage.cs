using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Pages
{
    public class RentCarPage
    {
        protected readonly IWebDriver driver;
        public bool IsCarPage;
        WebDriverWait wait;
        IWebElement carTab;
        IWebElement pickUpLocationInput;
        IWebElement dropOffLocationInput;
        IWebElement pickUpDate;
        IWebElement dropOffDate;
        public RentCarPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void ClickCarTab()
        {
            carTab = driver.FindElement(By.XPath(".//*[@data-title='cars']"));
            carTab.Click();
        }

        public void SetPickUpLocation()
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='s2id_carlocations']/a/span[1]")))[0].Click();
            pickUpLocationInput = driver.FindElement(By.XPath("//*[@id='select2-drop']/div/input"));
            pickUpLocationInput.SendKeys("Manchester");
            pickUpLocationInput.SendKeys(Keys.Enter);

        }
        public void SetDropDownLocation()
        {
            wait.Until(ExpectedConditions.StalenessOf(driver.FindElement(By.XPath("//*[@id='s2id_carlocations2']/a/span[1]"))));
            driver.FindElement(By.XPath("//*[@id='s2id_carlocations2']/a/span[1]")).Click();
            dropOffLocationInput = driver.FindElement(By.XPath("//*[@id='select2-drop']/div/input"));

            //drop off location
            dropOffLocationInput.SendKeys("Manchester");
            dropOffLocationInput.SendKeys(Keys.Enter);

        }
        public void SelectPickUpDate()
        {
            pickUpDate = driver.FindElement(By.XPath("//*[@id='departcar']"));
            pickUpDate.Clear();
            pickUpDate.SendKeys("20/09/2019");

            // Select "Pick Up Time" dropdown
            SelectElement pickUpTime = new SelectElement(driver.FindElement(By.Name("pickupTime")));

            // Select 06:00
            pickUpTime.SelectByValue("06:00");

        }
        public void SelectDropOffDate()
        {
            dropOffDate = driver.FindElement(By.XPath("//*[@id='returncar']"));

            // Clear field and send date
            dropOffDate.Clear();
            dropOffDate.SendKeys("30/09/2019");

       
            SelectElement dropOffTime = new SelectElement(driver.FindElement(By.Name("dropoffTime")));
 
            dropOffTime.SelectByValue("10:00");

        }
        public void ClickSearchButton()
        {
            var element = driver.FindElement(By.Id("cars"));
            element.FindElement(By.TagName("button")).Click();
        }
       public bool IsCarPageDisplayed()
        {
            IsCarPage = driver.FindElement(By.ClassName("listingbg")).Displayed;
            return IsCarPage;
        }
    }
}
