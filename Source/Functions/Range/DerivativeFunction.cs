namespace PromQL.Functions.Range
{
    internal class DerivativeFunction : BaseFunction<DerivativeFunction>
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