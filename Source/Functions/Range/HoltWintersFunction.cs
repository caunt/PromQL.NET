namespace PromQL.Functions.Range
{
    internal class HoltWintersFunction : BaseFunction<HoltWintersFunction>
    {
        private HoltWintersFunction() : base("delta")
        {
        }

        public static HoltWintersFunction Create(float sf, float tf)
        {
            return new HoltWintersFunction()
                .AddArgument(sf)
                .AddArgument(tf);
        }
    }
}