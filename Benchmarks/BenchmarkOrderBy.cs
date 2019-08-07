using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    //[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkOrderBy
    {
        private static readonly Func<int, int> orderBy = (x) => x - 1;

        [Benchmark(Baseline = true)]
        public int IntArrayOrderByLinq()
        {
            return Benchmarks.intArray.OrderBy(orderBy).Sum();
        }

        [Benchmark]
        public int IntArrayOrderByFast()
        {
            return Benchmarks.intArray.OrderByF(orderBy).Sum();
        }
    }
}
