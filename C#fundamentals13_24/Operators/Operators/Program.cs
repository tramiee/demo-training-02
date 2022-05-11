using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = 5 + 3 * 3;
			int b = 5 + 3 * 3 / 2;
			int c = (5 + 3) * 3 / 2;
			int d = (3 * 3) * (3 / 3 + 5);

			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
			Console.WriteLine($"c = {c}");
			Console.WriteLine($"d = {d}");
		}
    }
}
