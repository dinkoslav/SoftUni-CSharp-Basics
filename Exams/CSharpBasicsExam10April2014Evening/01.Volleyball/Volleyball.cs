using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int weekendsInYear = 48;
        int normalWeekends = weekendsInYear - h;

        double gamesCount = (normalWeekends * 3d / 4d) + (p * 2d / 3d) + h * 1d;
        if (leap == "leap")
        {
            gamesCount += gamesCount * 0.15;
        }
        Console.WriteLine((int)gamesCount);
    }
}
