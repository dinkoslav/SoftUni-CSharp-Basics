using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minNum = Int32.MaxValue;
        int maxNum = Int32.MinValue;
        int sum = 0;
        double avg = 0;

        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());

            if (m < minNum)
            {
                minNum = m;
            }
            if (m > maxNum)
            {
                maxNum = m;
            }
            sum = sum + m;

        }
        avg = (double)sum / (double)n;
        Console.WriteLine("min = {0}", minNum);
        Console.WriteLine("max = {0}", maxNum);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}