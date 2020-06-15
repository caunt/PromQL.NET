namespace PromQL.Functions.Range
{
    public class IncreaseFunction : BaseFunction<IncreaseFunction>
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