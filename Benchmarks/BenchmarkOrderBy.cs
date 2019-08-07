using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkOrderBy
    {
        private static readonly Func<int, int> orderBy = (x) => x - 1;

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public int IntArrayOrderByLinq()
        {
            return Benchmarks.intArray.OrderBy(orderBy).Sum();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArrayOrderByFast()
        {
            return Benchmarks.intArray.OrderByF(orderBy).Sum();
        }
    }
}
