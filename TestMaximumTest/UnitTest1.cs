using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestMaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1-1.3 : Tests the maximum integer number.
        /// </summary>
        [TestMethod]
        [DataRow(44,33,22)]
        [DataRow(33,44,22)]
        [DataRow(22,33,44)]
        public void TestMaximumIntegerNumber(int first, int second, int third)
        {
            int expected = 44;
            int result = Program.maximumIntegerNumber(first, second, third);
            Assert.AreEqual(result, expected);
        }
    }
}
