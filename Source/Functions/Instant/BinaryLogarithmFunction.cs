namespace PromQL.Functions.Instant
{
    public class BinaryLogarithmFunction : BaseFunction<NaturalLogarithmFunction>
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