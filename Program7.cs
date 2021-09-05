using System;

namespace array_7
{
    class array
    {
        public void array7()
        {
            int[] array_1 = new int[100];
            int[] array_2 = new int[100];
            int ctr = 0;

            Console.WriteLine("Enter size of array");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} element",s);
            for (int i = 0; i < s; i++)
            {
                array_1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < s; i++)
            {
                array_2[i] = array_1[i];
            }

            for (int i = 0; i < s; i++)
            {
                ctr = 0;
                for (int j = 0; j < s; j++)
                {
                    if(array_1[i]==array_2[j])
                    {
                        ctr++;
                    }                   
                }
                if (ctr == 1)
                {
                    Console.WriteLine("Unique element are {0}", array_1[i]);
                }
            }
            
        }
    }
    class Program7
    {
        static void Main(string[] args)
        {
            array a = new array();
            a.array7();
        }
    }
}
