using System;

namespace Valuetuple
{
    class Program
    {
        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine("{0} , {1}, {2}", person.Item1, person.Item2, person.Item3);
        }
        static (int, string, string) GetPerson()
        {
            return (1, "Bill", "Gates");
        }

        static (int Id, string FirstName, string LastName) GetMyInfo()
        {
            return (Id: 1, FirstName: "Tra", LastName: "My");
        }
        static void Main(string[] args)
        {
            //ValueTuple As Parameter
            DisplayTuple((1, "Bill", "Gates"));

            //ValueTuple As Return Type
            var persons = GetPerson();
            Console.WriteLine("{0}, {1}, {2}", persons.Item1, persons.Item2, persons.Item3);

            //ValueTuple As Return Type
            var myinfo = GetMyInfo();
            Console.WriteLine("{0}, {1}, {2}", myinfo.Item1, myinfo.Item2, myinfo.Item3);

            //Deconstruct ValueTuple
            (int Id, string FirstName, string LastName) = GetMyInfo();
            Console.WriteLine("{0},{1}, {2}", Id, FirstName, LastName);
        }
    }
}
