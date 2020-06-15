using System.Collections.Generic;
using System.Text;

namespace PromQL.Operators.Filters
{
    public enum LabelFilterType
    {
        Without,
        By
    }

    public class LabelFilter
    {
        private HashSet<string> fields;
        private LabelFilterType type;

        private LabelFilter()
        {
            fields = new HashSet<string>();
        }

        public static LabelFilter Create()
        {
            return new LabelFilter();
        }

        public LabelFilter AddField(string field)
        {
            fields.Add(field);
            return this;
        }

        public void Apply(StringBuilder source)
        {
            source.Append(' ');
            source.Append(type);
            source.Append(" (");
            source.Append(string.Join(", ", fields));
            source.Append(") ");
        }

        public LabelFilter WithType(LabelFilterType type)
        {
            this.type = type;
            return this;
        }
    }
}