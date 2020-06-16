namespace PromQL.Functions.Instant
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