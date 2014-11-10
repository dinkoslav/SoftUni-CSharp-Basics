using System;

    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string hexadecimal = "";
            while (n != 0)
            {
                string str = "";
                long hexaNumber = n % 16;
                if (hexaNumber > 9)
                {
                    if (hexaNumber == 10)
                    {
                        str = "A";
                    }
                    else if (hexaNumber == 11)
                    {
                        str = "B";
                    }
                    else if (hexaNumber == 12)
                    {
                        str = "C";
                    }
                    else if (hexaNumber == 13)
                    {
                        str = "D";
                    }
                    else if (hexaNumber == 14)
                    {
                        str = "E";
                    }
                    else if (hexaNumber == 15)
                    {
                        str = "F";
                    }
                }
                else
                {
                    str = hexaNumber.ToString();
                }
                hexadecimal = str + hexadecimal;
                n = n / 16;
            }
            Console.WriteLine(hexadecimal);
        }
    }
