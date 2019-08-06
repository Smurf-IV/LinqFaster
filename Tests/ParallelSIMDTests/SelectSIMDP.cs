using System.Collections.Generic;
using NUnit.Framework;
using JM.LinqFaster.SIMD.Parallel;
using System.Linq;

namespace Tests
{
    [TestFixture]
    class SelectSIMDPTests
    {
        [Test]
        public  void SelectSIMDP()
        {
            int[] a = Test.intArray.SelectSP(x => x * x, x => x*x);
            IEnumerable<int> b = Test.intArray.Select(x => x * x);

            Assert.That(a, Is.EqualTo(b));

        
//            Assert.That(c, Is.EqualTo(d));

         
  //          Assert.That(e, Is.EqualTo(f));
        }
      
    }
}
