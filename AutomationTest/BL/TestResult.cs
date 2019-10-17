using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Interfaces;
using OpenQA.Selenium;

namespace AutomationTest.BL
{
    public class TestResult
    {
        public TestResult()
        {
            PageLogics = new List<IPageLogic>();
            TestStartTime = DateTime.Now;
        }
        public List<VisitedPage> PageHtmls { get; set; } = new List<VisitedPage>();
        public List<IPageLogic> PageLogics { get; set; }
        public bool IsSuccess { get; internal set; }//
        public DateTime TestStartTime { get; set; }
        public IWebDriver driver { get; set; }
        public IPageLogic GetCurrentPageLogic => PageLogics.Last();
    }
}
