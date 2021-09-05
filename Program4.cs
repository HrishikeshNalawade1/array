using System;

namespace array_4
{
    class Program4
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int[] array1 = new int[100];
            Console.WriteLine("Enter size of array");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < s; i++)
            {
                array1[i] = array[i];
            }
            Console.WriteLine("copied element from array to array1 are ");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }
}
