namespace PromQL.Functions.Range
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