namespace PromQL.Functions.Range.Aggregations
{
    internal class AbsentOverTimeFunction : BaseOverTimeFunction
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