namespace PromQL.Functions.Instant
{
    public class CeilFunction : BaseFunction<CeilFunction>
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