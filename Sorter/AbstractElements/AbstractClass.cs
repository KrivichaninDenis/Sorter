using System.Collections.Generic;

namespace MasSortLibrary.AbstractElements
{
    public  abstract class AbstractClass<T>
    {
        public abstract void Sort(List<T> someArray,IComparer<T> baseOrNewComparator);
    }
}
