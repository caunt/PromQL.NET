namespace PromQL.Functions.Range
{
    public abstract class BaseOverTimeFunction : BaseFunction<BaseOverTimeFunction>
    {
        internal BaseOverTimeFunction(string aggregation) : base(aggregation + "_over_time")
        {
        }
    }
}