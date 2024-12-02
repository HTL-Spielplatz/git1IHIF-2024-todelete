using System;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop
            Console.WriteLine("For loop:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            // While loop
            Console.WriteLine("\nWhile loop:");
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine($"Iteration {j}");
                j++;
            }

            // Do-while loop
            Console.WriteLine("\nDo-while loop:");
            int k = 0;
            do
            {
                Console.WriteLine($"Iteration {k}");
                k++;
            } while (k < 5);

            // Foreach loop
            Console.WriteLine("\nForeach loop:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
}