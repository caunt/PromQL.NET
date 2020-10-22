namespace PromQL.Functions.Range.Aggregations
{
    internal class MaxOverTimeFunction : BaseOverTimeFunction
    {
        private MaxOverTimeFunction() : base("max")
        {
        }

        public static MaxOverTimeFunction Create()
        {
            return new MaxOverTimeFunction();
        }
    }
}