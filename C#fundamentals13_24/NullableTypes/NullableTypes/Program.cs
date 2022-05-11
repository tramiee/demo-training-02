using System;

namespace NullableTypes
{
    class MyClass
    {
        public Nullable<int> i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //HasValue
            Nullable<int> a = null;
            if (a.HasValue)
                Console.WriteLine(a.Value); 
            else
                Console.WriteLine("Null");

            //GetValueOrDefault()
            Nullable<int> b = null;
            Console.WriteLine(b.GetValueOrDefault());

            //Shorthand Syntax for Nullable Types
            int? c = null;
            int d = c ?? 0;
            Console.WriteLine(d);

            //Nullable type as Class Field
            MyClass mycls = new MyClass();
            if (mycls.i == null)
                Console.WriteLine("Null");

            //Nullable Type Comparison
            int? m = null;
            int n = 10;
            if (m < n)
                Console.WriteLine("m < n");
            else if (m > 10)
                Console.WriteLine("m > n");
            else if (m == 10)
                Console.WriteLine("m == n");
            else
                Console.WriteLine("Could not compare");

            //Helper Class
            int? i = null;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");
        }
    }
}
