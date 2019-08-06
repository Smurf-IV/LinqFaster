using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<int, int> MaxInts = (x) => x + 1;

        [Benchmark]
        public double IntArrayMaxLinq()
        {
            return intArray.Max();
        }

        [Benchmark]
        public double IntArrayMaxFast()
        {
            return intArray.MaxF();
        }

        [Benchmark]
        public double IntSpanMaxForEach()
        {
            int[] localArray = intArray;
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

        [Benchmark]
        public double IntSpanMaxFast()
        {
            int[] localArray = intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MaxF();
        }

        [Benchmark]
        public double IntListMaxLinq()
        {
            return intList.Max();
        }

        [Benchmark]
        public double IntListMaxFast()
        {
            return intList.MaxF();
        }

        [Benchmark]
        public double IntAsListReadOnlyMaxLinq()
        {
            return intList.AsReadOnly().Max();
        }

        [Benchmark]
        public double IntAsListReadOnlyMaxFast()
        {
            return intList.AsReadOnly().MaxF();
        }

        [Benchmark]
        public double IntArrayAsReadOnlyMaxLinq()
        {
            return Array.AsReadOnly(intArray).Max();
        }

        [Benchmark]
        public double IntArrayAsReadOnlyMaxFast()
        {
            return Array.AsReadOnly(intArray).MaxF();
        }


        [Benchmark]
        public double IntArrayMaxLinqSelector()
        {
            return intArray.Max(MaxInts);
        }

        [Benchmark]
        public double IntArrayMaxFastSelector()
        {
            return intArray.MaxF(MaxInts);
        }

        [Benchmark]
        public double IntSpanMaxForEachSelector()
        {
            int[] localArray = intArray;
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

        [Benchmark]
        public double IntSpanMaxFastSelector()
        {
            int[] localArray = intArray;
            Span<int> asSpan = localArray.AsSpan();
            return asSpan.MaxF(MaxInts);
        }

        [Benchmark]
        public double IntListMaxLinqSelector()
        {
            return intList.Max(MaxInts);
        }

        [Benchmark]
        public double IntListMaxFastSelector()
        {
            return intList.MaxF(MaxInts);
        }

        [Benchmark]
        public double IntAsListReadOnlyMaxLinqSelector()
        {
            return intList.AsReadOnly().Max(MaxInts);
        }

        [Benchmark]
        public double IntAsListReadOnlyMaxFastSelector()
        {
            return intList.AsReadOnly().MaxF(MaxInts);
        }

        [Benchmark]
        public double IntArrayAsReadOnlyMaxLinqSelector()
        {
            return Array.AsReadOnly(intArray).Max(MaxInts);
        }

        [Benchmark]
        public double IntArrayAsReadOnlyMaxFastSelector()
        {
            return Array.AsReadOnly(intArray).MaxF(MaxInts);
        }

    }
}
