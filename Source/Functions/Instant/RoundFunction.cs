using System;

namespace PromQL.Functions.Instant
{
    internal class RoundFunction : BaseFunction<RoundFunction>
    {
        private RoundFunction() : base("round")
        {
        }

        public static RoundFunction Create(bool toNearest)
        {
            return new RoundFunction()
                .AddArgument(Convert.ToSingle(toNearest));
        }
    }
}