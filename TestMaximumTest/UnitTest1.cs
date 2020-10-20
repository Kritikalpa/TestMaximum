using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximum;

namespace TestMaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1-1.3 :Tests the maximum integer number.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <param name="third">The third.</param>
        [TestMethod]
        [DataRow(44,33,22)]
        [DataRow(33,44,22)]
        [DataRow(22,33,44)]
        public void TestMaximumIntegerNumber(int first, int second, int third)
        {
            MaxValue<int> intObj = new MaxValue<int>(first, second, third);
            int expected = 44;
            int result = intObj.MaximumValue();
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// TC 2.1-2.3 :Tests the maximum float number.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <param name="third">The third.</param>
        [TestMethod]
        [DataRow(3.3, 2.2, 1.1)]
        [DataRow(2.2, 3.3, 1.1)]
        [DataRow(1.1, 2.2, 3.3)]
        public void TestMaximumFloatNumber(double first, double second, double third)
        {
            MaxValue<double> floatObj = new MaxValue<double>(first, second, third);
            double expected = 3.3;
            double result = floatObj.MaximumValue();
            Assert.AreEqual(result, expected);
        }

        /// <summary>
        /// TC 3.1 - 3.3 :Tests the maximum string number.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <param name="third">The third.</param>
        [TestMethod]
        [DataRow("PEACH", "APPLE", "BANANA")]
        [DataRow("APPLE", "PEACH", "BANANA")]
        [DataRow("APPLE", "BANANA", "PEACH")]
        public void TestMaximumStringNumber(string first, string second, string third)
        {
            MaxValue<string> stringObj = new MaxValue<string>(first, second, third);
            string expected = "PEACH";
            string result = stringObj.MaximumValue();
            Assert.AreEqual(result, expected);
        }
    }
}
