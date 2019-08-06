﻿using NUnit.Framework;
using JM.LinqFaster.SIMD;
using System.Linq;
using System;
using System.Numerics;

namespace Tests
{
    [TestFixture]
    class AverageSIMDTests
    {

        [Test]
        public void AverageSIMDInts()
        {
            double a = Test.intArray.Average();
            double b = Test.intArray.AverageS();
            double diff = Math.Abs(a - b);
            Assert.That(diff, Is.LessThan(0.1));
        }

        [Test]
        public void AverageSIMDFloats()
        {
            float a = Test.floatArray.Average();
            float b = Test.floatArray.AverageSf();
            double diff = Math.Abs(a - b);
            Assert.That(diff, Is.LessThan(0.1));
        }

        [Test]
        public void AverageBySIMDInts()
        {
            double a = Test.intArray.Average(x => x - 1);
            double b = Test.intArray.AverageS(x => x - new Vector<int>(1));
            double diff = Math.Abs(a - b);
            Assert.That(diff, Is.LessThan(0.1));
        }

    }
}