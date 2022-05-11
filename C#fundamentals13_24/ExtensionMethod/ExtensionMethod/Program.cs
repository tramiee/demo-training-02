using System;

namespace ExtensionMethod
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine("Result: {0}", result);
        }
    }
}
