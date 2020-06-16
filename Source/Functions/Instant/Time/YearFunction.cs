namespace PromQL.Functions.Instant.Time
{
    public class YearFunction : BaseFunction<YearFunction>
    {
        private YearFunction() : base("year")
        {
        }

        public static YearFunction Create()
        {
            return new YearFunction();
        }
    }
}