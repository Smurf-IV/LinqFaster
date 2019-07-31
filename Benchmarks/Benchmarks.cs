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
        public int?[] intNullArray;
        public int[] array2;
        public float[] floatArray;
        public double[] doubleArray;
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
            array2 = new int[TEST_SIZE];
            floatArray = new float[TEST_SIZE];
            doubleArray = new double[TEST_SIZE];
            list = new List<int>(TEST_SIZE);
            strarray = new string[TEST_SIZE];
                                    
            for (int i = 0; i < TEST_SIZE; i++)
            {
                intArray[i] = i % 2;
                byteArray[i] = (byte)intArray[i];
                shortArray[i] = (short)intArray[i];
                intNullArray[i] = intArray[i];
                array2[i] = i % 2;
                list.Add(intArray[i]);
                strarray[i] = intArray[i].ToString();
                floatArray[i] = intArray[i];
                doubleArray[i] = floatArray[i];
            }
            array2[TEST_SIZE / 2] = 0;
        }

        //[Benchmark]
        //public int OrderByLinq()
        //{
        //    return intArray.OrderBy((x => x -1)).Sum();
        //}

        //[Benchmark]
        //public int OrderByFast()
        //{
        //    return intArray.OrderByF((x => x - 1)).Sum();
        //}


        //[Benchmark]
        //public int ByteSumLinq()
        //{
        //    return byteArray.Aggregate(0, (current, b1) => current + b1);
        //}

        //[Benchmark]
        //public uint ByteSumFast()
        //{
        //    return byteArray.SumF();
        //}


        //[Benchmark]
        //public int ShortSumLinq()
        //{
        //    return shortArray.Aggregate(0, (current, s1) => current + s1);
        //}

        //[Benchmark]
        //public int ShortSumFast()
        //{
        //    return shortArray.SumF();
        //}


        [Benchmark]
        public int IntSumLinq()
        {
            return intArray.Sum();
        }

        [Benchmark]
        public int IntSumFast()
        {
            return intArray.SumF();
        }

        [Benchmark]
        public int IntSumLinqSelect()
        {
            return intArray.Sum(x=>x);
        }

        [Benchmark]
        public int IntSumFastSelect()
        {
            return intArray.SumF(x=>x);
        }

        //[Benchmark]
        //public int SumFastSIMD()
        //{
        //    return intArray.SumS();
        //}

        [Benchmark]
        public int? IntNullSumLinq()
        {
            return intNullArray.Sum();
        }

        [Benchmark]
        public int? IntNullSumFast()
        {
            return intNullArray.SumF();
        }

        [Benchmark]
        public int? IntNullSumFastSelect()
        {
            return intNullArray.SumF(x => x ?? 0);
        }

        //[Benchmark]
        //public float FloatSumLinq()
        //{
        //    return floatArray.Sum();
        //}

        //[Benchmark]
        //public float FloatSumFast()
        //{
        //    return floatArray.SumF();
        //}


        //[Benchmark]
        //public double DoubleSumLinq()
        //{
        //    return doubleArray.Sum();
        //}

        //[Benchmark]
        //public double DoubleSumFast()
        //{
        //    return doubleArray.SumF();
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
        //public int[] RepeastFast()
        //{
        //    return LinqFaster.RepeatArrayF(5, TEST_SIZE);
        //}


        //[Benchmark]
        //public int[] RepeastFastSIMD()
        //{
        //    return LinqFasterSIMD.RepeatS(5, TEST_SIZE);
        //}

        //[Benchmark]
        //public int[] RepeastFastSIMDB()
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
