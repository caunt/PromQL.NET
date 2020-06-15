namespace PromQL.Functions.Range
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