using System.Collections.Generic;
using MasSortLibrary.OneElementInList;

namespace MasSortLibrary.Comparator
{
    public class NewComparator<T> :IComparer<T> where T: OneElement
    {
        public int Compare(T x, T y)
        {
            if (x.IntValue < y.IntValue) return -1;
            return x.IntValue > y.IntValue ? 1 : 0;
        }
    }
}
