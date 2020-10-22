namespace PromQL.Functions.Range
{
    internal class DeltaFunction : BaseFunction<ChangesFunction>
    {
        private DeltaFunction() : base("delta")
        {
        }

        public static DeltaFunction Create()
        {
            return new DeltaFunction();
        }
    }
}