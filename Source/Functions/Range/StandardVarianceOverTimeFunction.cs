namespace PromQL.Functions.Range
{
    public class StandardVarianceOverTimeFunction : BaseOverTimeFunction
    {
        private StandardVarianceOverTimeFunction() : base("stdvar")
        {
        }

        public static StandardVarianceOverTimeFunction Create()
        {
            return new StandardVarianceOverTimeFunction();
        }
    }
}