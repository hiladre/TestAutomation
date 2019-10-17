
using AutomationTest.Asserts;
using AutomationTest.Executeros;
using AutomationTest.Flows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pages;
using Pages.Enums;
namespace Tests
{
    [TestClass]
    public class Test
    {      
        private static AbstractTestFlow flow;
        private Asserts asserts;
        [TestInitialize]
        public void ini()
        {
            asserts= new Asserts();
        }
    
        [TestMethod]
        public void Create5Users()
        {
            for (int i = 0; i < 5; i++)
            {
                flow = new LoginAndSignUpFlow().CreateUser().End();
                flow.myAccountLoginOrSignup = MyAccountEnums.SignUp;
                var testResult = FlowExecutorFactory
                    .GetExecutor<LoginAndSignUpFlow>()
                    .ExecuteFlow(flow);
            }             
        }
        [TestMethod]
        public void RentCar()
        {
            flow = new RentCarFlow();
            var testResult = FlowExecutorFactory
                .GetExecutor<RentCarFlow>()
               .ExecuteFlow(flow);
           asserts.IsCarPageDisplayed(testResult);
        }






    }
}
