namespace PromQL.Functions.Instant
{
    internal class ClampMinFunction : BaseFunction<ClampMinFunction>
    {
        private ClampMinFunction() : base("clamp_min")
        {
        }

        public static ClampMinFunction Create(float minScalar)
        {
            return new ClampMinFunction()
                .AddArgument(minScalar.ToString());
        }
    }
}