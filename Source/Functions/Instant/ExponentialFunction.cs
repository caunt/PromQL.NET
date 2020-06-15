using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL.Functions.Instant
{
    public class ExponentialFunction : BaseFunction<AbsoluteFunction>
    {
        private ExponentialFunction() : base("exp")
        {
        }

        public static ExponentialFunction Create()
        {
            return new ExponentialFunction();
        }
    }
}