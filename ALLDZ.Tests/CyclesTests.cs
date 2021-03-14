using NUnit.Framework;

namespace ALLDZ.Tests
{
    class CyclesTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(6, 0, 1)]
        public void Exercise_01_Test(double numberA, double numberB, double expected)
        {
            double actual = Cycles.Exercise_01(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(500, "500 1000 ")]
        [TestCase(100, "100 200 300 400 500 600 700 800 900 1000 ")]
        [TestCase(90, "90 180 270 360 450 540 630 720 810 900 990 ")]
        public void Exercise_02_Test(int numberA, string expected)
        {
            string actual = Cycles.Exercise_02(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 3)]
        [TestCase(10, 3)]
        [TestCase(20, 4)]
        public void Exercise_03_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_03(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, 500)]
        [TestCase(10, 5)]
        [TestCase(366, 183)]
        public void Exercise_04_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_04(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 500, 17892)]
        [TestCase(22, 66, 273)]
        [TestCase(300, 183, 3864)]
        public void Exercise_05_Test(int numberA, int numberB, int expected)
        {
            int actual = Cycles.Exercise_05(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5)]
        [TestCase(8, 21)]
        [TestCase(11, 89)]
        public void Exercise_06_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_06(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 100, 10)]
        [TestCase(77, 35, 7)]
        [TestCase(125, 50, 25)]
        public void Exercise_07_Test(int numberA, int numberB, int expected)
        {
            int actual = Cycles.Exercise_07(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 2)]
        [TestCase(27, 3)]
        [TestCase(64, 4)]
        public void Exercise_08_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_08(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12345, 3)]
        [TestCase(99999, 5)]
        [TestCase(56834, 2)]
        public void Exercise_09_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_09(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12345, 54321)]
        [TestCase(99999, 99999)]
        [TestCase(56834, 43865)]
        public void Exercise_10_Test(int numberA, int expected)
        {
            int actual = Cycles.Exercise_10(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, "2 4 6 8 ")]
        [TestCase(13, "2 4 6 8 12 ")]
        [TestCase(20, "2 4 6 8 12 14 16 18 20 ")]
        public void Exercise_11_Test(int numberA, string expected)
        {
            string actual = Cycles.Exercise_11(numberA);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 345, "Да")]
        [TestCase(13, 99, "Нет")]
        [TestCase(44444, 444, "Да")]
        public void Exercise_12_Test(int numberA, int numberb, string expected)
        {
            string actual = Cycles.Exercise_12(numberA, numberb);
            Assert.AreEqual(expected, actual);
        }
    }
}
