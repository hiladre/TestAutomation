using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.BL;
using AutomationTest.Flows;

namespace AutomationTest.Executeros
{
    public class RentCarExecuter: TestExecuter<RentCarFlow>
    {
        private RentCarLogic  rentCarLogic;
        public override TestResult ExecuteFlow(AbstractTestFlow flow)
        {
            Flow = flow as RentCarFlow;
            result = new TestResult();
            var driver = InitPage();
            rentCarLogic = new RentCarLogic (driver);
            RentCarFullFlow();
            PushCurrentPage(rentCarLogic);
            return result;
        }

        public void RentCarFullFlow()
        {
            rentCarLogic.RentCarFullFlow();
        }
       
    }
}
