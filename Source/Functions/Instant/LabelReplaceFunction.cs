namespace PromQL.Functions.Instant
{
    public class LabelReplaceFunction : BaseFunction<LabelReplaceFunction>
    {
        private LabelReplaceFunction() : base("label_replace")
        {
        }

        public static LabelReplaceFunction Create(string destinationLabel, string replacement, string sourceLabel, string regex)
        {
            return new LabelReplaceFunction()
                .AddArgument(destinationLabel)
                .AddArgument(replacement)
                .AddArgument(sourceLabel)
                .AddArgument(regex);
        }
    }
}