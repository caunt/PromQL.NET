namespace PromQL.Functions.Instant
{
    internal class ExponentialFunction : BaseFunction<AbsoluteFunction>
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