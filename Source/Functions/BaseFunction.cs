using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL.Functions
{
    public abstract class BaseFunction<T> : IVectorAction where T : BaseFunction<T>
    {
        protected List<string> arguments;
        protected List<string> preArguments;
        private string function;

        internal BaseFunction(string function)
        {
            this.function = function;

            arguments = new List<string>(2);
            preArguments = new List<string>(1);
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

        public T AddPreArgument(float argument)
        {
            return AddPreArgument(Convert.ToString(argument));
        }

        public T AddPreArgument(string argument)
        {
            preArguments.Add('"' + argument + '"');
            return this as T;
        }

        public void Apply(StringBuilder source)
        {
            BeforeApply();

            var offset = function.Length;

            source.Insert(0, function);
            source.Insert(offset++, '(');

            if (preArguments.Count > 0)
            {
                var arguments = string.Join(", ", preArguments);
                source.Insert(offset, arguments);

                offset += arguments.Length;
                source.Insert(offset, ", ");
            }

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