namespace PromQL.Functions.Range
{
    public class RateFunction : BaseFunction<RateFunction>
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