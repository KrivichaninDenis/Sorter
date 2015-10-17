using System;
using Sorter.AbstractElements;
using Sorter.SwapAndWrite;

namespace Sorter.SortingType
{
    class ShakerSort<T> : AbstractClass<T> where T : IComparable
    {
        protected override void SortAlgorithm()
        {           
            var left = 0;
            var right = Mas.Count - 1;
            var flag = false;

            while (!flag)
            {
                flag = true;

                for (var i = left; i < right; i++)
                {
                    if (Mas[i].CompareTo(Mas[i + 1]) <=0 ) {continue;}
                    SwapItems.Swap(Mas, i + 1, i);                    
                    flag = false;
                }

                right--;

                for (var i = right; i >= left; i--)
                {
                    if (Mas[i + 1].CompareTo(Mas[i]) >= 0 ) {continue;}
                    SwapItems.Swap(Mas, i + 1, i);                   
                    flag = false;
                }

                left++;
            }
        }        
    }
}
