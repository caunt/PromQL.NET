namespace PromQL.Functions.Range
{
    public class DerivativeFunction : BaseFunction<DerivativeFunction>
    {
        private DerivativeFunction() : base("deriv")
        {
        }

        public static DerivativeFunction Create()
        {
            return new DerivativeFunction();
        }
    }
}