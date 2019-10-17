using System;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pages.Enums;

namespace Pages
{
    public class LoginPhpTravelPage
    {
        protected readonly IWebDriver driver;
        public  bool Islanguage;
 
        public LoginPhpTravelPage(IWebDriver driver)
        {
            this.driver = driver;    
        }

        public void ClickOnMyAccount(MyAccountEnums myAccount)
        {
            var element = driver.FindElement(By.XPath("//nav[@class='navbar navbar-default']//li[@id='li_myaccount']"));
            element.Click();
            GoToLoginOrSignUp(element, myAccount);


        }
        public void SetFirstName(string firstName)
        {
            
            driver.FindElement(By.XPath("//*[@id='headersignupform']//input[@name='firstname']")).SendKeys(firstName);
        }
        public void SetLastName(string lastName)
        {

            driver.FindElement(By.XPath("//*[@id='headersignupform']//input[@name='lastname']")).SendKeys(lastName);
        }
        public void SetEmail(string email)
        {
            driver.FindElement(By.XPath("//*[@id='headersignupform']//input[@name='email']")).SendKeys(email);
        }
        public void ClickSignUp(string confirmpassword)
        {
            driver.FindElement(By.XPath("//*[@id='headersignupform']//button[@class='signupbtn btn_full btn btn-action btn-block btn-lg']")).Click();
        }
        public void SetPasswordAndConfirmPassword(string password)
        {
          
            driver.FindElement(By.XPath("//*[@id='headersignupform']//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//*[@id='headersignupform']//input[@name='confirmpassword']")).SendKeys(password);

        }

        private void GoToLoginOrSignUp(IWebElement element, MyAccountEnums myAccount)
        {
            var myaccountList = element.FindElements(By.TagName("li"));

            switch (myAccount)
            {
                case MyAccountEnums.Login:
                    myaccountList[0].Click();
                    break;
                case MyAccountEnums.SignUp:
                    myaccountList[1].Click();
                    break;
                default:
                    break;
            }
          
        }
     



    }
}
