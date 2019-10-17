using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.BL;
using AutomationTest.Flows;
using AutomationTest.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest.Executeros
{
    public abstract class TestExecuter<T> where T :AbstractTestFlow
    {
        protected T Flow { get; set; }

        protected TestResult result { get; set; }
    
        public virtual TestResult ExecuteFlow(AbstractTestFlow flow)
        {
            Flow = (T)flow;
            result = new TestResult();
            var driver = InitPage();
            return result;
        }

        protected virtual IWebDriver InitPage()
        {
            ChromeOptions options = new ChromeOptions();
           
            IWebDriver driver = new ChromeDriver(options);
   
            
            return driver;

        }

        public void PushCurrentPage(IPageLogic step)
        {
            step.TakeSnapshot();
            result.PageLogics.Add(step);
      
        }
    }
}
