using System.Collections.Generic;

namespace Sorter.SwapAndWrite
{
    public  class SwapItems
    {
        public static void Swap<T>(List<T> mas, int index1, int index2)
        {            
            var value = mas[index1];
            mas[index1] = mas[index2];
            mas[index2] = value;
        }
    }
}
