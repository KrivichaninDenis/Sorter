using System;
using System.Collections.Generic;
using System.Diagnostics;
using Sorter.SortingType;
using Sorter.SwapAndWrite;

namespace Sorter
{
    class Program
    {
        
        static void Main()
        {
            var selSort=new SelectionSort<int>();
            var shakeSort=new ShakerSort<int>();
            var incSort=new InclusionSort<int>();

            var selSortClass = new SelectionSort<OneElement>();

            var myStopWatch=new Stopwatch();

            var firstList = new List<int>();
            var r=new Random();

            for (int i = 0; i < 20; i++)
            {
                firstList.Add(r.Next(-100,100));
            }

            var secondList = new List<OneElement>
            {
                new OneElement(9),
                new OneElement(8),
                new OneElement(7),
                new OneElement(6),
                new OneElement(5),
                new OneElement(4),
                new OneElement(3),
                new OneElement(2),
                new OneElement(1)
            };

            Console.WriteLine("Array before sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("\n");

            //Сортировка выбором                          
            myStopWatch.Start();
            selSort.Sort(firstList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Selection sorting:");
            WriteItems.Write(firstList); 
            Console.WriteLine("Time: "+myStopWatch.Elapsed+"\n");
            

            //Сортировка перемешиванием(разновидность пузырьковой сортировки)                       
            myStopWatch.Restart();
            shakeSort.Sort(firstList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Shaker sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("Time: " + myStopWatch.Elapsed+"\n");
            

            //Сортировка включениями           
            myStopWatch.Restart();
            incSort.Sort(firstList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Inclusion sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("Time: " + myStopWatch.Elapsed+"\n");
          

            
             //Сортировка List<class>                   
            selSortClass.Sort(secondList);
                                   
            Console.WriteLine("Array after sorting:");
            WriteItems.Write(secondList);
             
        }
    }
}
