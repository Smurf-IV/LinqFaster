using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using static Tests.Test;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    class ContainsTests {

        [Test]
        public void ContainsStringArrayTrue() {
            bool a = stringArray.ContainsF("0",EqualityComparer<string>.Default);
            bool b = stringArray.Contains("0", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));          
        }

        [Test]
        public void ContainsStringArrayFalse() {
            bool a = stringArray.ContainsF("No Match", EqualityComparer<string>.Default);
            bool b = stringArray.Contains("No Match", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsStringListTrue() {
            bool a = stringList.ContainsF("0", EqualityComparer<string>.Default);
            bool b = stringList.Contains("0", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsStringListFalse() {
            bool a = stringList.ContainsF("no match", EqualityComparer<string>.Default);
            bool b = stringList.Contains("no match", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

    }
}
