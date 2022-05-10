using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "My";

            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(name);

            int i = 100;
            int j = i + 20;
            Console.WriteLine("j = {0}", j);

            i = 200;
            j = i + 20;
            Console.WriteLine("j = {0}", j);

            i = 300;
            Console.WriteLine("j = {0}", j);
        }
    }
}
