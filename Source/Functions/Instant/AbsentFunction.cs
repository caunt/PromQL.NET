namespace PromQL.Functions.Instant
{
    internal class AbsentFunction : BaseFunction<AbsentFunction>
    {
        private AbsentFunction() : base("absent")
        {
        }

        public static AbsentFunction Create()
        {
            return new AbsentFunction();
        }
    }
}