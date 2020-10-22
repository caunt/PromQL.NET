namespace PromQL.Functions.Range.Aggregations
{
    internal class AverageOverTimeFunction : BaseOverTimeFunction
    {
        private AverageOverTimeFunction() : base("avg")
        {
        }

        public static AverageOverTimeFunction Create()
        {
            return new AverageOverTimeFunction();
        }
    }
}