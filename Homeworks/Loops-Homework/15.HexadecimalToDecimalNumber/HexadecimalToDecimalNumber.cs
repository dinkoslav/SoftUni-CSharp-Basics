using System;

    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            string inputHexa = Console.ReadLine();
            long decimalNumber = 0;
            for (int i = 0; i < inputHexa.Length; i++)
            {
                string hexaNumber = Char.ToString(inputHexa[(inputHexa.Length - 1 - i)]);
                long number;
                bool result = Int64.TryParse(hexaNumber, out number);
                if (result)
                {
                    decimalNumber = decimalNumber + number * (long)Math.Pow(16, i);
                }
                else
                {
                    if (hexaNumber == "A")
                    {
                        decimalNumber = decimalNumber + 10 * (long)Math.Pow(16, i);
                    }
                    else if (hexaNumber == "B")
	                {
                        decimalNumber = decimalNumber + 11 * (long)Math.Pow(16, i);
	                }
                    else if (hexaNumber == "C")
	                {
                        decimalNumber = decimalNumber + 12 * (long)Math.Pow(16, i);
	                }
                    else if (hexaNumber == "D")
	                {
                        decimalNumber = decimalNumber + 13 * (long)Math.Pow(16, i);
	                }
                    else if (hexaNumber == "E")
	                {
                        decimalNumber = decimalNumber + 14 * (long)Math.Pow(16, i);
	                }
                    else if (hexaNumber == "F")
	                {
                        decimalNumber = decimalNumber + 15 * (long)Math.Pow(16, i);
	                }
                }
            }
            Console.WriteLine(decimalNumber);
        }
    }
