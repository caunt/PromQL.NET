namespace PromQL.Functions.Instant
{
    public class FloorFunction : BaseFunction<FloorFunction>
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