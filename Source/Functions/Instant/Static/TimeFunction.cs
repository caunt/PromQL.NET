namespace PromQL.Functions.Instant.Static
{
    public class TimeFunction : BaseFunction<TimeFunction>
    {
        private TimeFunction() : base("time")
        {
        }

        public static TimeFunction Create()
        {
            return new TimeFunction();
        }
    }
}