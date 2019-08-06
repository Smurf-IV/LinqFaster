using NUnit.Framework;
using JM.LinqFaster.SIMD;
using System.Linq;
using System;

namespace Tests
{
    [TestFixture]
    class SumSIMDTests
    {

        [Test]
        public void SumSIMDInts()
        {
            int a = Test.intArray.Sum();
            int b = Test.intArray.SumS();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SumSIMDFloats()
        {
            float a = Test.floatArray.Sum();
            float b = Test.floatArray.SumS();
            double diff = Math.Abs(a - b);
            Assert.That(diff, Is.LessThan(0.1));
        }


        [Test]
        public void SumBySIMDFloats()
        {
            float a = Test.floatArray.Sum(x => x * x);
            float b = Test.floatArray.SumS(x => x * x);
            double diff = Math.Abs(a - b);
            Assert.That(diff, Is.LessThan(0.15));

        }

    }
}
