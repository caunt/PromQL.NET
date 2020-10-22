namespace PromQL.Functions.Instant
{
    internal class BinaryLogarithmFunction : BaseFunction<NaturalLogarithmFunction>
    {
        private BinaryLogarithmFunction() : base("log2")
        {
        }

        public static BinaryLogarithmFunction Create()
        {
            return new BinaryLogarithmFunction();
        }
    }
}