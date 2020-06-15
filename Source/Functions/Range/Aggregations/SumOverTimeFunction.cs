namespace PromQL.Functions.Range.Aggregations
{
    public class SumOverTimeFunction : BaseOverTimeFunction
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