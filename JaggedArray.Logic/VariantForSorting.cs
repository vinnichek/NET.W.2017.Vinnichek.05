using System;
namespace JaggedArray.Logic
{
    public class VariantForSorting : IComparer
    {
        private delegate int variantForSorting(int[] lhs, int[] rhs);
        private variantForSorting variant;

        /// <summary>
        /// Ctor with parameter.
        /// </summary>
        /// <param name="comparer">Comparer which method will be contain into delegate.</param>
        public VariantForSorting(IComparer comparer)
        {
            if (ReferenceEquals(comparer, null)) throw new ArgumentNullException($"{nameof(comparer)} is null.");
            variant = comparer.Compare;
        }

        /// <summary>
        /// Call method, which compares two rows of matrix.
        /// </summary>
        /// <param name="lhs">One matrix row.</param>
        /// <param name="rhs">Another matrix row.</param>
        /// <returns>Negative number if left row is less; positive number if greater; 0 if they are equal.</returns>
        public int Compare(int[] lhs, int[] rhs) => variant(lhs, rhs);
    }
}
