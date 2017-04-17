namespace SortingExamples
{
    class SelectionSortInt
    {
        /// <summary>
        /// Sorts an integer array using selection sort, assumes non-empty array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Sorted array of int smallest to largest.</returns>
        public int[] SelectionSort(int[] array)
        {
            IntegerConsolePrinter consolePrinter = new IntegerConsolePrinter();
            for (int i = 0; i < array.Length-1; i++)
            {
                int lowestIndex = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[lowestIndex] > array[j])
                    {
                        lowestIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[lowestIndex];
                array[lowestIndex] = temp;
                consolePrinter.PrintIntegerArray(array);
            }
            return array;
        }

    }
}
