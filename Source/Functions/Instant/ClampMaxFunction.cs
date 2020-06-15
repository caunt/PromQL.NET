namespace PromQL.Functions.Instant
{
    public class ClampMaxFunction : BaseFunction<ClampMaxFunction>
    {
        private ClampMaxFunction() : base("clamp_max")
        {
        }

        public static ClampMaxFunction Create(int maxScalar)
        {
            return new ClampMaxFunction()
                .AddArgument(maxScalar.ToString());
        }
    }
}