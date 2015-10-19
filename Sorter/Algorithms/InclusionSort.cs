using System.Collections.Generic;
using MasSortLibrary.AbstractElements;
using MasSortLibrary.SwapAndWrite;

namespace MasSortLibrary.Algorithms
{
    public class InclusionSort<T>:AbstractClass<T> 
    {
        public override void Sort(List<T> mas, IComparer<T> baseOrNewComparator)
        {
            var copyMas = mas;
            for (var i = 1; i < copyMas.Count; i++)
            {
                if (baseOrNewComparator.Compare(copyMas[i],copyMas[i - 1])>=0) continue;
                var j = i;
                do
                {

                    SwapItems.Swap(mas, j, j - 1);

                    j--;
                    if (j == 0) break;
                } while (baseOrNewComparator.Compare(copyMas[j], copyMas[j - 1]) < 0);
            }
        }

        
    }
}
