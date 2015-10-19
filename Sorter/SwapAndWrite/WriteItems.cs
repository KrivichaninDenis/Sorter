using System;
using System.Collections.Generic;

namespace MasSortLibrary.SwapAndWrite
{
    public  class WriteItems
    {
        public static void Write<T>(List<T> list)
        {            
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
