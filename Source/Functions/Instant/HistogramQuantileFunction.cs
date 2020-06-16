namespace PromQL.Functions.Instant
{
    public class HistogramQuantileFunction : BaseFunction<HistogramQuantileFunction>
    {
        private HistogramQuantileFunction() : base("histogram_quantile")
        {
        }

        public static HistogramQuantileFunction Create(float quantile)
        {
            return new HistogramQuantileFunction()
                .AddPreArgument(quantile);
        }
    }
}