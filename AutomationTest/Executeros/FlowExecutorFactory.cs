using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Flows;

namespace AutomationTest.Executeros
{
    public static class FlowExecutorFactory
    {
        public static TestExecuter<T> GetExecutor<T>() where T : AbstractTestFlow
        {
              if (typeof(T) == typeof(RentCarFlow))
                return new RentCarExecuter() as TestExecuter<T>;
            if (typeof(T) == typeof(LoginAndSignUpFlow))
                return new LoginAndSignUpExecuter() as TestExecuter<T>;
            return null;
        }
    }
}
