using System;

namespace PartialClass
{
    public partial class Employee
    {
        public Employee()
        {
            GenerateEmpId();
        }

        private void GenerateEmpId()
        {
            
        }

        public int EmpId { get; set; }
        public string Name { get; set; }

        partial void GenerateEmployeeId();
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            Console.WriteLine(emp.EmpId); // prints genereted id

            Console.ReadLine();

        }
    }
}
