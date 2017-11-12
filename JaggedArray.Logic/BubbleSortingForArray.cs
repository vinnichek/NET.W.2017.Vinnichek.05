using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Logic
{
    public class BubbleSortingForArray
    {
        #region Public Methods

        /// <summary>
        /// Sort jagged array using bubble sorting by different criteria.
        /// </summary>
        /// <param name="jaggedArray">Jagged array.</param>
        /// <param name="comparer">Selected class of sorting among suitable.</param>
        public static void BubbleSorting(int[][] jaggedArray, IComparer comparer)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentNullException(nameof(jaggedArray));
            }
            for (int i = 1; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1; j++)
                {
                    if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }
        #endregion

        #region Private Methods
        private static void Swap<T>(ref T i, ref T j)
        {
            T temp = i;
            i = j;
            j = temp;
        }
        #endregion
    }
}
