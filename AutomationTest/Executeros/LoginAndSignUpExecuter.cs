using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.BL;
using AutomationTest.Flows;

namespace AutomationTest.Executeros
{
    public class LoginAndSignUpExecuter : TestExecuter<LoginAndSignUpFlow>
    {
        private LoginLogic loginLogic;
        public override TestResult ExecuteFlow(AbstractTestFlow flow)
        {
            Flow = flow as LoginAndSignUpFlow;
            result = new TestResult();           
            var driver = InitPage();
            loginLogic = new LoginLogic(driver);
            SignUpAndLogin();
            PushCurrentPage(loginLogic);
            return result;
        }

        public void SignUpAndLogin()
        {
            loginLogic.GoToLogin(Flow.myAccountLoginOrSignup,Flow.signUp);
        }
    }
}
