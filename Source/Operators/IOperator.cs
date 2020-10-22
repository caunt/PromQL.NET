using PromQL.Linq;
using PromQL.Operators.Filters;

namespace PromQL.Operators
{
    internal interface IOperator : IVectorAction
    {
        SumOperator WithFilter(LabelFilter filter);
    }
}