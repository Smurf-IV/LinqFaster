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
            var a = intArray.SumF();
            var b = intArray.Sum();
            Assert.That(a, Is.EqualTo(b));
            var an = intNullArray.SumF();
            var bn = intNullArray.Sum();
            Assert.That(an, Is.EqualTo(bn));

            var c = floatArray.SumF();
            var d = floatArray.Sum();
            Assert.That(c, Is.EqualTo(d));
            var dn = floatNullArray.SumF();
            Assert.That(c, Is.EqualTo(dn));

            var e = decimalArray.SumF();
            var f = decimalArray.Sum();
            Assert.That(e, Is.EqualTo(f));

            var g = byteArray.SumF();
            var h = byteArray.Aggregate(0U, (current, b1) => current + b1);
            Assert.That(g, Is.EqualTo(h));

            var i = shortArray.SumF();
            var j = shortArray.Aggregate(0, (current, s1) => current + s1);
            Assert.That(i, Is.EqualTo(j));

            var k = doubleArray.SumF();
            var l = doubleArray.Sum();
            Assert.That(k, Is.EqualTo(l));
            var ln = doubleNullArray.SumF();
            Assert.That(k, Is.EqualTo(ln));


        }


        [Test]
        public void SumArraySelector()
        {
            var a = intArray.SumF(x => x + 1);
            var b = intArray.Sum(x => x + 1);

            var an = intNullArray.SumF(x => x ?? 0);
            var bn = intNullArray.Sum(x => x ?? 0);
            Assert.That(an, Is.EqualTo(bn));

            Assert.That(a, Is.EqualTo(b));

            var c = floatArray.SumF(squaredFloats);
            var d = floatArray.Sum(squaredFloats);

            Assert.That(c, Is.EqualTo(d));
        }

        [Test]
        public void SumList()
        {
            var a = intList.SumF();
            var b = intList.Sum();

            Assert.That(a, Is.EqualTo(b));

            var c = floatList.SumF();
            var d = floatList.Sum();

            Assert.That(c, Is.EqualTo(d));

            var e = decimalList.SumF();
            var f = decimalList.Sum();

            Assert.That(e, Is.EqualTo(f));
        }

        [Test]
        public void SumListSelector()
        {
            var a = intList.SumF(x => x + 1);
            var b = intList.Sum(x => x + 1);

            Assert.That(a, Is.EqualTo(b));

            var c = floatList.SumF(squaredFloats);
            var d = floatList.Sum(squaredFloats);

            Assert.That(c, Is.EqualTo(d));
        }

    }
}
