namespace PromQL.Functions.Instant
{
    internal class LabelJoinFunction : BaseFunction<LabelJoinFunction>
    {
        private static string defaultSeparator = ", ";

        private LabelJoinFunction() : base("label_join")
        {
        }

        public static LabelJoinFunction Create(string destinationLabel)
        {
            return new LabelJoinFunction()
                .AddArgument(destinationLabel);
        }

        public LabelJoinFunction AddLabel(string label)
        {
            if (arguments.Count == 1)
                AddArgument(defaultSeparator);

            return AddArgument(label);
        }

        public LabelJoinFunction WithSeparator(string separator)
        {
            if (arguments.Count == 1)
                return AddArgument(separator);

            arguments[1] = separator;
            return this;
        }

        protected override void BeforeApply()
        {
            if (arguments.Count == 1)
                AddArgument(defaultSeparator);
        }
    }
}