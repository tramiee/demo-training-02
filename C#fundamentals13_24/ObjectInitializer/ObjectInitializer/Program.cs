using System;
using System.Collections.Generic;

namespace ObjectInitializer
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stringList = new List<Student>()
            {
                new Student(){StudentID = 1, StudentName = "My"},
                new Student(){StudentID = 2, StudentName = "Tra"}
            };

            Console.WriteLine("Total Student: {0}", stringList.Count);
        }
    }
}
