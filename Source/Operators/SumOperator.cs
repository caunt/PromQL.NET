using PromQL.Operators.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL.Operators
{
    public class SumOperator : IOperator
    {
        private LabelFilter filter;

        private SumOperator()
        {
        }

        public static SumOperator Create()
        {
            return new SumOperator();
        }

        public void Apply(StringBuilder source)
        {
            var builder = new StringBuilder("sum");

            if (filter != null)
                filter.Apply(builder);

            builder.Append('(');
            source.Insert(0, builder);
            source.Append(')');
        }

        public SumOperator WithFilter(LabelFilter filter)
        {
            this.filter = filter;
            return this;
        }
    }
}