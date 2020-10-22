namespace PromQL.Functions.Range.Aggregations
{
    internal class CountOverTimeFunction : BaseOverTimeFunction
    {
        private CountOverTimeFunction() : base("count")
        {
        }

        public static CountOverTimeFunction Create()
        {
            return new CountOverTimeFunction();
        }
    }
}