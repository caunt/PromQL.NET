using System.Text;

namespace PromQL.Functions.Range
{
    public class SumOverTimeFunction : BaseOverTimeFunction
    {
        private SumOverTimeFunction() : base("sum")
        {
        }

        public static SumOverTimeFunction Create()
        {
            return new SumOverTimeFunction();
        }
    }
}