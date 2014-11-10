using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');
            int[] convertedNumbers = Array.ConvertAll<string,int>(tokens, int.Parse);
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < convertedNumbers.Length ; i++)
            {
                if ((i+1)%2!=0)
                {
                    oddProduct = oddProduct * convertedNumbers[i];
                }
                else if ((i+1)%2==0)
                {
                    evenProduct = evenProduct * convertedNumbers[i];
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",oddProduct);
            }
            else if (oddProduct != evenProduct)
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",oddProduct);
                Console.WriteLine("even_product = {0}", evenProduct);
            }
        }
    }
