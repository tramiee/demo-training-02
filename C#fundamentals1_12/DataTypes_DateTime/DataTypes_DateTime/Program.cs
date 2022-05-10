using System;

namespace DataTypes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
			//assigns default value 01/01/0001 00:00:00
			DateTime dt1 = new DateTime();
			Console.WriteLine(dt1);

			//assign year, month, day
			DateTime dt2 = new DateTime(2015, 12, 31);
			Console.WriteLine(dt2);

			//assign year, month, day, hour, min, seconds
			DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
			Console.WriteLine(dt3);

			//assign year, month, day, hour, min, seconds, UTC timezone
			DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
			Console.WriteLine(dt4);

			//Ticks
			DateTime dt = new DateTime(636370000000000000);
			Console.WriteLine(dt);

			Console.WriteLine(DateTime.MaxValue.Ticks);
			Console.WriteLine(DateTime.MinValue.Ticks);

			//DateTime Static Fields
			DateTime currentDateTime = DateTime.Now;
			DateTime todaysDate = DateTime.Today;
			DateTime currentDateTimeUTC = DateTime.UtcNow;

			DateTime maxDateTimeValue = DateTime.MaxValue;
			DateTime minDateTimeValue = DateTime.MinValue;

			Console.WriteLine($"Current DateTime {currentDateTime}");
			Console.WriteLine($"Today's DateTime {todaysDate}");
			Console.WriteLine($"Current DateTime UTC Timezone {currentDateTimeUTC}");
			Console.WriteLine($"Max DateTime Value {maxDateTimeValue}");
			Console.WriteLine($"Min DateTime Value {minDateTimeValue}");

			//TimeSpan
			DateTime dtime = new DateTime(2015, 12, 31);
			TimeSpan ts = new TimeSpan(25, 20, 55);

			DateTime newDate = dtime.Add(ts);

			Console.WriteLine(newDate);

			//Subtract Dates
			DateTime dtime1 = new DateTime(2015, 12, 31);
			DateTime dtime2 = new DateTime(2016, 2, 2);
			TimeSpan result = dtime2.Subtract(dtime1);
			Console.WriteLine(result);

			//Operators
			DateTime dt5 = new DateTime(2015, 12, 20);
			DateTime dt6 = new DateTime(2016, 12, 31, 5, 10, 20);
			TimeSpan time = new TimeSpan(10, 5, 25, 50);

			Console.WriteLine(dt6 + time);
			Console.WriteLine(dt6 - dt5);
			Console.WriteLine(dt5 == dt6);
			Console.WriteLine(dt5 != dt6);
			Console.WriteLine(dt5 > dt6);
			Console.WriteLine(dt5 < dt6);
			Console.WriteLine(dt5 >= dt6);
			Console.WriteLine(dt5 <= dt6);

			//Convert String to DateTime
			var str = "5/12/2020";
			DateTime dt7;

			var isValidDate = DateTime.TryParse(str, out dt7);
			if (isValidDate)
				Console.WriteLine(dt7);
			else
				Console.WriteLine($"{str} is not a valid date string");


		}
    }
}
