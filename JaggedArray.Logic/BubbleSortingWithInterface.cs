using System;
namespace JaggedArray.Logic
{
    public class BubbleSortingWithInterface
    {
        #region Public Methods

        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="jaggedArray">Jagged array.</param>
        /// <param name="icomparer">Class of sorting among suitable.</param>
        public static void BubbleSorting(int[][] jaggedArray, IComparer icomparer)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentNullException(nameof(jaggedArray));
            }

            for (int i = 1; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1; j++)
                {
                    if (icomparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="array">Jagged array.</param>
        /// <param name="variantForSorting">Delegate.</param>
        public static void BubbleSorting(int[][] array, VariantForSorting variantForSorting)
        {
            BubbleSorting(array, (IComparer)variantForSorting);
        }

        #endregion

        #region Private Methods
        private static void Swap<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }

        private static void CheckArrayRows(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, null)) throw new ArgumentNullException($"{nameof(lhs)} is null.");
            if (ReferenceEquals(rhs, null)) throw new ArgumentNullException($"{nameof(rhs)} is null.");
        }
        #endregion
    }
}
