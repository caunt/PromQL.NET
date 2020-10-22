using System;
using PromQL.Vectors;
using PromQL.Operators.Filters;
using PromQL;

namespace Basic_Usage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // PromQL has two basic types of data on which you can select and aggregate time series data in real time.
            // so you have InstantVector and RangeVector to go, enjoy :)

            // Example #1:
            // Create InstantVector and apply "sum" aggregation operator on it: https://prometheus.io/docs/prometheus/latest/querying/operators/#aggregation-operators
            var query = InstantVector
                .WithString("http_requests_total")
                .Sum();

            Console.WriteLine($"sum http_requests_total:\n\t{query}\n");

            // Example #2:
            // For now were using RangeVector instead of InstantVector, selecting http requests count per instance, and sorting it in descending order
            query = RangeVector
                .WithString("http_requests_total", TimeSpan.FromSeconds(15))
                .SumOverTime()  // Same "sum" aggregation operator as in InstantVector, but applies over time on RangeVector and returns as result InstantVector (!) instead of RangeVector
                .SumWithFilter(
                    LabelFilter.Create()
                        .WithType(LabelFilterType.By)
                        .AddField("instance"))
                .SortDescending();

            Console.WriteLine($"sum http_requests_total of 15 seconds:\n\t{query}");
        }
    }
}