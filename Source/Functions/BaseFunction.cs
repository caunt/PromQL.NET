using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL.Functions
{
    public abstract class BaseFunction<T> : IVectorAction where T : BaseFunction<T>
    {
        protected List<string> arguments;
        private string function;

        internal BaseFunction(string function)
        {
            this.function = function;

            arguments = new List<string>(2);
        }

        public T AddArgument(float argument)
        {
            return AddArgument(Convert.ToString(argument));
        }

        public T AddArgument(string argument)
        {
            arguments.Add('"' + argument + '"');
            return this as T;
        }

        public void Apply(StringBuilder source)
        {
            BeforeApply();

            source.Insert(0, function);
            source.Insert(function.Length, '(');

            if (arguments.Count > 0)
            {
                source.Append(", ");
                source.Append(string.Join(", ", arguments));
            }

            source.Append(')');
        }

        protected virtual void BeforeApply()
        {
        }
    }
}