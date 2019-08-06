using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<double, int, double> mulXInts = (acc, x) => acc += x * x;

        //[Benchmark]
        //public double IntArrayAggregateLinq()
        //{
        //    return intArray.Aggregate(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntArrayAggregateFast()
        //{
        //    return intArray.AggregateF(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyArrayAggregateLinq()
        //{
        //    return Array.AsReadOnly(intArray).Aggregate(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyArrayAggregateFast()
        //{
        //    return Array.AsReadOnly(intArray).AggregateF(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntSpanAggregateForEach()
        //{
        //    //return intArray.AsSpan().Aggregate(0.0, mulXInts);
        //    double result = 0.0D;
        //    foreach (var v in intArray.AsSpan())
        //    {
        //        result = mulXInts(result, v);
        //    }
        //    return result;

        //}

        //[Benchmark]
        //public double IntSpanAggregateFast()
        //{
        //    return intArray.AsSpan().AggregateF(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntArrayAggregateLinqSelector()
        //{
        //    return intArray.Aggregate(0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double IntArrayAggregateFastSelector()
        //{
        //    return intArray.AggregateF(0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double IntListAggregateLinq()
        //{
        //    return intList.Aggregate(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntListAggregateFast()
        //{
        //    return intList.AggregateF(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyListAggregateLinq()
        //{
        //    return intList.AsReadOnly().Aggregate(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyListAggregateFast()
        //{
        //    return intList.AsReadOnly().AggregateF(0.0, mulXInts);
        //}
    }
}
