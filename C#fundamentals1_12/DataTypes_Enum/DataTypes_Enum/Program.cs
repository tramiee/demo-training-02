using System;

namespace DataTypes_Enum
{
    class Program
    {
		enum WeekDays
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
		static void Main(string[] args)
        {
			Console.WriteLine(WeekDays.Friday);
			int day = (int)WeekDays.Friday;
			Console.WriteLine(day);

			var wd = (WeekDays)5;
			Console.WriteLine(wd);
		}
    }
}
