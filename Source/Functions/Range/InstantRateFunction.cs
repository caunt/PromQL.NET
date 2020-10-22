namespace PromQL.Functions.Range
{
    internal class InstantRateFunction : BaseFunction<InstantRateFunction>
    {
        private InstantRateFunction() : base("irate")
        {
        }

        public static InstantRateFunction Create()
        {
            return new InstantRateFunction();
        }
    }
}