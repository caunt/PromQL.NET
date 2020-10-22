namespace PromQL.Functions.Instant
{
    internal class NaturalLogarithmFunction : BaseFunction<NaturalLogarithmFunction>
    {
        private NaturalLogarithmFunction() : base("ln")
        {
        }

        public static NaturalLogarithmFunction Create()
        {
            return new NaturalLogarithmFunction();
        }
    }
}