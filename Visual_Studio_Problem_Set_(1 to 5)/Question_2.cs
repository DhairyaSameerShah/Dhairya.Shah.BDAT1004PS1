// Question 2: Write (and evaluate) C# expressions that answer these questions:
// 2 (a) : How many letters are there in 'Supercalifragilisticexpialidocious'?
// 2 (b) : Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring ?
// 2 (c) : Which of the following words is the longest: Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or
// Bababadalgharaghtakamminarronnkonn?
// 2 (d) : Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian', 'Bartok', 'Bellini', 'Buxtehude',
// 'Bernstein'. Which one comes last?


using System;

namespace DP_ProblemSet_1
{
    class Question_2
    {
        static void Main(string[] args)
        {
            // Part a: How many letters are there in 'Supercalifragilisticexpialidocious'?

            string str1 = "Supercalifragilisticexpialidocious";
            string str2 = "Honorificabilitudinitatibus";
            string str3 = "Bababadalgharaghtakamminarronnkonn";

            Console.WriteLine("String 1: " + str1);
            Console.WriteLine("String 2: " + str2);
            Console.WriteLine("String 3: " + str3);

            Console.WriteLine("\n");
            Console.WriteLine("<---------------------------------------- Answer 2.A -------------------------------------->");
            
            // length of string
            Console.WriteLine("Length of '" + str1 + "' is: " + str1.Length);


            // Part b: Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring?

            Console.WriteLine("\n");
            Console.WriteLine("<---------------------------------------- Answer 2.B -------------------------------------->");
            String substring = "ice";
            Boolean result = str1.Contains(substring);
            Console.WriteLine("Does '{0}' contain '{1}' as a substring ? {2}", str1, substring, result);


            // Part c: Which of the following words is the longest:
            // Supercalifragilisticexpialidocious, Honorificabilitudinitatibus, or Bababadalgharaghtakamminarronnkonn ?

            Console.WriteLine("\n");
            Console.WriteLine("<---------------------------------------- Answer 2.C -------------------------------------->");
            if (str1.Length >= str2.Length)
            {
                if (str1.Length >= str3.Length)
                {
                    Console.WriteLine(str1 + " and " + str3 + " are equal in length !");
                }
                else if (str1.Length >= str3.Length)
                {
                    Console.WriteLine(str1 + " is greater in length than " + str3);
                }
                else
                {
                    Console.WriteLine(str1 + " is not equal or greater in length than " + str3);
                }
            }
            else if (str2.Length >= str3.Length)
            {
                Console.WriteLine(str2 + " and " + str3 + " are equal in length !");
            }
            else if (str1.Length >= str3.Length)
            {
                Console.WriteLine(str2 + " is greater in length than " + str3);
            }
            else
            {
                Console.WriteLine(str2 + " is not equal or greater in length than " + str3);
            }


            // Part d: Which composer comes first in the dictionary: 'Berlioz', 'Borodin', 'Brian', 'Bartok', 'Bellini',
            // 'Buxtehude', 'Bernstein'. Which one comes last ?

            Console.WriteLine("\n");
            Console.WriteLine("<---------------------------------------- Answer 2.D -------------------------------------->");
            string[] words = new string[7] { "Berlioz", "Borodin", "Brian", "Bartok", "Bellini", "Buxtehude", "Bernstein" };
            
            // sorting 
            Array.Sort(words);                                                                 
            Console.WriteLine("First word in the dictionary is '{0}'", words[0]);
            Console.WriteLine("Last word in the dictionary is '{0}'", words[6]);
            Console.WriteLine("\n");
        }
    }
}
