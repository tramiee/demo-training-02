using System;

namespace Value_ReferenceTypes
{
    public class Student
    {
        public string StudentName { get; set; }
    }
    class Program
    {
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        public static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }
        static void ChangeReferenceType1(string name)
        {
            name = "Steve";
        }
        static void Main(string[] args)
        {
            //Value Type and Reference Type
            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);

            //Passing Reference Type Variable
            Student std1 = new Student();
            std1.StudentName = "Bill";
            ChangeReferenceType(std1);
            Console.WriteLine(std1.StudentName);

            //Passing String
            string name = "Bill";
            ChangeReferenceType1(name);
            Console.WriteLine(name);

        }
    }
}
