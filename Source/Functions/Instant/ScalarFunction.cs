namespace PromQL.Functions.Instant
{
    public class ScalarFunction : BaseFunction<ScalarFunction>
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