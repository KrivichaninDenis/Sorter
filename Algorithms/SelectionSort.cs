using System;
using Sorter.AbstractElements;
using Sorter.SwapAndWrite;


namespace Sorter.SortingType
{
    class SelectionSort<T>: AbstractClass<T> where T:IComparable
    {
        protected override void SortAlgorithm()
        {
            for (var i = 0; i < Mas.Count - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < Mas.Count; j++)
                {

                    if (Mas[j].CompareTo(Mas[min]) < 0)
                    {
                        min = j;

                    }                    
                }
                if (min == i) continue;
              SwapItems.Swap(Mas, i, min);                
            }                                    
        }                
    }
}
