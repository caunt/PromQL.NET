using System;
using System.Collections.Generic;
using System.Text;

namespace PromQL
{
    // public class MetricQuery
    // {
    //     private DateTime fromTime;
    //     private string name;
    //     private List<IMetricSelector> selectors;
    //     private char timeAccuracy;
    //
    //     private MetricQuery(string metricName)
    //     {
    //         name = metricName;
    //         fromTime = DateTime.MinValue;
    //         timeAccuracy = 's';
    //         selectors = new List<IMetricSelector>();
    //     }
    //
    //     public static MetricQuery Create(string name)
    //     {
    //         return new MetricQuery(name);
    //     }
    //
    //     public static implicit operator string(MetricQuery metricQuery)
    //     {
    //         var builder = new StringBuilder(metricQuery.name);
    //
    //         if (metricQuery.fromTime != DateTime.MinValue)
    //         {
    //             builder.Append('[');
    //             builder.Append(Math.Ceiling((DateTime.Now - metricQuery.fromTime).TotalSeconds));
    //             builder.Append(metricQuery.timeAccuracy);
    //             builder.Append(']');
    //         }
    //
    //         foreach (var selector in metricQuery.selectors)
    //             selector.Apply(builder);
    //
    //         return builder.ToString();
    //     }
    //
    //     public MetricQuery AsRangeVector(DateTime fromTime)
    //     {
    //         this.fromTime = fromTime;
    //         return this;
    //     }
    //
    //     public override string ToString()
    //     {
    //         return this;
    //     }
    //
    //     public MetricQuery WithSumBy(string field)
    //     {
    //         selectors.Add(new SumBySelector(field));
    //         return this;
    //     }
    //
    //     public MetricQuery WithSumOverTime()
    //     {
    //         selectors.Add(new SumOverTimeSelector());
    //         return this;
    //     }
    //
    //     public MetricQuery WithTimeAccuracy(char suffix = 's')
    //     {
    //         this.timeAccuracy = suffix;
    //         return this;
    //     }
    // }
}