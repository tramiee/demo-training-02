using System;
using System.Collections.Generic;

namespace CreateQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and Add Elements in the Queue
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.WriteLine(id);

            //Dequeue()
            Queue<string> myQ = new Queue<string>();
            myQ.Enqueue("H");
            myQ.Enqueue("E");
            myQ.Enqueue("L");
            myQ.Enqueue("L");
            myQ.Enqueue("O");

            Console.WriteLine("Total element: {0}", myQ.Count);

            while (myQ.Count > 0)
                Console.WriteLine(myQ.Dequeue());

            Console.WriteLine("Total element: {0}", myQ.Count);

            //Peek()
            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("T");
            strQ.Enqueue("R");
            strQ.Enqueue("A");
            strQ.Enqueue("M");
            strQ.Enqueue("Y");
            Console.WriteLine("Total element: {0}", strQ.Count);
            if(strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek());
            }
            Console.WriteLine("Total element: {0}", strQ.Count);

            //Contains
            Console.WriteLine(strQ.Contains("B")); 
            Console.WriteLine(strQ.Contains("M"));
        }
    }
}
