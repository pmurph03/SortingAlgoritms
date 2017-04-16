using System;

namespace SortingExamples
{
    class IntegerConsolePrinter
    {
        public void PrintIntegerArray(int[] intArray)
        {
            string stringToPrint = "";
            for (int i = 0; i < intArray.Length; ++i)
            {
                stringToPrint += intArray[i] + ",";
            }
            Console.WriteLine(stringToPrint);
        }
    }
}
