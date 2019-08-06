using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Tests
{
    public partial class Benchmarks
    {
            private static readonly Func<int, int> MinInts = (x) => x + 1;

        //[Benchmark]
        //public double IntArrayMinLinq()
        //{
        //    return intArray.Min();
        //}

        //    [Benchmark]
        //    public double IntArrayMinFast()
        //    {
        //        return intArray.MinF();
        //    }

        //[Benchmark]
        //public int IntArrayMinFastSIMD()
        //{
        //    return intArray.MinS();
        //}

        //    [Benchmark]
        //    public double IntSpanMinForEach()
        //    {
        //        int[] localArray = intArray;
        //        Span<int> asSpan = localArray.AsSpan();
        //        int Min = int.MinValue;
        //        foreach (int i in asSpan)
        //        {
        //            if (Min > i)
        //            {
        //                Min = i;
        //            }
        //        }

        //        return Min;
        //    }

        //    [Benchmark]
        //    public double IntSpanMinFast()
        //    {
        //        int[] localArray = intArray;
        //        Span<int> asSpan = localArray.AsSpan();
        //        return asSpan.MinF();
        //    }

        //    [Benchmark]
        //    public double IntListMinLinq()
        //    {
        //        return intList.Min();
        //    }

        //    [Benchmark]
        //    public double IntListMinFast()
        //    {
        //        return intList.MinF();
        //    }

        //    [Benchmark]
        //    public double IntAsListReadOnlyMinLinq()
        //    {
        //        return intList.AsReadOnly().Min();
        //    }

        //    [Benchmark]
        //    public double IntAsListReadOnlyMinFast()
        //    {
        //        return intList.AsReadOnly().MinF();
        //    }

        //    [Benchmark]
        //    public double IntArrayAsReadOnlyMinLinq()
        //    {
        //        return Array.AsReadOnly(intArray).Min();
        //    }

        //    [Benchmark]
        //    public double IntArrayAsReadOnlyMinFast()
        //    {
        //        return Array.AsReadOnly(intArray).MinF();
        //    }


        //    [Benchmark]
        //    public double IntArrayMinLinqSelector()
        //    {
        //        return intArray.Min(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntArrayMinFastSelector()
        //    {
        //        return intArray.MinF(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntSpanMinForEachSelector()
        //    {
        //        int[] localArray = intArray;
        //        Span<int> asSpan = localArray.AsSpan();
        //        int Min = int.MinValue;
        //        foreach (int i in asSpan)
        //        {
        //            int l = MinInts(i);
        //            if (Min > l)
        //            {
        //                Min = l;
        //            }
        //        }

        //        return Min;
        //    }

        //    [Benchmark]
        //    public double IntSpanMinFastSelector()
        //    {
        //        int[] localArray = intArray;
        //        Span<int> asSpan = localArray.AsSpan();
        //        return asSpan.MinF(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntListMinLinqSelector()
        //    {
        //        return intList.Min(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntListMinFastSelector()
        //    {
        //        return intList.MinF(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntAsListReadOnlyMinLinqSelector()
        //    {
        //        return intList.AsReadOnly().Min(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntAsListReadOnlyMinFastSelector()
        //    {
        //        return intList.AsReadOnly().MinF(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntArrayAsReadOnlyMinLinqSelector()
        //    {
        //        return Array.AsReadOnly(intArray).Min(MinInts);
        //    }

        //    [Benchmark]
        //    public double IntArrayAsReadOnlyMinFastSelector()
        //    {
        //        return Array.AsReadOnly(intArray).MinF(MinInts);
        //    }

    }
}
