namespace PromQL.Functions.Instant
{
    internal class AbsoluteFunction : BaseFunction<AbsoluteFunction>
    {
        private AbsoluteFunction() : base("abs")
        {
        }

        public static AbsoluteFunction Create()
        {
            return new AbsoluteFunction();
        }
    }
}