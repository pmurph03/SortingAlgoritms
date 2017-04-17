using System;

namespace SortingExamples
{
    class Program
    {
    //    private int[] integerArray;
        private static bool bubbleSortedExample = false;
        static void Main(string[] args)
        {
            if (!bubbleSortedExample)
            {
                BubbleSortInt bubbleSorter = new BubbleSortInt();
                int[] array = new int[10] { 8, 4, 2, 7, 5, 1, 2, 7, 4, 2 };
                IntegerConsolePrinter consolePrinter = new IntegerConsolePrinter();
                Console.WriteLine("Start Bubble Sort");
                consolePrinter.PrintIntegerArray(array);
                array = bubbleSorter.BubbleSortIntArray(array);
                bubbleSortedExample = true;
                Console.WriteLine("Bubble Sort Complete.");
                Console.WriteLine("");
                Console.WriteLine("Begin Selection Sort");
                array = new int[10] { 8, 4, 2, 7, 5, 1, 2, 7, 4, 2 };
                consolePrinter.PrintIntegerArray(array);
                SelectionSortInt selectionSorter = new SelectionSortInt();
                array = selectionSorter.SelectionSort(array);
                Console.WriteLine("Selection Sort Complete.");
                Console.WriteLine("");
                Console.WriteLine("Begin Insertion Sort");
                array = new int[10] { 8, 4, 2, 7, 5, 1, 2, 7, 4, 2 };
                consolePrinter.PrintIntegerArray(array);
                InsertionSortInt insertionSorter = new InsertionSortInt();
                array = insertionSorter.InsertionSort(array);
                Console.WriteLine("Insertion Sort Complete.");
                Console.ReadLine();
            }
        }

   
    }
}
