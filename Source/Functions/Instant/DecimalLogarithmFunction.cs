namespace PromQL.Functions.Instant
{
    public class DecimalLogarithmFunction : BaseFunction<DecimalLogarithmFunction>
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