using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.BL;
using AutomationTest.Flows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AutomationTest.Asserts
{
    public class Asserts
    {
     
        public void IsCarPageDisplayed(TestResult test)
        {
            var isDisplay = test.GetCurrentPageLogic as RentCarLogic ;
            Assert.IsTrue(isDisplay.IsCarPage, "CarPage not display");

        }
    }
}
