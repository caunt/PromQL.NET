namespace PromQL.Functions.Instant.Time
{
    public class MinuteFunction : BaseFunction<AbsentFunction>
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