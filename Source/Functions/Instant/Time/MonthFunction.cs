namespace PromQL.Functions.Instant.Time
{
    public class MonthFunction : BaseFunction<AbsentFunction>
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