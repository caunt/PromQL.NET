namespace PromQL.Functions.Instant
{
    public class SortAscendingFunction : BaseFunction<SortAscendingFunction>
    {
        private SortAscendingFunction() : base("sort")
        {
        }

        public static SortAscendingFunction Create()
        {
            return new SortAscendingFunction();
        }
    }
}