using System.Collections.Generic;
using System.Linq;

namespace Sorter.AbstractElements
{
    abstract class AbstractClass<T> 
    {
        protected List<T>Mas { get; set; }

        public List<T> Sort(List<T> someArray )
        {
            Mas = someArray;
            SortAlgorithm();
            return Mas.ToList();
        }

        protected abstract void SortAlgorithm();


        
    }
}
