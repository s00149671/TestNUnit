using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssign1.Tests
{
    [TestFixture]
    class PremiumTests
    {
        [Test]
        public void test1()
        {
            var test = new Premium();

            Assert.AreEqual(5, test.CalcPremium(20, "female"));
           

    }
}
