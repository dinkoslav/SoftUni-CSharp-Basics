using System;
using System.Globalization;

    class BeerTime
    {
        static void Main()
        {
            DateTime givenTime = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", CultureInfo.InvariantCulture);
            if (givenTime >= DateTime.ParseExact("1:00 PM", "h:mm tt", CultureInfo.InvariantCulture) ||
                givenTime <= DateTime.ParseExact("3:00 AM", "h:mm tt", CultureInfo.InvariantCulture))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }