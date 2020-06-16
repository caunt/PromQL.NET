namespace PromQL.Functions.Instant.Time
{
    public class DayOfMonthFunction : BaseFunction<AbsentFunction>
    {
        private DayOfMonthFunction() : base("day_of_month")
        {
        }

        public static DayOfMonthFunction Create()
        {
            return new DayOfMonthFunction();
        }
    }
}