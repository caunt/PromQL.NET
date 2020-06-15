using PromQL.Functions.Range;
using PromQL.Functions.Range.Aggregations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PromQL
{
    public class RangeVector
    {
        private List<IVectorAction> actions;
        private int duration;
        private string source;
        private char unit;

        private RangeVector(string name, int duration, char unit)
        {
            this.source = name;
            this.duration = duration;
            this.unit = unit;

            actions = new List<IVectorAction>();
        }

        public static RangeVector Create(string name, int duration, char unit = 'm')
        {
            return new RangeVector(name, duration, unit);
        }

        public static implicit operator string(RangeVector vector)
        {
            var builder = new StringBuilder(vector.source);
            builder.Append('[');
            builder.Append(vector.duration);
            builder.Append(vector.unit);
            builder.Append(']');

            foreach (var action in vector.actions)
                action.Apply(builder);

            return builder.ToString().ToLower();
        }

        /// <summary>
        /// Returns an empty vector if the range vector passed to it has any elements and a 1-element vector with the value 1 if the range vector passed to it has no elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector AbsentOverTime()
        {
            actions.Add(AbsentOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        [Obsolete("Adding actions directly to query is unsafe, please make use of methods in type of InstantVector.")]
        public InstantVector AddAction(IVectorAction action)
        {
            actions.Add(action);
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The average value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector AverageOverTime()
        {
            actions.Add(AverageOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// For each input time series, returns the number of times its value has changed within the provided time range as an instant vector.
        /// </summary>
        /// <returns></returns>
        public InstantVector Changes()
        {
            actions.Add(ChangesFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The count of all values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector CountOverTime()
        {
            actions.Add(CountOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Calculates the difference between the first and last value of each time series element in a range vector, returning an instant vector with the given deltas and equivalent labels. The delta is extrapolated to cover the full time range as specified in the range vector selector, so that it is possible to get a non-integer result even if the sample values are all integers.
        /// </summary>
        /// <returns></returns>
        public InstantVector Delta()
        {
            actions.Add(DeltaFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Calculates the per-second derivative of the time series in a range vector, using simple linear regression.
        /// </summary>
        /// <returns></returns>
        public InstantVector Derivative()
        {
            actions.Add(DerivativeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Produces a smoothed value for time series based on the range.
        /// The lower the smoothing factor sf, the more importance is given to old data.
        /// The higher the trend factor tf, the more trends in the data is considered. Both sf and tf must be between 0 and 1.
        /// HoltWinters should only be used with gauges.
        /// </summary>
        /// <returns></returns>
        public InstantVector HoltWinters(float sf, float tf)
        {
            actions.Add(HoltWintersFunction.Create(sf, tf));
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Calculates the increase in the time series in the range vector. Breaks in monotonicity (such as counter resets due to target restarts) are automatically adjusted for. The increase is extrapolated to cover the full time range as specified in the range vector selector, so that it is possible to get a non-integer result even if a counter increases only by integer increments.
        /// Increase should only be used with counters. It is syntactic sugar for rate(v) multiplied by the number of seconds under the specified time range window, and should be used primarily for human readability. Use rate in recording rules so that increases are tracked consistently on a per-second basis.
        /// </summary>
        /// <returns></returns>
        public InstantVector Increase()
        {
            actions.Add(IncreaseFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Calculates the difference between the last two samples in the range vector v, returning an instant vector with the given deltas and equivalent labels.
        /// InstantDelta should only be used with gauges.
        /// </summary>
        /// <returns></returns>
        public InstantVector InstantDelta()
        {
            actions.Add(InstantDeltaFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// Calculates the per-second instant rate of increase of the time series in the range vector. This is based on the last two data points. Breaks in monotonicity (such as counter resets due to target restarts) are automatically adjusted for.
        /// InstantRate should only be used when graphing volatile, fast-moving counters. Use rate for alerts and slow-moving counters, as brief changes in the rate can reset the FOR clause and graphs consisting entirely of rare spikes are hard to read.
        /// </summary>
        /// <returns></returns>
        public InstantVector InstantRate()
        {
            actions.Add(InstantRateFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The maximum value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector MaxOverTime()
        {
            actions.Add(MaxOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The minimum value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector MinOverTime()
        {
            actions.Add(MinOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The population standard deviation of the values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector StandardDeviationOverTime()
        {
            actions.Add(StandardDeviationOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The population standard variance of the values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector StandardVarianceOverTime()
        {
            actions.Add(StandardVarianceOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        /// <summary>
        /// The sum of all values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector SumOverTime()
        {
            actions.Add(SumOverTimeFunction.Create());
            return InstantVector.WithName(this);
        }

        public override string ToString()
        {
            return this;
        }

        #region Hide System.Object inherited methods

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param><filterpriority>2</filterpriority>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public Type GetType()
        {
            return base.GetType();
        }

        #endregion Hide System.Object inherited methods
    }
}