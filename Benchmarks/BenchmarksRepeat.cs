﻿using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarksRepeat
    {

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public int[] IntArrayRepeatLinq()
        {
            return Enumerable.Repeat(5, Benchmarks.TEST_SIZE).ToArray();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int[] IntArrayRepeatFast()
        {
            return LinqFaster.RepeatArrayF(5, Benchmarks.TEST_SIZE);
        }


        [BenchmarkCategory("intArray"), Benchmark]
        public int[] IntArrayRepeatFastSIMD()
        {
            return LinqFasterSIMD.RepeatS(5, Benchmarks.TEST_SIZE);
        }

        //[BenchmarkCategory("intArray"), Benchmark]
        //public int[] IntArrayRepeatFastSIMDB()
        //{
        //    return LinqFasterSIMD.RepeatSB(5, Benchmarks.TEST_SIZE);
        //}
    }
}
