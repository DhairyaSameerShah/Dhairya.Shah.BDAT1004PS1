// Question 4 : Write a program in C# Sharp to separate odd and even integers in separate arrays.

using System;

namespace DP_ProblemSet_1
{
    class Question_4
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[99];
            int[] array2 = new int[99];
            int[] array3 = new int[99];
            int i, j = 0, k = 0, num;


            Console.WriteLine("Separate Odd and Even Integers \n");
            Console.Write("Input the number of elements to be stored in the array :");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", num);
            for (i = 0; i < num; i++)
            {
                Console.Write("element - {0} : ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < num; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[k] = array1[i];
                    k++;
                }
            }

            Console.WriteLine("\nThe Even elements are :");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine("{0} ", array2[i]);
            }

            Console.WriteLine("\nThe Odd elements are :");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine("{0} ", array3[i]);
            }
        }
    }
}
