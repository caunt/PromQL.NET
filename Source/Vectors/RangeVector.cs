using System;
using System.ComponentModel;
using System.Text;

namespace PromQL.Vectors
{
    public partial class RangeVector : AbstractVector<RangeVector>
    {
        private int duration;
        private string source;
        private char unit;

        private RangeVector(string source, int duration, char unit)
        {
            this.source = source;
            this.duration = duration;
            this.unit = unit;
        }

        public static implicit operator string(RangeVector vector)
        {
            var builder = new StringBuilder(vector.source);
            builder.Append('[');
            builder.Append(vector.duration);
            builder.Append(vector.unit);
            builder.Append(']');

            foreach (var action in vector.GetActions())
                action.Apply(builder);

            return builder.ToString().ToLower();
        }

        public static RangeVector WithString(string source, int duration, char unit = 'm')
        {
            return new RangeVector(source, duration, unit);
        }

        public override string ToString()
        {
            return this;
        }
    }
}