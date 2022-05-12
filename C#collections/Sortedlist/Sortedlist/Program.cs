using System;
using System.Collections.Generic;

namespace Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            Console.WriteLine("---NumberNames---");
            foreach (var kvp in numberNames)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);

            SortedList<string, string> cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Johannesburg", "South Africa"}
                                    };
            Console.WriteLine("---Cities---");
            foreach (var kvp in cities)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
        }
    }
}
