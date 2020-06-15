namespace PromQL.Functions.Range.Aggregations
{
    public class StandardDeviationOverTimeFunction : BaseOverTimeFunction
    {
        private StandardDeviationOverTimeFunction() : base("stddev")
        {
        }

        public static StandardDeviationOverTimeFunction Create()
        {
            return new StandardDeviationOverTimeFunction();
        }
    }
}