using System;

    class NumberAsWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = (n % 100);
            int c = n % 10;

            

            switch (a)
            {
                case 0: Console.Write(""); break;
                case 1: Console.Write("One hundred"); break;
                case 2: Console.Write("Two hundred"); break;
                case 3: Console.Write("Three hundred"); break;
                case 4: Console.Write("Four hundred"); break;
                case 5: Console.Write("Five hundred"); break;
                case 6: Console.Write("Six hundred"); break;
                case 7: Console.Write("Seven hundred"); break;
                case 8: Console.Write("Eight hundred"); break;
                case 9: Console.Write("Nine hundred"); break;
                default: break;
            }

            
            if (a!=0 && (b!=0 || c!=0))
            {
                Console.Write(" and ");
            }
            if (b > 9 && b < 20)
            {
                switch (b)
                {
                    case 10: Console.Write("Ten"); break;
                    case 11: Console.Write("Eleven"); break;
                    case 12: Console.Write("Twelve"); break;
                    case 13: Console.Write("Thirteen"); break;
                    case 14: Console.Write("Fourteen"); break;
                    case 15: Console.Write("Fifteen"); break;
                    case 16: Console.Write("Sixteen"); break;
                    case 17: Console.Write("Seventeen"); break;
                    case 18: Console.Write("Eighteen"); break;
                    case 19: Console.Write("Nineteen"); break;
                    default: break;
                }
            }
            else
            {
                b = b / 10;
                switch (b)
                {
                    case 0: Console.Write(""); break;
                    case 2: Console.Write("Twenty"); break;
                    case 3: Console.Write("Thirty"); break;
                    case 4: Console.Write("Fourty"); break;
                    case 5: Console.Write("Fifty"); break;
                    case 6: Console.Write("Sixty"); break;
                    case 7: Console.Write("Seventy"); break;
                    case 8: Console.Write("Eighty"); break;
                    case 9: Console.Write("Ninety"); break;
                    default: break;
                }

                    
                if ((b != 0 || a != 0)&&c!=0)
                {
                    Console.Write(" ");
                }
                switch (c)
                {
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                    default: break;
                }
            }
            if (a == 0 && b == 0 && c == 0)
            {
                Console.Write("Zero");
            }
            Console.WriteLine("");
        }
    }