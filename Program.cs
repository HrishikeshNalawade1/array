using System;

namespace array_8
{
    class arr
    {
        public void Array()
        {
            int[] array_1 = new int[100];
            int[] array_2 = new int[100];
            int[] array_3 = new int[200];
            int s3,i,j;
            Console.WriteLine("Enter size of array");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements", s1);
            for (i = 0; i < s1; i++)
            {
                array_1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter size of array");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements", s2);
            for ( i = 0; i < s2; i++)
            {
                array_2[i] = Convert.ToInt32(Console.ReadLine());
            }
            s3 = s1 + s2;
            for ( i = 0; i < s1; i++)
            {
                array_3[i] = array_1[i];
            }
            for ( j = 0; j < s2; j++)
            {
                array_3[i] = array_2[j];
                i++;
            }

            for ( i = 0; i < s3; i++)
            {
                Console.WriteLine(array_3[i]);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                arr a = new arr();
                a.Array();
                //still have to do ascending order
            }
        }
    }
}
