namespace PromQL.Functions.Range.Aggregations
{
    internal class StandardVarianceOverTimeFunction : BaseOverTimeFunction
    {
        private StandardVarianceOverTimeFunction() : base("stdvar")
        {
        }

        public static StandardVarianceOverTimeFunction Create()
        {
            return new StandardVarianceOverTimeFunction();
        }
    }
}