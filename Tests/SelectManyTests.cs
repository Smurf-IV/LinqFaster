﻿using System.Collections.Generic;
using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using static Tests.Test;

namespace Tests
{
    [TestFixture]
    class SelectManyTests
    {

        [Test]
        public void SelectManyArray()
        {
            float[] a = floatArray.SelectManyF(x => LinqFaster.RepeatArrayF(x, 2));
            float[] b = floatArray.SelectMany(x => Enumerable.Repeat(x, 2).ToArray()).ToArray();

            Assert.That(a, Is.EqualTo(b));

            a = floatArray.SelectManyF((x,i) => LinqFaster.RepeatArrayF(x+i, 2));
            b = floatArray.SelectMany((x,i) => Enumerable.Repeat(x+i, 2).ToArray()).ToArray();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SelectManyList()
        {
            List<float> a = floatList.SelectManyF(x => LinqFaster.RepeatListF(x, 2));
            List<float> b = floatList.SelectMany(x => Enumerable.Repeat(x, 2).ToList()).ToList();

            Assert.That(a, Is.EqualTo(b));

            a = floatList.SelectManyF((x, i) => LinqFaster.RepeatListF(x + i, 2));
            b = floatList.SelectMany((x, i) => Enumerable.Repeat(x + i, 2).ToList()).ToList();

            Assert.That(a, Is.EqualTo(b));
        }

    }
}
