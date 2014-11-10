using System;

    class DecimalToBinaryNumber
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string binary = "";
            while (n!=0)
            {
                long binaryNumber = n % 2;
                string str = binaryNumber.ToString();
                binary = str + binary;
                n = n / 2;
            }
            Console.WriteLine(binary);
        }
    }