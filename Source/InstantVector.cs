using PromQL.Operators;
using PromQL.Operators.Filters;
using PromQL.Functions.Instant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PromQL.Functions.Instant.Time;

namespace PromQL
{
    public class InstantVector
    {
        private List<IVectorAction> actions;
        private string name;

        private InstantVector(string source)
        {
            name = source;
            actions = new List<IVectorAction>();
        }

        public static implicit operator string(InstantVector vector)
        {
            var builder = new StringBuilder(vector.name);

            foreach (var action in vector.actions)
                action.Apply(builder);

            return builder.ToString().ToLower();
        }

        public static InstantVector WithName(string name)
        {
            return new InstantVector(name);
        }

        /// <summary>
        /// Returns an empty vector if the vector passed to it has any elements and a 1-element vector with the value 1 if the vector passed to it has no elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Absent()
        {
            actions.Add(AbsentFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns the input vector with all sample values converted to their absolute value.
        /// </summary>
        public InstantVector Absolute()
        {
            actions.Add(AbsoluteFunction.Create());
            return this;
        }

        public InstantVector AddOperator(IOperator @operator)
        {
            actions.Add(@operator);
            return this;
        }

        /// <summary>
        /// Calculates the binary logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector BinaryLogarithm()
        {
            actions.Add(BinaryLogarithmFunction.Create());
            return this;
        }

        /// <summary>
        /// Rounds the sample values of all elements up to the nearest integer.
        /// </summary>
        /// <returns></returns>
        public InstantVector Ceiling()
        {
            actions.Add(CeilFunction.Create());
            return this;
        }

        /// <summary>
        /// Clamps the sample values of all elements to have an upper limit of max.
        /// </summary>
        /// <returns></returns>
        public InstantVector ClampMax(float scalar)
        {
            actions.Add(ClampMaxFunction.Create(scalar));
            return this;
        }

        /// <summary>
        /// Clamps the sample values of all elements to have an lower limit of max.
        /// </summary>
        /// <returns></returns>
        public InstantVector ClampMin(float scalar)
        {
            actions.Add(ClampMinFunction.Create(scalar));
            return this;
        }

        /// <summary>
        /// Returns the day of the month for each of the given times in UTC. Returned values are from 1 to 31.
        /// </summary>
        /// <returns></returns>
        public InstantVector DayOfMonth()
        {
            actions.Add(DayOfMonthFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns the day of the week for each of the given times in UTC. Returned values are from 0 to 6, where 0 means Sunday etc.
        /// </summary>
        /// <returns></returns>
        public InstantVector DayOfWeek()
        {
            actions.Add(DayOfWeekFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns number of days in the month for each of the given times in UTC. Returned values are from 28 to 31.
        /// </summary>
        /// <returns></returns>
        public InstantVector DaysInMonth()
        {
            actions.Add(DaysInMonthFunction.Create());
            return this;
        }

        /// <summary>
        /// Calculates the decimal logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector DecimalLogarithm()
        {
            actions.Add(DecimalLogarithmFunction.Create());
            return this;
        }

        /// <summary>
        /// Calculates the exponential function for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Exponential()
        {
            actions.Add(ExponentialFunction.Create());
            return this;
        }

        /// <summary>
        /// Rounds the sample values of all elements down to the nearest integer.
        /// </summary>
        /// <returns></returns>
        public InstantVector Floor()
        {
            actions.Add(FloorFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns the hour of the day for each of the given times in UTC. Returned values are from 0 to 23.
        /// </summary>
        /// <returns></returns>
        public InstantVector Hour()
        {
            actions.Add(HourFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns the minute of the hour for each of the given times in UTC. Returned values are from 0 to 59.
        /// </summary>
        /// <returns></returns>
        public InstantVector Minute()
        {
            actions.Add(MinuteFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns the month of the year for each of the given times in UTC. Returned values are from 1 to 12, where 1 means January etc.
        /// </summary>
        /// <returns></returns>
        public InstantVector Month()
        {
            actions.Add(MonthFunction.Create());
            return this;
        }

        /// <summary>
        /// Calculates the natural logarithm for all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector NaturalLogarithm()
        {
            actions.Add(NaturalLogarithmFunction.Create());
            return this;
        }

        /// <summary>
        /// Given a single-element input vector, scalar(v instant-vector) returns the sample value of that single element as a scalar. If the input vector does not have exactly one element, scalar will return NaN.
        /// </summary>
        /// <returns></returns>
        public InstantVector Scalar()
        {
            actions.Add(ScalarFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns vector elements sorted by their sample values, in ascending order.
        /// </summary>
        /// <returns></returns>
        public InstantVector SortAscending()
        {
            actions.Add(SortAscendingFunction.Create());
            return this;
        }

        /// <summary>
        /// Returns vector elements sorted by their sample values, in descending order.
        /// </summary>
        /// <returns></returns>
        public InstantVector SortDescending()
        {
            actions.Add(SortDescendingFunction.Create());
            return this;
        }

        /// <summary>
        /// Calculates the square root of all elements.
        /// </summary>
        /// <returns></returns>
        public InstantVector Sqrt()
        {
            actions.Add(SqrtFunction.Create());
            return this;
        }

        /// <summary>
        /// Calculate sum over dimensions
        /// </summary>
        /// <returns></returns>
        public InstantVector Sum()
        {
            actions.Add(SumOperator.Create());
            return this;
        }

        /// <summary>
        /// Aggregate over all label dimensions or preserve distinct dimensions by including a without or by clause.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public InstantVector SumWithFilter(LabelFilter filter)
        {
            actions.Add(SumOperator.Create().WithFilter(filter));
            return this;
        }

        /// <summary>
        /// Returns the timestamp of each of the samples of the given vector as the number of seconds since January 1, 1970 UTC.
        /// </summary>
        /// <returns></returns>
        public InstantVector Timestamp()
        {
            actions.Add(TimestampFunction.Create());
            return this;
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