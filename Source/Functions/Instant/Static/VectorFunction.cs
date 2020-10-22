using System.Text;

namespace PromQL.Functions.Instant.Static
{
    internal class VectorFunction : BaseFunction<VectorFunction>
    {
        private float scalar;

        private VectorFunction(float scalar) : base("vector")
        {
            this.scalar = scalar;
        }

        public static VectorFunction Create(float scalar)
        {
            return new VectorFunction(scalar);
        }

        protected override void BeforeApply(StringBuilder source)
        {
            source.Append(scalar);
        }
    }
}