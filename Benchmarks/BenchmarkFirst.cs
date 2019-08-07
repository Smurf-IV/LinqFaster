using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarksFirst
    {
        private static readonly Func<int, bool> firstInts = (x) => x > 0;

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public double IntArrayFirstLinqSelector()
        {
            return Benchmarks.intArray.First(firstInts);
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayFirstArrayFindSelector()
        {
            Predicate<int> predicate = new Predicate<int>(firstInts);
            return Array.Find(Benchmarks.intArray, predicate);
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayFirstFastSelector()
        {
            return Benchmarks.intArray.FirstF(firstInts);
        }


        [BenchmarkCategory("localArray.AsSpan"), Benchmark(Baseline = true)]
        public double IntSpanFirstForEachSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            foreach (int i in asSpan)
            {
                if (firstInts(i))
                {
                    return i;
                }
            }

            return 0;
        }

        [BenchmarkCategory("localArray.AsSpan"), Benchmark]
        public double IntSpanFirstFastSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.FirstF(firstInts);
        }

        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public double IntListFirstLinqSelector()
        {
            return Benchmarks.intList.First(firstInts);
        }

        [BenchmarkCategory("intList"), Benchmark]
        public double IntListFirstFastSelector()
        {
            return Benchmarks.intList.FirstF(firstInts);
        }

        [BenchmarkCategory("intList.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntAsListReadOnlyFirstLinqSelector()
        {
            return Benchmarks.intList.AsReadOnly().First(firstInts);
        }

        [BenchmarkCategory("intList.AsReadOnly"), Benchmark]
        public double IntAsListReadOnlyFirstFastSelector()
        {
            return Benchmarks.intList.AsReadOnly().FirstF(firstInts);
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntArrayAsReadOnlyFirstLinqSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).First(firstInts);
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark]
        public double IntArrayAsReadOnlyFirstFastSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).FirstF(firstInts);
        }

    }
}
