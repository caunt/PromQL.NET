﻿using System;
using PromQL.Vectors;
using PromQL.Operators.Filters;

namespace Basic_Usage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // PromQL has two basic types of data on which you can select and aggregate time series data in real time.
            // also PromQL has Scalar and String types but here you should not worry about it as PromQL.NET makes it working on its own
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
                .WithString("http_requests_total", duration: 15, unit: 'm')
                .SumOverTime()      // Same "sum" aggregation operator as in InstantVector, but applies to RangeVector and returns as result InstantVector (!) instead of RangeVector
                .SumWithFilter(     // you shouldn't worry about types verification after applying operators and functions because IntelliSense wont give you wrong hints
                    LabelFilter.Create()
                        .WithType(LabelFilterType.By)
                        .AddField("instance"))
                .SortDescending();

            Console.WriteLine($"sum http_requests_total of 15 minutes:\n\t{query}");

            // As you can see in Example #2 PromQL.NET will preserve right hints about accessible methods on your aggregated data
        }
    }
}