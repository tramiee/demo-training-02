using System;

namespace Keywords
{
    public class @class
    {
        public static int MyProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            @class.MyProperty = 100;
            Console.WriteLine(@class.MyProperty);
        }
    }
}
