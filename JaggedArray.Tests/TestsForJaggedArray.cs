﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections;
using static JaggedArray.Logic.BubbleSortingForJaggedArray;

namespace JaggedArray.Tests
{
    [TestFixture]
    public class TestsForJaggedArray
    {
        [Test]
        public void ComparerSumByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            ArrayHelper.BubbleSorting(array, new ComparerSumByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerSumByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            ArrayHelper.BubbleSorting(array, new ComparerSumByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMaxByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 5 }, new int[] { 7 }, new int[] { 1, 3, 8 } };
            ArrayHelper.BubbleSorting(array, new ComparerMaxByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMaxByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            ArrayHelper.BubbleSorting(array, new ComparerMaxByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByInc_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 1, 3, 8 }, new int[] { 5 }, new int[] { 7 } };
            ArrayHelper.BubbleSorting(array, new ComparerMinByInc());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByDec_CorrectValues()
        {
            int[][] array = { new int[] { 1, 3, 8 }, new int[] { 7 }, new int[] { 5 } };
            int[][] expected = { new int[] { 7 }, new int[] { 5 }, new int[] { 1, 3, 8 } };
            ArrayHelper.BubbleSorting(array, new ComparerMinByDec());
            Assert.AreEqual(array, expected);
        }

        [Test]
        public void ComparerMinByDec_NullJaggedArray_ThrowArgumentNullException()
        {
            int[][] arr = null;
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.BubbleSorting(arr, new ComparerMinByDec()));
        }

        [Test]
        public void ComparerMinByDec_EmptyJaggedArray_ThrowArgumentNullException()
        {
            int[][] arr = new int[][] { };
            Assert.Throws<ArgumentException>(() => ArrayHelper.BubbleSorting(arr, new ComparerMinByDec()));
        }
    }
}