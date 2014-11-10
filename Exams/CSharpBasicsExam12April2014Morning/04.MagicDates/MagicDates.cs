using System;

class MagicDates
{
    static void Main()
    {

        DateTime startDate = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        DateTime endDate = new DateTime(int.Parse(Console.ReadLine()), 12, 31);
        int magicWeight = int.Parse(Console.ReadLine());
        int count = 0;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            string n = i.ToString("ddMMyyyy");
            int sum = 0;
            for (int j = 0; j < n.Length; j++)
            {
                for (int k = j + 1; k < n.Length; k++)
                {
                    int a = (int)Char.GetNumericValue(n[j]);
                    int b = (int)Char.GetNumericValue(n[k]);
                    sum = sum + ((int)Char.GetNumericValue(n[j]) * (int)Char.GetNumericValue(n[k]));
                }
            }
            if (sum == magicWeight)
            {
                Console.WriteLine("{0}{1}-{2}{3}-{4}{5}{6}{7}", n[0], n[1], n[2], n[3], n[4], n[5], n[6], n[7]);
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

//using System;

//public class MagicDates
//{
//    public static void Main()
//    {
//        int startYear = int.Parse(Console.ReadLine());
//        int endYear = int.Parse(Console.ReadLine());
//        int magicWeight = int.Parse(Console.ReadLine());

//        DateTime startDate = new DateTime(startYear, 1, 1);
//        DateTime endDate = new DateTime(endYear, 12, 31);
//        int count = 0;
//        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
//        {
//            int d1 = d.Day / 10;
//            int d2 = d.Day % 10;
//            int d3 = d.Month / 10;
//            int d4 = d.Month % 10;
//            int d5 = (d.Year / 1000) % 10;
//            int d6 = (d.Year / 100) % 10;
//            int d7 = (d.Year / 10) % 10;
//            int d8 = (d.Year / 1) % 10;
//            int[] digits = { d1, d2, d3, d4, d5, d6, d7, d8 };
//            int weight = 0;
//            for (int first = 0; first < digits.Length; first++)
//            {
//                for (int second = first + 1; second < digits.Length; second++)
//                {
//                    weight = weight + (digits[first] * digits[second]);
//                }
//            }
//            if (weight == magicWeight)
//            {
//                Console.WriteLine("{0:d2}-{1:d2}-{2:d2}", d.Day, d.Month, d.Year);
//                count++;
//            }
//        }

//        if (count == 0)
//        {
//            Console.WriteLine("No");
//        }
//    }
//}