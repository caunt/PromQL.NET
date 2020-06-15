namespace PromQL.Functions.Range.Aggregations
{
    public class MaxOverTimeFunction : BaseOverTimeFunction
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