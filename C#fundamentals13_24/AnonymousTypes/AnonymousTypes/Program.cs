using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypes
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentID = 1, StudentName = "John", age = 18},
                new Student(){StudentID = 2, StudentName = "Lisa", age = 17},
                new Student(){StudentID = 3, StudentName = "Bill", age = 16},
                new Student(){StudentID = 4, StudentName = "Steve", age = 20},
                new Student(){StudentID = 5, StudentName = "Ran", age = 19},
            };

            var students = from s in studentList select new { Id = s.StudentID, Name = s.StudentName, Age = s.age };

            foreach(var stud in students)
            {
                Console.WriteLine(stud.Id + " - " + stud.Name + " - Age:" + stud.Age);
            }
        }
    }
}
