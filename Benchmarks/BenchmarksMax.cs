using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFasterSpan;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarksMax
    {
        private static readonly Func<int, int> MaxInts = (x) => x + 1;

        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public double IntArrayMaxLinq()
        {
            return Benchmarks.intArray.Max();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public double IntArrayMaxFast()
        {
            return Benchmarks.intArray.MaxF();
        }

        [BenchmarkCategory("localArray.AsSpan"), Benchmark(Baseline = true)]
        public double IntSpanMaxForEach()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            int max = int.MinValue;
            foreach (int i in asSpan)
            {
                if (max > i)
                {
                    max = i;
                }
            }

            return max;
        }

        [BenchmarkCategory("localArray.AsSpan"), Benchmark]
        public double IntSpanMaxFast()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MaxF();
        }

        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public double IntListMaxLinq()
        {
            return Benchmarks.intList.Max();
        }

        [BenchmarkCategory("intList"), Benchmark]
        public double IntListMaxFast()
        {
            return Benchmarks.intList.MaxF();
        }

        [BenchmarkCategory("intList.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntAsListReadOnlyMaxLinq()
        {
            return Benchmarks.intList.AsReadOnly().Max();
        }

        [BenchmarkCategory("intList.AsReadOnly"), Benchmark]
        public double IntAsListReadOnlyMaxFast()
        {
            return Benchmarks.intList.AsReadOnly().MaxF();
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark(Baseline = true)]
        public double IntArrayAsReadOnlyMaxLinq()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Max();
        }

        [BenchmarkCategory("Array.AsReadOnly"), Benchmark]
        public double IntArrayAsReadOnlyMaxFast()
        {
            return Array.AsReadOnly(Benchmarks.intArray).MaxF();
        }


        [BenchmarkCategory("intArraySelector"), Benchmark(Baseline = true)]
        public double IntArrayMaxLinqSelector()
        {
            return Benchmarks.intArray.Max(MaxInts);
        }

        [BenchmarkCategory("intArraySelector"), Benchmark]
        public double IntArrayMaxFastSelector()
        {
            return Benchmarks.intArray.MaxF(MaxInts);
        }

        [BenchmarkCategory("localArray.AsSpanSelector"), Benchmark(Baseline = true)]
        public double IntSpanMaxForEachSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            int max = int.MinValue;
            foreach (int i in asSpan)
            {
                int l = MaxInts(i);
                if (max > l)
                {
                    max = l;
                }
            }

            return max;
        }

        [BenchmarkCategory("localArray.AsSpanSelector"), Benchmark]
        public double IntSpanMaxFastSelector()
        {
            int[] localArray = Benchmarks.intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MaxF(MaxInts);
        }

        [BenchmarkCategory("intListSelect"), Benchmark(Baseline = true)]
        public double IntListMaxLinqSelector()
        {
            return Benchmarks.intList.Max(MaxInts);
        }

        [BenchmarkCategory("intListSelect"), Benchmark]
        public double IntListMaxFastSelector()
        {
            return Benchmarks.intList.MaxF(MaxInts);
        }

        [BenchmarkCategory("intList.AsReadOnlySelector"), Benchmark(Baseline = true)]
        public double IntAsListReadOnlyMaxLinqSelector()
        {
            return Benchmarks.intList.AsReadOnly().Max(MaxInts);
        }

        [BenchmarkCategory("intList.AsReadOnlySelector"), Benchmark]
        public double IntAsListReadOnlyMaxFastSelector()
        {
            return Benchmarks.intList.AsReadOnly().MaxF(MaxInts);
        }

        [BenchmarkCategory("Array.AsReadOnlySelector"), Benchmark(Baseline = true)]
        public double IntArrayAsReadOnlyMaxLinqSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Max(MaxInts);
        }

        [BenchmarkCategory("Array.AsReadOnlySelector"), Benchmark]
        public double IntArrayAsReadOnlyMaxFastSelector()
        {
            return Array.AsReadOnly(Benchmarks.intArray).MaxF(MaxInts);
        }

    }
}
