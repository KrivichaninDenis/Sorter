using System;
using Sorter.AbstractElements;
using Sorter.SwapAndWrite;

namespace Sorter.Algorithms
{
    public class InclusionSort<T>:AbstractClass<T> where T : IComparable
    {
        protected override void SortAlgorithm()
        {
             var copyMas = Mas;
            for (var i = 1; i < copyMas.Count; i++)
            {
                if (copyMas[i].CompareTo(copyMas[i - 1]) >= 0) continue;
                var j = i;                    
                do
                {
                         
                    SwapItems.Swap(Mas,j, j - 1);
                       
                    j--;                       
                    if (j == 0) break;
                }
                while (copyMas[j].CompareTo(copyMas[j - 1]) < 0);
            }
        }

        
    }
}
