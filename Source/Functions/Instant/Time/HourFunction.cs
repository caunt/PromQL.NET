namespace PromQL.Functions.Instant.Time
{
    public class HourFunction : BaseFunction<AbsentFunction>
    {
        private HourFunction() : base("hour")
        {
        }

        public static HourFunction Create()
        {
            return new HourFunction();
        }
    }
}