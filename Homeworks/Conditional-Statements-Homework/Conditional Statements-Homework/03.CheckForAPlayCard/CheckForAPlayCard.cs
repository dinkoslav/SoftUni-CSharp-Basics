using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            string n = Console.ReadLine();
            int number;
            bool result = int.TryParse(n, out number);
            if (result)
            {
                if (number >= 2 && number <= 10)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
                
            }
            else if (n == "Q" || n == "K" || n == "A" || n == "J")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }