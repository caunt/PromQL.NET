using System.Text;

namespace PromQL
{
    public interface IVectorAction
    {
        void Apply(StringBuilder builder);
    }
}