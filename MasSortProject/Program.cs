using System;
using System.Collections.Generic;
using System.Diagnostics;
using Sorter.SwapAndWrite;
using Sorter.Algorithms;
using Sorter.OneElementInList;

namespace MasSortProject
{
    class Program
    {
        
        static void Main()
        {
            //Сортировки
            var selSort=new SelectionSort<int>();
            var shakeSort=new ShakerSort<int>();
            var incSort=new InclusionSort<int>();
            var bublSort=new BubbleSort<int>();

            var selSortClass = new SelectionSort<OneElement>();

            var myStopWatch=new Stopwatch();

            //Заполнение массива
            var firstList = new List<int>();
            var r=new Random();

            for (var i = 0; i < 20; i++)
            {
                firstList.Add(r.Next(-100,100));
            }
            var secondList = firstList;
            var thirdList = firstList;
            var fourthList = firstList;
          
            var classList = new List<OneElement>
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

            //Bubble Sort
            myStopWatch.Start();
            bublSort.Sort(firstList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Bubble sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("Time: " + myStopWatch.Elapsed + "\n");

            //Сортировка выбором                          
            myStopWatch.Restart();
            selSort.Sort(secondList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Selection sorting:");
            WriteItems.Write(firstList); 
            Console.WriteLine("Time: "+myStopWatch.Elapsed+"\n");
            

            //Сортировка перемешиванием(разновидность пузырьковой сортировки)                       
            myStopWatch.Restart();
            shakeSort.Sort(thirdList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Shaker sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("Time: " + myStopWatch.Elapsed+"\n");            

            //Сортировка включениями           
            myStopWatch.Restart();
            incSort.Sort(fourthList);
            myStopWatch.Stop();

            Console.WriteLine("Array after Inclusion sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("Time: " + myStopWatch.Elapsed+"\n");
                      
             //Сортировка List<class>                   
            selSortClass.Sort(classList);
                                   
            Console.WriteLine("Array after sorting:");
            WriteItems.Write(classList);             
        }
    }
}
