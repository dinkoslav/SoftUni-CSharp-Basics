using System;

class Triangle
{
    static void Main()
    {
        int pointAX = int.Parse(Console.ReadLine());
        int pointAY = int.Parse(Console.ReadLine());
        int pointBX = int.Parse(Console.ReadLine());
        int pointBY = int.Parse(Console.ReadLine());
        int pointCX = int.Parse(Console.ReadLine());
        int pointCY = int.Parse(Console.ReadLine());

        double distanceAB = Math.Sqrt(((pointBX - pointAX) * (pointBX - pointAX)) +
            ((pointBY - pointAY) * (pointBY - pointAY)));
        double distanceAC = Math.Sqrt(((pointCX - pointAX) * (pointCX - pointAX)) +
            ((pointCY - pointAY) * (pointCY - pointAY)));
        double distanceCB = Math.Sqrt(((pointBX - pointCX) * (pointBX - pointCX)) +
            ((pointBY - pointCY) * (pointBY - pointCY)));

        double p = (distanceAB + distanceAC + distanceCB) / 2;
        double area = Math.Sqrt(p * (p - distanceAB) * (p - distanceAC) * (p - distanceCB));

        if ((distanceAB + distanceAC) > distanceCB && (distanceAB + distanceCB) > distanceAC && (distanceCB + distanceAC) > distanceAB)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", distanceAB);
        }
    }
}