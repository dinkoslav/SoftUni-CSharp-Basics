using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer number : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter float number one : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter float number two : ");
            float c = float.Parse(Console.ReadLine());
            string aBinary = Convert.ToString(a, 2);
            Console.WriteLine("{0,-10} {1,-10} {2,-10} | {0,-10:X}|{3,-10:D10}|{1,10:F2}|{2,-10:F3}|", a, b, c, "00" + aBinary);
        }
    }