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
                for (int j = 0; j < array.Length -1 -i; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                        swappedInts = true;
                    }
                }
                if (!swappedInts)
                {
                    break;
                }
                consolePrinter.PrintIntegerArray(array);
            }
            return array;

        }
    }

    
}
