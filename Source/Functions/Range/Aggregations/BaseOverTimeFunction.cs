namespace PromQL.Functions.Range.Aggregations
{
    internal abstract class BaseOverTimeFunction : BaseFunction<BaseOverTimeFunction>
    {
        internal BaseOverTimeFunction(string aggregation) : base(aggregation + "_over_time")
        {
        }
    }
}