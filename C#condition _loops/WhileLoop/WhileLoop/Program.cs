using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# while Loop
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }

            //Exit from the while Loop
            int a = 0;
            while (true)
            {
                Console.WriteLine("a = {0}", a);
                a++;

                if (a > 10) break;
            }

            //Nested while Loop
            int m = 0, n = 1;
            while(m < 2)
            {
                Console.WriteLine("m = {0}", m);
                m++;

                while(n < 2)
                {
                    Console.WriteLine("n = {0}", n);
                    n++;
                }
            }

        }
    }
}
