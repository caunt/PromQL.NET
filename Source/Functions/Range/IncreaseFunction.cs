namespace PromQL.Functions.Range
{
    internal class IncreaseFunction : BaseFunction<IncreaseFunction>
    {
        private IncreaseFunction() : base("increase")
        {
        }

        public static IncreaseFunction Create()
        {
            return new IncreaseFunction();
        }
    }
}