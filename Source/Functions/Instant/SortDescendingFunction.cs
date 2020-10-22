namespace PromQL.Functions.Instant
{
    internal class SortDescendingFunction : BaseFunction<SortDescendingFunction>
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