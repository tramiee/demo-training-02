using System;
using System.Collections.Generic;

namespace CreatingList
{
    class Program
    {
        static void Main(string[] args)
        {
			//Add Arrays in List
			List<int> intList1 = new List<int>();
			intList1.Add(10);
			intList1.Add(20);
			intList1.Add(30);
			intList1.Add(40);

			List<int> intList2 = new List<int>();

			intList2.AddRange(intList1);
			Console.WriteLine(intList2.Count);

			//Accessing List
			List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

			intList.ForEach(el => Console.WriteLine(el));

			foreach (var el in intList)
				Console.WriteLine(el);

			for (int i = 0; i < intList.Count; i++)
				Console.WriteLine(intList[i]);

			//Check Elements in List
			var numbers = new List<int>() { 10, 20, 30, 40 };

			Console.WriteLine(numbers.Contains(10));
			Console.WriteLine(numbers.Contains(11));
			Console.WriteLine(numbers.Contains(20));
		}
    }
}
