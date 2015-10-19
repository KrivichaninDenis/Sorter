using System;
using System.Collections.Generic;
using System.Diagnostics;
using MasSortLibrary.Algorithms;
using MasSortLibrary.OneElementInList;
using MasSortLibrary.SwapAndWrite;
using MasSortLibrary.Comparator;

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
            var firstList = new List<int>{15,7,3,22,8,9,8,31,1,0,99,521};
            
            var secondList = firstList;
            var thirdList = firstList;
            var fourthList = firstList;
          
            var classList = new List<OneElement>
            {                
                new OneElement(5),
                new OneElement(4),
                new OneElement(3),
                new OneElement(2),
                new OneElement(1)
            };

            //Create two comparator
            var baseComp=new BaseComparator<int>();
            var classComp = new NewComparator<OneElement>();

            Console.WriteLine("Array before sorting:");
            WriteItems.Write(firstList);
            Console.WriteLine("\n");

            //Bubble Sort
            myStopWatch.Start();
            bublSort.Sort(firstList,baseComp);
            myStopWatch.Stop();
            OutTime("Bubble",myStopWatch,firstList);
           

            //Сортировка выбором                          
            myStopWatch.Restart();
            selSort.Sort(secondList,baseComp);
            myStopWatch.Stop();            
            OutTime("Selection", myStopWatch, secondList);

            //Сортировка перемешиванием(разновидность пузырьковой сортировки)                       
            myStopWatch.Restart();
            shakeSort.Sort(thirdList,baseComp);
            myStopWatch.Stop();            
            OutTime("Shaker", myStopWatch, thirdList);


            //Сортировка включениями           
            myStopWatch.Restart();
            incSort.Sort(fourthList,baseComp);
            myStopWatch.Stop();           
            OutTime("Inclusion", myStopWatch, fourthList);          

             //Сортировка List<class>                   
            selSortClass.Sort(classList,classComp);                                              
            OutTime("Class", myStopWatch, classList);        
        }

        public static void OutTime<T>(string typeSort, Stopwatch stWatch,List<T> list )
        {
            Console.WriteLine("Array after "+typeSort+" sorting:");
            WriteItems.Write(list);
            Console.WriteLine("Time: " + stWatch.Elapsed + "\n");
        }
    }
}
