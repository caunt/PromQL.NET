using System;
using System.Text;

namespace PromQL.Vectors
{
    public partial class RangeVector : AbstractVector<RangeVector>
    {
        private TimeSpan range;
        private string source;
        private TimeUnit unit;

        private RangeVector(string source, TimeSpan range, TimeUnit unit)
        {
            this.source = source;
            this.range = range;
            this.unit = unit;
        }

        public static implicit operator string(RangeVector vector)
        {
            var builder = new StringBuilder(vector.source);

            builder.Append('[');
            builder.Append(Convert.ToUInt64(vector.unit switch
            {
                TimeUnit unit when unit == TimeUnit.Milliseconds => vector.range.TotalMilliseconds,
                TimeUnit unit when unit == TimeUnit.Seconds => vector.range.TotalSeconds,
                TimeUnit unit when unit == TimeUnit.Minutes => vector.range.TotalMinutes,
                TimeUnit unit when unit == TimeUnit.Hours => vector.range.TotalHours,
                TimeUnit unit when unit == TimeUnit.Days => vector.range.TotalHours / 24, // assuming a day has always 24h
                TimeUnit unit when unit == TimeUnit.Weeks => vector.range.TotalHours / 24 / 7, // assuming a week has always 7d
                TimeUnit unit when unit == TimeUnit.Years => vector.range.TotalHours / 24 / 7 / 365, // assuming a year has always 365d
                _ => throw new ArgumentException($"Passed TimeUnit ({vector.unit}) invalid.") // https://prometheus.io/docs/prometheus/latest/querying/basics/#range-vector-selectors
            }));
            builder.Append(vector.unit);
            builder.Append(']');

            foreach (var action in vector.GetActions())
                action.Apply(builder);

            return builder.ToString().ToLower();
        }

        public static RangeVector WithString(string source, TimeSpan range)
        {
            return WithString(source, range, TimeUnit.Seconds);
        }

        public static RangeVector WithString(string source, TimeSpan range, TimeUnit unit)
        {
            return new RangeVector(source, range, unit);
        }

        public override string ToString()
        {
            return this;
        }
    }
}