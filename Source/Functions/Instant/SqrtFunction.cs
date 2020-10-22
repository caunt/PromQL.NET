namespace PromQL.Functions.Instant
{
    internal class SqrtFunction : BaseFunction<SqrtFunction>
    {
        private SqrtFunction() : base("sqrt")
        {
        }

        public static SqrtFunction Create()
        {
            return new SqrtFunction();
        }
    }
}