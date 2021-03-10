using NUnit.Framework;

namespace ALLDZ.Tests
{
    public class VariableTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(0, 6, 6)]
        [TestCase(10, 3, (double)59 / -7)]
        public void Exercise_01_Test(double numberA, double numberB, double expected)
        {
            double actual = Variables.Exercise_01(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 2, new double[2] { 2, 5 })]
        [TestCase(-10, 5, new double[2] { 5, -10 })]
        [TestCase(2.5, 6.23, new double[2] { 6.23, 2.5 })]

        public void Exercise_02_Test(double numberA, double numberB, double[] expected)
        {
            double[] actual = Variables.Exercise_02(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 2, new double[2] { 3, 0 })]
        [TestCase(6, 0.5, new double[2] { 12, 0 })]
        [TestCase(3, 6, new double[2] { 0.5, 3 })]

        public void Exercise_03_Test(double numberA, double numberB, double[] expected)
        {
            double[] actual = Variables.Exercise_03(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 5, "Бесконечно решений")]
        [TestCase(0, 5, 15, "Нет решений")]
        [TestCase(2, 6, 16, "5")]

        public void Exercise_04_Test(double numberA, double numberB, double numberC, string expected)
        {
            string actual = Variables.Exercise_04(numberA, numberB, numberC);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 4, "Y=1X+2")]
        [TestCase(2, 2, 3, 4, "Влом")]
        [TestCase(-4, -3, 2, 1, "Y=-1X+(-2)")]

        public void Exercise_05_Test(double numberA, double numberB, double numberC, double numberD, string expected)
        {
            string actual = Variables.Exercise_05(numberA, numberB, numberC, numberD);
            Assert.AreEqual(expected, actual);
        }
    }
}