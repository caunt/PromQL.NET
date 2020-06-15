namespace PromQL.Functions.Range
{
    public class AverageOverTimeFunction : BaseOverTimeFunction
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