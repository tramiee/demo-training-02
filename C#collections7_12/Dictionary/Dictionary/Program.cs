using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Dictionary and Add Elements
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //Access Dictionary Elements
            var cities = new Dictionary<string, string>() { {"UK", "London, Manchester, Birmingham"},
                                                            {"USA", "Chicago, New York, Washington"},
                                                            {"India", "Mumbai, New Delhi, Pune"}};
            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["USA"]);

            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }
            else
            {
                Console.WriteLine("No France");
            }

            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            for(int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }

            //Update Dictionary Elements
            cities["UK"] = "Liverpool, Bristol";
            cities["USA"] = "Los Angeles, Boston";

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //Remove Dictionary Elements
            Console.WriteLine("Total Elements: {0}", cities.Count);
            cities.Remove("UK");
            Console.WriteLine("Total Elements: {0}", cities.Count);
            cities.Clear();
            Console.WriteLine("Total Elements after Clear: {0}", cities.Count);
        }
    }
}
