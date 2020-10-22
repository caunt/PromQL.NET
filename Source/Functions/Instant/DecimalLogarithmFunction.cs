namespace PromQL.Functions.Instant
{
    internal class DecimalLogarithmFunction : BaseFunction<DecimalLogarithmFunction>
    {
        private DecimalLogarithmFunction() : base("log10")
        {
        }

        public static DecimalLogarithmFunction Create()
        {
            return new DecimalLogarithmFunction();
        }
    }
}