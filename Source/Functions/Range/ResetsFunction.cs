namespace PromQL.Functions.Range
{
    public class ResetsFunction : BaseFunction<ResetsFunction>
    {
        private ResetsFunction() : base("resets")
        {
        }

        public static ResetsFunction Create()
        {
            return new ResetsFunction();
        }
    }
}