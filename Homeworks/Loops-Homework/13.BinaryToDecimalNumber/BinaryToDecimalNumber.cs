using System;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            string inputBinari = Console.ReadLine();
            long decimalNumber = 0;
            for (int i = 0; i < inputBinari.Length; i++)
            {
                
                long n = Convert.ToInt64(Char.ToString(inputBinari[(inputBinari.Length-1-i)]));
                decimalNumber = decimalNumber + n * (long)Math.Pow(2,i);
            }
            Console.WriteLine(decimalNumber);
        }
    }