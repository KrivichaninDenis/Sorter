using System.Collections.Generic;
using MasSortLibrary.AbstractElements;
using MasSortLibrary.SwapAndWrite;

namespace MasSortLibrary.Algorithms
{
    public class ShakerSort<T> : AbstractClass<T> 
    {
        public override void Sort(List<T> mas, IComparer<T> baseOrNewComparator)
        {           
            var left = 0;
            var right = mas.Count - 1;
            var flag = false;

            while (!flag)
            {
                flag = true;

                for (var i = left; i < right; i++)
                {
                    if (baseOrNewComparator.Compare(mas[i], mas[i + 1])<=0) {continue;}
                    SwapItems.Swap(mas, i + 1, i);                    
                    flag = false;
                }

                right--;

                for (var i = right; i >= left; i--)
                {
                    if (baseOrNewComparator.Compare(mas[i + 1],mas[i]) >= 0) {continue;}
                    SwapItems.Swap(mas, i + 1, i);                   
                    flag = false;
                }

                left++;
            }
        }        
    }
}
