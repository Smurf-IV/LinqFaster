using System;
using System.Collections.Generic;
using System.Linq;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

using JM.LinqFaster;
using JM.LinqFaster.SIMD;

namespace Tests
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private const int LARGE_TEST_SIZE = 1000000;
        private const int SMALL_TEST_SIZE = 100;

        private List<int> list;
        private byte[] byteArray;
        private short[] shortArray;
        private int[] intArray;
        private List<int> intList;
        private int?[] intNullArray;
        private int[] array2;
        private float[] floatArray;
        private List<float> floatList;
        private float?[] floatNullArray;
        private double[] doubleArray;
        private List<double> doubleList;
        private double?[] doubleNullArray;
        private string[] strarray;


        [Params(1000000)]
        public int TEST_SIZE { get; set; }

        public Benchmarks()
        {
        }

        [GlobalSetup]
        public void Setup()
        {
            Random r = new Random();
            byteArray = new byte[TEST_SIZE];
            shortArray = new short[TEST_SIZE];
            intArray = new int[TEST_SIZE];
            intNullArray = new int?[TEST_SIZE];
            intList = new List<int>(TEST_SIZE);
            array2 = new int[TEST_SIZE];
            floatArray = new float[TEST_SIZE];
            floatList = new List<float>(TEST_SIZE);
            floatNullArray = new float?[TEST_SIZE];
            doubleArray = new double[TEST_SIZE];
            doubleList = new List<double>(TEST_SIZE);
            doubleNullArray = new double?[TEST_SIZE];
            list = new List<int>(TEST_SIZE);
            strarray = new string[TEST_SIZE];

            for (int i = 0; i < TEST_SIZE; i++)
            {
                intArray[i] = i % 2;
                byteArray[i] = (byte)intArray[i];
                shortArray[i] = (short)intArray[i];
                intNullArray[i] = intArray[i];
                intList.Add(intArray[i]);
                array2[i] = i % 2;
                list.Add(intArray[i]);
                strarray[i] = intArray[i].ToString();
                floatArray[i] = intArray[i];
                floatList.Add(floatArray[i]);
                floatNullArray[i] = floatArray[i];
                doubleArray[i] = floatArray[i];
                doubleList.Add(doubleArray[i]);
                doubleNullArray[i] = doubleArray[i];
            }
            array2[TEST_SIZE / 2] = 0;
        }

        //[Benchmark]
        //public int IntArrayOrderByLinq()
        //{
        //    return intArray.OrderBy((x => x - 1)).Sum();
        //}

        //[Benchmark]
        //public int IntArrayOrderByFast()
        //{
        //    return intArray.OrderByF((x => x - 1)).Sum();
        //}


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

        [Benchmark]
        public double IntReadOnlyArraySumWithSelectLinq()
        {
            return Array.AsReadOnly(intArray).Sum(x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyArraySumWithSelectFast()
        {
            return Array.AsReadOnly(intArray).SumF(x => x / 2);
        }

        //[Benchmark]
        //public int IntArraySumFastSIMD()
        //{
        //    return intArray.SumS();
        //}

        [Benchmark]
        public int? IntNullArraySumLinq()
        {
            return intNullArray.Sum();
        }

        [Benchmark]
        public int? IntNullArraySumFast()
        {
            return intNullArray.SumF();
        }

        [Benchmark]
        public int IntNullArraySumLinqSelect()
        {
            return intNullArray.Sum(x => x/2 ?? 0);
        }

        [Benchmark]
        public int IntNullArraySumFastSelect()
        {
            return intNullArray.SumF(x => x/2 ?? 0);
        }

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

        [Benchmark]
        public float? FloatNullArraySumLinq()
        {
            return floatNullArray.Sum();
        }

        [Benchmark]
        public float? FloatNullArraySumFast()
        {
            return floatNullArray.SumF();
        }

        [Benchmark]
        public float FloatNullArraySumLinqSelect()
        {
            return floatNullArray.Sum(x => x / 2 ?? 0);
        }

        [Benchmark]
        public float FloatNullArraySumFastSelect()
        {
            return floatNullArray.SumF(x => x / 2 ?? 0);
        }


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

        [Benchmark]
        public double? DoubleNullArraySumLinq()
        {
            return doubleNullArray.Sum();
        }

        [Benchmark]
        public double? DoubleNullArraySumFast()
        {
            return doubleNullArray.SumF();
        }

        [Benchmark]
        public double? DoubleNullArraySumLinqSelect()
        {
            return doubleNullArray.Sum(x => x / 2 ?? 0);
        }

        [Benchmark]
        public double? DoubleNullArraySumFastSelect()
        {
            return doubleNullArray.SumF(x => x / 2 ?? 0);
        }

        [Benchmark]
        public double IntArrayAverageLinq()
        {
            return intArray.Average();
        }

        [Benchmark]
        public double IntArrayAverageFast()
        {
            return intArray.AverageF();
        }

        //[Benchmark]
        //public double IntArrayAverageFastSIMD()
        //{
        //    return intArray.AverageS();
        //}


        [Benchmark]
        public double IntListAverageLinq()
        {
            return intList.Average();
        }

        [Benchmark]
        public double IntListAverageFast()
        {
            return intList.AverageF();
        }

        //[Benchmark]
        //public double IntListAverageFastSIMD()
        //{
        //    return intList.AverageS();
        //}

        [Benchmark]
        public int IntListSumWithSelectLinq()
        {
            return intList.Sum(x => x / 2);
        }

        [Benchmark]
        public int IntListSumWithSelectFast()
        {
            return intList.SumF(x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyListSumWithSelectLinq()
        {
            return intList.AsReadOnly().Sum(x => x / 2);
        }

        [Benchmark]
        public double IntReadOnlyListSumWithSelectFast()
        {
            return intList.AsReadOnly().SumF(x => x / 2);
        }


        //private static readonly Func<double, int, double> mulXInts = (acc, x) => acc += x * x;

        //[Benchmark]
        //public double IntArrayAggregateLinq()
        //{
        //    return intArray.Aggregate(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntArrayAggregateFast()
        //{
        //    return intArray.AggregateF(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyArrayAggregateLinq()
        //{
        //    return Array.AsReadOnly(intArray).Aggregate(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyArrayAggregateFast()
        //{
        //    return Array.AsReadOnly(intArray).AggregateF(0.0D, mulXInts);
        //}

        //[Benchmark]
        //public double IntSpanAggregateForEach()
        //{
        //    //return intArray.AsSpan().Aggregate(0.0, mulXInts);
        //    double result = 0.0D;
        //    foreach (var v in intArray.AsSpan())
        //    {
        //        result = mulXInts(result, v);
        //    }
        //    return result;

        //}

        //[Benchmark]
        //public double IntSpanAggregateFast()
        //{
        //    return intArray.AsSpan().AggregateF(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntArrayAggregateLinqSelector()
        //{
        //    return intArray.Aggregate(0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double IntArrayAggregateFastSelector()
        //{
        //    return intArray.AggregateF(0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double IntListAggregateLinq()
        //{
        //    return intList.Aggregate(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntListAggregateFast()
        //{
        //    return intList.AggregateF(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyListAggregateLinq()
        //{
        //    return intList.AsReadOnly().Aggregate(0.0, mulXInts);
        //}

        //[Benchmark]
        //public double IntReadOnlyListAggregateFast()
        //{
        //    return intList.AsReadOnly().AggregateF(0.0, mulXInts);
        //}

        //private static readonly Func<int, bool> firstInts = (x) => x > 0;

        //[Benchmark]
        //public double IntArrayFirstLinq()
        //{
        //    return intArray.First(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayFirstFast()
        //{
        //    return intArray.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayFirstFast1()
        //{
        //    Predicate<int> predicate = new Predicate<int>(firstInts);
        //    return Array.Find(intArray, predicate);
        //}


        //[Benchmark]
        //public double IntSpanFirstForEach()
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
        //public double IntSpanFirstFast()
        //{
        //    int[] localArray = intArray;
        //    Span<int> asSpan = localArray.AsSpan();
        //    return asSpan.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntListFirstLinq()
        //{
        //    return intList.First(firstInts);
        //}

        //[Benchmark]
        //public double IntListFirstFast()
        //{
        //    return intList.FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyFirstLinq()
        //{
        //    return intList.AsReadOnly().First(firstInts);
        //}

        //[Benchmark]
        //public double IntAsListReadOnlyFirstFast()
        //{
        //    return intList.AsReadOnly().FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyFirstLinq()
        //{
        //    return Array.AsReadOnly(intArray).First(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayAsReadOnlyFirstFast()
        //{
        //    return Array.AsReadOnly(intArray).FirstF(firstInts);
        //}

        //[Benchmark]
        //public double IntArrayWhereAggregateLinq()
        //{
        //    return intArray.Where(x => x % 2 == 0).Aggregate(0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double IntArrayWhereAggregateFast()
        //{
        //    return intArray.WhereAggregateF(x => x % 2 == 0, 0.0, mulXInts, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public int[] IntArraySelectLinq()
        //{
        //    return intArray.Select(x => x * x);
        //}

        //[Benchmark]
        //public int[] IntArraySelectFast()
        //{
        //    return intArray.SelectF(x => x * x);
        //}

        //[Benchmark]
        //public int[] IntArraySelectFastSIMD()
        //{
        //    return intArray.SelectS(x => x * x, x => x * x);
        //}



        //[Benchmark]
        //public int[] IntArrayRepeatLinq()
        //{
        //    return Enumerable.Repeat(5, TEST_SIZE).ToArray();
        //}

        //[Benchmark]
        //public int[] IntArrayRepeatFast()
        //{
        //    return LinqFaster.RepeatArrayF(5, TEST_SIZE);
        //}


        //[Benchmark]
        //public int[] IntArrayRepeatFastSIMD()
        //{
        //    return LinqFasterSIMD.RepeatS(5, TEST_SIZE);
        //}

        //[Benchmark]
        //public int[] IntArrayRepeatFastSIMDB()
        //{
        //    return LinqFasterSIMD.RepeatSB(5, TEST_SIZE);
        //}

        //[Benchmark]
        //public int IntArrayMinLinq()
        //{
        //    return intArray.Min();
        //}

        //[Benchmark]
        //public int IntArrayMinFast()
        //{
        //    return intArray.MinF();
        //}

        //[Benchmark]
        //public int IntArrayMinFastSIMD()
        //{
        //    return intArray.MinS();
        //}

        //[Benchmark]
        //public bool IntArraySequenceEqual()
        //{
        //    return intArray.SequenceEqual(array2);
        //}

        //[Benchmark]
        //public bool IntArraySequenceEqualF()
        //{
        //    return intArray.SequenceEqualF(array2);
        //}


        //[Benchmark]
        //public bool IntArraySequenceEqualP()
        //{
        //    return intArray.SequenceEqualP(array2);
        //}

        //[Benchmark]
        //public bool IntArraySequenceEqualS()
        //{
        //    return intArray.SequenceEqualS(array2);
        //}

        //[Benchmark]
        //public bool IntArraySequenceEqualSP()
        //{
        //    return intArray.SequenceEqualSP(array2);
        //}


        public static void Main(string[] args)
        {
            Console.WriteLine(BenchmarkRunner.Run<Benchmarks>(ManualConfig.Create(DefaultConfig.Instance).With(Job.RyuJitX64)).ResultsDirectoryPath);
            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }

    }
}
