using System;
using System.Collections.Generic;

namespace MasSortLibrary.Comparator
{
    public class BaseComparator<T>:IComparer<T> where T:IComparable
    {        
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}
