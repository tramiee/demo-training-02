using System;

namespace Do_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //do-while Loop
            int a = 0;
            do
            {
                Console.WriteLine("a = {0}", a);
                a++;
            } while (a < 5);

            //Exit from the do-while Loop
            int b = 0;
            do
            {
                Console.WriteLine("b = {0}", b);
                b++;

                if (b < 5) break;
            } while (b < 10);

            int i = 0;

            //Nested do-while Loop
            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                } while (j < 2);

            } while (i < 2);
        }
    }
}
