using System;
using System.Linq;

using BenchmarkDotNet.Attributes;

using JM.LinqFaster;

namespace Tests
{
    public partial class Benchmarks
    {
        private static readonly Func<int, int> orderBy = (x) => x - 1;

        //[Benchmark]
        //public int IntArrayOrderByLinq()
        //{
        //    return intArray.OrderBy(orderBy).Sum();
        //}

        //[Benchmark]
        //public int IntArrayOrderByFast()
        //{
        //    return intArray.OrderByF(orderBy).Sum();
        //}
    }
}
