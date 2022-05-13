using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and Add Elements
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //Update Hashtable
            var cities = new Hashtable() {{"UK", "London, Manchester, Birmingham"},
                                          {"USA", "Chicago, New York, Washington"},
                                          {"India", "Mumbai, New Delhi, Pune"} };

            string citiesOfUK = (string)cities["UK"];
            string citiesOfUSA = (string)cities["USA"];

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; 
            cities["USA"] = "Los Angeles, Boston";
            if (!cities.ContainsKey("France"))
                cities["France"] = "Paris";

            Console.WriteLine("---After updating values---");
            foreach (DictionaryEntry kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //Remove Elements in Hashtable
            Console.WriteLine("Total Elements: {0}", cities.Count);
            cities.Remove("UK"); 
            Console.WriteLine("Total Elements: {0}", cities.Count);

            if (cities.ContainsKey("France"))
            { 
                cities.Remove("France");
            }
            Console.WriteLine("Total Elements: {0}", cities.Count);
            cities.Clear();
            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
        }
    }
}
