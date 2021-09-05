using System;

namespace array_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            Console.WriteLine("enter 5 elements");
            for (int i = 0; i<= 4; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse");
            for (int i = 4; i >=0; i--)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
