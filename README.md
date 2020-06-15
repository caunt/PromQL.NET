# PromQL.NET

[![NuGet version (PromQL.NET)](https://img.shields.io/nuget/v/PromQL.NET.svg?style=flat-square)](https://www.nuget.org/packages/PromQL.NET/)


**PromQL has two basic types of data on which you can select and aggregate time series data in real time.**

**So were going to talk about instant vector and range vector.**

### Example #1:
Create InstantVector and apply "sum" aggregation operator on it: https://prometheus.io/docs/prometheus/latest/querying/operators/#aggregation-operators
```csharp
var query = InstantVector
    .WithName("http_requests_total")
    .Sum();

Console.WriteLine(query);
// OUTPUT: sum(http_requests_total)
```
### Example #2:
For now were using RangeVector instead of InstantVector, selecting http requests count per instance, and sorting it in descending order:
```csharp
var query = RangeVector
    .Create("http_requests_total", duration: 15, unit: 'm')
    .SumOverTime()      // Same "sum" aggregation operator as in InstantVector, but applies to RangeVector and returns as result InstantVector (!) instead of RangeVector
    .SumWithFilter(     // you shouldn't worry about types verification after applying operators and functions because IntelliSense wont give you wrong hints
        LabelFilter.Create()
            .WithType(LabelFilterType.By)
            .AddField("instance"))
    .SortDescending();

Console.WriteLine(query);
// OUTPUT: sort_desc(sum by (instance) (sum_over_time(http_requests_total[15m])))
```


As you can see in Example #2 PromQL.NET will preserve right hints about accessible methods on your aggregated data.

Our goal is to make everything works as expected, and prevent wrong syntax in generated queries.
