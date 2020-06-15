namespace PromQL.Functions.Instant
{
    public class TimestampFunction : BaseFunction<TimestampFunction>
    {
        private TimestampFunction() : base("timestamp")
        {
        }

        public static TimestampFunction Create()
        {
            return new TimestampFunction();
        }
    }
}