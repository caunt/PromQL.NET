using PromQL.Operators;
using PromQL.Operators.Filters;
using PromQL.Functions.Instant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PromQL
{
    public class InstantVector
    {
        private List<IVectorAction> actions;
        private string name;

        private InstantVector(string source)
        {
            this.name = source;

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
        public InstantVector ClampMax(int scalar)
        {
            actions.Add(ClampMaxFunction.Create(scalar));
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