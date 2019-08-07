using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkSelect
    {
        [BenchmarkCategory("intArray.Select"), Benchmark(Baseline = true)]
        public IEnumerable<int> IntArraySelectLinq()
        {
            return Benchmarks.intArray.Select(x => x * x);
        }

        [BenchmarkCategory("intArray.Select"), Benchmark]
        public int[] IntArraySelectFast()
        {
            return Benchmarks.intArray.SelectF(x => x * x);
        }

        [BenchmarkCategory("intArray.Select"), Benchmark]
        public int[] IntArraySelectFastSIMD()
        {
            return Benchmarks.intArray.SelectS(x => x * x, x => x * x);
        }


    }
}
