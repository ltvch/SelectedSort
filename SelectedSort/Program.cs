using System;

namespace SelectedSort
{
    class Program
    {
        static void SelectedSort(int[] array)
        {
            int min, temp;
            
            for(int i = 0; i<array.Length - 1;i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[min])
                        min = j;

                //swap the values
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
