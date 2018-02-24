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
        public void femaleAgeTest1()
        {
            var female = new Premium();

            Assert.AreEqual(5, female.CalcPremium(20, "female"));

        }

        [Test]
        public void femaleAgeTest2()
        {
            var female = new Premium();
            Assert.AreEqual(2.50, female.CalcPremium(31, "female"));
        }

        [Test]
        public void femaleAgeTest3()
        {
            var female = new Premium();
            Assert.AreEqual(0, female.CalcPremium(17, "female"));
        }

        [Test]
        public void maleAgeTest1()
        {
            var male = new Premium();
            Assert.AreEqual(6, male.CalcPremium(21, "male"));
        }

        [Test]
        public void maleAgeTest2()
        {
            var male = new Premium();
            Assert.AreEqual(5, male.CalcPremium(36, "male"));
        }

        [Test]
        public void maleAgeTest3()
        {
            var male = new Premium();
            Assert.AreEqual(0, male.CalcPremium(16, "male"));
        }

        [Test]
        public void genderTest()
        {
            var gender = new Premium();
            Assert.AreEqual(0, gender.CalcPremium(24, ""));
        }

        [Test]
        public void ageTest1()
        {
           
            var age = new Premium();
            Assert.AreEqual(5*0.15, age.CalcPremium(51, "male"));
        }

        [Test]
        public void ageTest2()
        {

            var age = new Premium();
            Assert.AreEqual(2.5*0.15, age.CalcPremium(51, "female"));
        }
    }
}
