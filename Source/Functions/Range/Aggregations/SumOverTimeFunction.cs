namespace PromQL.Functions.Range.Aggregations
{
    internal class SumOverTimeFunction : BaseOverTimeFunction
    {
        private SumOverTimeFunction() : base("sum")
        {
        }

        public static SumOverTimeFunction Create()
        {
            return new SumOverTimeFunction();
        }
    }
}