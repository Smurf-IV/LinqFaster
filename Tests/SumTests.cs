using System;
using System.Collections.Generic;
using System.Linq;

using JM.LinqFaster;

using NUnit.Framework;

using static Tests.Test;

namespace Tests
{
    [TestFixture]
    internal class SumTests
    {
        [Test]
        public void SumArray()
        {
            int a = ((IReadOnlyList<int>)intArray).SumF();

            int b = intArray.Sum();
            Assert.That(a, Is.EqualTo(b));
            int? an = ((IReadOnlyList<int?>)intNullArray).SumF();
            int? bn = intNullArray.Sum();
            Assert.That(an, Is.EqualTo(bn));

            float c = floatArray.SumF();
            float d = floatArray.Sum();
            Assert.That(c, Is.EqualTo(d));
            float? dn = floatNullArray.SumF();
            Assert.That(c, Is.EqualTo(dn));

            decimal e = decimalArray.SumF();
            decimal f = decimalArray.Sum();
            Assert.That(e, Is.EqualTo(f));

            uint g = byteArray.SumF();
            uint h = byteArray.Aggregate(0U, (current, b1) => current + b1);
            Assert.That(g, Is.EqualTo(h));

            int i = shortArray.SumF();
            int j = shortArray.Aggregate(0, (current, s1) => current + s1);
            Assert.That(i, Is.EqualTo(j));

            double k = doubleArray.SumF();
            double l = doubleArray.Sum();
            Assert.That(k, Is.EqualTo(l));
            double? ln = doubleNullArray.SumF();
            Assert.That(k, Is.EqualTo(ln));


        }


        [Test]
        public void SumArraySelector()
        {
            int a = intArray.SumF(x => x + 1);
            int b = intArray.Sum(x => x + 1);
            Assert.That(a, Is.EqualTo(b));

            int br = Array.AsReadOnly(intArray).SumF(x => x + 1);
            Assert.That(a, Is.EqualTo(br));

            int an = intNullArray.SumF(x => x ?? 0);
            int bn = intNullArray.Sum(x => x ?? 0);
            Assert.That(an, Is.EqualTo(bn));

            float c = floatArray.SumF(squaredFloats);
            float d = floatArray.Sum(squaredFloats);

            Assert.That(c, Is.EqualTo(d));
        }

        [Test]
        public void SumList()
        {
            int a = intList.SumF();
            int b = intList.Sum();

            Assert.That(a, Is.EqualTo(b));

            float c = floatList.SumF();
            float d = floatList.Sum();

            Assert.That(c, Is.EqualTo(d));

            decimal e = decimalList.SumF();
            decimal f = decimalList.Sum();

            Assert.That(e, Is.EqualTo(f));
        }

        [Test]
        public void SumListSelector()
        {
            int a = intList.SumF(x => x + 1);
            int b = intList.Sum(x => x + 1);
            Assert.That(a, Is.EqualTo(b));

            int br = intList.AsReadOnly().SumF(x => x + 1);
            Assert.That(a, Is.EqualTo(br));

            float c = floatList.SumF(squaredFloats);
            float d = floatList.Sum(squaredFloats);
            Assert.That(c, Is.EqualTo(d));
        }

    }
}
