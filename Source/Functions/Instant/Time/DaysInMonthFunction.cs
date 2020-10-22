namespace PromQL.Functions.Instant.Time
{
    internal class DaysInMonthFunction : BaseFunction<AbsentFunction>
    {
        private DaysInMonthFunction() : base("days_in_month")
        {
        }

        public static DaysInMonthFunction Create()
        {
            return new DaysInMonthFunction();
        }
    }
}