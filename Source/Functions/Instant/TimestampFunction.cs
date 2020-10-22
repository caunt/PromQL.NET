namespace PromQL.Functions.Instant
{
    internal class TimestampFunction : BaseFunction<TimestampFunction>
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