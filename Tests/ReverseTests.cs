using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using System;
using System.Collections.Generic;
using static Tests.Test;

namespace Tests
{
    [TestFixture]
    class ReverseTests {

        [Test]
        public void ReverseArray() {
            int[] a = intArray.ReverseF();
            int[] aSpan = intArray.AsSpan().ReverseF();
            IEnumerable<int> b = intArray.Reverse();

            Assert.That(a, Is.EqualTo(b));
            Assert.That(aSpan, Is.EqualTo(b));
        }

        [Test]
        public void ReverseList() {
            List<int> a = intList.ReverseF();
            List<int> b = intList.Select(x => x).ToList();
            b.Reverse();
            Assert.That(a, Is.EqualTo(b));
        }
    }
}
