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
                Console.WriteLine("BubbleSort Complete.");
                Console.ReadLine();
            }
        }

   
    }
}
