﻿using System.Collections.Generic;
using NUnit.Framework;
using JM.LinqFaster.Parallel;
using System.Linq;
using static Tests.Test;

namespace Tests
{
    [TestFixture]
    class SelectParallel
    {

        [Test]
        public void ParallelSelectArray()
        {
            int[] a = intArray.SelectP(x => x * x);
            IEnumerable<int> b = intArray.Select(x => x * x);

            Assert.That(a, Is.EqualTo(b));

            a = intArray.SelectP((x, i) => x + i);
            b = intArray.Select((x, i) => x + i);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelSelectList()
        {
            List<int> a = intList.SelectP(x => x * x);
            List<int> b = intList.Select(x => x * x).ToList();
            Assert.That(a.Count, Is.Not.EqualTo(0));
            Assert.That(a, Is.EqualTo(b));

            a = intList.SelectP((x, i) => x + i);
            b = intList.Select((x, i) => x + i).ToList();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}

