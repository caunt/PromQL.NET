using PromQL.Functions.Range;
using PromQL.Functions.Range.Aggregations;

namespace PromQL.Vectors
{
    public partial class RangeVector
    {
        /// <summary>
        /// Returns an empty vector if the range vector passed to it has any elements and a 1-element vector with the value 1 if the range vector passed to it has no elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector AbsentOverTime()
        {
            AddAction(AbsentOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The average value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector AverageOverTime()
        {
            AddAction(AverageOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// For each input time series, returns the number of times its value has changed within the provided time range as an instant vector.
        /// </summary>
        /// <returns></returns>
        public InstantVector Changes()
        {
            AddAction(ChangesFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The count of all values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector CountOverTime()
        {
            AddAction(CountOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the difference between the first and last value of each time series element in a range vector, returning an instant vector with the given deltas and equivalent labels. The delta is extrapolated to cover the full time range as specified in the range vector selector, so that it is possible to get a non-integer result even if the sample values are all integers.
        /// </summary>
        /// <returns></returns>
        public InstantVector Delta()
        {
            AddAction(DeltaFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the per-second derivative of the time series in a range vector, using simple linear regression.
        /// </summary>
        /// <returns></returns>
        public InstantVector Derivative()
        {
            AddAction(DerivativeFunction.Create());
            return InstantVector.WithString(this);
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
            AddAction(HoltWintersFunction.Create(sf, tf));
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the increase in the time series in the range vector. Breaks in monotonicity (such as counter resets due to target restarts) are automatically adjusted for. The increase is extrapolated to cover the full time range as specified in the range vector selector, so that it is possible to get a non-integer result even if a counter increases only by integer increments.
        /// Increase should only be used with counters. It is syntactic sugar for rate(v) multiplied by the number of seconds under the specified time range window, and should be used primarily for human readability. Use rate in recording rules so that increases are tracked consistently on a per-second basis.
        /// </summary>
        /// <returns></returns>
        public InstantVector Increase()
        {
            AddAction(IncreaseFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the difference between the last two samples in the range vector v, returning an instant vector with the given deltas and equivalent labels.
        /// InstantDelta should only be used with gauges.
        /// </summary>
        /// <returns></returns>
        public InstantVector InstantDelta()
        {
            AddAction(InstantDeltaFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the per-second instant rate of increase of the time series in the range vector. This is based on the last two data points. Breaks in monotonicity (such as counter resets due to target restarts) are automatically adjusted for.
        /// InstantRate should only be used when graphing volatile, fast-moving counters. Use rate for alerts and slow-moving counters, as brief changes in the rate can reset the FOR clause and graphs consisting entirely of rare spikes are hard to read.
        /// </summary>
        /// <returns></returns>
        public InstantVector InstantRate()
        {
            AddAction(InstantRateFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The maximum value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector MaxOverTime()
        {
            AddAction(MaxOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The minimum value of all points in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector MinOverTime()
        {
            AddAction(MinOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Predicts the value of time series from now, based on the range vector, using simple linear regression.
        /// PredictLinear should only be used with gauges.
        /// </summary>
        /// <returns></returns>
        public InstantVector PredictLinear(float seconds)
        {
            AddAction(PredictLinearFunction.Create(seconds));
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Calculates the per-second average rate of increase of the time series in the range vector. Breaks in monotonicity (such as counter resets due to target restarts) are automatically adjusted for. Also, the calculation extrapolates to the ends of the time range, allowing for missed scrapes or imperfect alignment of scrape cycles with the range's time period.
        /// Rate should only be used with counters. It is best suited for alerting, and for graphing of slow-moving counters.
        /// </summary>
        /// <returns></returns>
        public InstantVector Rate()
        {
            AddAction(RateFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// Returns the number of counter resets within the provided time range as an instant vector. Any decrease in the value between two consecutive samples is interpreted as a counter reset.
        /// Resets should only be used with counters.
        /// </summary>
        /// <returns></returns>
        public InstantVector Resets()
        {
            AddAction(ResetsFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The population standard deviation of the values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector StandardDeviationOverTime()
        {
            AddAction(StandardDeviationOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The population standard variance of the values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector StandardVarianceOverTime()
        {
            AddAction(StandardVarianceOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }

        /// <summary>
        /// The sum of all values in the specified interval.
        /// </summary>
        /// <returns></returns>
        public InstantVector SumOverTime()
        {
            AddAction(SumOverTimeFunction.Create());
            return InstantVector.WithString(this);
        }
    }
}