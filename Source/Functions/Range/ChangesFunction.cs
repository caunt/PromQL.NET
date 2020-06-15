namespace PromQL.Functions.Range
{
    public class ChangesFunction : BaseFunction<ChangesFunction>
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