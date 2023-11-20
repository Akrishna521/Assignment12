using System;

class QuicksortExample
{
    static void Main()
    {
        int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

        Console.WriteLine("Original array: " + string.Join(", ", array));

        Quicksort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));

        if (IsSorted(array))
            Console.WriteLine("Array is sorted correctly.");
        else
            Console.WriteLine("Array is not sorted correctly.");
    }

    static void Quicksort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            Quicksort(array, low, pivotIndex - 1);
            Quicksort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, high);

        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static bool IsSorted(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
                return false;
        }
        return true;
    }
}