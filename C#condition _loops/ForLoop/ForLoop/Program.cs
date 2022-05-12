using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exit the for Loop
            for (int a = 0; a < 10; a++)
            {
                if (a == 5)
                    break;
                Console.WriteLine("Value of a: {0}", a);
            }

            //Multiple Expressions
            for (int b = 0, c = 0; b + c < 5; b++, c++)
            {
                Console.WriteLine("Value of b: {0}, J: {1} ", b, c);
            }

            //Initializer and Iterator Statements
            int m = 0, n = 5;
            for (Console.WriteLine($"Initializer: m={m}, n={n}");
                 m++ < n--;
                 Console.WriteLine($"Iterator: m={m}, n={n}"))
            {
            }

            //Nested for Loop
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }

        }
    }
}
