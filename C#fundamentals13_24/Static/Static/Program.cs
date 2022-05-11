using System;

namespace Static
{
    public static class Calculator
    {
        private static int _resultStorage = 0;
        public static string Type = "Arithmetic";
        public static int Sum (int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator.Sum(10, 25);
            Calculator.Store(result);
            Console.WriteLine(result);

            var calcType = Calculator.Type;
            Calculator.Type = "Scientific";
        }
    }
}
