using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    internal class BenchmarksRepeat
    {

        [Benchmark(Baseline = true)]
        public int[] IntArrayRepeatLinq()
        {
            return Enumerable.Repeat(5, Benchmarks.TEST_SIZE).ToArray();
        }

        [BenchmarkCategory("IntArrayAggregate"), Benchmark(Baseline = true)]
        public int[] IntArrayRepeatFast()
        {
            return LinqFaster.RepeatArrayF(5, Benchmarks.TEST_SIZE);
        }


        [BenchmarkCategory("IntArrayAggregate"), Benchmark(Baseline = true)]
        public int[] IntArrayRepeatFastSIMD()
        {
            return LinqFasterSIMD.RepeatS(5, Benchmarks.TEST_SIZE);
        }

        //[BenchmarkCategory("IntArrayAggregate"), Benchmark(Baseline = true)]
        //public int[] IntArrayRepeatFastSIMDB()
        //{
        //    return LinqFasterSIMD.RepeatSB(5, Benchmarks.TEST_SIZE);
        //}
    }
}
