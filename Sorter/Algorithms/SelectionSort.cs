using System.Collections.Generic;
using MasSortLibrary.AbstractElements;
using MasSortLibrary.SwapAndWrite;

namespace MasSortLibrary.Algorithms
{
    public class SelectionSort<T>: AbstractClass<T> 
    {
        public override void Sort(List<T> mas, IComparer<T> baseOrNewComparator)
        {
            for (var i = 0; i < mas.Count - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < mas.Count; j++)
                {

                    if (baseOrNewComparator.Compare( mas[j],mas[min])<0)                         
                    {
                        min = j;

                    }                    
                }
                if (min == i) continue;
              SwapItems.Swap(mas, i, min);                
            }                                    
        }                
    }
}
