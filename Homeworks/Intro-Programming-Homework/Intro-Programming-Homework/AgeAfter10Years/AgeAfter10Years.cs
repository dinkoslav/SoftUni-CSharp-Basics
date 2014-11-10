using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Tell me Your Age ...");
            string YourAge = Console.ReadLine();
            int AgeAfter = Int32.Parse(YourAge) + 10;
            Console.WriteLine("After 10 Years you will be {0} Years old !!!", AgeAfter);
        }
    }