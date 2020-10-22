namespace PromQL.Functions.Instant
{
    internal class ScalarFunction : BaseFunction<ScalarFunction>
    {
        private ScalarFunction() : base("scalar")
        {
        }

        public static ScalarFunction Create()
        {
            return new ScalarFunction();
        }
    }
}