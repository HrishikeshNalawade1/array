using System;

namespace array_6
{
    class arr
    {
        public void array()
        {
            int[] array_1 = new int[100];
            int[] array_2 = new int[100];
            int[] array_3 = new int[100];
            int mm = 1;
            int ctr = 0;

            Console.WriteLine("enter size of array");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                array_1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < s; i++)
            {
                array_2[i]= array_1[i];
                array_3[i] = 0;
            }

            Console.WriteLine("lets check Duplicate elements");


            for (int i = 0; i < s; i++)
            {

                for (int j = 0; j < s; j++)
                {
                    if (array_1[i] == array_2[j])
                    {
                        array_3[j] = mm;
                        mm++;
                    }                   
                }
                mm = 1;
            }

                for (int i = 0; i < s; i++)
                {
                    if(array_3[i]==2)
                    {
                        ctr++;
                    }
                }
            Console.WriteLine("number of duplicate elements in array_1 are {0} ",ctr);
        }
    }
    class Program6
    {
        static void Main(string[] args)
        {
            arr a = new arr();
            a.array();
        }
    }
}
