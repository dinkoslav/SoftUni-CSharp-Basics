using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a += 10;
            b += 8;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
