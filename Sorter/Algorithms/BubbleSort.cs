using System.Collections.Generic;
using MasSortLibrary.AbstractElements;
using MasSortLibrary.SwapAndWrite;

namespace MasSortLibrary.Algorithms
{
    public class BubbleSort<T> : AbstractClass<T> 
    {
        public override void Sort(List<T> mas, IComparer<T> baseOrNewComparator)
        {
            for (var i = 0; i < mas.Count-1; i++)
            {
                for(var j=0;j<mas.Count-i-1;j++)
                {
                    if (baseOrNewComparator.Compare(mas[j],mas[j + 1])>0)                                                
                    {
                        SwapItems.Swap(mas,j,j+1);
                    }
                }
            }
        }
    }
}
