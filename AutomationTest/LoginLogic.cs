using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Interfaces;
using AutomationTest.Objects;
using OpenQA.Selenium;
using Pages;
using Pages.Enums;

namespace AutomationTest
{
    public class LoginLogic:IPageLogic
    {
        private LoginPhpTravelPage loginPhpTravelPage;
        protected IWebDriver driver;  
        public LoginLogic(IWebDriver driver)
        {
            this.driver = driver;
            loginPhpTravelPage = new LoginPhpTravelPage(driver);
        }

       
        public void GoToLogin(MyAccountEnums myAccount,SignUp signUpdetails)
        {
            driver.Navigate().GoToUrl("https://www.phptravels.net/");
            loginPhpTravelPage.ClickOnMyAccount(myAccount);
            if (myAccount == MyAccountEnums.SignUp)
            {
                loginPhpTravelPage.SetFirstName(signUpdetails.firstName);
                loginPhpTravelPage.SetLastName(signUpdetails.lastName);
                loginPhpTravelPage.SetEmail(signUpdetails.email);
                loginPhpTravelPage.SetPasswordAndConfirmPassword(signUpdetails.password);
                loginPhpTravelPage.ClickSignUp(signUpdetails.confirmpassword);
            }
        }
        public void TakeSnapshot()
        {
           
        }
    }
}
