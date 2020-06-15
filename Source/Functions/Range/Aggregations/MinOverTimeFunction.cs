namespace PromQL.Functions.Range.Aggregations
{
    public class MinOverTimeFunction : BaseOverTimeFunction
    {
        private MinOverTimeFunction() : base("min")
        {
        }

        public static MinOverTimeFunction Create()
        {
            return new MinOverTimeFunction();
        }
    }
}