using NUnit.Framework;

namespace ALLDZ.Tests
{
    public class BranchingStructuresTests
    {
        [TestCase(5, 4, 9)]
        [TestCase(4, 4, 16)]
        [TestCase(3, 7, -4)]
        public void Exercise_01_Test(int numberA, int numberB, int expected)
        {
            int actual = BranchingStructures.Exercise_01(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 4, 1)]
        [TestCase(5, -14, 4)]
        [TestCase(5, 0, 0)]
        public void Exercise_02_Test(int numberA, int numberB, int expected)
        {
            int actual = BranchingStructures.Exercise_02(numberA, numberB);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 6, 7, new int[3] { 5, 6, 7 })]
        [TestCase(8, 6, 7, new int[3] { 6, 7, 8 })]
        [TestCase(2, 5, 7, new int[3] { 2, 5, 7 })]
        public void Exercise_03_Test(int numberA, int numberB, int numberC, int[] expected)
        {
            int[] actual = BranchingStructures.Exercise_03(numberA, numberB, numberC);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 6, 9, "X=-3")]
        [TestCase(1, -5, 9, "корней нет")]
        [TestCase(1, 3, -4, "X1=1, X2=-4")]
        public void Exercise_04_Test(double numberA, double numberB, double numberC, string expected)
        {
            string actual = BranchingStructures.Exercise_04(numberA, numberB, numberC);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, "Двадцать")]
        [TestCase(11, "Одиннадцать")]
        [TestCase(99, "Девяносто девять")]
        public void Exercise_05_Test(int numberA, string expected)
        {
            string actual = BranchingStructures.Exercise_05(numberA);
            Assert.AreEqual(expected, actual);
        }

    }
}
