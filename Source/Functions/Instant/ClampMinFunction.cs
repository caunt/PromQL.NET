namespace PromQL.Functions.Instant
{
    public class ClampMinFunction : BaseFunction<ClampMinFunction>
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