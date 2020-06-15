using PromQL.Operators.Filters;
using System.Text;

namespace PromQL.Operators
{
    public interface IOperator : IVectorAction
    {
        SumOperator WithFilter(LabelFilter filter);
    }
}