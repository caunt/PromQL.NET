namespace PromQL.Functions.Range
{
    public class InstantRateFunction : BaseFunction<InstantRateFunction>
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