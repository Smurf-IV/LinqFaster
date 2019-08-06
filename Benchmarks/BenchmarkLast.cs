using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<int, bool> LastInts = (x) => x > 0;


        //[Benchmark]
        //public double IntArrayLastLinqSelector()
        //{
        //    return intArray.Last(LastInts);
        //}

        //[Benchmark]
        //public double IntArrayLastFastSelector()
        //{
        //    return intArray.LastF(LastInts);
        //}

        //[Benchmark]
        //public double IntArrayLastArrayFindSelector()
        //{
        //    Predicate<int> predicate = new Predicate<int>(LastInts);
        //    return Array.Find(intArray, predicate);
        //}


        //[Benchmark]
        //public double IntSpanLastForEachSelector()
        //{
        //    int[] localArray = intArray;
        //    Span<int> asSpan = localArray.AsSpan();
        //    foreach (int i in asSpan)
        //    {
        //        if (LastInts(i))
        //        {
        //            return i;
        //        }
        //    }

        //    return 0;
        //}

        //[Benchmark]
        //public double IntSpanLastFastSelector()
        //{
        //    int[] localArray = intArray;
        //    Span<int> asSpan = localArray.AsSpan();
        //    return asSpan.LastF(LastInts);
        //}

        //[Benchmark]
        //public double IntListLastLinqSelector()
        //{
        //    return intList.Last(LastInts);
        //}

        //[Benchmark]
        //public double IntListLastFastSelector()
        //{
        //    return intList.LastF(LastInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyLastLinqSelector()
        //{
        //    return intList.AsReadOnly().Last(LastInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyLastFastSelector()
        //{
        //    return intList.AsReadOnly().LastF(LastInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyLastLinqSelector()
        //{
        //    return Array.AsReadOnly(intArray).Last(LastInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyLastFastSelector()
        //{
        //    return Array.AsReadOnly(intArray).LastF(LastInts);
        //}
    }
}
