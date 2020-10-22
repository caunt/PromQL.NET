namespace PromQL.Functions.Range
{
    internal class ChangesFunction : BaseFunction<ChangesFunction>
    {
        private ChangesFunction() : base("changes")
        {
        }

        public static ChangesFunction Create()
        {
            return new ChangesFunction();
        }
    }
}