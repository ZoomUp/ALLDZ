using NUnit.Framework;

namespace ALLDZ.Tests
{
    class ArraysTests
    {
        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 22)]
        [TestCase(new int[] { 155, 33, 22, 44, 166 }, 22)]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, 55)]
        public void Exercise_01_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_01(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 66)]
        [TestCase(new int[] { 155, 33, 22, 44, 166 }, 166)]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, 322)]
        public void Exercise_02_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_02(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 2)]
        [TestCase(new int[] { 155, 33, 22, 44, 166 }, 2)]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, 0)]
        public void Exercise_03_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_03(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 4)]
        [TestCase(new int[] { 155, 33, 22, 44, 166 }, 4)]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, 2)]
        public void Exercise_04_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_04(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 77)]
        [TestCase(new int[] { 155, 33, 22, 44, 166 }, 77)]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, 377)]
        public void Exercise_05_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_05(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, new int[] { 66, 44, 22, 33, 55 })]
        [TestCase(new int[] { 155, 33, 22, 44, 166, 0 }, new int[] { 0, 166, 44, 22, 33, 155 })]
        [TestCase(new int[] { 55, 133, 322, 244, 66 }, new int[] { 66, 244, 322, 133, 55 })]
        public void Exercise_06_Test(int[] arrayZ1, int[] expected)
        {
            int[] actual = Arrays.Exercise_06(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, 2)]
        [TestCase(new int[] { 155, 33, 22, 44, 166, 44, 166 }, 3)]
        [TestCase(new int[] { 55, 133, 322, 244, 66, 322, 244, 66 }, 4)]
        public void Exercise_07_Test(int[] arrayZ1, int expected)
        {
            int actual = Arrays.Exercise_07(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, new int[] { 44, 66, 22, 55, 33 })]
        [TestCase(new int[] { 155, 33, 22, 44, 166, 0 }, new int[] { 44, 166, 0, 155, 33, 22 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        public void Exercise_08_Test(int[] arrayZ1, int[] expected)
        {
            int[] actual = Arrays.Exercise_08(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, new int[] { 22, 33, 44, 55, 66 })]
        [TestCase(new int[] { 155, 33, 22, 44, 166, 0 }, new int[] { 0, 22, 33, 44, 155, 166 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
        public void Exercise_09_Test(int[] arrayZ1, int[] expected)
        {
            int[] actual = Arrays.Exercise_09(arrayZ1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 55, 33, 22, 44, 66 }, new int[] { 66, 55, 44, 33, 22 })]
        [TestCase(new int[] { 155, 33, 22, 44, 166, 0 }, new int[] { 166, 155, 44, 33, 22, 0 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        public void Exercise_10_Test(int[] arrayZ1, int[] expected)
        {
            int[] actual = Arrays.Exercise_10(arrayZ1);
            Assert.AreEqual(expected, actual);
        }
    }
}
