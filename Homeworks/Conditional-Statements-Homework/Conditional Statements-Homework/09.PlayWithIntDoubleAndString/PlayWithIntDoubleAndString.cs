using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            byte n = byte.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                case 2:
                    double b = double.Parse(Console.ReadLine());
                    b = b + 1;
                    Console.WriteLine(b);
                    break;
                case 3:
                    string str = Console.ReadLine();
                    Console.WriteLine(str+"*");
                    break;
                default:break;
            }
        }
    }