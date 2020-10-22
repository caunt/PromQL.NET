using System.Text;

namespace PromQL.Linq
{
    internal interface IVectorAction
    {
        void Apply(StringBuilder builder);
    }
}