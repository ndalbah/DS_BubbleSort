using System;
namespace bubbleSort
{
	public class Sort
	{
        //ascending sort
        public static void Bubble_Sort_Ascending(int[] array)
		{

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j);
                    }
                }
            }
        }

        //descending sort
        public static void Bubble_Sort_Descending(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        Swap(array, j);
                    }
                }
            }
        }

        //swap
        private static void Swap(int[] array, int j)
        {
            int temp = array[j];
            array[j] = array[j+1];
            array[j+1] = temp;
        }


        //display
        public static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(" , ");
                }
            }
        }
    }
}

