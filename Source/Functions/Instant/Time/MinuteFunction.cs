namespace PromQL.Functions.Instant.Time
{
    internal class MinuteFunction : BaseFunction<AbsentFunction>
    {
        private MinuteFunction() : base("minute")
        {
        }

        public static MinuteFunction Create()
        {
            return new MinuteFunction();
        }
    }
}