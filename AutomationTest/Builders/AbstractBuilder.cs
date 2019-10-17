using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Builders
{
    public abstract class AbstractBuilder<T>
    {
        public T Flow;

        public AbstractBuilder(T flow)
        {
            this.Flow = flow;
        }

        public T End()
        {
            return Flow;
        }
    }
}
