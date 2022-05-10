using System;
using System.Collections.Generic;
using System.IO;

namespace Implicitly_TypedVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine(i.GetType());

            var name = "Tra My";
            Console.WriteLine(name.GetType());

            var dbl = 10.50d;
            Console.WriteLine(dbl.GetType());

            var isValid = true;
            Console.WriteLine(isValid.GetType());

            var ano = new { name = "My" };
            Console.WriteLine(ano.GetType());

            var arr = new[] { 1, 2, 3, 4 };
            Console.WriteLine(arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine(file.GetType());
        }
    }
}
