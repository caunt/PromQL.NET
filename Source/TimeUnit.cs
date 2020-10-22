using System;

namespace PromQL
{
    public class TimeUnit : IEquatable<TimeUnit>
    {
        public static readonly TimeUnit Days = "d";
        public static readonly TimeUnit Hours = "h";
        public static readonly TimeUnit Milliseconds = "ms";
        public static readonly TimeUnit Minutes = "m";
        public static readonly TimeUnit Seconds = new TimeUnit("s");
        public static readonly TimeUnit Weeks = "w";
        public static readonly TimeUnit Years = "y";

        private readonly string value;

        private TimeUnit(string value)
        {
            this.value = value;
        }

        public static implicit operator string(TimeUnit unit)
        {
            return unit.value;
        }

        public static implicit operator TimeUnit(string value)
        {
            return new TimeUnit(value);
        }

        public override bool Equals(object obj)
        {
            if (obj is not TimeUnit or null)
                return false;

            return Equals(obj as TimeUnit);
        }

        public bool Equals(TimeUnit unit)
        {
            return string.Equals(this, unit);
        }

        public override int GetHashCode()
        {
            return ((string)this).GetHashCode();
        }

        public override string ToString()
        {
            return this;
        }
    }
}