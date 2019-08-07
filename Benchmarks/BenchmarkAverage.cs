using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarksAverage
    {

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public double IntArrayAverageLinq()
        {
            return Benchmarks.intArray.Average();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayAverageFast()
        {
            return Benchmarks.intArray.AverageF();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayAverageFastSIMD()
        {
            return Benchmarks.intArray.AverageS();
        }


        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public double IntListAverageLinq()
        {
            return Benchmarks.intList.Average();
        }

        [BenchmarkCategory("intList"), Benchmark]
        public double IntListAverageFast()
        {
            return Benchmarks.intList.AverageF();
        }

        //[BenchmarkCategory("intList"), Benchmark]
        //public double IntListAverageFastSIMD()
        //{
        //    return Benchmarks.intList.AverageS();
        //}

    }
}
