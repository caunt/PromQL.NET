namespace PromQL.Functions.Instant.Time
{
    internal class MonthFunction : BaseFunction<AbsentFunction>
    {
        private MonthFunction() : base("month")
        {
        }

        public static MonthFunction Create()
        {
            return new MonthFunction();
        }
    }
}