using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFaster.Parallel;
using JM.LinqFaster.SIMD;
using JM.LinqFaster.SIMD.Parallel;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkSequenceEqual
    {
        [Benchmark(Baseline = true)]
        public bool IntArraySequenceEqual()
        {
            return Benchmarks.intArray.SequenceEqual(Benchmarks.array2);
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public bool IntArraySequenceEqualF()
        {
            return Benchmarks.intArray.SequenceEqualF(Benchmarks.array2);
        }


        [BenchmarkCategory("intArray"), Benchmark]
        public bool IntArraySequenceEqualP()
        {
            return Benchmarks.intArray.SequenceEqualP(Benchmarks.array2);
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public bool IntArraySequenceEqualS()
        {
            return Benchmarks.intArray.SequenceEqualS(Benchmarks.array2);
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public bool IntArraySequenceEqualSP()
        {
            return Benchmarks.intArray.SequenceEqualSP(Benchmarks.array2);
        }

    }
}
