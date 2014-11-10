using System;

class Electricity
    {
    static void Main()
        {
        int floors = int.Parse(Console.ReadLine()); ;
        int floats = int.Parse(Console.ReadLine()); ;
        string[] time = Console.ReadLine().Split(':');
        double watts = 0;

        double lamp = 100.53;
        double computer = 125.90;
        int n = int.Parse(time[0]);
        if (n >= 14 && n < 19)
            {
            watts = Math.Floor((2 * lamp + 2 * computer) * floors * floats);
            Console.WriteLine("{0:F0} Watts", watts);
            }
        else if (n >= 19 && n < 24)
            {
            watts = Math.Floor((7 * lamp + 6 * computer) * floors * floats);
            Console.WriteLine("{0:F0} Watts", watts);
            }
        else if (n >= 00 && n < 9)
            {
            watts = Math.Floor((1 * lamp + 8 * computer) * floors * floats);
            Console.WriteLine("{0:F0} Watts", watts);
            }
        else
            {
            Console.WriteLine("0 Watts");
            }
        }
    }
