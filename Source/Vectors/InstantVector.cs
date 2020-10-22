using System;
using System.ComponentModel;
using System.Text;
using PromQL.Functions.Instant.Static;

namespace PromQL.Vectors
{
    public partial class InstantVector : AbstractVector<InstantVector>
    {
        private readonly string source;

        private InstantVector(string source)
        {
            this.source = source;
        }

        public static InstantVector Empty()
        {
            return new InstantVector(string.Empty);
        }

        public static implicit operator string(InstantVector vector)
        {
            var builder = new StringBuilder(vector.source);

            foreach (var action in vector.GetActions())
                action.Apply(builder);

            return builder.ToString().ToLower();
        }

        /// <summary>
        /// Returns the scalar as a vector with no labels.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static InstantVector WithScalar(float value)
        {
            return Empty().AddAction(VectorFunction.Create(value));
        }

        /// <summary>
        /// Returns the string as a vector with no labels.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static InstantVector WithString(string source)
        {
            return new InstantVector(source);
        }

        /// <summary>
        /// Returns the number of seconds since January 1, 1970 UTC. Note that this does not actually return the current time, but the time at which the expression is to be evaluated.
        /// </summary>
        /// <returns></returns>
        public static InstantVector WithTime()
        {
            return Empty().AddAction(TimeFunction.Create());
        }

        public override string ToString()
        {
            return this;
        }

        #region Hide System.Object inherited methods

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool Equals(object objA, object objB)
        {
            return object.Equals(objA, objB);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool ReferenceEquals(object objA, object objB)
        {
            return object.ReferenceEquals(objA, objB);
        }

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
        public new Type GetType()
        {
            return base.GetType();
        }

        #endregion Hide System.Object inherited methods
    }
}