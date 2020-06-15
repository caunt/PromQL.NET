namespace PromQL.Functions.Instant
{
    public class SortDescendingFunction : BaseFunction<SortDescendingFunction>
    {
        private SortDescendingFunction() : base("sort_desc")
        {
        }

        public static SortDescendingFunction Create()
        {
            return new SortDescendingFunction();
        }
    }
}