namespace PromQL.Functions.Range
{
    public class HoltWintersFunction : BaseFunction<HoltWintersFunction>
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