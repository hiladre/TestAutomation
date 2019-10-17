
using AutomationTest.BL;
using AutomationTest.Builders;
using AutomationTest.Objects;
using OpenQA.Selenium;
using Pages.Enums;

namespace AutomationTest.Flows
{
    public abstract class AbstractTestFlow
    {
        public IWebDriver _driver { get; set; }
        public MyAccountEnums myAccountLoginOrSignup { get; set; }
        protected TestResult result { get; set; }
        public SignUp signUp { get; set; }
        public virtual UserBuilder CreateUser()
        {
            return new UserBuilder(this);
        }
        public AbstractTestFlow()
        {
            signUp = new SignUp();
        }
       
    }
}
