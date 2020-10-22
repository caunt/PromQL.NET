namespace PromQL.Functions.Range
{
    internal class ResetsFunction : BaseFunction<ResetsFunction>
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