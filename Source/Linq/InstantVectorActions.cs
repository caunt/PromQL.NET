using PromQL.Functions.Instant;
using PromQL.Functions.Instant.Time;
using PromQL.Operators;
using PromQL.Operators.Filters;

namespace PromQL.Vectors
{
    public partial class InstantVector
    {
        /// <summary>
        /// Returns an empty vector if the vector passed to it has any elements and a 1-element vector with the value 1 if the vector passed to it has no elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Absent()
        {
            return AddAction(AbsentFunction.Create());
        }

        /// <summary>
        /// Returns the input vector with all sample values converted to their absolute value.
        /// </summary>
        public InstantVector Absolute()
        {
            return AddAction(AbsoluteFunction.Create());
        }

        /// <summary>
        /// Calculates the binary logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector BinaryLogarithm()
        {
            return AddAction(BinaryLogarithmFunction.Create());
        }

        /// <summary>
        /// Rounds the sample values of all elements up to the nearest integer.
        /// </summary>
        /// <returns></returns>
        public InstantVector Ceiling()
        {
            return AddAction(CeilFunction.Create());
        }

        /// <summary>
        /// Clamps the sample values of all elements to have an upper limit of max.
        /// </summary>
        /// <returns></returns>
        public InstantVector ClampMax(float scalar)
        {
            return AddAction(ClampMaxFunction.Create(scalar));
        }

        /// <summary>
        /// Clamps the sample values of all elements to have an lower limit of max.
        /// </summary>
        /// <returns></returns>
        public InstantVector ClampMin(float scalar)
        {
            return AddAction(ClampMinFunction.Create(scalar));
        }

        /// <summary>
        /// Returns the day of the month for each of the given times in UTC. Returned values are from 1 to 31.
        /// </summary>
        /// <returns></returns>
        public InstantVector DayOfMonth()
        {
            return AddAction(DayOfMonthFunction.Create());
        }

        /// <summary>
        /// Returns the day of the week for each of the given times in UTC. Returned values are from 0 to 6, where 0 means Sunday etc.
        /// </summary>
        /// <returns></returns>
        public InstantVector DayOfWeek()
        {
            return AddAction(DayOfWeekFunction.Create());
        }

        /// <summary>
        /// Returns number of days in the month for each of the given times in UTC. Returned values are from 28 to 31.
        /// </summary>
        /// <returns></returns>
        public InstantVector DaysInMonth()
        {
            return AddAction(DaysInMonthFunction.Create());
        }

        /// <summary>
        /// Calculates the decimal logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector DecimalLogarithm()
        {
            return AddAction(DecimalLogarithmFunction.Create());
        }

        /// <summary>
        /// Calculates the exponential function for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Exponential()
        {
            return AddAction(ExponentialFunction.Create());
        }

        /// <summary>
        /// Rounds the sample values of all elements down to the nearest integer.
        /// </summary>
        /// <returns></returns>
        public InstantVector Floor()
        {
            return AddAction(FloorFunction.Create());
        }

        /// <summary>
        /// Calculates the φ-quantile (0 ≤ φ ≤ 1) from the buckets b of a histogram. (See histograms and summaries for a detailed explanation of φ-quantiles and the usage of the histogram metric type in general.) The samples in b are the counts of observations in each bucket. Each sample must have a label le where the label value denotes the inclusive upper bound of the bucket. (Samples without such a label are silently ignored.) The histogram metric type automatically provides time series with the _bucket suffix and the appropriate labels.
        /// </summary>
        /// <returns></returns>
        public InstantVector HistogramQuantile(float quantile)
        {
            return AddAction(HistogramQuantileFunction.Create(quantile));
        }

        /// <summary>
        /// Returns the hour of the day for each of the given times in UTC. Returned values are from 0 to 23.
        /// </summary>
        /// <returns></returns>
        public InstantVector Hour()
        {
            return AddAction(HourFunction.Create());
        }

        /// <summary>
        /// Returns the input vector with all sample values converted to their absolute value.
        /// </summary>
        public InstantVector LabelJoin(string destinationLabel, string separator, params string[] sourceLabels)
        {
            var function = LabelJoinFunction
                .Create(destinationLabel)
                .WithSeparator(separator);

            foreach (var label in sourceLabels)
                function.AddLabel(label);

            return AddAction(function);
        }

        /// <summary>
        /// For each timeseries, label_replace(v instant-vector, dst_label string, replacement string, src_label string, regex string) matches the regular expression regex against the label src_label. If it matches, then the timeseries is returned with the label dst_label replaced by the expansion of replacement. $1 is replaced with the first matching subgroup, $2 with the second etc. If the regular expression doesn't match then the timeseries is returned unchanged.
        /// </summary>
        /// <returns></returns>
        public InstantVector LabelReplace(string destinationLabel, string replacement, string sourceLabel, string regex)
        {
            return AddAction(LabelReplaceFunction.Create(destinationLabel, replacement, sourceLabel, regex));
        }

        /// <summary>
        /// Returns the minute of the hour for each of the given times in UTC. Returned values are from 0 to 59.
        /// </summary>
        /// <returns></returns>
        public InstantVector Minute()
        {
            return AddAction(MinuteFunction.Create());
        }

        /// <summary>
        /// Returns the month of the year for each of the given times in UTC. Returned values are from 1 to 12, where 1 means January etc.
        /// </summary>
        /// <returns></returns>
        public InstantVector Month()
        {
            return AddAction(MonthFunction.Create());
        }

        /// <summary>
        /// Calculates the natural logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector NaturalLogarithm()
        {
            return AddAction(NaturalLogarithmFunction.Create());
        }

        /// <summary>
        /// Rounds the sample values of all elements to the nearest integer. Ties are resolved by rounding up. The optional to_nearest argument allows specifying the nearest multiple to which the sample values should be rounded. This multiple may also be a fraction.
        /// </summary>
        /// <returns></returns>
        public InstantVector Round(bool toNearest = true)
        {
            return AddAction(RoundFunction.Create(toNearest));
        }

        /// <summary>
        /// Given a single-element input vector, scalar(v instant-vector) returns the sample value of that single element as a scalar. If the input vector does not have exactly one element, scalar will return NaN.
        /// </summary>
        /// <returns></returns>
        public InstantVector Scalar()
        {
            return AddAction(ScalarFunction.Create());
        }

        /// <summary>
        /// Returns vector elements sorted by their sample values, in ascending order.
        /// </summary>
        /// <returns></returns>
        public InstantVector SortAscending()
        {
            return AddAction(SortAscendingFunction.Create());
        }

        /// <summary>
        /// Returns vector elements sorted by their sample values, in descending order.
        /// </summary>
        /// <returns></returns>
        public InstantVector SortDescending()
        {
            return AddAction(SortDescendingFunction.Create());
        }

        /// <summary>
        /// Calculates the square root of all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Sqrt()
        {
            return AddAction(SqrtFunction.Create());
        }

        /// <summary>
        /// Calculate sum over dimensions
        /// </summary>
        /// <returns></returns>
        public InstantVector Sum()
        {
            return AddAction(SumOperator.Create());
        }

        /// <summary>
        /// Aggregate over all label dimensions or preserve distinct dimensions by including a without or by clause.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public InstantVector SumWithFilter(LabelFilter filter)
        {
            return AddAction(SumOperator.Create().WithFilter(filter));
        }

        /// <summary>
        /// Returns the timestamp of each of the samples of the given vector as the number of seconds since January 1, 1970 UTC.
        /// </summary>
        /// <returns></returns>
        public InstantVector Timestamp()
        {
            return AddAction(TimestampFunction.Create());
        }

        /// <summary>
        /// Returns the year for each of the given times in UTC.
        /// </summary>
        /// <returns></returns>
        public InstantVector Year()
        {
            return AddAction(YearFunction.Create());
        }
    }
}