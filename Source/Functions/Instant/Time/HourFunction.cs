namespace PromQL.Functions.Instant.Time
{
    internal class HourFunction : BaseFunction<AbsentFunction>
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