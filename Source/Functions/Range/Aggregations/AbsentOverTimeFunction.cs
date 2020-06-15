namespace PromQL.Functions.Range.Aggregations
{
    public class AbsentOverTimeFunction : BaseOverTimeFunction
    {
        private AbsentOverTimeFunction() : base("absent")
        {
        }

        public static AbsentOverTimeFunction Create()
        {
            return new AbsentOverTimeFunction();
        }
    }
}