namespace PromQL.Functions.Range
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