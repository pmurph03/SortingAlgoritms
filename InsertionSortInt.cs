namespace SortingExamples
{
    class InsertionSortInt
    {
        public int[] InsertionSort(int[] array)
        {
            IntegerConsolePrinter consolePrinter = new IntegerConsolePrinter();
            for (int i = 1; i < array.Length; i++)
            {
                int currentIndex = i;
                for (int j = i-1; j >= 0; j--)
                {
                    if (array[j] > array[currentIndex])
                    {
                        int temp = array[j];
                        array[j] = array[currentIndex];
                        array[currentIndex] = temp;
                        currentIndex -= 1;
                    }
                    else if (array[j] <= array[currentIndex])
                    {
                        break;
                    }
                }
                consolePrinter.PrintIntegerArray(array);
            }
            return array;
        }
    }
}
