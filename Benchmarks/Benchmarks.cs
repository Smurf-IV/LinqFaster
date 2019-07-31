using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using JM.LinqFaster;
using JM.LinqFaster.Parallel;
using JM.LinqFaster.SIMD.Parallel;
using JM.LinqFaster.SIMD;

using System.Linq;
using System.Collections.Generic;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;

namespace Tests
{
    [MemoryDiagnoser]
    public class Benchmarks
    {

        const int LARGE_TEST_SIZE = 1000000;
        const int SMALL_TEST_SIZE = 100;

        public List<int> list;
        public byte[] byteArray;
        public short[] shortArray;
        public int[] intArray;
        public List<int> intList;
        private int?[] intNullArray;
        public int[] array2;
        public float[] floatArray;
        public List<float> floatList;
        private float?[] floatNullArray;
        public double[] doubleArray;
        public List<double> doubleList;
        private double?[] doubleNullArray;
        public string[] strarray;
        

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
        //    return intArray.OrderBy((x => x -1)).Sum();
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


        [Benchmark]
        public int IntArraySumLinq()
        {
            return intArray.Sum();
        }

        [Benchmark]
        public int IntArraySumFast()
        {
            return intArray.SumF();
        }

        [Benchmark]
        public int IntListSumLinq()
        {
            return intList.Sum();
        }

        [Benchmark]
        public int IntListSumFast()
        {
            return intList.SumF();
        }

        [Benchmark]
        public int IntIListSumLinq()
        {
            return ((IList<int>)intList).Sum();
        }

        [Benchmark]
        public int IntIListSumFast()
        {
            return ((IList<int>)intList).SumF();
        }


        //[Benchmark]
        //public int IntArraySumLinqSelect()
        //{
        //    return intArray.Sum(x=>x);
        //}

        //[Benchmark]
        //public int IntArraySumFastSelect()
        //{
        //    return intArray.SumF(x=>x);
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
        //public int IntNullArraySumFastSelect()
        //{
        //    return intNullArray.SumF(x => x ?? 0);
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
        //    return floatArray.Sum(x => x);
        //}

        //[Benchmark]
        //public float FloatArraySumFastSelect()
        //{
        //    return floatArray.SumF(x => x);
        //}

        //[Benchmark]
        //public float ? FloatNullArraySumLinq()
        //{
        //    return floatNullArray.Sum();
        //}

        //[Benchmark]
        //public float ? FloatNullArraySumFast()
        //{
        //    return floatNullArray.SumF();
        //}

        //[Benchmark]
        //public float FloatNullArraySumFastSelect()
        //{
        //    return floatNullArray.SumF(x => x ?? 0);
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
        //    return doubleArray.Sum(x => x);
        //}

        //[Benchmark]
        //public double DoubleArraySumFastSelect()
        //{
        //    return doubleArray.SumF(x => x);
        //}

        //[Benchmark]
        //public double ? DoubleNullArraySumLinq()
        //{
        //    return doubleNullArray.Sum();
        //}

        //[Benchmark]
        //public double ? DoubleNullArraySumFast()
        //{
        //    return doubleNullArray.SumF();
        //}

        //[Benchmark]
        //public double ? DoubleNullArraySumFastSelect()
        //{
        //    return doubleNullArray.SumF(x => x ?? 0);
        //}

        //[Benchmark]
        //public double AverageLinq()
        //{
        //    return intArray.Average();
        //}

        //[Benchmark]
        //public double AverageFast()
        //{
        //    return intArray.AverageF();
        //}

        //[Benchmark]
        //public double AverageFastSIMD()
        //{
        //    return intArray.AverageS();
        //}

        //[Benchmark]
        //public int SumWithSelectLinq()
        //{
        //    return intArray.Sum(x => x / 2);
        //}

        //[Benchmark]
        //public int SumWithSelectFast()
        //{
        //    return intArray.SumF(x => x/2);
        //}


        //[Benchmark]
        //public double WhereAggregateLinq()
        //{        
        //    return intArray.Where(x => x % 2 == 0).Aggregate(0.0, (acc, x) => acc += x * x, acc => acc / intArray.Length);
        //}

        //[Benchmark]
        //public double WhereAggregateFast()
        //{
        //    return intArray.WhereAggregateF(x => x % 2 == 0,0.0,(acc,x)=> acc += x*x,acc => acc/array.Length);
        //}

        //[Benchmark]
        //public int[] SelectFast()
        //{
        //    return intArray.SelectF(x => x * x);
        //}

        //[Benchmark]
        //public int[] SelectFastSIMD()
        //{
        //    return intArray.SelectS(x => x * x, x=>x*x);
        //}



        //[Benchmark]
        //public int[] RepeatLinq()
        //{
        //    return Enumerable.Repeat(5, TEST_SIZE).ToArray();
        //}

        //[Benchmark]
        //public int[] RepeatFast()
        //{
        //    return LinqFaster.RepeatArrayF(5, TEST_SIZE);
        //}


        //[Benchmark]
        //public int[] RepeatFastSIMD()
        //{
        //    return LinqFasterSIMD.RepeatS(5, TEST_SIZE);
        //}

        //[Benchmark]
        //public int[] RepeatFastSIMDB()
        //{
        //    return LinqFasterSIMD.RepeatSB(5, TEST_SIZE);
        //}

        //[Benchmark]
        //public int MinLinq()
        //{
        //    return intArray.Min();
        //}

        //[Benchmark]
        //public int MinFast()
        //{
        //    return intArray.MinF();
        //}

        //[Benchmark]
        //public int MinFastSIMD()
        //{                        
        //    return intArray.MinS();
        //}

        //[Benchmark]
        //public bool SequenceEqual()
        //{
        //    return intArray.SequenceEqual(array2);
        //}

        //[Benchmark]
        //public bool SequenceEqualF()
        //{            
        //    return intArray.SequenceEqualF(array2);
        //}


        //[Benchmark]
        //public bool SequenceEqualP()
        //{
        //    return intArray.SequenceEqualP(array2);
        //}

        //[Benchmark]
        //public bool SequenceEqualS()
        //{
        //    return intArray.SequenceEqualS(array2);
        //}

        //[Benchmark]
        //public bool SequenceEqualSP()
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
