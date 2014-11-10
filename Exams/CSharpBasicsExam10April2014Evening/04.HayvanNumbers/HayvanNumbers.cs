using System;

    class HayvanNumbers
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int total = 0;
            for (int a = 5; a < 10; a++)
            {
                for (int b = 5; b < 10; b++)
                {
                    for (int c = 5; c < 10; c++)
                    {
                        for (int d = 5; d < 10; d++)
                        {
                            for (int e = 5; e < 10; e++)
                            {
                                for (int f = 5; f < 10; f++)
                                {
                                    for (int g = 5; g < 10; g++)
                                    {
                                        for (int h = 5; h < 10; h++)
                                        {
                                            for (int i = 5; i < 10; i++)
                                            {
                                                int abc = (a*100)+(b*10)+c;
                                                int def = (d*100)+(e*10)+f;
                                                int ghi = (g*100)+(h*10)+i;
                                                if ((a+b+c+d+e+f+g+h+i)==sum
                                                    &&(a+b+c)<(d+e+f)
                                                    &&(d+e+f)<(g+h+i)
                                                    &&(def-abc)==diff
                                                    &&(ghi-def)==diff)
                                                {
                                                    Console.WriteLine("{0}{1}{2}",abc, def, ghi);
                                                    total++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (total == 0)
            {
                Console.WriteLine("No");
            }
        }
    }

//using System;

//class HayvanNumbers
//{
//    static void Main()
//    {
//        int sum = int.Parse(Console.ReadLine());
//        int diff = int.Parse(Console.ReadLine());
//        int resultsCount = 0;
//        for (int num1 = 555; num1 <= 999; num1++)
//        {
//            int num2 = num1 + diff;
//            int num3 = num2 + diff;
//            if (IsAllowedNumber(num1) && IsAllowedNumber(num2) && IsAllowedNumber(num3) &&
//                (num3 <= 999) &&
//                CalcSumOfDigits(num1) + CalcSumOfDigits(num2) + CalcSumOfDigits(num3) == sum)
//            {
//                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
//                resultsCount++;
//            }
//        }

//        if (resultsCount == 0)
//        {
//            Console.WriteLine("No");
//        }
//    }

//    private static int CalcSumOfDigits(int num)
//    {
//        int sum = 0;
//        while (num > 0)
//        {
//            sum += num % 10;
//            num = num / 10;
//        }
//        return sum;
//    }

//    private static bool IsAllowedNumber(int num)
//    {
//        string digits = num.ToString();
//        foreach (var digit in digits)
//        {
//            if (digit < '5' || digit > '9')
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}
