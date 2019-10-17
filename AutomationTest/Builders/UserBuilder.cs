using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTest.Flows;

namespace AutomationTest.Builders
{
    public class UserBuilder : AbstractBuilder<AbstractTestFlow>
    {
        public UserBuilder(AbstractTestFlow flow) : base(flow)
        {
            this.Flow = flow;
        }
    }
}
