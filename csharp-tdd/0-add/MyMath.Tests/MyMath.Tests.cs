using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>Tests if the method works</summary>
    public class Tests
    {
        [Test]
        /// <summary>Testing with positive numbers</summary>
        public void test1()
        {
            int sum = Operations.Add(8, 9);
            Assert.AreEqual(17, sum);
        }
        [Test]
        /// <summary>Testing with only one negative number</summary>
        public void test1()
        {
            int sum = Operations.Add(-3, 9);
            Assert.AreEqual(6, sum);
        }
        [Test]
        /// <summary>Testing with two negative numbers</summary>
        public void test1()
        {
            int sum = Operations.Add(-8, -9);
            Assert.AreEqual(-17, sum);
        }
    }
}