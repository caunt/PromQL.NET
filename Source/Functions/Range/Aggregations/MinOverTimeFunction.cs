namespace PromQL.Functions.Range.Aggregations
{
    internal class MinOverTimeFunction : BaseOverTimeFunction
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