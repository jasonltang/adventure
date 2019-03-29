using System;
using Adventure;
using NUnit.Framework;

namespace AdventureTests
{
    [TestFixture]
    public class HelpersTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-2.5, -2.5)]
        public void RandomNormal_StDev0_ReturnsConstantNumber(double mean, double expectedResult)
        {
            var result = Helpers.RandomNormal(mean, 0);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(1, 2)]
        [TestCase(2, 10)]
        [TestCase(0, 0)]
        public void RandomNormal_ValidInputs_ReturnsDouble(double mean, double stDev)
        {
            var result = Helpers.RandomNormal(mean, stDev);
            Assert.That(result, Is.TypeOf<double>());
        }

        [Test]
        public void RandomNormal_NegativeStDev_Throws()
        {
            Assert.Throws<ArgumentException>(() => Helpers.RandomNormal(1, -2));
        }
    }
}
