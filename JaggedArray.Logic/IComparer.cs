using System;
namespace JaggedArray.Logic
{
    public interface IComparer
    {
        int Compare(int[] lhs, int[] rhs);
    }
}
