using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    public partial class Benchmarks
    {

        [Benchmark]
        public int ByteArrayWhereSumLinq()
        {
            return byteArray.Where(x=> x>0).Aggregate(0, (current, b1) => current + b1);
        }

        [Benchmark]
        public uint ByteArrayWhereSumFast()
        {
            return byteArray.WhereSumF(x => x > 0);
        }


        [Benchmark]
        public int ShortArrayWhereSumLinq()
        {
            return shortArray.Where(x => x > 0).Aggregate(0, (current, s1) => current + s1);
        }

        [Benchmark]
        public int ShortArrayWhereSumFast()
        {
            return shortArray.WhereSumF(x => x > 0);
        }


        [Benchmark]
        public int IntArrayWhereSumLinq()
        {
            return intArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int IntArrayWhereSumFast()
        {
            return intArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public int IntSpanWhereSumFor()
        {
            int val = 0;
            Span<int> span = intArray.AsSpan();
            for (int index = 0; index < span.Length; index++)
            {
                if (span[index] > 0)
                {
                    val += span[index];
                }
            }

            return val;
        }

        [Benchmark]
        public int IntSpanWhereSumFast()
        {
            return intArray.AsSpan().WhereSumF(x => x > 0);
        }

        [Benchmark]
        public int IntIArrayWhereSumFast()
        {
            return ((IReadOnlyList<int>)intArray).WhereSumF(x => x > 0);
        }

        [Benchmark]
        public int IntListWhereSumLinq()
        {
            return intList.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int IntListWhereSumFast()
        {
            return intList.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public int IntIReadOnlyListWhereSumLinq()
        {
            return ((IReadOnlyList<int>)intList).Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int IntIReadOnlyListWhereSumFast()
        {
            return ((IReadOnlyList<int>)intList).WhereSumF(x => x > 0);
        }


        [Benchmark]
        public int IntArrayWhereSumLinqSelect()
        {
            return intArray.Where(x => x > 0).Sum(x => x / 2);
        }

        [Benchmark]
        public int IntArrayWhereSumFastSelect()
        {
            return intArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyArraySumWithSelectLinq()
        {
            return Array.AsReadOnly(intArray).Where(x => x > 0).Sum(x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyArraySumWithSelectFast()
        {
            return Array.AsReadOnly(intArray).WhereSumF(x => x > 0, x => x / 2);
        }

        /*
        [Benchmark]
        public int IntArrayWhereSumFastSIMD()
        {
            return intArray.WhereSumS(x => x > 0);
        }
        */
        [Benchmark]
        public int? IntNullArrayWhereSumLinq()
        {
            return intNullArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int? IntNullArrayWhereSumFast()
        {
            return intNullArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public int IntNullArrayWhereSumLinqSelect()
        {
            return intNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [Benchmark]
        public int IntNullArrayWhereSumFastSelect()
        {
            return intNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }

        [Benchmark]
        public float FloatArrayWhereSumLinq()
        {
            return floatArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public float FloatArrayWhereSumFast()
        {
            return floatArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public float FloatListWhereSumLinq()
        {
            return floatList.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public float FloatListWhereSumFast()
        {
            return floatList.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public float FloatArrayWhereSumLinqSelect()
        {
            return floatArray.Where(x => x > 0).Sum( x => x / 2);
        }

        [Benchmark]
        public float FloatArrayWhereSumFastSelect()
        {
            return floatArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [Benchmark]
        public float? FloatNullArrayWhereSumLinq()
        {
            return floatNullArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public float? FloatNullArrayWhereSumFast()
        {
            return floatNullArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public float FloatNullArrayWhereSumLinqSelect()
        {
            return floatNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [Benchmark]
        public float FloatNullArrayWhereSumFastSelect()
        {
            return floatNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }


        [Benchmark]
        public double DoubleArrayWhereSumLinq()
        {
            return doubleArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public double DoubleArrayWhereSumFast()
        {
            return doubleArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public double DoubleListWhereSumLinq()
        {
            return doubleList.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public double DoubleListWhereSumFast()
        {
            return doubleList.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public double DoubleArrayWhereSumLinqSelect()
        {
            return doubleArray.Where(x => x > 0).Sum(x => x / 2);
        }

        [Benchmark]
        public double DoubleArrayWhereSumFastSelect()
        {
            return doubleArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [Benchmark]
        public double? DoubleNullArrayWhereSumLinq()
        {
            return doubleNullArray.Where(x => x > 0).Sum();
        }

        [Benchmark]
        public double? DoubleNullArrayWhereSumFast()
        {
            return doubleNullArray.WhereSumF(x => x > 0);
        }

        [Benchmark]
        public double? DoubleNullArrayWhereSumLinqSelect()
        {
            return doubleNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [Benchmark]
        public double? DoubleNullArrayWhereSumFastSelect()
        {
            return doubleNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }

        [Benchmark]
        public int IntListSumWithSelectLinq()
        {
            return intList.Where(x => x > 0).Sum(x => x / 2);
        }

        [Benchmark]
        public int IntListSumWithSelectFast()
        {
            return intList.WhereSumF(x => x > 0, x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyListSumWithSelectLinq()
        {
            return intList.AsReadOnly().Where(x => x > 0).Sum(x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyListSumWithSelectFast()
        {
            return intList.AsReadOnly().WhereSumF(x => x > 0, x => x / 2);
        }

    }
}
