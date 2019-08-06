using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<int, bool> firstInts = (x) => x > 0;

        //[Benchmark]
        //public double IntArrayFirstLinqSelector()
        //{
        //    return intArray.First(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayFirstFastSelector()
        //{
        //    return intArray.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayFirstArrayFindSelector()
        //{
        //    Predicate<int> predicate = new Predicate<int>(firstInts);
        //    return Array.Find(intArray, predicate);
        //}


        //[Benchmark]
        //public double IntSpanFirstForEachSelector()
        //{
        //    int[] localArray = intArray;
        //    Span<int> asSpan = localArray.AsSpan();
        //    foreach (int i in asSpan)
        //    {
        //        if (firstInts(i))
        //        {
        //            return i;
        //        }
        //    }

        //    return 0;
        //}

        //[Benchmark]
        //public double IntSpanFirstFastSelector()
        //{
        //    int[] localArray = intArray;
        //    Span<int> asSpan = localArray.AsSpan();
        //    return asSpan.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntListFirstLinqSelector()
        //{
        //    return intList.First(firstInts);
        //}

        //[Benchmark]
        //public double IntListFirstFastSelector()
        //{
        //    return intList.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyFirstLinqSelector()
        //{
        //    return intList.AsReadOnly().First(firstInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyFirstFastSelector()
        //{
        //    return intList.AsReadOnly().FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyFirstLinqSelector()
        //{
        //    return Array.AsReadOnly(intArray).First(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyFirstFastSelector()
        //{
        //    return Array.AsReadOnly(intArray).FirstF(firstInts);
        //}

    }
}
