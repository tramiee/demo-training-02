using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Access two-dimensional Array
            int[,] arr2d = new int[3, 2] { { 1, 2 }, 
                                           { 3, 4 }, 
                                           { 5, 6 } };
            Console.WriteLine("arr2d Values");
            Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(arr2d[0, 1]);
            Console.WriteLine(arr2d[1, 0]);
            Console.WriteLine(arr2d[1, 1]);
            Console.WriteLine(arr2d[2, 0]);
            Console.WriteLine(arr2d[2, 1]);

            //Three-dimensional Array
            int[,,] arr3d2 = new int[2, 2, 2]{{{1, 2}, {3, 4}},
                                              {{5, 6}, {7, 8}}};
            Console.WriteLine("arr3d2 Values");
            Console.WriteLine(arr3d2[0, 0, 0]);
            Console.WriteLine(arr3d2[0, 0, 1]);
            Console.WriteLine(arr3d2[0, 1, 0]);
            Console.WriteLine(arr3d2[0, 1, 1]);
            Console.WriteLine(arr3d2[1, 0, 0]);
            Console.WriteLine(arr3d2[1, 0, 1]);
            Console.WriteLine(arr3d2[1, 1, 0]);
            Console.WriteLine(arr3d2[1, 1, 1]);

            //Four-dimensional Array
            int[,,,] arr4d1 = new int[1, 1, 2, 2]{{{{1, 2}, {3, 4}}}};
            Console.WriteLine("arr4d1");
            Console.WriteLine(arr4d1[0, 0, 0, 0]);
            Console.WriteLine(arr4d1[0, 0, 0, 1]);
            Console.WriteLine(arr4d1[0, 0, 1, 0]);
            Console.WriteLine(arr4d1[0, 0, 1, 1]);
        }
    }
}
