using System;
using NUnit.Framework;
using SOAPServiceTests.ServiceReference1;

namespace SOAPServiceTests
{
    [TestFixture]
    public class ServicesTests
    {
        private static readonly object[] TestData =
         {
            new object[] { 0, 5, 0},
            new object[] { -1, -3, 3},
            new object[] { -2, 1, -2 },
            new object[] { 2.5, 2, 5 }
        };
        [Test, TestCaseSource(nameof(TestData))]
        public void MulTest( double a, double b, double expected)
        {
            MulWrapper wrapper = new MulWrapper();
            Assert.AreEqual(expected, wrapper.Mul(a, b));
        }
    }
}
