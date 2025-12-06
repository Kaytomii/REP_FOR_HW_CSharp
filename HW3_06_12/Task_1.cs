namespace HW3_06_12;

internal class Task_1
{
    static int[] Sort_Array(int[] original_array, int[] sorting_array)
    {
        byte count = 0;
        int[] sorted_array = new int[original_array.Length];

        for (int i = 0; i < original_array.Length; i++)
        {
            bool toRemove = false;

            for (int j = 0; j < sorting_array.Length; j++)
            {
                if (original_array[i] == sorting_array[j])
                {
                    toRemove = true;
                    break;
                }
            }

            if (!toRemove)
            {
                sorted_array[count] = original_array[i];
                count++;
            }
        }

        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = sorted_array[i];
        }

        return result;
    }
        static void Main(string[] args)
    {
        int[] arr_1 = { 1, 2, 6, -1, 88, 7, 6 };
        int[] sort_arr = { 6, 88, 7 };

        int[] filtered = Sort_Array(arr_1, sort_arr);

        Console.WriteLine("Original Array: ");

        for (int i = 0; i < arr_1.Length; ++i)
        {
            Console.Write(arr_1[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Array after sorting: ");
        for (int i = 0; i < filtered.Length;i++)
        {
            Console.Write(filtered[i] + " ");
        }
    }
}
