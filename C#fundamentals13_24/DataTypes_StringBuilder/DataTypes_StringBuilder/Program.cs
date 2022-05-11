using System;
using System.Text;

namespace DataTypes_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder Iteration
            StringBuilder sb = new StringBuilder("Hello World!");
            for (int i = 0; i < sb.Length; i++)
            {
                Console.Write(sb[i]);
            }

            Console.WriteLine();

            // Adding or Appending Strings in StringBuilder
            StringBuilder sb1 = new StringBuilder("Hello ", 50);
            sb1.Append("World!");
            sb1.AppendLine(" Hello C#!");
            sb1.AppendLine("This is new line");

            Console.WriteLine(sb1);

        }
    }
}
