namespace PromQL.Functions.Instant
{
    internal class FloorFunction : BaseFunction<FloorFunction>
    {
        private FloorFunction() : base("floor")
        {
        }

        public static FloorFunction Create()
        {
            return new FloorFunction();
        }
    }
}