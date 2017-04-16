namespace SortingExamples
{
    class BubbleSortInt
    {
        public int[] BubbleSortIntArray(int[] array)
        {
            IntegerConsolePrinter consolePrinter = new IntegerConsolePrinter();
            for (int i = 0; i < array.Length; ++i)
            {
                bool swappedInts = false;
                for (int j = 0; j < array.Length - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        swappedInts = true;
                    }
                }
                consolePrinter.PrintIntegerArray(array);
                if (!swappedInts)
                {
                    break;
                }
            }
            return array;

        }
    }

    
}
