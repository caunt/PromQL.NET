namespace PromQL.Functions.Range
{
    internal class InstantDeltaFunction : BaseFunction<InstantDeltaFunction>
    {
        private InstantDeltaFunction() : base("idelta")
        {
        }

        public static InstantDeltaFunction Create()
        {
            return new InstantDeltaFunction();
        }
    }
}