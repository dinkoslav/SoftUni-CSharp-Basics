using System;

    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter four digit number :");
            int givenNumber = Math.Abs(int.Parse(Console.ReadLine()));
            int d = givenNumber % 10;
            int c = (givenNumber / 10) % 10;
            int b = (givenNumber / 100) % 10;
            int a = givenNumber / 1000;

            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);

        }
    }
