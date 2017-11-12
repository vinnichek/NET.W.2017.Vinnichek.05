using System;
using System.Linq;
using JaggedArray.Logic;

namespace JaggedArray.Tests
{
    public class Comparers
    {
        /// <summary>
        /// In the order of increasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if sum of the next row is greater, positive number if less, and 0 if sums are equal.</returns>
        public class ComparerSumByInc : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return 1;
                }
                if (rhs == null)
                {
                    return -1;
                }
                return lhs.Sum() - rhs.Sum();
            }
        }

        /// <summary>
        /// In the order of increasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if sum of the next row is greater, positive number if less, and 0 if sums are equal.</returns>
        public class ComparerSumByDec : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return -1;
                }
                if (rhs == null)
                {
                    return 1;
                }
                return rhs.Sum() - lhs.Sum();
            }
        }

        /// <summary>
        /// In the order of increasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if sum of the next row is greater, positive number if less, and 0 if sums are equal.</returns>
        public class ComparerMaxByInc : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return 1;
                }
                if (rhs == null)
                {
                    return -1;
                }
                return lhs.Max() - rhs.Max();
            }
        }

        /// <summary>
        /// In the order of increasing sums of elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if sum of the next row is greater, positive number if less, and 0 if sums are equal.</returns>
        public class ComparerMaxByDec : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return -1;
                }
                if (rhs == null)
                {
                    return 1;
                }
                return rhs.Max() - lhs.Max();
            }
        }

        /// <summary>
        /// In the order of increasing min elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if min element of the next row is greater, positive number if less, and 0 if max elements are equal.</returns>
        public class ComparerMinByInc : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return 1;
                }
                if (rhs == null)
                {
                    return -1;
                }
                return lhs.Min() - rhs.Min();
            }
        }

        /// <summary>
        /// In the order of increasing min elements of rows in matrix.
        /// </summary>
        /// <param name="lhs">One row of matrix.</param>
        /// <param name="rhs">Another row of matrix.</param>
        /// <returns>Negative number if min element of the next row is greater, positive number if less, and 0 if max elements are equal.</returns>
        public class ComparerMinByDec : IComparer
        {
            public int Compare(int[] lhs, int[] rhs)
            {
                if (lhs == null)
                {
                    return 1;
                }
                if (rhs == null)
                {
                    return -1;
                }
                return rhs.Min() - lhs.Min();
            }
        }
    }
}
