using System;

namespace CreateTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accessing Tuple Elements
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); 
            Console.WriteLine(person.Item2); 
            Console.WriteLine(person.Item3);

            var nums = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(nums.Item1); 
            Console.WriteLine(nums.Item2); 
            Console.WriteLine(nums.Item3); 
            Console.WriteLine(nums.Item4); 
            Console.WriteLine(nums.Item5); 
            Console.WriteLine(nums.Item6); 
            Console.WriteLine(nums.Item7); 
            Console.WriteLine(nums.Rest); 
            Console.WriteLine(nums.Rest.Item1);

            //Nested Tuple
            var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);

            Console.WriteLine(numbers.Item1); 
            Console.WriteLine(numbers.Item2); 
            Console.WriteLine(numbers.Item3); 
            Console.WriteLine(numbers.Item3.Item1); 
            Console.WriteLine(numbers.Item4); 
            Console.WriteLine(numbers.Rest.Item1); 
        }
    }
}
