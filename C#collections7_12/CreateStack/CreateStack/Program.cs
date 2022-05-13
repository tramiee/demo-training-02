using System;
using System.Collections.Generic;

namespace CreateStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and Add Elements in Stack
            Stack<int> nums = new Stack<int>();
            nums.Push(1);
            nums.Push(2);
            nums.Push(3);
            nums.Push(4);

            foreach (var item in nums)
                Console.Write(item + ", ");

            //Create and Add Elements in Stack
            Console.WriteLine();
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack = new Stack<int>(arr);
            foreach (var item in myStack)
                Console.Write(item + ", ");

            //Access Stack using Pop()
            Console.WriteLine();
            Stack<int> myStack1 = new Stack<int>();
            myStack1.Push(1);
            myStack1.Push(2);
            myStack1.Push(3);
            myStack1.Push(4);
            myStack1.Push(5);

            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);

            while (myStack1.Count > 0)
                Console.Write(myStack1.Pop() + ", ");
            Console.WriteLine();
            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);

            //Retrieve Elements usign Peek()
            Stack<int> myStack2 = new Stack<int>();
            myStack2.Push(1);
            myStack2.Push(2);
            myStack2.Push(3);
            myStack2.Push(4);
            myStack2.Push(5);
            Console.WriteLine("Number of elements in Stack: {0}", myStack2.Count);
            if (myStack2.Count > 0)
                Console.WriteLine(myStack2.Peek());
            Console.WriteLine("Number of elements in Stack: {0}", myStack2.Count);

            // Contains()
            Console.WriteLine(myStack2.Contains(2));
            Console.WriteLine(myStack2.Contains(10));


        }
    }
}
