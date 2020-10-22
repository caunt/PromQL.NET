namespace PromQL.Functions.Range
{
    internal class RateFunction : BaseFunction<RateFunction>
    {
        private RateFunction() : base("rate")
        {
        }

        public static RateFunction Create()
        {
            return new RateFunction();
        }
    }
}