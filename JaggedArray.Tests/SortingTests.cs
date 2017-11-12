using System;
using NUnit.Framework;
using JaggedArray.Logic;
using static JaggedArray.Tests.Comparers;

namespace JaggedArray.Tests
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void ComparerSumByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerSumByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerSumByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerSumByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMaxByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerMaxByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMaxByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerMaxByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 5 }, new int[] { 7 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerMinByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 7 }, new int[] { 5 }, new int[] { 1, 3, 8 } };
            BubbleSortingForArray.BubbleSorting(array, new ComparerMinByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByDec_NullJaggedArray_ThrowArgumentNullException()
        {
            int[][] arr = null;
            Assert.Throws<ArgumentNullException>(() => BubbleSortingForArray.BubbleSorting(arr, new ComparerMinByDec()));
        }

        #region Tests For Delegate
        [Test]
        public void BubbleSortingWithDelegate_ComparerSumByInc_CorrectValues_PositiveTest()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerSumByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithDelegate_ComparerSumByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerSumByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithDelegate_ComparerMaxByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerMaxByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithDelegate_ComparerMaxByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerMaxByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithDelegate_ComparerMinByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 5 }, new int[] { 7 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerMinByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithDelegate_ComparerMinByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 7 }, new int[] { 5 }, new int[] { 1, 3, 8 } };
            BubbleSortingWithDelegate.BubbleSorting(array, new ComparerMinByDec());
            Assert.AreEqual(array, expected);
        }

        #endregion

        #region Tests For Interface
        [Test]
        public void BubbleSortingWithInterface_ComparerSumByInc_CorrectValues_PositiveTest()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            BubbleSortingWithInterface.BubbleSorting(array, new ComparerSumByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void BubbleSortingWithInterface_ComparerSumByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            BubbleSortingWithInterface.BubbleSorting(array, new ComparerSumByDec());
            Assert.AreEqual(array, expected);
        }
        #endregion
    }
}
