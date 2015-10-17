using System;
using Sorter.AbstractElements;
using Sorter.SwapAndWrite;

namespace Sorter.Algorithms
{
    class BubbleSort<T> : AbstractClass<T> where T : IComparable
    {
        protected override void SortAlgorithm()
        {
            for (var i = 0; i < Mas.Count-1; i++)
            {
                for(var j=0;j<Mas.Count-i-1;j++)
                {
                    if (Mas[j].CompareTo(Mas[j + 1]) > 0)
                    {
                        SwapItems.Swap(Mas,j,j+1);
                    }
                }
            }
        }
    }
}
