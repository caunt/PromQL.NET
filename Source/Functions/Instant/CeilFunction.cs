namespace PromQL.Functions.Instant
{
    internal class CeilFunction : BaseFunction<CeilFunction>
    {
        private CeilFunction() : base("ceil")
        {
        }

        public static CeilFunction Create()
        {
            return new CeilFunction();
        }
    }
}