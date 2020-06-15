using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL.Functions.Range
{
    public class AbsentOverTimeFunction : BaseOverTimeFunction
    {
        private AbsentOverTimeFunction() : base("absent")
        {
        }

        public static AbsentOverTimeFunction Create()
        {
            return new AbsentOverTimeFunction();
        }
    }
}