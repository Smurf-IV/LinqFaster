using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkWhereSum
    {

        [BenchmarkCategory("byteArray"), Benchmark(Baseline = true)]
        public int ByteArrayWhereSumLinq()
        {
            return Benchmarks.byteArray.Where(x => x > 0).Aggregate(0, (current, b1) => current + b1);
        }

        [BenchmarkCategory("byteArray"), Benchmark]
        public uint ByteArrayWhereSumFast()
        {
            return Benchmarks.byteArray.WhereSumF(x => x > 0);
        }


        [BenchmarkCategory("shortArray"), Benchmark(Baseline = true)]
        public int ShortArrayWhereSumLinq()
        {
            return Benchmarks.shortArray.Where(x => x > 0).Aggregate(0, (current, s1) => current + s1);
        }

        [BenchmarkCategory("shortArray"), Benchmark]
        public int ShortArrayWhereSumFast()
        {
            return Benchmarks.shortArray.WhereSumF(x => x > 0);
        }


        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public int IntArrayWhereSumLinq()
        {
            return Benchmarks.intArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArrayWhereSumFast()
        {
            return Benchmarks.intArray.WhereSumF(x => x > 0);
        }

        /*
        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArrayWhereSumFastSIMD()
        {
            return intArray.WhereSumS(x => x > 0);
        }
        */


        [BenchmarkCategory("intArray.AsSpan"), Benchmark(Baseline = true)]
        public int IntSpanWhereSumFor()
        {
            int val = 0;
            Span<int> span = Benchmarks.intArray.AsSpan();
            for (int index = 0; index < span.Length; index++)
            {
                if (span[index] > 0)
                {
                    val += span[index];
                }
            }

            return val;
        }

        [BenchmarkCategory("intArray.AsSpan"), Benchmark]
        public int IntSpanWhereSumFast()
        {
            return Benchmarks.intArray.AsSpan().WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public int IntListWhereSumLinq()
        {
            return Benchmarks.intList.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("intList"), Benchmark]
        public int IntListWhereSumFast()
        {
            return Benchmarks.intList.WhereSumF(x => x > 0);
        }


        [BenchmarkCategory("intArraySelect"), Benchmark(Baseline = true)]
        public int IntArrayWhereSumLinqSelect()
        {
            return Benchmarks.intArray.Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("intArraySelect"), Benchmark]
        public int IntArrayWhereSumFastSelect()
        {
            return Benchmarks.intArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [BenchmarkCategory("Array.AsReadOnlySelect"), Benchmark(Baseline = true)]
        public double IntReadOnlyArraySumWithSelectLinq()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("Array.AsReadOnlySelect"), Benchmark]
        public double IntReadOnlyArraySumWithSelectFast()
        {
            return Array.AsReadOnly(Benchmarks.intArray).WhereSumF(x => x > 0, x => x / 2);
        }


        [BenchmarkCategory("intNullArray"), Benchmark(Baseline = true)]
        public int? IntNullArrayWhereSumLinq()
        {
            return Benchmarks.intNullArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("intNullArray"), Benchmark]
        public int? IntNullArrayWhereSumFast()
        {
            return Benchmarks.intNullArray.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("intNullArraySelect"), Benchmark(Baseline = true)]
        public int IntNullArrayWhereSumLinqSelect()
        {
            return Benchmarks.intNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("intNullArraySelect"), Benchmark]
        public int IntNullArrayWhereSumFastSelect()
        {
            return Benchmarks.intNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }

        [BenchmarkCategory("floatArray"), Benchmark(Baseline = true)]
        public float FloatArrayWhereSumLinq()
        {
            return Benchmarks.floatArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("floatArray"), Benchmark]
        public float FloatArrayWhereSumFast()
        {
            return Benchmarks.floatArray.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("floatList"), Benchmark(Baseline = true)]
        public float FloatListWhereSumLinq()
        {
            return Benchmarks.floatList.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("floatList"), Benchmark]
        public float FloatListWhereSumFast()
        {
            return Benchmarks.floatList.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("floatArraySelect"), Benchmark(Baseline = true)]
        public float FloatArrayWhereSumLinqSelect()
        {
            return Benchmarks.floatArray.Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("floatArraySelect"), Benchmark]
        public float FloatArrayWhereSumFastSelect()
        {
            return Benchmarks.floatArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [BenchmarkCategory("floatNullArray"), Benchmark(Baseline = true)]
        public float? FloatNullArrayWhereSumLinq()
        {
            return Benchmarks.floatNullArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("floatNullArray"), Benchmark]
        public float? FloatNullArrayWhereSumFast()
        {
            return Benchmarks.floatNullArray.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("floatNullArraySelect"), Benchmark(Baseline = true)]
        public float FloatNullArrayWhereSumLinqSelect()
        {
            return Benchmarks.floatNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("floatNullArraySelect"), Benchmark]
        public float FloatNullArrayWhereSumFastSelect()
        {
            return Benchmarks.floatNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }


        [BenchmarkCategory("doubleArray"), Benchmark(Baseline = true)]
        public double DoubleArrayWhereSumLinq()
        {
            return Benchmarks.doubleArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("doubleArray"), Benchmark]
        public double DoubleArrayWhereSumFast()
        {
            return Benchmarks.doubleArray.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("doubleList"), Benchmark(Baseline = true)]
        public double DoubleListWhereSumLinq()
        {
            return Benchmarks.doubleList.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("doubleList"), Benchmark]
        public double DoubleListWhereSumFast()
        {
            return Benchmarks.doubleList.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("doubleArraySelect"), Benchmark(Baseline = true)]
        public double DoubleArrayWhereSumLinqSelect()
        {
            return Benchmarks.doubleArray.Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("doubleArraySelect"), Benchmark]
        public double DoubleArrayWhereSumFastSelect()
        {
            return Benchmarks.doubleArray.WhereSumF(x => x > 0, x => x / 2);
        }

        [BenchmarkCategory("doubleNullArray"), Benchmark(Baseline = true)]
        public double? DoubleNullArrayWhereSumLinq()
        {
            return Benchmarks.doubleNullArray.Where(x => x > 0).Sum();
        }

        [BenchmarkCategory("doubleNullArray"), Benchmark]
        public double? DoubleNullArrayWhereSumFast()
        {
            return Benchmarks.doubleNullArray.WhereSumF(x => x > 0);
        }

        [BenchmarkCategory("doubleNullArraySelect"), Benchmark(Baseline = true)]
        public double? DoubleNullArrayWhereSumLinqSelect()
        {
            return Benchmarks.doubleNullArray.Where(x => x > 0).Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("doubleNullArraySelect"), Benchmark]
        public double? DoubleNullArrayWhereSumFastSelect()
        {
            return Benchmarks.doubleNullArray.WhereSumF(x => x > 0, x => x / 2 ?? 0);
        }

        [BenchmarkCategory("intListSelect"), Benchmark(Baseline = true)]
        public int IntListSumWithSelectLinq()
        {
            return Benchmarks.intList.Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("intListSelect"), Benchmark]
        public int IntListSumWithSelectFast()
        {
            return Benchmarks.intList.WhereSumF(x => x > 0, x => x / 2);
        }

        [BenchmarkCategory("intList.AsReadOnlySelect"), Benchmark(Baseline = true)]
        public double IntReadOnlyListSumWithSelectLinq()
        {
            return Benchmarks.intList.AsReadOnly().Where(x => x > 0).Sum(x => x / 2);
        }

        [BenchmarkCategory("intList.AsReadOnlySelect"), Benchmark]
        public double IntReadOnlyListSumWithSelectFast()
        {
            return Benchmarks.intList.AsReadOnly().WhereSumF(x => x > 0, x => x / 2);
        }

    }
}
