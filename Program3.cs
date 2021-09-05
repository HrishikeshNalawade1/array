using System;

namespace array_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[3];
            Console.WriteLine("Enter 3 elements");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
