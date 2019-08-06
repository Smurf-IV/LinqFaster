using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Benchmarks
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
