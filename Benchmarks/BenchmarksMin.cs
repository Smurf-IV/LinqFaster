using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;
using JM.LinqFasterSpan;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarksMin
    {
        private static readonly Func<int, int> MinInts = (x) => x + 1;

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public double IntArrayMinLinq()
        {
            return Benchmarks.intArray.Min();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayMinFast()
        {
            return Benchmarks.intArray.MinF();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArrayMinFastSIMD()
        {
            return Benchmarks.intArray.MinS();
        }

        [BenchmarkCategory("localArray.AsSpan"), Benchmark(Baseline = true)]
        public double IntSpanMinForEach()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            int Min = int.MinValue;
            foreach (int i in asSpan)
            {
                if (Min > i)
                {
                    Min = i;
                }
            }

            return Min;
        }

        [BenchmarkCategory("localArray.AsSpan"), Benchmark]
        public double IntSpanMinFast()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MinF();
        }

        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public double IntListMinLinq()
        {
            return Benchmarks.intList.Min();
        }

        [BenchmarkCategory("intList"), Benchmark]
        public double IntListMinFast()
        {
            return Benchmarks.intList.MinF();
        }

        [BenchmarkCategory("intList.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntAsListReadOnlyMinLinq()
        {
            return Benchmarks.intList.AsReadOnly().Min();
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark]
        public double IntAsListReadOnlyMinFast()
        {
            return Benchmarks.intList.AsReadOnly().MinF();
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntArrayAsReadOnlyMinLinq()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Min();
        }

        [BenchmarkCategory("intArraySelector"), Benchmark]
        public double IntArrayAsReadOnlyMinFast()
        {
            return Array.AsReadOnly(Benchmarks.intArray).MinF();
        }


        [BenchmarkCategory("intArraySelector"), Benchmark(Baseline = true)]
        public double IntArrayMinLinqSelector()
        {
            return Benchmarks.intArray.Min(MinInts);
        }

        [BenchmarkCategory("IntArrayAggregate"), Benchmark]
        public double IntArrayMinFastSelector()
        {
            return Benchmarks.intArray.MinF(MinInts);
        }

        [BenchmarkCategory("localArray.AsSpanSelector"), Benchmark(Baseline = true)]
        public double IntSpanMinForEachSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            int Min = int.MinValue;
            foreach (int i in asSpan)
            {
                int l = MinInts(i);
                if (Min > l)
                {
                    Min = l;
                }
            }

            return Min;
        }

        [BenchmarkCategory("localArray.AsSpanSelector"), Benchmark]
        public double IntSpanMinFastSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MinF(MinInts);
        }

        [BenchmarkCategory("intListSelector"), Benchmark(Baseline = true)]
        public double IntListMinLinqSelector()
        {
            return Benchmarks.intList.Min(MinInts);
        }

        [BenchmarkCategory("intListSelector"), Benchmark]
        public double IntListMinFastSelector()
        {
            return Benchmarks.intList.MinF(MinInts);
        }

        [BenchmarkCategory("intList.AsReadOnlySelector"), Benchmark(Baseline = true)]
        public double IntAsListReadOnlyMinLinqSelector()
        {
            return Benchmarks.intList.AsReadOnly().Min(MinInts);
        }

        [BenchmarkCategory("intList.AsReadOnlySelector"), Benchmark]
        public double IntAsListReadOnlyMinFastSelector()
        {
            return Benchmarks.intList.AsReadOnly().MinF(MinInts);
        }

        [BenchmarkCategory("Array.AsReadOnlySelector"), Benchmark(Baseline = true)]
        public double IntArrayAsReadOnlyMinLinqSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Min(MinInts);
        }

        [BenchmarkCategory("Array.AsReadOnlySelector"), Benchmark]
        public double IntArrayAsReadOnlyMinFastSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).MinF(MinInts);
        }

    }
}
