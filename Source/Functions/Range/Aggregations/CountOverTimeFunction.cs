namespace PromQL.Functions.Range.Aggregations
{
    public class CountOverTimeFunction : BaseOverTimeFunction
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