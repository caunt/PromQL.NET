namespace PromQL.Functions.Range.Aggregations
{
    public abstract class BaseOverTimeFunction : BaseFunction<BaseOverTimeFunction>
    {
        internal BaseOverTimeFunction(string aggregation) : base(aggregation + "_over_time")
        {
        }
    }
}