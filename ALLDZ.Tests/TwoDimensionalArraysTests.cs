using NUnit.Framework;

namespace ALLDZ.Tests
{
    class TwoDimensionalArraysTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 11)]
        [TestCase(3, 2)]

        public void Exercise_01_Test(int mockNumber, int expected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int actual = TwoDimensionalArrays.Exercise_01(array2d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_01_TestException(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_01(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }



        [TestCase(1, 9)]
        [TestCase(2, 19)]
        [TestCase(3, 14)]

        public void Exercise_02_Test(int mockNumber, int expected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int actual = TwoDimensionalArrays.Exercise_02(array2d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_02_TestException(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_02(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, new int[] { 0, 0 })]
        [TestCase(2, new int[] { 0, 0 })]
        [TestCase(3, new int[] { 2, 1 })]

        public void Exercise_03_Test(int mockNumber, int[] expected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int[] actual = TwoDimensionalArrays.Exercise_03(array2d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_03_TestException(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_03(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 2, 2 })]
        [TestCase(3, new int[] { 1, 0 })]

        public void Exercise_04_Test(int mockNumber, int[] expected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int[] actual = TwoDimensionalArrays.Exercise_04(array2d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_04_TestException(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_04(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]

        public void Exercise_05_Test(int mockNumber, int expected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int actual = TwoDimensionalArrays.Exercise_05(array2d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_05_TestExceprion(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_05(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]

        public void Exercise_06_Test(int mockNumber, int mockNumberExpected)
        {
            int[,] array2d = Exercise_01_TestMock.GetMock(mockNumber);
            int[,] expected = Exercise_06_TestMock.GetMock(mockNumberExpected);
            int[,] actual = TwoDimensionalArrays.Exercise_06(array2d);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]


        public void Exercise_06_TestExceprion(int mockNumber)
        {
            int[,] array2d = TwoDemException.GetMock(mockNumber);
            try
            {
                TwoDimensionalArrays.Exercise_06(array2d);
                Assert.Fail();
            }
            catch
            {
                Assert.Pass();
            }
        }




        public static class Exercise_01_TestMock
        {
            public static int[,] GetMock(int number)
            {
                int[,] result = new int[0,0];
                switch (number)
                {
                    case 1:
                        result = new int[,]
                        {
                        {1, 2, 3 },
                        {4, 5, 6 },
                        {7, 8, 9 }
                        };
                        break;
                    case 2:
                        result = new int[,]
                        {
                        {11, 12, 13 },
                        {14, 15, 16 },
                        {17, 18, 19 }
                        };
                        break;
                    case 3:
                        result = new int[,]
                        {
                        {11, 12, 13 },
                        {14, 5, 14 },
                        {3, 2, 11 }
                        };
                        break;
                }
                return result;
                
            }
        }
        public static class Exercise_06_TestMock
        {
            public static int[,] GetMock(int mockNumberExpected)
            {
                int[,] result = new int[0, 0];
                switch (mockNumberExpected)
                {
                    case 1:
                        result = new int[,]
                        {
                        {1, 4, 7 },
                        {2, 5, 8 },
                        {3, 6, 9 }
                        };
                        break;
                    case 2:
                        result = new int[,]
                        {
                        {11, 14, 17 },
                        {12, 15, 18 },
                        {13, 16, 19 }
                        };
                        break;
                    case 3:
                        result = new int[,]
                        {
                        {11, 14, 3 },
                        {12, 5, 2 },
                        {13, 14, 11 }
                        };
                        break;
                }
                return result;

            }
        }
        public static class TwoDemException
        {
            public static int[,] GetMock (int number)
            {
                int[,] result = new int[0, 0];
                switch (number)
                {
                    case 1:
                        result = new int[,]
                        {
                        {1, 4, 7 }
                        };
                        break;
                    case 2:
                        break;
                }
                return result;
            }
        }
    }
}
