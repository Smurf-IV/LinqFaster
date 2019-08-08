using System;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;

using JM.LinqFaster;
using JM.LinqFasterSpan;
using JM.LinqFaster.SIMD;

namespace Tests
{
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    public class BenchmarkSum
    {
        private static readonly Func<int, int> sumDivide = (x) => x / 2;

        [BenchmarkCategory("byteArray"), Benchmark(Baseline = true)]
        public int ByteArraySumLinq()
        {
            return Benchmarks.byteArray.Aggregate(0, (current, b1) => current + b1);
        }

        [BenchmarkCategory("byteArray"), Benchmark]
        public uint ByteArraySumFast()
        {
            return Benchmarks.byteArray.SumF();
        }


        [BenchmarkCategory("shortArray"), Benchmark(Baseline = true)]
        public int ShortArraySumLinq()
        {
            return Benchmarks.shortArray.Aggregate(0, (current, s1) => current + s1);
        }

        [BenchmarkCategory("shortArray"), Benchmark]
        public int ShortArraySumFast()
        {
            return Benchmarks.shortArray.SumF();
        }


        [BenchmarkCategory("intArray"), Benchmark(Baseline = true)]
        public int IntArraySumLinq()
        {
            return Benchmarks.intArray.Sum();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArraySumFast()
        {
            return Benchmarks.intArray.SumF();
        }

        [BenchmarkCategory("intArray"), Benchmark]
        public int IntArraySumFastSIMD()
        {
            return Benchmarks.intArray.SumS();
        }

        [BenchmarkCategory("intArraySpan"), Benchmark(Baseline = true)]
        public int IntSpanSumFor()
        {
            int val = 0;
            Span<int> span = Benchmarks.intArray.AsSpan();
            for (int index = 0; index < span.Length; index++)
            {
                val += span[index];
            }

            return val;
        }

        [BenchmarkCategory("intArraySpan"), Benchmark]
        public int IntSpanSumFast()
        {
            return Benchmarks.intArray.AsSpan().SumF();
        }

        [BenchmarkCategory("intList"), Benchmark(Baseline = true)]
        public int IntListSumLinq()
        {
            return Benchmarks.intList.Sum();
        }

        [BenchmarkCategory("intList"), Benchmark]
        public int IntListSumFast()
        {
            return Benchmarks.intList.SumF();
        }


        [BenchmarkCategory("IntArrayAggregate"), Benchmark(Baseline = true)]
        public int IntArraySumLinqSelect()
        {
            return Benchmarks.intArray.Sum(sumDivide);
        }

        [BenchmarkCategory("IntArrayAggregate"), Benchmark]
        public int IntArraySumFastSelect()
        {
            return Benchmarks.intArray.SumF(sumDivide);
        }

        [BenchmarkCategory("intArrayAsReadOnly"), Benchmark(Baseline = true)]
        public double IntReadOnlyArraySumWithSelectLinq()
        {
            return Array.AsReadOnly(Benchmarks.intArray).Sum(sumDivide);
        }

        [BenchmarkCategory("intArrayAsReadOnly"), Benchmark]
        public double IntReadOnlyArraySumWithSelectFast()
        {
            return Array.AsReadOnly(Benchmarks.intArray).SumF(sumDivide);
        }

        [BenchmarkCategory("intNullArray"), Benchmark(Baseline = true)]
        public int? IntNullArraySumLinq()
        {
            return Benchmarks.intNullArray.Sum();
        }

        [BenchmarkCategory("intNullArray"), Benchmark]
        public int? IntNullArraySumFast()
        {
            return Benchmarks.intNullArray.SumF();
        }

        [BenchmarkCategory("intNullArraySelect"), Benchmark(Baseline = true)]
        public int IntNullArraySumLinqSelect()
        {
            return Benchmarks.intNullArray.Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("intNullArraySelect"), Benchmark]
        public int IntNullArraySumFastSelect()
        {
            return Benchmarks.intNullArray.SumF(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("floatArray"), Benchmark(Baseline = true)]
        public float FloatArraySumLinq()
        {
            return Benchmarks.floatArray.Sum();
        }

        [BenchmarkCategory("floatArray"), Benchmark]
        public float FloatArraySumFast()
        {
            return Benchmarks.floatArray.SumF();
        }

        [BenchmarkCategory("floatList"), Benchmark(Baseline = true)]
        public float FloatListSumLinq()
        {
            return Benchmarks.floatList.Sum();
        }

        [BenchmarkCategory("floatList"), Benchmark]
        public float FloatListSumFast()
        {
            return Benchmarks.floatList.SumF();
        }

        [BenchmarkCategory("floatArraySelect"), Benchmark(Baseline = true)]
        public float FloatArraySumLinqSelect()
        {
            return Benchmarks.floatArray.Sum(x => x / 2);
        }

        [BenchmarkCategory("floatArraySelect"), Benchmark]
        public float FloatArraySumFastSelect()
        {
            return Benchmarks.floatArray.SumF(x => x / 2);
        }

        [BenchmarkCategory("floatNullArray"), Benchmark(Baseline = true)]
        public float? FloatNullArraySumLinq()
        {
            return Benchmarks.floatNullArray.Sum();
        }

        [BenchmarkCategory("floatNullArray"), Benchmark]
        public float? FloatNullArraySumFast()
        {
            return Benchmarks.floatNullArray.SumF();
        }

        [BenchmarkCategory("floatNullArraySelect"), Benchmark(Baseline = true)]
        public float FloatNullArraySumLinqSelect()
        {
            return Benchmarks.floatNullArray.Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("floatNullArraySelect"), Benchmark]
        public float FloatNullArraySumFastSelect()
        {
            return Benchmarks.floatNullArray.SumF(x => x / 2 ?? 0);
        }


        [BenchmarkCategory("doubleArray"), Benchmark(Baseline = true)]
        public double DoubleArraySumLinq()
        {
            return Benchmarks.doubleArray.Sum();
        }

        [BenchmarkCategory("doubleArray"), Benchmark]
        public double DoubleArraySumFast()
        {
            return Benchmarks.doubleArray.SumF();
        }

        [BenchmarkCategory("doubleList"), Benchmark(Baseline = true)]
        public double DoubleListSumLinq()
        {
            return Benchmarks.doubleList.Sum();
        }

        [BenchmarkCategory("doubleList"), Benchmark]
        public double DoubleListSumFast()
        {
            return Benchmarks.doubleList.SumF();
        }

        [BenchmarkCategory("doubleArraySelect"), Benchmark(Baseline = true)]
        public double DoubleArraySumLinqSelect()
        {
            return Benchmarks.doubleArray.Sum(x => x / 2);
        }

        [BenchmarkCategory("doubleArraySelect"), Benchmark]
        public double DoubleArraySumFastSelect()
        {
            return Benchmarks.doubleArray.SumF(x => x / 2);
        }

        [BenchmarkCategory("doubleNullArray"), Benchmark(Baseline = true)]
        public double? DoubleNullArraySumLinq()
        {
            return Benchmarks.doubleNullArray.Sum();
        }

        [BenchmarkCategory("doubleNullArray"), Benchmark]
        public double? DoubleNullArraySumFast()
        {
            return Benchmarks.doubleNullArray.SumF();
        }

        [BenchmarkCategory("doubleNullArraySelect"), Benchmark(Baseline = true)]
        public double? DoubleNullArraySumLinqSelect()
        {
            return Benchmarks.doubleNullArray.Sum(x => x / 2 ?? 0);
        }

        [BenchmarkCategory("doubleNullArraySelect"), Benchmark]
        public double? DoubleNullArraySumFastSelect()
        {
            return Benchmarks.doubleNullArray.SumF(x => x / 2 ?? 0);
        }
    }
}
