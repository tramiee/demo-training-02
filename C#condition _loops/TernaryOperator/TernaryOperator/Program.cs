using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nested Ternary Operator
            int a = 10, b = 100;

            string result = a > b ? "x is greater than y"
                                    : a < b ? "x is less than y"
                                        : a == b ? "x is equal to y" : "No result";
            Console.WriteLine(result);

            //
            int x = 5, y = 10, z = 15;
            int results = x * 3 > y ? x : y > z ? y : z;
            Console.WriteLine(results);
        }
    }
}
