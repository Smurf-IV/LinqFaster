using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<int, int> sumDivide = (x) => x / 2;

        //[Benchmark]
        //public int ByteArraySumLinq()
        //{
        //    return byteArray.Aggregate(0, (current, b1) => current + b1);
        //}

        //[Benchmark]
        //public uint ByteArraySumFast()
        //{
        //    return byteArray.SumF();
        //}


        //[Benchmark]
        //public int ShortArraySumLinq()
        //{
        //    return shortArray.Aggregate(0, (current, s1) => current + s1);
        //}

        //[Benchmark]
        //public int ShortArraySumFast()
        //{
        //    return shortArray.SumF();
        //}


        //[Benchmark]
        //public int IntArraySumLinq()
        //{
        //    return intArray.Sum();
        //}

        //[Benchmark]
        //public int IntArraySumFast()
        //{
        //    return intArray.SumF();
        //}

        //[Benchmark]
        //public int IntSpanSumFor()
        //{
        //    int val = 0;
        //    Span<int> span = intArray.AsSpan();
        //    for (int index = 0; index < span.Length; index++)
        //    {
        //        val += span[index];
        //    }

        //    return val;
        //}

        //[Benchmark]
        //public int IntSpanSumFast()
        //{
        //    return intArray.AsSpan().SumF();
        //}

        //[Benchmark]
        //public int IntIArraySumFast()
        //{
        //    return ((IReadOnlyList<int>)intArray).SumF();
        //}

        //[Benchmark]
        //public int IntListSumLinq()
        //{
        //    return intList.Sum();
        //}

        //[Benchmark]
        //public int IntListSumFast()
        //{
        //    return intList.SumF();
        //}

        //[Benchmark]
        //public int IntIReadOnlyListSumLinq()
        //{
        //    return ((IReadOnlyList<int>)intList).Sum();
        //}

        //[Benchmark]
        //public int IntIReadOnlyListSumFast()
        //{
        //    return ((IReadOnlyList<int>)intList).SumF();
        //}


        //[Benchmark]
        //public int IntArraySumLinqSelect()
        //{
        //    return intArray.Sum(x => x / 2);
        //}

        //[Benchmark]
        //public int IntArraySumFastSelect()
        //{
        //    return intArray.SumF(x => x / 2);
        //}

        //[Benchmark]
        //public double IntReadOnlyArraySumWithSelectLinq()
        //{
        //    return Array.AsReadOnly(intArray).Sum(x => x / 2);
        //}

        //[Benchmark]
        //public double IntReadOnlyArraySumWithSelectFast()
        //{
        //    return Array.AsReadOnly(intArray).SumF(x => x / 2);
        //}

        //[Benchmark]
        //public int IntArraySumFastSIMD()
        //{
        //    return intArray.SumS();
        //}

        //[Benchmark]
        //public int? IntNullArraySumLinq()
        //{
        //    return intNullArray.Sum();
        //}

        //[Benchmark]
        //public int? IntNullArraySumFast()
        //{
        //    return intNullArray.SumF();
        //}

        //[Benchmark]
        //public int IntNullArraySumLinqSelect()
        //{
        //    return intNullArray.Sum(x => x/2 ?? 0);
        //}

        //[Benchmark]
        //public int IntNullArraySumFastSelect()
        //{
        //    return intNullArray.SumF(x => x/2 ?? 0);
        //}

        //[Benchmark]
        //public float FloatArraySumLinq()
        //{
        //    return floatArray.Sum();
        //}

        //[Benchmark]
        //public float FloatArraySumFast()
        //{
        //    return floatArray.SumF();
        //}

        //[Benchmark]
        //public float FloatListSumLinq()
        //{
        //    return floatList.Sum();
        //}

        //[Benchmark]
        //public float FloatListSumFast()
        //{
        //    return floatList.SumF();
        //}

        //[Benchmark]
        //public float FloatArraySumLinqSelect()
        //{
        //    return floatArray.Sum(x => x / 2);
        //}

        //[Benchmark]
        //public float FloatArraySumFastSelect()
        //{
        //    return floatArray.SumF(x => x / 2);
        //}

        //[Benchmark]
        //public float? FloatNullArraySumLinq()
        //{
        //    return floatNullArray.Sum();
        //}

        //[Benchmark]
        //public float? FloatNullArraySumFast()
        //{
        //    return floatNullArray.SumF();
        //}

        //[Benchmark]
        //public float FloatNullArraySumLinqSelect()
        //{
        //    return floatNullArray.Sum(x => x / 2 ?? 0);
        //}

        //[Benchmark]
        //public float FloatNullArraySumFastSelect()
        //{
        //    return floatNullArray.SumF(x => x / 2 ?? 0);
        //}


        //[Benchmark]
        //public double DoubleArraySumLinq()
        //{
        //    return doubleArray.Sum();
        //}

        //[Benchmark]
        //public double DoubleArraySumFast()
        //{
        //    return doubleArray.SumF();
        //}

        //[Benchmark]
        //public double DoubleListSumLinq()
        //{
        //    return doubleList.Sum();
        //}

        //[Benchmark]
        //public double DoubleListSumFast()
        //{
        //    return doubleList.SumF();
        //}

        //[Benchmark]
        //public double DoubleArraySumLinqSelect()
        //{
        //    return doubleArray.Sum(x => x / 2);
        //}

        //[Benchmark]
        //public double DoubleArraySumFastSelect()
        //{
        //    return doubleArray.SumF(x => x / 2);
        //}

        //[Benchmark]
        //public double? DoubleNullArraySumLinq()
        //{
        //    return doubleNullArray.Sum();
        //}

        //[Benchmark]
        //public double? DoubleNullArraySumFast()
        //{
        //    return doubleNullArray.SumF();
        //}

        //[Benchmark]
        //public double? DoubleNullArraySumLinqSelect()
        //{
        //    return doubleNullArray.Sum(x => x / 2 ?? 0);
        //}

        //[Benchmark]
        //public double? DoubleNullArraySumFastSelect()
        //{
        //    return doubleNullArray.SumF(x => x / 2 ?? 0);
        //}
    }
}
