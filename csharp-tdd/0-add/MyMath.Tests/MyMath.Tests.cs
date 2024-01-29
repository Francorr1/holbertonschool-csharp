using NUnit.Framework;

namespace MyMath.Tests;
{
    public class Tests
    {
        [Test]
        /// <summary>Tests with two positive numbers</summary>
        public void Test1()
        {
            int sum = Operations.Add(5, 6);
            Assert.AreEqual(11, sum);
        }

        [Test]
        /// <summary>Tests with one positive number and one negative</summary>
        public void Test2()
        {
            int sum = Operations.Add(5, -6);
            Assert.AreEqual(-1, sum);
        }

        [Test]
        /// <summary>Tests with two negative numbers</summary>
        public void Test3()
        {
            int sum = Operations.Add(-5, -6);
            Assert.AreEqual(-11, sum);
        }
    }
}