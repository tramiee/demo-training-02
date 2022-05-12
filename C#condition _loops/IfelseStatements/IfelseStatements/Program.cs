using System;

namespace IfelseStatements
{
    class Program
    {
		static bool isGreater(int i, int j)
		{
			return i > j;
		}
		static void Main(string[] args)
        {
			// if Statement
			int i = 10, j = 20;
			if (i > j)
			{
				Console.WriteLine("i is greater than j");
			}

			if (i < j)
			{
				Console.WriteLine("i is less than j");
			}

			if (i == j)
			{
				Console.WriteLine("i is equal to j");
			}

			//Calling Function as Condition
			int a = 10, b = 20;
			if (isGreater(a, b))
			{
				Console.WriteLine("a is less than b");
			}

			if (isGreater(b, a))
			{
				Console.WriteLine("b is greater than b=a");
			}

			//else if Statements
			int c = 10, d = 20;
			if (c == d)
			{
				Console.WriteLine("c is equal to d");
			}
			else if (c > d)
			{
				Console.WriteLine("c is greater than d");
			}
			else if (c < d)
			{
				Console.WriteLine("c is less than d");
			}
		}
    }
}
