using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding Elements in ArrayList
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("Bill");
            arrayList1.Add(true);
            arrayList1.Add(4.5);
            arrayList1.Add(null);

            ArrayList arrayList2 = new ArrayList() { 2, "Steve", true, 4.5, null };

            Console.WriteLine("ArrayList 1 Elements");
            for(int i = 0; i < arrayList1.Count; i++)
            {
                Console.WriteLine(arrayList1[i]);
            }

            Console.WriteLine("ArrayList 2 Elements");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.WriteLine(arrayList2[i]);
            }

            //Adding Entire Array/ArrayList into ArrayList
            ArrayList arrayList3 = new ArrayList();
            ArrayList arrayList4 = new ArrayList() { 1, "Bill", 4.5, null };

            int[] arr = { 1, 2, 3, 4 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");

            arrayList3.AddRange(arrayList4);
            arrayList3.AddRange(arr);
            arrayList3.AddRange(myQ);

            Console.WriteLine("ArrayList Element");
            for(int i = 0; i < arrayList3.Count; i++)
            {
                Console.WriteLine(arrayList3[i]);
            }

            //Iterate ArrayList
            ArrayList arrayList5 = new ArrayList() { 1, "Bill", 300, 4.5F};
            Console.WriteLine("foreach loop");
            foreach (var item in arrayList5)
                Console.Write(item + ", ");
            Console.WriteLine("");
            Console.WriteLine("for loop");
            for (int i = 0; i < arrayList5.Count; i++)
                Console.Write(arrayList5[i] + ", ");

            //Insert Element in ArrayList
            Console.WriteLine();
            arrayList5.Insert(1, "second Item");
            foreach(var val in arrayList5)
            {
                Console.WriteLine(val);
            }

            //Insert Collection in ArrayList
            Console.WriteLine();
            ArrayList arrayList6 = new ArrayList() { 100, 200, 600 };
            ArrayList arrayList7 = new ArrayList() { 300, 400, 500 };
            arrayList6.InsertRange(2, arrayList7);
            foreach (var item in arrayList6)
                Console.Write(item + ", ");


        }
    }
}
