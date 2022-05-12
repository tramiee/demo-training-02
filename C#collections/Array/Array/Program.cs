using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Access Array Elements using Indexes
            int[] evenNums = new int[5];
            evenNums[0] = 2;
            evenNums[1] = 12;
            evenNums[2] = 23;
            evenNums[3] = 34;
            evenNums[4] = 45;

            Console.WriteLine(evenNums[0]);
            Console.WriteLine(evenNums[1]);
            Console.WriteLine(evenNums[2]);
            Console.WriteLine(evenNums[3]);
            Console.WriteLine(evenNums[4]);

            //Accessing Array Elements using for Loop
            int[] nums = { 2, 4, 6, 8, 10 };
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("After setting values");
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + 10;
                Console.WriteLine(nums[i]);
            }

            //Accessing Array using foreach Loop
            int[] numbers = { 2, 4, 6, 8, 10 };
            string[] cities = { "VietNam", "London", "New York" };
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            foreach(var city in cities)
            {
                Console.WriteLine(city);
            }

            //LINQ Methods
            int[] numbs = new int[5] { 2, 4, 6, 8, 10 };
            Console.WriteLine(numbs.Max());
            Console.WriteLine(numbs.Min());
            Console.WriteLine(numbs.Sum());
            Console.WriteLine(numbs.Average());


            //Passing Array as Argument
            int[] number = { 1, 2, 3, 4, 5 };
            UpdateArray(number);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }
        public static void UpdateArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 10;
            }
        }
    }
}
